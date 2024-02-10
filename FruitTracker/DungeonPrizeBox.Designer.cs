namespace FruitTracker {
    partial class DungeonPrizeBox {
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dungeonBox = new System.Windows.Forms.PictureBox();
            this.prizeBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dungeonBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prizeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dungeonBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.prizeBox, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(48, 48);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dungeonBox
            // 
            this.dungeonBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dungeonBox.Image = global::FruitTracker.Properties.Inventory.AT;
            this.dungeonBox.Location = new System.Drawing.Point(3, 3);
            this.dungeonBox.Name = "dungeonBox";
            this.dungeonBox.Size = new System.Drawing.Size(42, 18);
            this.dungeonBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dungeonBox.TabIndex = 0;
            this.dungeonBox.TabStop = false;
            this.dungeonBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dungeonBox_MouseClick);
            // 
            // prizeBox
            // 
            this.prizeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prizeBox.Image = global::FruitTracker.Properties.Inventory.prize_unknown;
            this.prizeBox.Location = new System.Drawing.Point(2, 26);
            this.prizeBox.Margin = new System.Windows.Forms.Padding(2);
            this.prizeBox.Name = "prizeBox";
            this.prizeBox.Size = new System.Drawing.Size(44, 20);
            this.prizeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.prizeBox.TabIndex = 1;
            this.prizeBox.TabStop = false;
            this.prizeBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.prizeBox_MouseClick);
            // 
            // DungeonPrizeBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "DungeonPrizeBox";
            this.Size = new System.Drawing.Size(48, 48);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dungeonBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prizeBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox dungeonBox;
        private System.Windows.Forms.PictureBox prizeBox;
    }
}
