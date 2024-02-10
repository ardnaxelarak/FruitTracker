using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FruitTracker {
    internal class InventoryIcon : StackedIcons {
        private static readonly IconManager IM = IconManager.Instance;

        private int value = 999;
        public int Value {
            get {
                return this.value;
            } 
            set {
                if (this.value != value) {
                    this.value = value;
                    if (value < images.Length) {
                        Icons.Clear();
                        Icons.AddRange(images[value]);
                        Refresh();
                    }
                    if (CellId.Length > 0) {
                        TrackerManager.Instance.Tracker?.UpdateItem(CellId, imageSources[value]);
                    }
                }
            }
        }

        private Image[][] images = Array.Empty<Image[]>();
        private string[][] imageSources = Array.Empty<string[]>();

        public string CellId { get; set; } = "";

        public string[][] ImageSets {
            set {
                images = value.Select(row => row.Select(item => IM.GetImage($"items/{item}")).ToArray()).ToArray();
                imageSources = value.Select(row => row.Select(item => $"icons/items/{item}.png").ToArray()).ToArray();
            }
        }

        public InventoryIcon() : base() {
            Dock = DockStyle.Fill;
            Margin = new Padding(0);
            OnIconClicked += OnClicked;
        }

        public void UpdateBroadcast() {
            if (CellId.Length > 0) {
                TrackerManager.Instance.Tracker?.UpdateItem(CellId, imageSources[value]);
            }
        }

        private void OnClicked(MouseButtons button) {
            if (button == MouseButtons.Left) {
                if (Value < images.Length - 1) {
                    Value++;
                }
            } else if (button == MouseButtons.Right) {
                if (Value > 0) {
                    Value--;
                }
            }
        }
    }
}
