using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using HarmonyLib;
using Karambolo.PO;
using Klei.CustomSettings;
using STRINGS;
using TUNING;
using UnityEngine;
using static RoomConstraints;

namespace TranslationFix
{
    [HarmonyPatch(typeof(PressureDoorConfig), "CreateBuildingDef")]
    public sealed class CreateBuildingDefPatch
    {
        public static bool initialized = false;

        public static POCatalog strings = null;

        public static BindingFlags staticFlags =
            BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public;

        public static void UpdateLabelAndTooltip<T>(T obj)
        {
            var label = Traverse.Create(obj).Field("<label>k__BackingField");
            var tooltip = Traverse.Create(obj).Field("<tooltip>k__BackingField");
            var labelTranslation = strings.GetTranslation(new POKey(label.GetValue<string>()));
            var tooltipTranslation = strings.GetTranslation(new POKey(tooltip.GetValue<string>()));
            if (labelTranslation != null && tooltip != null)
            {
                label.SetValue(labelTranslation);
                tooltip.SetValue(tooltipTranslation);
            }
        }

        public static void FixGameSettingTranslation()
        {
            FieldInfo[] fields = typeof(CustomGameSettingConfigs).GetFields(staticFlags);
            int num = 0;
            int num2 = 0;
            FieldInfo[] array = fields;
            foreach (FieldInfo fieldInfo in array)
            {
                num++;
                try
                {
                    object value = fieldInfo.GetValue(null);
                    if (value == null)
                    {
                        continue;
                    }
                    if (value is SettingConfig config)
                    {
                        num2++;
                        UpdateLabelAndTooltip(config);
                    }
                    if (value is ToggleSettingConfig val)
                    {
                        UpdateLabelAndTooltip(val.on_level);
                        UpdateLabelAndTooltip(val.off_level);
                    }
                    if (!(value is ListSettingConfig))
                    {
                        continue;
                    }
                    List<SettingLevel> levels = ((ListSettingConfig)value).GetLevels();
                    if (levels == null)
                    {
                        continue;
                    }
                    foreach (var item in levels)
                    {
                        if (item != null)
                        {
                            UpdateLabelAndTooltip(item);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.LogWarning(ex);
                }
            }
        }

        public static void FixRoomTranslation()
        {
            FieldInfo[] fields = typeof(RoomConstraints).GetFields(staticFlags);
            int num = 0;
            int num2 = 0;
            int num3 = 0;
            FieldInfo[] array = fields;
            foreach (var fieldInfo in array)
            {
                var value = fieldInfo.GetValue(null);
                if (!(value is Constraint))
                {
                    continue;
                }
                var constraint = (Constraint)value;
                var value2 = strings.GetTranslation(new POKey(constraint.name));
                if (value2 != null)
                {
                    constraint.name = value2;
                }
                else
                {
                    FieldInfo field = typeof(MockRoomConstraints).GetField(
                        fieldInfo.Name,
                        staticFlags
                    );
                    if (field != null)
                    {
                        var constraint2 = (Constraint)field.GetValue(null);
                        constraint.name = constraint2.name;
                        constraint.description = constraint2.description;
                    }
                    if (field == null)
                    {
                        num3++;
                    }
                    num2++;
                }
                var value3 = strings.GetTranslation(new POKey(constraint.description));
                if (value3 != null)
                {
                    constraint.description = value3;
                }
                if (constraint.name.Contains("Cots"))
                {
                    constraint.name += " (床铺)";
                }
                num++;
            }
        }

        public static void FixTraitTranslation()
        {
            var traits = Db.Get().traits;
            int num = 0;
            foreach (var resource in traits.resources)
            {
                var value = strings.GetTranslation(new POKey(resource.Name));
                if (value != null)
                {
                    resource.Name = value + "(" + resource.Name + ")";
                    resource.description =
                        strings.GetTranslation(new POKey(resource.description))
                        + " "
                        + resource.description;
                    num++;
                }
            }
            _ = CODEX.STORY_TRAITS.MORB_ROVER_MAKER.STATUSITEMS.GERM_COLLECTION_PROGRESS.TOOLTIP;
        }

        public static void Postfix()
        {
            if (!initialized)
            {
                initialized = true;
                string currentLanguageCode = Localization.GetCurrentLanguageCode();
                string path = Path.Combine(
                    Application.dataPath,
                    "/StreamingAssets/strings/strings_preinstalled_" + currentLanguageCode + ".po"
                );
                if (File.Exists(path))
                {
                    var parser = new POParser();
                    var parseResult = parser.Parse(File.OpenText(path));
                    if (parseResult.Success)
                    {
                        strings = parseResult.Catalog;
                    }
                    LocString nAME = DUPLICANTS.TRAITS.IRONGUT.NAME;
                    FixGameSettingTranslation();
                    FixTraitTranslation();
                    FixRoomTranslation();
                }
            }
        }

        public void TestExample()
        {
            _ = DUPLICANTS.TRAITS.IRONGUT.NAME;
            foreach (var tRAIT_CREATOR in TRAITS.TRAIT_CREATORS)
            {
                _ = tRAIT_CREATOR;
            }
            TRAITS.TRAIT_CREATORS.ForEach((action) => action());
            Db.Get()
                .CreateTrait(
                    "IronGut",
                    DUPLICANTS.TRAITS.IRONGUT.NAME,
                    DUPLICANTS.TRAITS.IRONGUT.DESC,
                    null,
                    true,
                    null,
                    false,
                    true
                );
        }
    }
}
