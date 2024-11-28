using System.Collections.Generic;
using Klei.CustomSettings;
using STRINGS;
using static STRINGS.UI.FRONTEND.CUSTOMGAMESETTINGSSCREEN;

namespace TranslationFix
{
    public class MockCustomGameSettingConfigs
    {
        public static SeedSettingConfig WorldgenSeed = new SeedSettingConfig(
            "WorldgenSeed",
            SETTINGS.WORLDGEN_SEED.NAME,
            SETTINGS.WORLDGEN_SEED.TOOLTIP,
            triggers_custom_game: false
        );

        public static ListSettingConfig ClusterLayout = new ListSettingConfig(
            "ClusterLayout",
            SETTINGS.CLUSTER_CHOICE.NAME,
            SETTINGS.CLUSTER_CHOICE.TOOLTIP,
            null,
            null,
            null,
            triggers_custom_game: false,
            hide_in_ui: true
        );

        public static SettingConfig SandboxMode = new ToggleSettingConfig(
            "SandboxMode",
            SETTINGS.SANDBOXMODE.NAME,
            SETTINGS.SANDBOXMODE.TOOLTIP,
            new SettingLevel(
                "Disabled",
                SETTINGS.SANDBOXMODE.LEVELS.DISABLED.NAME,
                SETTINGS.SANDBOXMODE.LEVELS.DISABLED.TOOLTIP
            ),
            new SettingLevel(
                "Enabled",
                SETTINGS.SANDBOXMODE.LEVELS.ENABLED.NAME,
                SETTINGS.SANDBOXMODE.LEVELS.ENABLED.TOOLTIP
            ),
            "Disabled",
            "Disabled"
        );

        public static SettingConfig FastWorkersMode = new ToggleSettingConfig(
            "FastWorkersMode",
            SETTINGS.FASTWORKERSMODE.NAME,
            SETTINGS.FASTWORKERSMODE.TOOLTIP,
            new SettingLevel(
                "Disabled",
                SETTINGS.FASTWORKERSMODE.LEVELS.DISABLED.NAME,
                SETTINGS.FASTWORKERSMODE.LEVELS.DISABLED.TOOLTIP
            ),
            new SettingLevel(
                "Enabled",
                SETTINGS.FASTWORKERSMODE.LEVELS.ENABLED.NAME,
                SETTINGS.FASTWORKERSMODE.LEVELS.ENABLED.TOOLTIP
            ),
            "Disabled",
            "Disabled",
            debug_only: true
        );

        public static SettingConfig SaveToCloud = new ToggleSettingConfig(
            "SaveToCloud",
            SETTINGS.SAVETOCLOUD.NAME,
            SETTINGS.SAVETOCLOUD.TOOLTIP,
            new SettingLevel(
                "Disabled",
                SETTINGS.SAVETOCLOUD.LEVELS.DISABLED.NAME,
                SETTINGS.SAVETOCLOUD.LEVELS.DISABLED.TOOLTIP
            ),
            new SettingLevel(
                "Enabled",
                SETTINGS.SAVETOCLOUD.LEVELS.ENABLED.NAME,
                SETTINGS.SAVETOCLOUD.LEVELS.ENABLED.TOOLTIP
            ),
            "Enabled",
            "Enabled",
            triggers_custom_game: false
        );

        public static SettingConfig CalorieBurn = new ListSettingConfig(
            "CalorieBurn",
            SETTINGS.CALORIE_BURN.NAME,
            SETTINGS.CALORIE_BURN.TOOLTIP,
            new List<SettingLevel>
            {
                new SettingLevel(
                    "Disabled",
                    SETTINGS.CALORIE_BURN.LEVELS.DISABLED.NAME,
                    SETTINGS.CALORIE_BURN.LEVELS.DISABLED.TOOLTIP,
                    2L
                ),
                new SettingLevel(
                    "Easy",
                    SETTINGS.CALORIE_BURN.LEVELS.EASY.NAME,
                    SETTINGS.CALORIE_BURN.LEVELS.EASY.TOOLTIP,
                    1L
                ),
                new SettingLevel(
                    "Default",
                    SETTINGS.CALORIE_BURN.LEVELS.DEFAULT.NAME,
                    SETTINGS.CALORIE_BURN.LEVELS.DEFAULT.TOOLTIP,
                    0L
                ),
                new SettingLevel(
                    "Hard",
                    SETTINGS.CALORIE_BURN.LEVELS.HARD.NAME,
                    SETTINGS.CALORIE_BURN.LEVELS.HARD.TOOLTIP,
                    3L
                ),
                new SettingLevel(
                    "VeryHard",
                    SETTINGS.CALORIE_BURN.LEVELS.VERYHARD.NAME,
                    SETTINGS.CALORIE_BURN.LEVELS.VERYHARD.TOOLTIP,
                    4L
                ),
            },
            "Default",
            "Easy",
            8L
        );

