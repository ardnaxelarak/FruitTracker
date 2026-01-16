using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace FruitTracker {
    public partial class IconPanel : UserControl {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Icon? Icon { get; set; }

        public event Action<Icon>? OnIconClicked;

        public IconPanel() {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);

            e.Graphics.Clear(BackColor);

            Icon?.Draw(e.Graphics, ClientRectangle);
        }

        private void IconPanel_Click(object sender, EventArgs e) {
            if (Icon != null) {
                OnIconClicked?.Invoke(Icon);
            }
        }
    }
}
