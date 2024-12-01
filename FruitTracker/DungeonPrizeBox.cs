using ALttPREffectProcessor;
using FruitTracker.Properties;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FruitTracker {
    public partial class DungeonPrizeBox : UserControl {
        private static readonly Dictionary<Prize, string> prizeIconSource = new() {
            [Prize.Unknown] = "prize_unknown",
            [Prize.Crystal] = "prize_crystal",
            [Prize.RedCrystal] = "prize_redcrystal",
            [Prize.Pendant] = "prize_pendant",
            [Prize.GreenPendant] = "prize_greenpendant",
        };

        private static readonly Dictionary<Prize, Image> prizeIconHas = new() {
            [Prize.Unknown] = Inventory.prize_unknown,
            [Prize.Crystal] = Inventory.prize_crystal,
            [Prize.RedCrystal] = Inventory.prize_redcrystal,
            [Prize.Pendant] = Inventory.prize_pendant,
            [Prize.GreenPendant] = Inventory.prize_greenpendant,
        };

        private static readonly Dictionary<Prize, Image> prizeIconHasNot = new() {
            [Prize.Unknown] = Inventory.no_prize_unknown,
            [Prize.Crystal] = Inventory.no_prize_crystal,
            [Prize.RedCrystal] = Inventory.no_prize_redcrystal,
            [Prize.Pendant] = Inventory.no_prize_pendant,
            [Prize.GreenPendant] = Inventory.no_prize_greenpendant,
        };

        private static readonly Dictionary<Dungeon, string> dungeonIconSource = new() {
            [Dungeon.Sewers] = "HC",
            [Dungeon.HyruleCastle] = "HC",
            [Dungeon.EasternPalace] = "EP",
            [Dungeon.DesertPalace] = "DP",
            [Dungeon.TowerOfHera] = "TH",
            [Dungeon.CastleTower] = "AT",
            [Dungeon.PalaceOfDarkness] = "PD",
            [Dungeon.SwampPalace] = "SP",
            [Dungeon.SkullWoods] = "SW",
            [Dungeon.ThievesTown] = "TT",
            [Dungeon.IcePalace] = "IP",
            [Dungeon.MiseryMire] = "MM",
            [Dungeon.TurtleRock] = "TR",
            [Dungeon.GanonsTower] = "GT",
        };

        private static readonly Dictionary<Dungeon, Image> dungeonIconHas = new() {
            [Dungeon.Sewers] = Inventory.HC,
            [Dungeon.HyruleCastle] = Inventory.HC,
            [Dungeon.EasternPalace] = Inventory.EP,
            [Dungeon.DesertPalace] = Inventory.DP,
            [Dungeon.TowerOfHera] = Inventory.TH,
            [Dungeon.CastleTower] = Inventory.AT,
            [Dungeon.PalaceOfDarkness] = Inventory.PD,
            [Dungeon.SwampPalace] = Inventory.SP,
            [Dungeon.SkullWoods] = Inventory.SW,
            [Dungeon.ThievesTown] = Inventory.TT,
            [Dungeon.IcePalace] = Inventory.IP,
            [Dungeon.MiseryMire] = Inventory.MM,
            [Dungeon.TurtleRock] = Inventory.TR,
            [Dungeon.GanonsTower] = Inventory.GT,
        };

        private static readonly Dictionary<Dungeon, Image> dungeonIconHasNot = new() {
            [Dungeon.Sewers] = Inventory.HC_dark,
            [Dungeon.HyruleCastle] = Inventory.HC_dark,
            [Dungeon.EasternPalace] = Inventory.EP_dark,
            [Dungeon.DesertPalace] = Inventory.DP_dark,
            [Dungeon.TowerOfHera] = Inventory.TH_dark,
            [Dungeon.CastleTower] = Inventory.AT_dark,
            [Dungeon.PalaceOfDarkness] = Inventory.PD_dark,
            [Dungeon.SwampPalace] = Inventory.SP_dark,
            [Dungeon.SkullWoods] = Inventory.SW_dark,
            [Dungeon.ThievesTown] = Inventory.TT_dark,
            [Dungeon.IcePalace] = Inventory.IP_dark,
            [Dungeon.MiseryMire] = Inventory.MM_dark,
            [Dungeon.TurtleRock] = Inventory.TR_dark,
            [Dungeon.GanonsTower] = Inventory.GT_dark,
        };

        private Prize prize = Prize.Unknown;
        private Dungeon dungeon;
        private bool completed;

        public Prize PrizeIcon {
            get => prize;
            set {
                if (prize != value) {
                    prize = value;
                    SetImages();
                }
            }
        }

        public Dungeon DungeonIcon {
            get => dungeon;
            set {
                if (dungeon != value) {
                    dungeon = value;
                    SetImages();
                }
            }
        }

        public bool Completed {
            get => completed;
            set {
                if (completed != value) {
                    completed = value;
                    SetImages();
                }
            }
        }

        public bool ShowPrize {
            get => prizeBox.Visible;
            set => prizeBox.Visible = value;
        }

        private void SetImages() {
            string prizeImage;
            string dungeonImage;
            if (completed) {
                prizeBox.Image = prizeIconHas[prize];
                prizeImage = $"icons/dungeons/{prizeIconSource[prize]}.png";
                dungeonBox.Image = dungeonIconHas[dungeon];
                dungeonImage = $"icons/dungeons/{dungeonIconSource[dungeon]}.png";
            } else {
                prizeBox.Image = prizeIconHasNot[prize];
                prizeImage = $"icons/dungeons/no_{prizeIconSource[prize]}.png";
                dungeonBox.Image = dungeonIconHasNot[DungeonIcon];
                dungeonImage = $"icons/dungeons/{dungeonIconSource[DungeonIcon]}_dark.png";
            }

            TrackerManager.Instance.Tracker.UpdateDungeonPrize(DungeonIcon.ToString(), dungeonImage, prizeImage);
        }

        public enum Prize {
            Unknown,
            Pendant,
            GreenPendant,
            Crystal,
            RedCrystal,
        }

        public DungeonPrizeBox() {
            InitializeComponent();
            SetImages();
        }

        public void UpdateBroadcast() {
            SetImages();
        }

        private static Prize NextPrize(Prize current) {
            return current switch {
                Prize.Crystal => Prize.RedCrystal,
                Prize.RedCrystal => Prize.Pendant,
                Prize.Pendant => Prize.GreenPendant,
                Prize.GreenPendant => Prize.Unknown,
                _ => Prize.Crystal,
            };
        }

        private static Prize PrevPrize(Prize current) {
            return current switch {
                Prize.Crystal => Prize.Unknown,
                Prize.RedCrystal => Prize.Crystal,
                Prize.Pendant => Prize.RedCrystal,
                Prize.GreenPendant => Prize.Pendant,
                _ => Prize.GreenPendant,
            };
        }

        private void dungeonBox_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                Completed = !Completed;
            } else if (e.Button == MouseButtons.Right) {
                PrizeIcon = NextPrize(PrizeIcon);
            }
        }

        private void prizeBox_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                PrizeIcon = PrevPrize(PrizeIcon);
            } else if (e.Button == MouseButtons.Right) {
                PrizeIcon = NextPrize(PrizeIcon);
            }
        }
    }
}
