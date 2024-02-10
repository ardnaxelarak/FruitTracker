using ALttPREffectProcessor;
using FruitTracker.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FruitTracker {
    public partial class KeyBox : UserControl {
        private int maxKeys = 1;
        private int keys = 0;

        public Dungeon DungeonId { get; set; }

        public int MaxKeys {
            get => maxKeys;
            set {
                if (value >= 0) {
                    maxKeys = value;
                }
                if (keys > maxKeys) {
                    Keys = maxKeys;
                } else {
                    counterLabel.ForeColor = keys < maxKeys ? Color.White : Color.Lime;
                }
            }
        }

        public int Keys {
            get => keys;
            set {
                if (keys != value) {
                    if (value < 0) {
                        keys = 0;
                    } else if (value > maxKeys) {
                        keys = maxKeys;
                    } else {
                        keys = value;
                    }
                    counterLabel.Text = keys.ToString();
                    counterLabel.Left = this.Width - 7 - counterLabel.Width;
                    counterLabel.ForeColor = keys < maxKeys ? Color.White : Color.Lime;
                    keyIconBox.Image = keys > 0 ? Inventory.smallkey : Inventory.no_smallkey;

                    TrackerManager.Instance.Tracker?.UpdateKeys(DungeonId.ToString(), keys, keys == maxKeys);
                }
            }
        }

        public KeyBox() {
            InitializeComponent();
        }

        public void UpdateBroadcast() {
            TrackerManager.Instance.Tracker?.UpdateKeys(DungeonId.ToString(), keys, keys == maxKeys);
        }

        private void keyIconBox_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                if (keys < maxKeys) {
                    Keys++;
                }
            } else if (e.Button == MouseButtons.Right) {
                if (keys > 0) {
                    Keys--;
                }
            }
        }
    }
}
