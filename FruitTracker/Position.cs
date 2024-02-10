using System.Drawing;
using System.Windows.Forms;

namespace FruitTracker {
    public struct Position {
        public int X { get; set; }
        public int Y { get; set; }
        public AnchorStyles Anchor { get; set; }

        public void SetLocation(Control control) {
            control.Left = X;
            control.Top = Y;

            if (Anchor.HasFlag(AnchorStyles.Right)) {
                control.Left -= control.Width;
            }
            if (Anchor.HasFlag(AnchorStyles.Bottom)) {
                control.Top -= control.Height;
            }
        }
    }
}
