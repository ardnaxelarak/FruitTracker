namespace FruitTracker {
    partial class ChestBox {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChestBox));
            this.counterLabel = new System.Windows.Forms.Label();
            this.chestIconBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize) this.chestIconBox).BeginInit();
            this.SuspendLayout();
            // 
            // counterLabel
            // 
            this.counterLabel.Anchor =  System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.counterLabel.AutoSize = true;
            this.counterLabel.BackColor = System.Drawing.Color.Black;
            this.counterLabel.Font = new System.Drawing.Font("Comic Mono", 11F, System.Drawing.FontStyle.Bold);
            this.counterLabel.ForeColor = System.Drawing.Color.White;
            this.counterLabel.Location = new System.Drawing.Point(29, 27);
            this.counterLabel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.counterLabel.Name = "counterLabel";
            this.counterLabel.Padding = new System.Windows.Forms.Padding(1, 6, 2, 0);
            this.counterLabel.Size = new System.Drawing.Size(20, 23);
            this.counterLabel.TabIndex = 1;
            this.counterLabel.Text = "2";
            this.counterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.counterLabel.MouseDown += this.ChestIconBox_MouseClick;
            this.counterLabel.MouseEnter += this.ChestBox_MouseEnter;
            this.counterLabel.MouseLeave += this.ChestBox_MouseLeave;
            // 
            // chestIconBox
            // 
            this.chestIconBox.Anchor =  System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.chestIconBox.Image = (System.Drawing.Image) resources.GetObject("chestIconBox.Image");
            this.chestIconBox.Location = new System.Drawing.Point(5, 5);
            this.chestIconBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.chestIconBox.Name = "chestIconBox";
            this.chestIconBox.Size = new System.Drawing.Size(47, 46);
            this.chestIconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chestIconBox.TabIndex = 0;
            this.chestIconBox.TabStop = false;
            this.chestIconBox.MouseDown += this.ChestIconBox_MouseClick;
            this.chestIconBox.MouseEnter += this.ChestBox_MouseEnter;
            this.chestIconBox.MouseLeave += this.ChestBox_MouseLeave;
            // 
            // ChestBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.counterLabel);
            this.Controls.Add(this.chestIconBox);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ChestBox";
            this.Size = new System.Drawing.Size(56, 55);
            this.KeyDown += this.ChestBox_KeyDown;
            this.MouseEnter += this.ChestBox_MouseEnter;
            this.MouseLeave += this.ChestBox_MouseLeave;
            ((System.ComponentModel.ISupportInitialize) this.chestIconBox).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox chestIconBox;
        private System.Windows.Forms.Label counterLabel;
    }
}
