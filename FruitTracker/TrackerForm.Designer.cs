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
            lightWorldPanel = new Panel();
            darkWorldPanel = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            statusStrip = new StatusStrip();
            resetIcon = new ToolStripStatusLabel();
            resetTimerLabel = new ToolStripStatusLabel();
            startTimerLabel = new ToolStripStatusLabel();
            stopTimerLabel = new ToolStripStatusLabel();
            spacerLabel = new ToolStripStatusLabel();
            tripleGloveLabel = new ToolStripStatusLabel();
            doubleMirrorLabel = new ToolStripStatusLabel();
            funnySettingsLabel = new ToolStripStatusLabel();
            mapShuffleLabel = new ToolStripStatusLabel();
            compassShuffleLabel = new ToolStripStatusLabel();
            bigKeyShuffleLabel = new ToolStripStatusLabel();
            smallKeyShuffleLabel = new ToolStripStatusLabel();
            entranceLabel = new ToolStripStatusLabel();
            doorsLabel = new ToolStripStatusLabel();
            autoTrackingLabel = new ToolStripStatusLabel();
            dungeonTable1 = new DungeonTable();
            inventoryTable1 = new InventoryTable();
            tableLayoutPanel1.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // lightWorldPanel
            // 
            lightWorldPanel.Dock = DockStyle.Fill;
            lightWorldPanel.Location = new Point(4, 3);
            lightWorldPanel.Margin = new Padding(4, 3, 4, 3);
            lightWorldPanel.Name = "lightWorldPanel";
            lightWorldPanel.Size = new Size(504, 508);
            lightWorldPanel.TabIndex = 1;
            // 
            // darkWorldPanel
            // 
            darkWorldPanel.Dock = DockStyle.Fill;
            darkWorldPanel.Location = new Point(516, 3);
            darkWorldPanel.Margin = new Padding(4, 3, 4, 3);
            darkWorldPanel.Name = "darkWorldPanel";
            darkWorldPanel.Size = new Size(504, 508);
            darkWorldPanel.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor =  AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(darkWorldPanel, 1, 0);
            tableLayoutPanel1.Controls.Add(lightWorldPanel, 0, 0);
            tableLayoutPanel1.Location = new Point(11, 11);
            tableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1024, 514);
            tableLayoutPanel1.TabIndex = 2;
            tableLayoutPanel1.Resize += MapPanel_SizeChanged;
            // 
            // statusStrip
            // 
            statusStrip.Anchor =  AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            statusStrip.AutoSize = false;
            statusStrip.BackColor = SystemColors.ControlLightLight;
            statusStrip.Dock = DockStyle.None;
            statusStrip.ImageScalingSize = new Size(24, 24);
            statusStrip.Items.AddRange(new ToolStripItem[] { resetIcon, resetTimerLabel, startTimerLabel, stopTimerLabel, spacerLabel, tripleGloveLabel, doubleMirrorLabel, funnySettingsLabel, mapShuffleLabel, compassShuffleLabel, bigKeyShuffleLabel, smallKeyShuffleLabel, entranceLabel, doorsLabel, autoTrackingLabel });
            statusStrip.Location = new Point(0, 726);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1047, 36);
            statusStrip.SizingGrip = false;
            statusStrip.TabIndex = 3;
            // 
            // resetIcon
            // 
            resetIcon.AutoSize = false;
            resetIcon.DisplayStyle = ToolStripItemDisplayStyle.Image;
            resetIcon.Image = (Image) resources.GetObject("resetIcon.Image");
            resetIcon.Margin = new Padding(3, 2, 0, 0);
            resetIcon.Name = "resetIcon";
            resetIcon.Size = new Size(24, 34);
            resetIcon.Click += resetIcon_Click;
            // 
            // resetTimerLabel
            // 
            resetTimerLabel.AutoSize = false;
            resetTimerLabel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            resetTimerLabel.Image = (Image) resources.GetObject("resetTimerLabel.Image");
            resetTimerLabel.ImageScaling = ToolStripItemImageScaling.None;
            resetTimerLabel.Margin = new Padding(0, 2, 0, 0);
            resetTimerLabel.Name = "resetTimerLabel";
            resetTimerLabel.Size = new Size(34, 34);
            resetTimerLabel.MouseDown += resetTimerLabel_MouseDown;
            // 
            // startTimerLabel
            // 
            startTimerLabel.AutoSize = false;
            startTimerLabel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            startTimerLabel.Image = (Image) resources.GetObject("startTimerLabel.Image");
            startTimerLabel.ImageScaling = ToolStripItemImageScaling.None;
            startTimerLabel.Margin = new Padding(0, 2, 0, 0);
            startTimerLabel.Name = "startTimerLabel";
            startTimerLabel.Size = new Size(24, 34);
            startTimerLabel.MouseDown += startTimerLabel_MouseDown;
            // 
            // stopTimerLabel
            // 
            stopTimerLabel.AutoSize = false;
            stopTimerLabel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            stopTimerLabel.Image = (Image) resources.GetObject("stopTimerLabel.Image");
            stopTimerLabel.ImageScaling = ToolStripItemImageScaling.None;
            stopTimerLabel.Margin = new Padding(0, 2, 0, 0);
            stopTimerLabel.Name = "stopTimerLabel";
            stopTimerLabel.Size = new Size(24, 34);
            stopTimerLabel.MouseDown += stopTimerLabel_MouseDown;
            // 
            // spacerLabel
            // 
            spacerLabel.Name = "spacerLabel";
            spacerLabel.Size = new Size(639, 31);
            spacerLabel.Spring = true;
            // 
            // tripleGloveLabel
            // 
            tripleGloveLabel.AutoSize = false;
            tripleGloveLabel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tripleGloveLabel.Image = (Image) resources.GetObject("tripleGloveLabel.Image");
            tripleGloveLabel.Margin = new Padding(0, 2, 0, 0);
            tripleGloveLabel.Name = "tripleGloveLabel";
            tripleGloveLabel.Size = new Size(24, 34);
            tripleGloveLabel.Visible = false;
            tripleGloveLabel.MouseDown += tripleGloveLabel_MouseDown;
            // 
            // doubleMirrorLabel
            // 
            doubleMirrorLabel.AutoSize = false;
            doubleMirrorLabel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            doubleMirrorLabel.Image = (Image) resources.GetObject("doubleMirrorLabel.Image");
            doubleMirrorLabel.Margin = new Padding(0, 2, 0, 0);
            doubleMirrorLabel.Name = "doubleMirrorLabel";
            doubleMirrorLabel.Size = new Size(24, 34);
            doubleMirrorLabel.Visible = false;
            doubleMirrorLabel.MouseDown += doubleMirrorLabel_MouseDown;
            // 
            // funnySettingsLabel
            // 
            funnySettingsLabel.AutoSize = false;
            funnySettingsLabel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            funnySettingsLabel.Image = (Image) resources.GetObject("funnySettingsLabel.Image");
            funnySettingsLabel.ImageScaling = ToolStripItemImageScaling.None;
            funnySettingsLabel.Margin = new Padding(0, 2, 0, 0);
            funnySettingsLabel.Name = "funnySettingsLabel";
            funnySettingsLabel.Size = new Size(12, 34);
            funnySettingsLabel.MouseDown += funnySettingsLabel_MouseDown;
            // 
            // mapShuffleLabel
            // 
            mapShuffleLabel.AutoSize = false;
            mapShuffleLabel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            mapShuffleLabel.Image = (Image) resources.GetObject("mapShuffleLabel.Image");
            mapShuffleLabel.Margin = new Padding(0, 2, 0, 0);
            mapShuffleLabel.Name = "mapShuffleLabel";
            mapShuffleLabel.Size = new Size(24, 34);
            mapShuffleLabel.MouseDown += mapShuffleLabel_MouseDown;
            // 
            // compassShuffleLabel
            // 
            compassShuffleLabel.AutoSize = false;
            compassShuffleLabel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            compassShuffleLabel.Image = (Image) resources.GetObject("compassShuffleLabel.Image");
            compassShuffleLabel.Margin = new Padding(0, 2, 0, 0);
            compassShuffleLabel.Name = "compassShuffleLabel";
            compassShuffleLabel.Size = new Size(24, 34);
            compassShuffleLabel.MouseDown += compassShuffleLabel_MouseDown;
            // 
            // bigKeyShuffleLabel
            // 
            bigKeyShuffleLabel.AutoSize = false;
            bigKeyShuffleLabel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bigKeyShuffleLabel.Image = (Image) resources.GetObject("bigKeyShuffleLabel.Image");
            bigKeyShuffleLabel.Margin = new Padding(0, 2, 0, 0);
            bigKeyShuffleLabel.Name = "bigKeyShuffleLabel";
            bigKeyShuffleLabel.Size = new Size(24, 34);
            bigKeyShuffleLabel.MouseDown += bigKeyShuffleLabel_MouseDown;
            // 
            // smallKeyShuffleLabel
            // 
            smallKeyShuffleLabel.AutoSize = false;
            smallKeyShuffleLabel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            smallKeyShuffleLabel.Image = (Image) resources.GetObject("smallKeyShuffleLabel.Image");
            smallKeyShuffleLabel.Margin = new Padding(0, 2, 0, 0);
            smallKeyShuffleLabel.Name = "smallKeyShuffleLabel";
            smallKeyShuffleLabel.Size = new Size(24, 34);
            smallKeyShuffleLabel.MouseDown += smallKeyShuffleLabel_MouseDown;
            // 
            // entranceLabel
            // 
            entranceLabel.AutoSize = false;
            entranceLabel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            entranceLabel.Image = (Image) resources.GetObject("entranceLabel.Image");
            entranceLabel.Margin = new Padding(5, 2, 5, 0);
            entranceLabel.Name = "entranceLabel";
            entranceLabel.Size = new Size(24, 34);
            entranceLabel.Click += modeLabel_Click;
            // 
            // doorsLabel
            // 
            doorsLabel.AutoSize = false;
            doorsLabel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            doorsLabel.Image = (Image) resources.GetObject("doorsLabel.Image");
            doorsLabel.Margin = new Padding(5, 2, 5, 0);
            doorsLabel.Name = "doorsLabel";
            doorsLabel.Size = new Size(24, 34);
            doorsLabel.Click += doorsLabel_Click;
            // 
            // autoTrackingLabel
            // 
            autoTrackingLabel.AutoSize = false;
            autoTrackingLabel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            autoTrackingLabel.Image = (Image) resources.GetObject("autoTrackingLabel.Image");
            autoTrackingLabel.Margin = new Padding(5, 2, 0, 0);
            autoTrackingLabel.Name = "autoTrackingLabel";
            autoTrackingLabel.Size = new Size(24, 34);
            autoTrackingLabel.MouseDown += autoTrackingLabel_MouseDown;
            // 
            // dungeonTable1
            // 
            dungeonTable1.Anchor =  AnchorStyles.Bottom | AnchorStyles.Left;
            dungeonTable1.Location = new Point(401, 531);
            dungeonTable1.Margin = new Padding(4, 3, 4, 3);
            dungeonTable1.Name = "dungeonTable1";
            dungeonTable1.Size = new Size(634, 192);
            dungeonTable1.TabIndex = 6;
            // 
            // inventoryTable1
            // 
            inventoryTable1.Anchor =  AnchorStyles.Bottom | AnchorStyles.Left;
            inventoryTable1.Location = new Point(11, 531);
            inventoryTable1.Margin = new Padding(4, 3, 4, 3);
            inventoryTable1.Name = "inventoryTable1";
            inventoryTable1.Size = new Size(384, 192);
            inventoryTable1.TabIndex = 0;
            // 
            // TrackerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 761);
            Controls.Add(dungeonTable1);
            Controls.Add(inventoryTable1);
            Controls.Add(statusStrip);
            Controls.Add(tableLayoutPanel1);
            Icon = (System.Drawing.Icon) resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(500, 300);
            Name = "TrackerForm";
            Padding = new Padding(10);
            Text = "FruitTracker";
            Load += TrackerForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
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