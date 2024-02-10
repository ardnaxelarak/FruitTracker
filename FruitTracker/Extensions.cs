using System.Drawing;

namespace FruitTracker {
    internal static class Extensions {
        private static readonly IconManager IM = IconManager.Instance;

        public static void Draw(this Icon icon, Graphics g, RectangleF rect) {
            if (icon.Filename != null) {
                g.DrawImage(IM.GetImage(icon.Filename), rect);
            }
            if (icon.Overlay != null) {
                RectangleF overlayRect = new() {
                    Width = rect.Width * 0.5f,
                    Height = rect.Height * 0.4f,
                    X = rect.Right - rect.Width * 0.5f,
                    Y = rect.Bottom - rect.Height * 0.4f,
                };
                g.DrawImage(IM.GetImage(icon.Overlay), overlayRect);
            }
        }
    }
}