        public static SettingConfig ImmuneSystem = new ListSettingConfig(
            "ImmuneSystem",
            SETTINGS.IMMUNESYSTEM.NAME,
            SETTINGS.IMMUNESYSTEM.TOOLTIP,
            new List<SettingLevel>
            {
                new SettingLevel(
                    "Invincible",
                    SETTINGS.IMMUNESYSTEM.LEVELS.INVINCIBLE.NAME,
                    SETTINGS.IMMUNESYSTEM.LEVELS.INVINCIBLE.TOOLTIP,
                    2L
                ),
                new SettingLevel(
                    "Strong",
                    SETTINGS.IMMUNESYSTEM.LEVELS.STRONG.NAME,
                    SETTINGS.IMMUNESYSTEM.LEVELS.STRONG.TOOLTIP,
                    1L
                ),
                new SettingLevel(
                    "Default",
                    SETTINGS.IMMUNESYSTEM.LEVELS.DEFAULT.NAME,
                    SETTINGS.IMMUNESYSTEM.LEVELS.DEFAULT.TOOLTIP,
                    0L
                ),
                new SettingLevel(
                    "Weak",
                    SETTINGS.IMMUNESYSTEM.LEVELS.WEAK.NAME,
                    SETTINGS.IMMUNESYSTEM.LEVELS.WEAK.TOOLTIP,
                    3L
                ),
                new SettingLevel(
                    "Compromised",
                    SETTINGS.IMMUNESYSTEM.LEVELS.COMPROMISED.NAME,
                    SETTINGS.IMMUNESYSTEM.LEVELS.COMPROMISED.TOOLTIP,
                    4L
                ),
            },
            "Default",
            "Strong",
            8L
        );

        public static SettingConfig Morale = new ListSettingConfig(
            "Morale",
            SETTINGS.MORALE.NAME,
            SETTINGS.MORALE.TOOLTIP,
            new List<SettingLevel>
            {
                new SettingLevel(
                    "Disabled",
                    SETTINGS.MORALE.LEVELS.DISABLED.NAME,
                    SETTINGS.MORALE.LEVELS.DISABLED.TOOLTIP,
                    2L
                ),
                new SettingLevel(
                    "Easy",
                    SETTINGS.MORALE.LEVELS.EASY.NAME,
                    SETTINGS.MORALE.LEVELS.EASY.TOOLTIP,
                    1L
                ),
                new SettingLevel(
                    "Default",
                    SETTINGS.MORALE.LEVELS.DEFAULT.NAME,
                    SETTINGS.MORALE.LEVELS.DEFAULT.TOOLTIP,
                    0L
                ),
                new SettingLevel(
                    "Hard",
                    SETTINGS.MORALE.LEVELS.HARD.NAME,
                    SETTINGS.MORALE.LEVELS.HARD.TOOLTIP,
                    3L
                ),
                new SettingLevel(
                    "VeryHard",
                    SETTINGS.MORALE.LEVELS.VERYHARD.NAME,
                    SETTINGS.MORALE.LEVELS.VERYHARD.TOOLTIP,
                    4L
                ),
            },
            "Default",
            "Easy",
            8L
        );

