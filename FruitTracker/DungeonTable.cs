using ALttPREffectProcessor;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace FruitTracker {
    public partial class DungeonTable : UserControl {
        private static readonly Dictionary<Dungeon, int> baseChecks = new() {
            [Dungeon.HyruleCastle] = 6,
            [Dungeon.EasternPalace] = 3,
            [Dungeon.DesertPalace] = 2,
            [Dungeon.TowerOfHera] = 2,
            [Dungeon.CastleTower] = 0,
            [Dungeon.PalaceOfDarkness] = 5,
            [Dungeon.SwampPalace] = 6,
            [Dungeon.SkullWoods] = 2,
            [Dungeon.ThievesTown] = 4,
            [Dungeon.IcePalace] = 3,
            [Dungeon.MiseryMire] = 2,
            [Dungeon.TurtleRock] = 5,
            [Dungeon.GanonsTower] = 20,
        };

        private static readonly Dictionary<Dungeon, int> keys = new() {
            [Dungeon.HyruleCastle] = 1,
            [Dungeon.EasternPalace] = 0,
            [Dungeon.DesertPalace] = 1,
            [Dungeon.TowerOfHera] = 1,
            [Dungeon.CastleTower] = 2,
            [Dungeon.PalaceOfDarkness] = 6,
            [Dungeon.SwampPalace] = 1,
            [Dungeon.SkullWoods] = 3,
            [Dungeon.ThievesTown] = 1,
            [Dungeon.IcePalace] = 2,
            [Dungeon.MiseryMire] = 3,
            [Dungeon.TurtleRock] = 4,
            [Dungeon.GanonsTower] = 4,
        };

        private Tracking? tracking;
        private readonly Dictionary<Dungeon, DungeonBoxes> boxes = new();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool ShuffleMaps { get; set; } = false;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool ShuffleCompasses { get; set; } = false;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool ShuffleSmallKeys { get; set; } = false;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool ShuffleBigKeys { get; set; } = false;

        private bool doorShuffle = false;

        private struct DungeonBoxes {
            public DungeonPrizeBox? PrizeBox;
            public ChestBox? ChestBox;
            public KeyBox? KeyBox;
            public DungeonItemBox? DungeonItemBox;
        }

        public DungeonTable() {
            InitializeComponent();

            boxes[Dungeon.HyruleCastle] = new() {
                PrizeBox = hyruleCastlePrizeBox,
                ChestBox = hyruleCastleChestBox,
				KeyBox = hyruleCastleSmallKeys,
                DungeonItemBox = hyruleCastleDungeonItems,
            };

            boxes[Dungeon.EasternPalace] = new() {
                PrizeBox = easternPrizeBox,
                ChestBox = easternChestBox,
				KeyBox = easternSmallKeys,
                DungeonItemBox = easternDungeonItems,
            };

            boxes[Dungeon.DesertPalace] = new() {
                PrizeBox = desertPrizeBox,
                ChestBox = desertChestBox,
				KeyBox = desertSmallKeys,
                DungeonItemBox = desertDungeonItems,
            };

            boxes[Dungeon.TowerOfHera] = new() {
                PrizeBox = heraPrizeBox,
                ChestBox = heraChestBox,
				KeyBox = heraSmallKeys,
                DungeonItemBox = heraDungeonItems,
            };

            boxes[Dungeon.CastleTower] = new() {
                PrizeBox = castleTowerPrizeBox,
                ChestBox = castleTowerChestBox,
                KeyBox = castleTowerSmallKeys,
                DungeonItemBox = castleTowerDungeonItems,
            };

            boxes[Dungeon.PalaceOfDarkness] = new() {
                PrizeBox = podPrizeBox,
                ChestBox = podChestBox,
				KeyBox = podSmallKeys,
                DungeonItemBox = podDungeonItems,
            };

            boxes[Dungeon.SwampPalace] = new() {
                PrizeBox = swampPrizeBox,
                ChestBox = swampChestBox,
				KeyBox = swampSmallKeys,
                DungeonItemBox = swampDungeonItems,
            };

            boxes[Dungeon.SkullWoods] = new() {
                PrizeBox = skullPrizeBox,
                ChestBox = skullChestBox,
				KeyBox = skullSmallKeys,
                DungeonItemBox = skullDungeonItems,
            };

            boxes[Dungeon.ThievesTown] = new() {
                PrizeBox = thievesPrizeBox,
                ChestBox = thievesChestBox,
				KeyBox = thievesSmallKeys,
                DungeonItemBox = thievesDungeonItems,
            };

            boxes[Dungeon.IcePalace] = new() {
                PrizeBox = icePrizeBox,
                ChestBox = iceChestBox,
				KeyBox = iceSmallKeys,
                DungeonItemBox = iceDungeonItems,
            };

            boxes[Dungeon.MiseryMire] = new() {
                PrizeBox = mirePrizeBox,
                ChestBox = mireChestBox,
				KeyBox = mireSmallKeys,
                DungeonItemBox = mireDungeonItems,
            };

            boxes[Dungeon.TurtleRock] = new() {
                PrizeBox = turtlePrizeBox,
                ChestBox = turtleChestBox,
				KeyBox = turtleSmallKeys,
                DungeonItemBox = turtleDungeonItems,
            };

            boxes[Dungeon.GanonsTower] = new() {
                PrizeBox = ganonsTowerPrizeBox,
                ChestBox = ganonsTowerChestBox,
				KeyBox = ganonsTowerSmallKeys,
                DungeonItemBox = ganonsTowerDungeonItems,
            };
        }

        public void SetAutoTracker(Tracking tracking) {
            this.tracking = tracking;
            tracking.OnReceiveUpdate += AutoTrackerUpdate;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool DoorShuffle {
            get => doorShuffle;
            set {
                if (doorShuffle == value) {
                    return;
                }

                doorShuffle = value;
                hyruleCastleDungeonItems.ShowCompass = doorShuffle;
                castleTowerDungeonItems.Visible = doorShuffle;

                ResetMaxCheckCounts();
            }
        }

        private void AutoTrackerUpdate() {
            if (tracking == null) {
                return;
            }

            foreach (KeyValuePair<Dungeon, DungeonBoxes> kvp in boxes) {
                if (kvp.Value.KeyBox != null) {
                    if (tracking.SmallKeys[kvp.Key] is IEquipment keys) {
                        kvp.Value.KeyBox.Keys = keys.Value;
                    }
                }
                if (kvp.Value.DungeonItemBox != null) {
                    if (tracking.BigKey[kvp.Key] is IEquipment bigkey) {
                        kvp.Value.DungeonItemBox.BigKey = bigkey.Value > 0;
                    }
                    if (tracking.Map[kvp.Key] is IEquipment map) {
                        kvp.Value.DungeonItemBox.Map = map.Value > 0;
                    }
                    if (tracking.Compass[kvp.Key] is IEquipment compass) {
                        kvp.Value.DungeonItemBox.Compass = compass.Value > 0;
                    }
                }
                if (kvp.Value.PrizeBox != null) {
                    if (tracking.Bosses[kvp.Key] is IEquipment boss) {
                        kvp.Value.PrizeBox.Completed = boss.Value > 0;
                    }
                }
            }
        }

        public void UpdateBroadcastView() {
            foreach (DungeonBoxes boxes in boxes.Values) {
                boxes.KeyBox?.UpdateBroadcast();
                boxes.ChestBox?.UpdateBroadcast();
                boxes.DungeonItemBox?.UpdateBroadcast();
                boxes.PrizeBox?.UpdateBroadcast();
            }
        }

        public void UpdateMaxCheckCounts() {
            if (!DoorShuffle) {
                foreach (KeyValuePair<Dungeon, DungeonBoxes> kvp in boxes) {
                    if (kvp.Value.ChestBox is ChestBox chestBox) {
                        int count = baseChecks[kvp.Key];
                        if (ShuffleSmallKeys) {
                            count += keys[kvp.Key];
                        }
                        if (kvp.Key != Dungeon.CastleTower) {
                            if (ShuffleMaps) {
                                count += 1;
                            }
                            if (kvp.Key != Dungeon.HyruleCastle) {
                                if (ShuffleBigKeys) {
                                    count += 1;
                                }
                                if (ShuffleCompasses) {
                                    count += 1;
                                }
                            }
                        }
                        chestBox.MaxChecks = count;
                    }
                    if (kvp.Value.KeyBox is KeyBox keyBox) {
                        keyBox.MaxKeys = keys[kvp.Key];
                    }
                }
            }
        }

        public void ResetPrizeBoxes() {
            foreach (KeyValuePair<Dungeon, DungeonBoxes> kvp in boxes) {
                if (kvp.Value.PrizeBox is DungeonPrizeBox prizeBox) {
                    prizeBox.PrizeIcon = DungeonPrizeBox.Prize.Unknown;
                    prizeBox.Completed = false;
                }
            }
        }

        public void ResetMaxCheckCounts() {
            if (!DoorShuffle) {
                UpdateMaxCheckCounts();
            } else {
                foreach (KeyValuePair<Dungeon, DungeonBoxes> kvp in boxes) {
                    if (kvp.Value.ChestBox is ChestBox chestBox) {
                        chestBox.MaxChecks = 999;
                    }
                    if (kvp.Value.KeyBox is KeyBox keyBox) {
                        keyBox.MaxKeys = 999;
                    }
                }
            }
        }

        public void ResetCheckCounts() {
            foreach (KeyValuePair<Dungeon, DungeonBoxes> kvp in boxes) {
                if (kvp.Value.ChestBox is ChestBox chestBox) {
                    chestBox.Checks = -1;
                }
            }
        }

        public void ResetKeyCounts() {
            foreach (KeyValuePair<Dungeon, DungeonBoxes> kvp in boxes) {
                if (kvp.Value.KeyBox is KeyBox keyBox) {
                    keyBox.Keys = -1;
                }
            }
        }

        public void ResetDungeonItems() {
            foreach (KeyValuePair<Dungeon, DungeonBoxes> kvp in boxes) {
                if (kvp.Value.DungeonItemBox is DungeonItemBox itemBox) {
                    itemBox.Compass = false;
                    itemBox.Map = false;
                    itemBox.BigKey = false;
                }
            }
        }
    }
}
