using ALttPREffectProcessor;
using FruitTracker.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FruitTracker {
    public partial class ChestBox : UserControl {
        private int maxChecks;
        private int checks;
        private int tempInput = 0;
        private bool hasFocus = false;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Dungeon DungeonId { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int MaxChecks {
            get => maxChecks;
            set {
                if (value >= 0) {
                    maxChecks = value;
                }
                if (checks > maxChecks) {
                    Checks = maxChecks;
                } else {
                    UpdateGraphics();
                }
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int Checks {
            get => checks;
            set {
                if (checks != value) {
                    if (value < 0) {
                        checks = 0;
                    } else if (value > maxChecks) {
                        checks = maxChecks;
                    } else {
                        checks = value;
                    }
                    UpdateGraphics();
                }
            }
        }

        private void UpdateGraphics() {
            if (maxChecks == 999) {
                counterLabel.Text = checks.ToString();
                counterLabel.ForeColor = Color.Tomato;
            } else {
                counterLabel.Text = (maxChecks - checks).ToString();
                counterLabel.ForeColor = checks > 0 ? Color.Yellow : Color.Orange;
            }
            counterLabel.Left = this.Width - 4 - counterLabel.Width;
            counterLabel.Visible = checks < maxChecks;
            chestIconBox.Image = checks < maxChecks ? Resources.chest : Resources.chest_opened;
        }

        public ChestBox() {
            InitializeComponent();
        }

        public void UpdateBroadcast() {
        }

        private void ChestIconBox_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                if (checks < maxChecks) {
                    Checks++;
                }
            } else if (e.Button == MouseButtons.Right) {
                if (checks > 0) {
                    Checks--;
                }
            }
        }

        private void ChestBox_MouseLeave(object sender, EventArgs e) {
            tempInput = 0;
            hasFocus = false;
        }

        private void ChestBox_KeyDown(object sender, KeyEventArgs e) {
            if (!hasFocus) {
                return;
            }
            int? value = null;
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) {
                value = e.KeyCode - Keys.D0;
            } else if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) {
                value = e.KeyCode - Keys.NumPad0;
            }
            if (value != null) {
                tempInput = (tempInput * 10) + value.Value;
                return;
            }
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return) {
                if (tempInput > 0 && tempInput < 999) {
                    MaxChecks = tempInput;
                }
            }
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back) {
                MaxChecks = 999;
                tempInput = 0;
            }
        }

        private void ChestBox_MouseEnter(object sender, EventArgs e) {
            Focus();
            hasFocus = true;
        }
    }
}
