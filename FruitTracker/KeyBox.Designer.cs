namespace FruitTracker {
    partial class KeyBox {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.keyIconBox = new System.Windows.Forms.PictureBox();
            this.counterLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) this.keyIconBox).BeginInit();
            this.SuspendLayout();
            // 
            // keyIconBox
            // 
            this.keyIconBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keyIconBox.Image = Properties.Inventory.no_smallkey;
            this.keyIconBox.Location = new System.Drawing.Point(0, 0);
            this.keyIconBox.Margin = new System.Windows.Forms.Padding(0);
            this.keyIconBox.Name = "keyIconBox";
            this.keyIconBox.Size = new System.Drawing.Size(48, 48);
            this.keyIconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.keyIconBox.TabIndex = 0;
            this.keyIconBox.TabStop = false;
            this.keyIconBox.MouseDown += this.keyIconBox_MouseClick;
            this.keyIconBox.MouseEnter += this.KeyBox_MouseEnter;
            this.keyIconBox.MouseLeave += this.KeyBox_MouseLeave;
            // 
            // counterLabel
            // 
            this.counterLabel.Anchor =  System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.counterLabel.AutoSize = true;
            this.counterLabel.BackColor = System.Drawing.Color.Black;
            this.counterLabel.Font = new System.Drawing.Font("Comic Mono", 11F, System.Drawing.FontStyle.Bold);
            this.counterLabel.ForeColor = System.Drawing.Color.White;
            this.counterLabel.Location = new System.Drawing.Point(24, 23);
            this.counterLabel.Margin = new System.Windows.Forms.Padding(3);
            this.counterLabel.Name = "counterLabel";
            this.counterLabel.Padding = new System.Windows.Forms.Padding(1, 6, 2, 0);
            this.counterLabel.Size = new System.Drawing.Size(20, 23);
            this.counterLabel.TabIndex = 1;
            this.counterLabel.Text = "0";
            this.counterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.counterLabel.MouseDown += this.keyIconBox_MouseClick;
            this.counterLabel.MouseEnter += this.KeyBox_MouseEnter;
            this.counterLabel.MouseLeave += this.KeyBox_MouseLeave;
            // 
            // KeyBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.counterLabel);
            this.Controls.Add(this.keyIconBox);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "KeyBox";
            this.Size = new System.Drawing.Size(48, 48);
            this.Load += this.KeyBox_Load;
            this.KeyDown += this.KeyBox_KeyDown;
            this.MouseEnter += this.KeyBox_MouseEnter;
            this.MouseLeave += this.KeyBox_MouseLeave;
            ((System.ComponentModel.ISupportInitialize) this.keyIconBox).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox keyIconBox;
        private System.Windows.Forms.Label counterLabel;
    }
}
