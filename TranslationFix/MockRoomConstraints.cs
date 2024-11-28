using STRINGS;
using static RoomConstraints;

namespace TranslationFix
{
    public static class MockRoomConstraints
    {
        public static Constraint CEILING_HEIGHT_4 = new Constraint(
            null,
            (Room room) => 1 + room.cavity.maxY - room.cavity.minY >= 4,
            1,
            string.Format(ROOMS.CRITERIA.CEILING_HEIGHT.NAME, "4"),
            string.Format(ROOMS.CRITERIA.CEILING_HEIGHT.DESCRIPTION, "4")
        );

        public static Constraint CEILING_HEIGHT_6 = new Constraint(
            null,
            (Room room) => 1 + room.cavity.maxY - room.cavity.minY >= 6,
            1,
            string.Format(ROOMS.CRITERIA.CEILING_HEIGHT.NAME, "6"),
            string.Format(ROOMS.CRITERIA.CEILING_HEIGHT.DESCRIPTION, "6")
        );

        public static Constraint MINIMUM_SIZE_12 = new Constraint(
            null,
            (Room room) => room.cavity.numCells >= 12,
            1,
            string.Format(ROOMS.CRITERIA.MINIMUM_SIZE.NAME, "12"),
            string.Format(ROOMS.CRITERIA.MINIMUM_SIZE.DESCRIPTION, "12")
        );

        public static Constraint MINIMUM_SIZE_24 = new Constraint(
            null,
            (Room room) => room.cavity.numCells >= 24,
            1,
            string.Format(ROOMS.CRITERIA.MINIMUM_SIZE.NAME, "24"),
            string.Format(ROOMS.CRITERIA.MINIMUM_SIZE.DESCRIPTION, "24")
        );

        public static Constraint MINIMUM_SIZE_32 = new Constraint(
            null,
            (Room room) => room.cavity.numCells >= 32,
            1,
            string.Format(ROOMS.CRITERIA.MINIMUM_SIZE.NAME, "32"),
            string.Format(ROOMS.CRITERIA.MINIMUM_SIZE.DESCRIPTION, "32")
        );

        public static Constraint MAXIMUM_SIZE_64 = new Constraint(
            null,
            (Room room) => room.cavity.numCells <= 64,
            1,
            string.Format(ROOMS.CRITERIA.MAXIMUM_SIZE.NAME, "64"),
            string.Format(ROOMS.CRITERIA.MAXIMUM_SIZE.DESCRIPTION, "64")
        );

        public static Constraint MAXIMUM_SIZE_96 = new Constraint(
            null,
            (Room room) => room.cavity.numCells <= 96,
            1,
            string.Format(ROOMS.CRITERIA.MAXIMUM_SIZE.NAME, "96"),
            string.Format(ROOMS.CRITERIA.MAXIMUM_SIZE.DESCRIPTION, "96")
        );

        public static Constraint MAXIMUM_SIZE_120 = new Constraint(
            null,
            (Room room) => room.cavity.numCells <= 120,
            1,
            string.Format(ROOMS.CRITERIA.MAXIMUM_SIZE.NAME, "120"),
            string.Format(ROOMS.CRITERIA.MAXIMUM_SIZE.DESCRIPTION, "120")
        );

        public static Constraint DECORATIVE_ITEM = new Constraint(
            (KPrefabID bc) => bc.HasTag(GameTags.Decoration),
            null,
            1,
            string.Format(ROOMS.CRITERIA.DECORATIVE_ITEM.NAME, 1),
            string.Format(ROOMS.CRITERIA.DECORATIVE_ITEM.DESCRIPTION, 1)
        );

        public static Constraint DECORATIVE_ITEM_2 = new Constraint(
            (KPrefabID bc) => bc.HasTag(GameTags.Decoration),
            null,
            2,
            string.Format(ROOMS.CRITERIA.DECORATIVE_ITEM.NAME, 2),
            string.Format(ROOMS.CRITERIA.DECORATIVE_ITEM.DESCRIPTION, 2)
        );

        public static Constraint DECORATIVE_ITEM_SCORE_20 = new Constraint(
            (KPrefabID bc) => bc.HasTag(GameTags.Decoration) && bc.HasTag(ConstraintTags.Decor20),
            null,
            1,
            string.Format(ROOMS.CRITERIA.DECOR20.NAME, "20"),
            string.Format(ROOMS.CRITERIA.DECOR20.DESCRIPTION, "20")
        );

        public static Constraint POWER_STATION = new Constraint(
            (KPrefabID bc) => bc.HasTag(ConstraintTags.HeavyDutyGeneratorType),
            delegate(Room room)
            {
                int num7 = 0;
                bool flag2 = false;
                foreach (KPrefabID building5 in room.buildings)
                {
                    flag2 = flag2 || building5.HasTag(ConstraintTags.HeavyDutyGeneratorType);
                    num7 += (building5.HasTag(ConstraintTags.PowerBuilding) ? 1 : 0);
                }
                return flag2 && num7 >= 2;
            },
            1,
            ROOMS.CRITERIA.POWERPLANT.NAME,
            ROOMS.CRITERIA.POWERPLANT.DESCRIPTION,
            null,
            ROOMS.CRITERIA.POWERPLANT.CONFLICT_DESCRIPTION
        );
    }
}
