﻿using System;
using System.Windows.Forms;

namespace FruitTracker {
    public partial class IconPanel : UserControl {
        public Icon? Icon { get; set; }

        public event Action<Icon>? OnIconClicked;

        public IconPanel() {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);

            e.Graphics.Clear(BackColor);

            if (Icon != null) {
                Icon.Draw(e.Graphics, ClientRectangle);
            }
        }

        private void IconPanel_Click(object sender, EventArgs e) {
            if (Icon != null) {
                OnIconClicked?.Invoke(Icon);
            }
        }
    }
}
