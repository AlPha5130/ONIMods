using System;
using HarmonyLib;

namespace TranslationFix
{
    public sealed class TranslationFixMain : KMod.UserMod2
    {
        public override void OnLoad(Harmony harmony)
        {
            try
            {
                Localization.Initialize();
            }
            catch (Exception obj)
            {
                Debug.LogWarning(obj);
            }
        }
    }
}
