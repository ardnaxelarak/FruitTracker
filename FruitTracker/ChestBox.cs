using ALttPREffectProcessor;
using FruitTracker.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FruitTracker {
    public partial class ChestBox : UserControl {
        private int maxChecks;
        private int checks;

        public Dungeon DungeonId { get; set; }

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

        private void chestIconBox_MouseClick(object sender, MouseEventArgs e) {
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
    }
}
