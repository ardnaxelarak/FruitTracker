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
            this.lightWorldPanel = new Panel();
            this.darkWorldPanel = new Panel();
            this.tableLayoutPanel1 = new TableLayoutPanel();
            this.statusStrip = new StatusStrip();
            this.resetIcon = new ToolStripStatusLabel();
            this.resetTimerLabel = new ToolStripStatusLabel();
            this.startTimerLabel = new ToolStripStatusLabel();
            this.stopTimerLabel = new ToolStripStatusLabel();
            this.spacerLabel = new ToolStripStatusLabel();
            this.tripleGloveLabel = new ToolStripStatusLabel();
            this.doubleMirrorLabel = new ToolStripStatusLabel();
            this.funnySettingsLabel = new ToolStripStatusLabel();
            this.mapShuffleLabel = new ToolStripStatusLabel();
            this.compassShuffleLabel = new ToolStripStatusLabel();
            this.bigKeyShuffleLabel = new ToolStripStatusLabel();
            this.smallKeyShuffleLabel = new ToolStripStatusLabel();
            this.entranceLabel = new ToolStripStatusLabel();
            this.doorsLabel = new ToolStripStatusLabel();
            this.autoTrackingLabel = new ToolStripStatusLabel();
            this.dungeonTable1 = new DungeonTable();
            this.inventoryTable1 = new InventoryTable();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lightWorldPanel
            // 
            this.lightWorldPanel.Dock = DockStyle.Fill;
            this.lightWorldPanel.Location = new Point(4, 3);
            this.lightWorldPanel.Margin = new Padding(4, 3, 4, 3);
            this.lightWorldPanel.Name = "lightWorldPanel";
            this.lightWorldPanel.Size = new Size(504, 508);
            this.lightWorldPanel.TabIndex = 1;
            // 
            // darkWorldPanel
            // 
            this.darkWorldPanel.Dock = DockStyle.Fill;
            this.darkWorldPanel.Location = new Point(516, 3);
            this.darkWorldPanel.Margin = new Padding(4, 3, 4, 3);
            this.darkWorldPanel.Name = "darkWorldPanel";
            this.darkWorldPanel.Size = new Size(504, 508);
            this.darkWorldPanel.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor =  AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.tableLayoutPanel1.BackColor = Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.darkWorldPanel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lightWorldPanel, 0, 0);
            this.tableLayoutPanel1.Location = new Point(11, 11);
            this.tableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new Size(1024, 514);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Resize += this.MapPanel_SizeChanged;
            // 
            // statusStrip
            // 
            this.statusStrip.Anchor =  AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.statusStrip.AutoSize = false;
            this.statusStrip.BackColor = SystemColors.ControlLightLight;
            this.statusStrip.Dock = DockStyle.None;
            this.statusStrip.ImageScalingSize = new Size(24, 24);
            this.statusStrip.Items.AddRange(new ToolStripItem[] { this.resetIcon, this.resetTimerLabel, this.startTimerLabel, this.stopTimerLabel, this.spacerLabel, this.tripleGloveLabel, this.doubleMirrorLabel, this.funnySettingsLabel, this.mapShuffleLabel, this.compassShuffleLabel, this.bigKeyShuffleLabel, this.smallKeyShuffleLabel, this.entranceLabel, this.doorsLabel, this.autoTrackingLabel });
            this.statusStrip.Location = new Point(0, 726);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new Size(1047, 36);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 3;
            // 
            // resetIcon
            // 
            this.resetIcon.AutoSize = false;
            this.resetIcon.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.resetIcon.Image = (Image) resources.GetObject("resetIcon.Image");
            this.resetIcon.Margin = new Padding(3, 2, 0, 0);
            this.resetIcon.Name = "resetIcon";
            this.resetIcon.Size = new Size(24, 34);
            this.resetIcon.Click += this.resetIcon_Click;
            // 
            // resetTimerLabel
            // 
            this.resetTimerLabel.AutoSize = false;
            this.resetTimerLabel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.resetTimerLabel.Image = (Image) resources.GetObject("resetTimerLabel.Image");
            this.resetTimerLabel.ImageScaling = ToolStripItemImageScaling.None;
            this.resetTimerLabel.Margin = new Padding(0, 2, 0, 0);
            this.resetTimerLabel.Name = "resetTimerLabel";
            this.resetTimerLabel.Size = new Size(34, 34);
            this.resetTimerLabel.MouseDown += this.resetTimerLabel_MouseDown;
            // 
            // startTimerLabel
            // 
            this.startTimerLabel.AutoSize = false;
            this.startTimerLabel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.startTimerLabel.Image = (Image) resources.GetObject("startTimerLabel.Image");
            this.startTimerLabel.ImageScaling = ToolStripItemImageScaling.None;
            this.startTimerLabel.Margin = new Padding(0, 2, 0, 0);
            this.startTimerLabel.Name = "startTimerLabel";
            this.startTimerLabel.Size = new Size(24, 34);
            this.startTimerLabel.MouseDown += this.startTimerLabel_MouseDown;
            // 
            // stopTimerLabel
            // 
            this.stopTimerLabel.AutoSize = false;
            this.stopTimerLabel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.stopTimerLabel.Image = (Image) resources.GetObject("stopTimerLabel.Image");
            this.stopTimerLabel.ImageScaling = ToolStripItemImageScaling.None;
            this.stopTimerLabel.Margin = new Padding(0, 2, 0, 0);
            this.stopTimerLabel.Name = "stopTimerLabel";
            this.stopTimerLabel.Size = new Size(24, 34);
            this.stopTimerLabel.MouseDown += this.stopTimerLabel_MouseDown;
            // 
            // spacerLabel
            // 
            this.spacerLabel.Name = "spacerLabel";
            this.spacerLabel.Size = new Size(716, 31);
            this.spacerLabel.Spring = true;
            // 
            // tripleGloveLabel
            // 
            this.tripleGloveLabel.AutoSize = false;
            this.tripleGloveLabel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.tripleGloveLabel.Image = (Image) resources.GetObject("tripleGloveLabel.Image");
            this.tripleGloveLabel.Margin = new Padding(0, 2, 0, 0);
            this.tripleGloveLabel.Name = "tripleGloveLabel";
            this.tripleGloveLabel.Size = new Size(24, 34);
            this.tripleGloveLabel.Visible = false;
            this.tripleGloveLabel.MouseDown += this.tripleGloveLabel_MouseDown;
            // 
            // doubleMirrorLabel
            // 
            this.doubleMirrorLabel.AutoSize = false;
            this.doubleMirrorLabel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.doubleMirrorLabel.Image = (Image) resources.GetObject("doubleMirrorLabel.Image");
            this.doubleMirrorLabel.Margin = new Padding(0, 2, 0, 0);
            this.doubleMirrorLabel.Name = "doubleMirrorLabel";
            this.doubleMirrorLabel.Size = new Size(24, 34);
            this.doubleMirrorLabel.Visible = false;
            this.doubleMirrorLabel.MouseDown += this.doubleMirrorLabel_MouseDown;
            // 
            // funnySettingsLabel
            // 
            this.funnySettingsLabel.AutoSize = false;
            this.funnySettingsLabel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.funnySettingsLabel.Image = (Image) resources.GetObject("funnySettingsLabel.Image");
            this.funnySettingsLabel.ImageScaling = ToolStripItemImageScaling.None;
            this.funnySettingsLabel.Margin = new Padding(0, 2, 0, 0);
            this.funnySettingsLabel.Name = "funnySettingsLabel";
            this.funnySettingsLabel.Size = new Size(12, 34);
            this.funnySettingsLabel.MouseDown += this.funnySettingsLabel_MouseDown;
            // 
            // mapShuffleLabel
            // 
            this.mapShuffleLabel.AutoSize = false;
            this.mapShuffleLabel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.mapShuffleLabel.Image = (Image) resources.GetObject("mapShuffleLabel.Image");
            this.mapShuffleLabel.Margin = new Padding(0, 2, 0, 0);
            this.mapShuffleLabel.Name = "mapShuffleLabel";
            this.mapShuffleLabel.Size = new Size(24, 34);
            this.mapShuffleLabel.MouseDown += this.mapShuffleLabel_MouseDown;
            // 
            // compassShuffleLabel
            // 
            this.compassShuffleLabel.AutoSize = false;
            this.compassShuffleLabel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.compassShuffleLabel.Image = (Image) resources.GetObject("compassShuffleLabel.Image");
            this.compassShuffleLabel.Margin = new Padding(0, 2, 0, 0);
            this.compassShuffleLabel.Name = "compassShuffleLabel";
            this.compassShuffleLabel.Size = new Size(24, 34);
            this.compassShuffleLabel.MouseDown += this.compassShuffleLabel_MouseDown;
            // 
            // bigKeyShuffleLabel
            // 
            this.bigKeyShuffleLabel.AutoSize = false;
            this.bigKeyShuffleLabel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.bigKeyShuffleLabel.Image = (Image) resources.GetObject("bigKeyShuffleLabel.Image");
            this.bigKeyShuffleLabel.Margin = new Padding(0, 2, 0, 0);
            this.bigKeyShuffleLabel.Name = "bigKeyShuffleLabel";
            this.bigKeyShuffleLabel.Size = new Size(24, 34);
            this.bigKeyShuffleLabel.MouseDown += this.bigKeyShuffleLabel_MouseDown;
            // 
            // smallKeyShuffleLabel
            // 
            this.smallKeyShuffleLabel.AutoSize = false;
            this.smallKeyShuffleLabel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.smallKeyShuffleLabel.Image = (Image) resources.GetObject("smallKeyShuffleLabel.Image");
            this.smallKeyShuffleLabel.Margin = new Padding(0, 2, 0, 0);
            this.smallKeyShuffleLabel.Name = "smallKeyShuffleLabel";
            this.smallKeyShuffleLabel.Size = new Size(24, 34);
            this.smallKeyShuffleLabel.MouseDown += this.smallKeyShuffleLabel_MouseDown;
            // 
            // entranceLabel
            // 
            this.entranceLabel.AutoSize = false;
            this.entranceLabel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.entranceLabel.Image = (Image) resources.GetObject("entranceLabel.Image");
            this.entranceLabel.Margin = new Padding(5, 2, 5, 0);
            this.entranceLabel.Name = "entranceLabel";
            this.entranceLabel.Size = new Size(24, 34);
            this.entranceLabel.Click += this.modeLabel_Click;
            // 
            // doorsLabel
            // 
            this.doorsLabel.AutoSize = false;
            this.doorsLabel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.doorsLabel.Image = Properties.Resources.no_door_shuffle;
            this.doorsLabel.Margin = new Padding(5, 2, 5, 0);
            this.doorsLabel.Name = "doorsLabel";
            this.doorsLabel.Size = new Size(26, 34);
            this.doorsLabel.Click += this.doorsLabel_Click;
            // 
            // autoTrackingLabel
            // 
            this.autoTrackingLabel.AutoSize = false;
            this.autoTrackingLabel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.autoTrackingLabel.Image = (Image) resources.GetObject("autoTrackingLabel.Image");
            this.autoTrackingLabel.Margin = new Padding(5, 2, 0, 0);
            this.autoTrackingLabel.Name = "autoTrackingLabel";
            this.autoTrackingLabel.Size = new Size(24, 34);
            this.autoTrackingLabel.MouseDown += this.autoTrackingLabel_MouseDown;
            // 
            // dungeonTable1
            // 
            this.dungeonTable1.Anchor =  AnchorStyles.Bottom | AnchorStyles.Left;
            this.dungeonTable1.Location = new Point(401, 531);
            this.dungeonTable1.Margin = new Padding(4, 3, 4, 3);
            this.dungeonTable1.Name = "dungeonTable1";
            this.dungeonTable1.Size = new Size(634, 192);
            this.dungeonTable1.TabIndex = 6;
            // 
            // inventoryTable1
            // 
            this.inventoryTable1.Anchor =  AnchorStyles.Bottom | AnchorStyles.Left;
            this.inventoryTable1.Location = new Point(11, 531);
            this.inventoryTable1.Margin = new Padding(4, 3, 4, 3);
            this.inventoryTable1.Name = "inventoryTable1";
            this.inventoryTable1.Size = new Size(384, 192);
            this.inventoryTable1.TabIndex = 0;
            // 
            // TrackerForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1047, 761);
            this.Controls.Add(this.dungeonTable1);
            this.Controls.Add(this.inventoryTable1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = (System.Drawing.Icon) resources.GetObject("$this.Icon");
            this.Margin = new Padding(4, 3, 4, 3);
            this.MinimumSize = new Size(500, 300);
            this.Name = "TrackerForm";
            this.Padding = new Padding(10);
            this.Text = "FruitTracker";
            this.Load += this.TrackerForm_Load;
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
        private ToolStripStatusLabel doubleMirrorLabel;
        private ToolStripStatusLabel funnySettingsLabel;
        private ToolStripStatusLabel tripleGloveLabel;
        private ToolStripStatusLabel startTimerLabel;
        private ToolStripStatusLabel resetTimerLabel;
        private ToolStripStatusLabel stopTimerLabel;
    }
}