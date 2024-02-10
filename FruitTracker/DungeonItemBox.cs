using ALttPREffectProcessor;
using FruitTracker.Properties;
using System.Windows.Forms;

namespace FruitTracker {
    public partial class DungeonItemBox : UserControl {
        private bool bigkey;
        private bool map;
        private bool compass;

        private bool showCompass = true;

        public Dungeon DungeonId { get; set; }

        public bool BigKey {
            get => bigkey;
            set {
                if (bigkey != value) {
                    bigkey = value;
                    bigkeyBox.Image = bigkey ? Inventory.bigkey : Inventory.no_bigkey;
                    TrackerManager.Instance.Tracker?.UpdateBigKey(DungeonId.ToString(), bigkey);
                }
            }
        }

        public bool Map {
            get => map;
            set {
                map = value;
                mapBox.Image = map ? Inventory.map : Inventory.no_map;
            }
        }

        public bool Compass {
            get => compass;
            set {
                compass = value;
                compassBox.Image = compass ? Inventory.compass : Inventory.no_compass;
            }
        }

        public bool ShowCompass {
            get => showCompass;
            set {
                showCompass = value;
                compassBox.Visible = showCompass;
            }
        }

        public DungeonItemBox() {
            InitializeComponent();
        }

        public void UpdateBroadcast() {
            TrackerManager.Instance.Tracker?.UpdateBigKey(DungeonId.ToString(), bigkey);
        }

        private void bigkeyBox_Click(object sender, System.EventArgs e) {
            BigKey = !BigKey;
        }

        private void mapBox_Click(object sender, System.EventArgs e) {
            Map = !Map;
        }

        private void compassBox_Click(object sender, System.EventArgs e) {
            Compass = !Compass;
        }
    }
}
