using ALttPREffectProcessor;
using FruitTracker.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using KeyCode = System.Windows.Forms.Keys;

namespace FruitTracker {
    public partial class KeyBox : UserControl {
        private int maxKeys = 1;
        private int keys = 999;
        private int tempInput = 0;
        private bool hasFocus = false;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Dungeon DungeonId { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
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

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
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

                    TrackerManager.Instance.Tracker.UpdateKeys(DungeonId.ToString(), keys, keys == maxKeys);
                }
            }
        }

        public KeyBox() {
            InitializeComponent();
        }

        public void UpdateBroadcast() {
            TrackerManager.Instance.Tracker.UpdateKeys(DungeonId.ToString(), keys, keys == maxKeys);
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

        private void KeyBox_Load(object sender, EventArgs e) {
            Keys = 0;
        }

        private void KeyBox_MouseLeave(object sender, EventArgs e) {
            tempInput = 0;
            hasFocus = false;
        }

        private void KeyBox_KeyDown(object sender, KeyEventArgs e) {
            if (!hasFocus) {
                return;
            }
            int? value = null;
            if (e.KeyCode >= KeyCode.D0 && e.KeyCode <= KeyCode.D9) {
                value = e.KeyCode - KeyCode.D0;
            } else if (e.KeyCode >= KeyCode.NumPad0 && e.KeyCode <= KeyCode.NumPad9) {
                value = e.KeyCode - KeyCode.NumPad0;
            }
            if (value != null) {
                tempInput = (tempInput * 10) + value.Value;
                return;
            }
            if (e.KeyCode == KeyCode.Enter || e.KeyCode == KeyCode.Return) {
                if (tempInput > 0 && tempInput < 999) {
                    this.MaxKeys = tempInput;
                }
            }
            if (e.KeyCode == KeyCode.Delete || e.KeyCode == KeyCode.Back) {
                this.MaxKeys = 999;
                tempInput = 0;
            }
        }

        private void KeyBox_MouseEnter(object sender, EventArgs e) {
            Focus();
            hasFocus = true;
        }
    }
}
