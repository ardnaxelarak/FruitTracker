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
            keyIconBox = new System.Windows.Forms.PictureBox();
            counterLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) keyIconBox).BeginInit();
            SuspendLayout();
            // 
            // keyIconBox
            // 
            keyIconBox.Dock = System.Windows.Forms.DockStyle.Fill;
            keyIconBox.Image = Properties.Inventory.no_smallkey;
            keyIconBox.Location = new System.Drawing.Point(0, 0);
            keyIconBox.Margin = new System.Windows.Forms.Padding(0);
            keyIconBox.Name = "keyIconBox";
            keyIconBox.Size = new System.Drawing.Size(48, 48);
            keyIconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            keyIconBox.TabIndex = 0;
            keyIconBox.TabStop = false;
            keyIconBox.MouseDown += keyIconBox_MouseClick;
            // 
            // counterLabel
            // 
            counterLabel.Anchor =  System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            counterLabel.AutoSize = true;
            counterLabel.BackColor = System.Drawing.Color.Black;
            counterLabel.Font = new System.Drawing.Font("Comic Mono", 11F, System.Drawing.FontStyle.Bold);
            counterLabel.ForeColor = System.Drawing.Color.White;
            counterLabel.Location = new System.Drawing.Point(24, 23);
            counterLabel.Margin = new System.Windows.Forms.Padding(3);
            counterLabel.Name = "counterLabel";
            counterLabel.Padding = new System.Windows.Forms.Padding(1, 6, 2, 0);
            counterLabel.Size = new System.Drawing.Size(20, 23);
            counterLabel.TabIndex = 1;
            counterLabel.Text = "0";
            counterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            counterLabel.MouseDown += keyIconBox_MouseClick;
            // 
            // KeyBox
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(counterLabel);
            Controls.Add(keyIconBox);
            Margin = new System.Windows.Forms.Padding(0);
            Name = "KeyBox";
            Size = new System.Drawing.Size(48, 48);
            Load += KeyBox_Load;
            ((System.ComponentModel.ISupportInitialize) keyIconBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox keyIconBox;
        private System.Windows.Forms.Label counterLabel;
    }
}