        public static SettingConfig Durability = new ListSettingConfig(
            "Durability",
            SETTINGS.DURABILITY.NAME,
            SETTINGS.DURABILITY.TOOLTIP,
            new List<SettingLevel>
            {
                new SettingLevel(
                    "Indestructible",
                    SETTINGS.DURABILITY.LEVELS.INDESTRUCTIBLE.NAME,
                    SETTINGS.DURABILITY.LEVELS.INDESTRUCTIBLE.TOOLTIP,
                    (DlcManager.IsPureVanilla() ? 0L : 2L)
                ),
                new SettingLevel(
                    "Reinforced",
                    SETTINGS.DURABILITY.LEVELS.REINFORCED.NAME,
                    SETTINGS.DURABILITY.LEVELS.REINFORCED.TOOLTIP,
                    1L
                ),
                new SettingLevel(
                    "Default",
                    SETTINGS.DURABILITY.LEVELS.DEFAULT.NAME,
                    SETTINGS.DURABILITY.LEVELS.DEFAULT.TOOLTIP,
                    (DlcManager.IsPureVanilla() ? 2L : 0L)
                ),
                new SettingLevel(
                    "Flimsy",
                    SETTINGS.DURABILITY.LEVELS.FLIMSY.NAME,
                    SETTINGS.DURABILITY.LEVELS.FLIMSY.TOOLTIP,
                    3L
                ),
                new SettingLevel(
                    "Threadbare",
                    SETTINGS.DURABILITY.LEVELS.THREADBARE.NAME,
                    SETTINGS.DURABILITY.LEVELS.THREADBARE.TOOLTIP,
                    4L
                ),
            },
            DlcManager.IsPureVanilla() ? "Indestructible" : "Default",
            DlcManager.IsPureVanilla() ? "Indestructible" : "Reinforced",
            8L
        );

        public static SettingConfig Radiation = new ListSettingConfig(
            "Radiation",
            SETTINGS.RADIATION.NAME,
            SETTINGS.RADIATION.TOOLTIP,
            new List<SettingLevel>
            {
                new SettingLevel(
                    "Easiest",
                    SETTINGS.RADIATION.LEVELS.EASIEST.NAME,
                    SETTINGS.RADIATION.LEVELS.EASIEST.TOOLTIP,
                    2L
                ),
                new SettingLevel(
                    "Easier",
                    SETTINGS.RADIATION.LEVELS.EASIER.NAME,
                    SETTINGS.RADIATION.LEVELS.EASIER.TOOLTIP,
                    1L
                ),
                new SettingLevel(
                    "Default",
                    SETTINGS.RADIATION.LEVELS.DEFAULT.NAME,
                    SETTINGS.RADIATION.LEVELS.DEFAULT.TOOLTIP,
                    0L
                ),
                new SettingLevel(
                    "Harder",
                    SETTINGS.RADIATION.LEVELS.HARDER.NAME,
                    SETTINGS.RADIATION.LEVELS.HARDER.TOOLTIP,
                    3L
                ),
                new SettingLevel(
                    "Hardest",
                    SETTINGS.RADIATION.LEVELS.HARDEST.NAME,
                    SETTINGS.RADIATION.LEVELS.HARDEST.TOOLTIP,
                    4L
                ),
            },
            "Default",
            "Easier",
            8L,
            false,
            true,
            DlcManager.EXPANSION1
        );

        public static SettingConfig Stress = new ListSettingConfig(
            "Stress",
            SETTINGS.STRESS.NAME,
            SETTINGS.STRESS.TOOLTIP,
            new List<SettingLevel>
            {
                new SettingLevel(
                    "Indomitable",
                    SETTINGS.STRESS.LEVELS.INDOMITABLE.NAME,
                    SETTINGS.STRESS.LEVELS.INDOMITABLE.TOOLTIP,
                    2L
                ),
                new SettingLevel(
                    "Optimistic",
                    SETTINGS.STRESS.LEVELS.OPTIMISTIC.NAME,
                    SETTINGS.STRESS.LEVELS.OPTIMISTIC.TOOLTIP,
                    1L
                ),
                new SettingLevel(
                    "Default",
                    SETTINGS.STRESS.LEVELS.DEFAULT.NAME,
                    SETTINGS.STRESS.LEVELS.DEFAULT.TOOLTIP,
                    0L
                ),
                new SettingLevel(
                    "Pessimistic",
                    SETTINGS.STRESS.LEVELS.PESSIMISTIC.NAME,
                    SETTINGS.STRESS.LEVELS.PESSIMISTIC.TOOLTIP,
                    3L
                ),
                new SettingLevel(
                    "Doomed",
                    SETTINGS.STRESS.LEVELS.DOOMED.NAME,
                    SETTINGS.STRESS.LEVELS.DOOMED.TOOLTIP,
                    4L
                ),
            },
            "Default",
            "Optimistic",
            8L
        );

