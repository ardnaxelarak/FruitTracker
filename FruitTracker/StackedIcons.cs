using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace FruitTracker {
    public partial class StackedIcons : UserControl {
        private static readonly IconManager IM = IconManager.Instance;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public List<Image> Icons { get; set; } = new();

        public event Action<MouseButtons>? OnIconClicked;

        public StackedIcons() {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);

            e.Graphics.Clear(BackColor);

            e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
            e.Graphics.SmoothingMode = SmoothingMode.None;

            Console.WriteLine(ClientRectangle);

            foreach (Image img in Icons) {
                e.Graphics.DrawImage(img, ClientRectangle);
            }
        }

        private void StackedIcons_MouseClick(object sender, MouseEventArgs e) {
            OnIconClicked?.Invoke(e.Button);
        }
    }
}
