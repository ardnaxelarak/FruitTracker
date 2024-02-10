namespace FruitTracker {
    partial class DungeonItemBox {
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
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            compassBox = new System.Windows.Forms.PictureBox();
            mapBox = new System.Windows.Forms.PictureBox();
            bigkeyBox = new System.Windows.Forms.PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) compassBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize) mapBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize) bigkeyBox).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(compassBox, 1, 1);
            tableLayoutPanel1.Controls.Add(mapBox, 0, 1);
            tableLayoutPanel1.Controls.Add(bigkeyBox, 0, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new System.Drawing.Size(48, 48);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // compassBox
            // 
            compassBox.Dock = System.Windows.Forms.DockStyle.Fill;
            compassBox.Image = Properties.Inventory.no_compass;
            compassBox.Location = new System.Drawing.Point(24, 24);
            compassBox.Margin = new System.Windows.Forms.Padding(0);
            compassBox.Name = "compassBox";
            compassBox.Size = new System.Drawing.Size(24, 24);
            compassBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            compassBox.TabIndex = 5;
            compassBox.TabStop = false;
            compassBox.Click += compassBox_Click;
            // 
            // mapBox
            // 
            mapBox.Dock = System.Windows.Forms.DockStyle.Fill;
            mapBox.Image = Properties.Inventory.no_map;
            mapBox.Location = new System.Drawing.Point(0, 24);
            mapBox.Margin = new System.Windows.Forms.Padding(0);
            mapBox.Name = "mapBox";
            mapBox.Size = new System.Drawing.Size(24, 24);
            mapBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            mapBox.TabIndex = 4;
            mapBox.TabStop = false;
            mapBox.Click += mapBox_Click;
            // 
            // bigkeyBox
            // 
            tableLayoutPanel1.SetColumnSpan(bigkeyBox, 2);
            bigkeyBox.Dock = System.Windows.Forms.DockStyle.Fill;
            bigkeyBox.Image = Properties.Inventory.no_bigkey;
            bigkeyBox.Location = new System.Drawing.Point(0, 0);
            bigkeyBox.Margin = new System.Windows.Forms.Padding(0);
            bigkeyBox.Name = "bigkeyBox";
            bigkeyBox.Size = new System.Drawing.Size(48, 24);
            bigkeyBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            bigkeyBox.TabIndex = 3;
            bigkeyBox.TabStop = false;
            bigkeyBox.Click += bigkeyBox_Click;
            // 
            // DungeonItemBox
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new System.Windows.Forms.Padding(0);
            Name = "DungeonItemBox";
            Size = new System.Drawing.Size(48, 48);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) compassBox).EndInit();
            ((System.ComponentModel.ISupportInitialize) mapBox).EndInit();
            ((System.ComponentModel.ISupportInitialize) bigkeyBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox compassBox;
        private System.Windows.Forms.PictureBox mapBox;
        private System.Windows.Forms.PictureBox bigkeyBox;
    }
}