        public static SettingConfig StressBreaks = new ToggleSettingConfig(
            "StressBreaks",
            SETTINGS.STRESS_BREAKS.NAME,
            SETTINGS.STRESS_BREAKS.TOOLTIP,
            new SettingLevel(
                "Disabled",
                SETTINGS.STRESS_BREAKS.LEVELS.DISABLED.NAME,
                SETTINGS.STRESS_BREAKS.LEVELS.DISABLED.TOOLTIP,
                1L
            ),
            new SettingLevel(
                "Default",
                SETTINGS.STRESS_BREAKS.LEVELS.DEFAULT.NAME,
                SETTINGS.STRESS_BREAKS.LEVELS.DEFAULT.TOOLTIP,
                0L
            ),
            "Default",
            "Default",
            5L
        );

        public static SettingConfig CarePackages = new ToggleSettingConfig(
            "CarePackages",
            SETTINGS.CAREPACKAGES.NAME,
            SETTINGS.CAREPACKAGES.TOOLTIP,
            new SettingLevel(
                "Disabled",
                SETTINGS.CAREPACKAGES.LEVELS.DUPLICANTS_ONLY.NAME,
                SETTINGS.CAREPACKAGES.LEVELS.DUPLICANTS_ONLY.TOOLTIP,
                1L
            ),
            new SettingLevel(
                "Enabled",
                SETTINGS.CAREPACKAGES.LEVELS.NORMAL.NAME,
                SETTINGS.CAREPACKAGES.LEVELS.NORMAL.TOOLTIP,
                0L
            ),
            "Enabled",
            "Enabled",
            5L
        );

        public static SettingConfig Teleporters = new ToggleSettingConfig(
            "Teleporters",
            SETTINGS.TELEPORTERS.NAME,
            SETTINGS.TELEPORTERS.TOOLTIP,
            new SettingLevel(
                "Disabled",
                SETTINGS.TELEPORTERS.LEVELS.DISABLED.NAME,
                SETTINGS.TELEPORTERS.LEVELS.DISABLED.TOOLTIP,
                1L
            ),
            new SettingLevel(
                "Enabled",
                SETTINGS.TELEPORTERS.LEVELS.ENABLED.NAME,
                SETTINGS.TELEPORTERS.LEVELS.ENABLED.TOOLTIP,
                0L
            ),
            "Enabled",
            "Enabled",
            5L,
            required_content: DlcManager.EXPANSION1
        );

        public static SettingConfig MeteorShowers = new ListSettingConfig(
            "MeteorShowers",
            SETTINGS.METEORSHOWERS.NAME,
            SETTINGS.METEORSHOWERS.TOOLTIP,
            new List<SettingLevel>
            {
                new SettingLevel(
                    "ClearSkies",
                    SETTINGS.METEORSHOWERS.LEVELS.CLEAR_SKIES.NAME,
                    SETTINGS.METEORSHOWERS.LEVELS.CLEAR_SKIES.TOOLTIP,
                    2L
                ),
                new SettingLevel(
                    "Infrequent",
                    SETTINGS.METEORSHOWERS.LEVELS.INFREQUENT.NAME,
                    SETTINGS.METEORSHOWERS.LEVELS.INFREQUENT.TOOLTIP,
                    1L
                ),
                new SettingLevel(
                    "Default",
                    SETTINGS.METEORSHOWERS.LEVELS.DEFAULT.NAME,
                    SETTINGS.METEORSHOWERS.LEVELS.DEFAULT.TOOLTIP,
                    0L
                ),
                new SettingLevel(
                    "Intense",
                    SETTINGS.METEORSHOWERS.LEVELS.INTENSE.NAME,
                    SETTINGS.METEORSHOWERS.LEVELS.INTENSE.TOOLTIP,
                    3L
                ),
                new SettingLevel(
                    "Doomed",
                    SETTINGS.METEORSHOWERS.LEVELS.DOOMED.NAME,
                    SETTINGS.METEORSHOWERS.LEVELS.DOOMED.TOOLTIP,
                    4L
                ),
            },
            "Default",
            "Infrequent",
            8L
        );
    }
}
