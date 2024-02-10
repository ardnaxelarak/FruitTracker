using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FruitTracker {
    partial class TrackerForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrackerForm));
            this.lightWorldPanel = new System.Windows.Forms.Panel();
            this.darkWorldPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.spacerLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.resetIcon = new System.Windows.Forms.ToolStripStatusLabel();
            this.mapShuffleLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.compassShuffleLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.bigKeyShuffleLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.smallKeyShuffleLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.entranceLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.doorsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.autoTrackingLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.dungeonTable1 = new FruitTracker.DungeonTable();
            this.inventoryTable1 = new FruitTracker.InventoryTable();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lightWorldPanel
            // 
            this.lightWorldPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lightWorldPanel.Location = new System.Drawing.Point(3, 3);
            this.lightWorldPanel.Name = "lightWorldPanel";
            this.lightWorldPanel.Size = new System.Drawing.Size(506, 508);
            this.lightWorldPanel.TabIndex = 1;
            // 
            // darkWorldPanel
            // 
            this.darkWorldPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.darkWorldPanel.Location = new System.Drawing.Point(515, 3);
            this.darkWorldPanel.Name = "darkWorldPanel";
            this.darkWorldPanel.Size = new System.Drawing.Size(506, 508);
            this.darkWorldPanel.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.darkWorldPanel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lightWorldPanel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 11);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1024, 514);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Resize += new System.EventHandler(this.MapPanel_SizeChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusStrip.AutoSize = false;
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetIcon,
            this.spacerLabel,
            this.mapShuffleLabel,
            this.compassShuffleLabel,
            this.bigKeyShuffleLabel,
            this.smallKeyShuffleLabel,
            this.entranceLabel,
            this.doorsLabel,
            this.autoTrackingLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 726);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip.Size = new System.Drawing.Size(1047, 36);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 3;
            // 
            // spacerLabel
            // 
            this.spacerLabel.Name = "spacerLabel";
            this.spacerLabel.Size = new System.Drawing.Size(812, 31);
            this.spacerLabel.Spring = true;
            // 
            // resetIcon
            // 
            this.resetIcon.AutoSize = false;
            this.resetIcon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.resetIcon.Image = global::FruitTracker.Properties.Resources.reset;
            this.resetIcon.Margin = new System.Windows.Forms.Padding(3, 2, 0, 0);
            this.resetIcon.Name = "resetIcon";
            this.resetIcon.Size = new System.Drawing.Size(24, 34);
            this.resetIcon.Click += new System.EventHandler(this.resetIcon_Click);
            // 
            // mapShuffleLabel
            // 
            this.mapShuffleLabel.AutoSize = false;
            this.mapShuffleLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mapShuffleLabel.Image = ((System.Drawing.Image)(resources.GetObject("mapShuffleLabel.Image")));
            this.mapShuffleLabel.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.mapShuffleLabel.Name = "mapShuffleLabel";
            this.mapShuffleLabel.Size = new System.Drawing.Size(24, 34);
            this.mapShuffleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mapShuffleLabel_MouseDown);
            // 
            // compassShuffleLabel
            // 
            this.compassShuffleLabel.AutoSize = false;
            this.compassShuffleLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.compassShuffleLabel.Image = ((System.Drawing.Image)(resources.GetObject("compassShuffleLabel.Image")));
            this.compassShuffleLabel.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.compassShuffleLabel.Name = "compassShuffleLabel";
            this.compassShuffleLabel.Size = new System.Drawing.Size(24, 34);
            this.compassShuffleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.compassShuffleLabel_MouseDown);
            // 
            // bigKeyShuffleLabel
            // 
            this.bigKeyShuffleLabel.AutoSize = false;
            this.bigKeyShuffleLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bigKeyShuffleLabel.Image = ((System.Drawing.Image)(resources.GetObject("bigKeyShuffleLabel.Image")));
            this.bigKeyShuffleLabel.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.bigKeyShuffleLabel.Name = "bigKeyShuffleLabel";
            this.bigKeyShuffleLabel.Size = new System.Drawing.Size(24, 34);
            this.bigKeyShuffleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bigKeyShuffleLabel_MouseDown);
            // 
            // smallKeyShuffleLabel
            // 
            this.smallKeyShuffleLabel.AutoSize = false;
            this.smallKeyShuffleLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.smallKeyShuffleLabel.Image = ((System.Drawing.Image)(resources.GetObject("smallKeyShuffleLabel.Image")));
            this.smallKeyShuffleLabel.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.smallKeyShuffleLabel.Name = "smallKeyShuffleLabel";
            this.smallKeyShuffleLabel.Size = new System.Drawing.Size(24, 34);
            this.smallKeyShuffleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.smallKeyShuffleLabel_MouseDown);
            // 
            // entranceLabel
            // 
            this.entranceLabel.AutoSize = false;
            this.entranceLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.entranceLabel.Image = global::FruitTracker.Properties.Resources.bow;
            this.entranceLabel.Margin = new System.Windows.Forms.Padding(5, 2, 5, 0);
            this.entranceLabel.Name = "entranceLabel";
            this.entranceLabel.Size = new System.Drawing.Size(24, 34);
            this.entranceLabel.Click += new System.EventHandler(this.modeLabel_Click);
            // 
            // doorsLabel
            // 
            this.doorsLabel.AutoSize = false;
            this.doorsLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.doorsLabel.Image = global::FruitTracker.Properties.Resources.open_door;
            this.doorsLabel.Margin = new System.Windows.Forms.Padding(5, 2, 5, 0);
            this.doorsLabel.Name = "doorsLabel";
            this.doorsLabel.Size = new System.Drawing.Size(24, 34);
            this.doorsLabel.Click += new System.EventHandler(this.doorsLabel_Click);
            // 
            // autoTrackingLabel
            // 
            this.autoTrackingLabel.AutoSize = false;
            this.autoTrackingLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.autoTrackingLabel.Image = global::FruitTracker.Properties.Resources.gray_snes;
            this.autoTrackingLabel.Margin = new System.Windows.Forms.Padding(5, 2, 0, 0);
            this.autoTrackingLabel.Name = "autoTrackingLabel";
            this.autoTrackingLabel.Size = new System.Drawing.Size(24, 34);
            this.autoTrackingLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.autoTrackingLabel_MouseDown);
            // 
            // dungeonTable1
            // 
            this.dungeonTable1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dungeonTable1.DoorShuffle = false;
            this.dungeonTable1.Location = new System.Drawing.Point(401, 531);
            this.dungeonTable1.Name = "dungeonTable1";
            this.dungeonTable1.ShuffleBigKeys = false;
            this.dungeonTable1.ShuffleCompasses = false;
            this.dungeonTable1.ShuffleMaps = false;
            this.dungeonTable1.ShuffleSmallKeys = false;
            this.dungeonTable1.Size = new System.Drawing.Size(634, 192);
            this.dungeonTable1.TabIndex = 6;
            // 
            // inventoryTable1
            // 
            this.inventoryTable1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.inventoryTable1.Location = new System.Drawing.Point(11, 531);
            this.inventoryTable1.Name = "inventoryTable1";
            this.inventoryTable1.Size = new System.Drawing.Size(384, 192);
            this.inventoryTable1.TabIndex = 5;
            // 
            // TrackerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 761);
            this.Controls.Add(this.dungeonTable1);
            this.Controls.Add(this.inventoryTable1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(431, 265);
            this.Name = "TrackerForm";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.Text = "FruitTracker";
            this.Load += new System.EventHandler(this.TrackerForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel lightWorldPanel;
        private Panel darkWorldPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel autoTrackingLabel;
        private ToolStripStatusLabel spacerLabel;
        private ToolStripStatusLabel entranceLabel;
        private InventoryTable inventoryTable1;
        private DungeonTable dungeonTable1;
        private ToolStripStatusLabel mapShuffleLabel;
        private ToolStripStatusLabel compassShuffleLabel;
        private ToolStripStatusLabel bigKeyShuffleLabel;
        private ToolStripStatusLabel smallKeyShuffleLabel;
        private ToolStripStatusLabel doorsLabel;
        private ToolStripStatusLabel resetIcon;
    }
}