using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace FruitTracker {
    public partial class MapPanel : UserControl {
        private static readonly IconManager IM = IconManager.Instance;

        private static readonly Color clearedColor = Color.FromArgb(192, 128, 128, 128);
        private static readonly Color entranceColor = ColorTranslator.FromHtml("#3ECF00");
        private static readonly Color dropdownColor = ColorTranslator.FromHtml("#64D3FF");
        private static readonly Color itemColor = ColorTranslator.FromHtml("#F4FF55");

        private static readonly Brush clearedBrush = new SolidBrush(clearedColor);
        private static readonly Brush entranceBrush = new SolidBrush(entranceColor);
        private static readonly Brush dropdownBrush = new SolidBrush(dropdownColor);
        private static readonly Brush itemBrush = new SolidBrush(itemColor);

        private static readonly Pen iconOutline = new(Color.Black, 3);

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public float IconSize { get; set; } = 28;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Image? MapImage { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public List<MapIcon> Locations { get; set; } = new();

        public event Action<MapIcon, Point>? OnMapIconHover;
        public event Action<MouseButtons, MapIcon, Point>? OnMapIconSelect;
        public event Action? OnMapIconExit;
        public event Action? OnMapIconDeselect;


        public MapPanel() {
            InitializeComponent();

            SetStyle(ControlStyles.UserPaint, true);
        }

        public void UpdateIcon(MapIcon icon) {
            if (Locations.Contains(icon)) {
                RectangleF rect = new() {
                    X = icon.X * Width - IconSize / 2 - 3,
                    Y = icon.Y * Height - IconSize / 2 - 3,
                    Width = IconSize + 7,
                    Height = IconSize + 7,
                };
                Invalidate(Rectangle.Round(rect));
            }
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            if (MapImage != null) {
                e.Graphics.DrawImage(MapImage, ClientRectangle);
            }

            foreach (MapIcon loc in Locations) {
                RectangleF outerRect = new() {
                    X = loc.X * Width - IconSize / 2,
                    Y = loc.Y * Height - IconSize / 2,
                    Width = IconSize,
                    Height = IconSize,
                };
                int innerWidth = (int) Math.Round(IconSize * 0.75f) - 1;

                Rectangle innerRect = new() {
                    X = (int) Math.Round(loc.X * Width - innerWidth / 2),
                    Y = (int) Math.Round(loc.Y * Height - innerWidth / 2),
                    Width = innerWidth,
                    Height = innerWidth,
                };
                if (loc.Cleared) {
                    e.Graphics.FillEllipse(clearedBrush, innerRect);
                    e.Graphics.DrawEllipse(iconOutline, innerRect);
                } else if (loc.DisplayIcon != null) {
                    loc.DisplayIcon.Draw(e.Graphics, outerRect);
                } else {
                    Brush brush = loc.Type switch {
                        LocationType.Entrance => entranceBrush,
                        LocationType.DropdownEntrance => entranceBrush,
                        LocationType.Dropdown => dropdownBrush,
                        LocationType.Item => itemBrush,
                        _ => entranceBrush,
                    };
                    e.Graphics.FillEllipse(brush, innerRect);
                    e.Graphics.DrawEllipse(iconOutline, innerRect);
                }
                if (loc.Annotations.Count > 0) {
                    innerRect.Width += 1;
                    innerRect.Height += 1;
                    e.Graphics.DrawImage(IM.GetImage("plus"), innerRect);
                }
            }
        }

        private void MapPanel_MouseMove(object sender, MouseEventArgs e) {
            MapIcon? icon = GetClosestMapIcon(e.Location);
            if (icon != null) {
                OnMapIconHover?.Invoke(icon, PointToScreen(GetIconPoint(icon)));
            } else {
                OnMapIconExit?.Invoke();
            }
        }

        private void MapPanel_MouseDown(object sender, MouseEventArgs e) {
            MapIcon? icon = GetClosestMapIcon(e.Location);
            if (icon != null) {
                OnMapIconSelect?.Invoke(e.Button, icon, PointToScreen(GetIconPoint(icon)));
            } else {
                OnMapIconDeselect?.Invoke();
            }
        }

        private MapIcon? GetClosestMapIcon(Point p) {
            float minDist = float.MaxValue;
            MapIcon? closest = null;
            foreach (MapIcon icon in Locations) {
                float dist = GetDist2(p, icon);
                if (dist < minDist) {
                    closest = icon;
                    minDist = dist;
                }
            }

            if (minDist < IconSize * IconSize / 4) {
                return closest;
            } else {
                return null;
            }
        }

        private float GetDist2(Point a, MapIcon icon) {
            float x = icon.X * Width - a.X;
            float y = icon.Y * Height - a.Y;
            return x * x + y * y;
        }

        private Point GetIconPoint(MapIcon icon) {
            return new Point((int) (icon.X * Width), (int) (icon.Y * Height));
        }
    }
}
