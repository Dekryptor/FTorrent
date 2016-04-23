namespace FTorrent
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            GlacialComponents.Controls.GLColumn glColumn1 = new GlacialComponents.Controls.GLColumn();
            GlacialComponents.Controls.GLColumn glColumn2 = new GlacialComponents.Controls.GLColumn();
            GlacialComponents.Controls.GLColumn glColumn3 = new GlacialComponents.Controls.GLColumn();
            GlacialComponents.Controls.GLColumn glColumn4 = new GlacialComponents.Controls.GLColumn();
            GlacialComponents.Controls.GLColumn glColumn5 = new GlacialComponents.Controls.GLColumn();
            GlacialComponents.Controls.GLColumn glColumn6 = new GlacialComponents.Controls.GLColumn();
            GlacialComponents.Controls.GLColumn glColumn7 = new GlacialComponents.Controls.GLColumn();
            GlacialComponents.Controls.GLColumn glColumn8 = new GlacialComponents.Controls.GLColumn();
            GlacialComponents.Controls.GLColumn glColumn9 = new GlacialComponents.Controls.GLColumn();
            GlacialComponents.Controls.GLColumn glColumn10 = new GlacialComponents.Controls.GLColumn();
            GlacialComponents.Controls.GLColumn glColumn11 = new GlacialComponents.Controls.GLColumn();
            GlacialComponents.Controls.GLColumn glColumn12 = new GlacialComponents.Controls.GLColumn();
            GlacialComponents.Controls.GLColumn glColumn13 = new GlacialComponents.Controls.GLColumn();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.torrentPanel = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.torrentList = new GlacialComponents.Controls.GlacialList();
            this.Torrent = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pauseMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.stopMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.torrentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.torrentTabs = new System.Windows.Forms.TabControl();
            this.infoTab = new System.Windows.Forms.TabPage();
            this.outPathLbl = new System.Windows.Forms.Label();
            this.torrentPathLbl = new System.Windows.Forms.Label();
            this.torrentCommentLbl = new System.Windows.Forms.Label();
            this.torrentSizeLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stateLbl = new System.Windows.Forms.Label();
            this.torrentNameLbl = new System.Windows.Forms.Label();
            this.filesTab = new System.Windows.Forms.TabPage();
            this.filesList = new GlacialComponents.Controls.GlacialList();
            this.trackersTab = new System.Windows.Forms.TabPage();
            this.trackersList = new GlacialComponents.Controls.GlacialList();
            this.peersTab = new System.Windows.Forms.TabPage();
            this.peersList = new GlacialComponents.Controls.GlacialList();
            this.speedTab = new System.Windows.Forms.TabPage();
            this.speedCounter = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.dhtBox = new System.Windows.Forms.CheckBox();
            this.preferEncyptionBox = new System.Windows.Forms.CheckBox();
            this.maxConnections = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.maxUpload = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.maximumDownload = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.torrentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskBarIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.taskBarMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.torrentBar = new FTorrent.Controls.FProgressBar();
            this.torrentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.Torrent.SuspendLayout();
            this.torrentTabs.SuspendLayout();
            this.infoTab.SuspendLayout();
            this.filesTab.SuspendLayout();
            this.trackersTab.SuspendLayout();
            this.peersTab.SuspendLayout();
            this.speedTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedCounter)).BeginInit();
            this.settingsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxConnections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxUpload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximumDownload)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.taskBarMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // torrentPanel
            // 
            this.torrentPanel.BackColor = System.Drawing.Color.White;
            this.torrentPanel.Controls.Add(this.splitContainer1);
            this.torrentPanel.Controls.Add(this.menuStrip1);
            this.torrentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.torrentPanel.Location = new System.Drawing.Point(0, 0);
            this.torrentPanel.Name = "torrentPanel";
            this.torrentPanel.Size = new System.Drawing.Size(923, 526);
            this.torrentPanel.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.torrentList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.torrentTabs);
            this.splitContainer1.Size = new System.Drawing.Size(923, 502);
            this.splitContainer1.SplitterDistance = 275;
            this.splitContainer1.TabIndex = 5;
            // 
            // torrentList
            // 
            this.torrentList.AllowColumnResize = true;
            this.torrentList.AllowMultiselect = false;
            this.torrentList.AlternateBackground = System.Drawing.Color.DarkGreen;
            this.torrentList.AlternatingColors = false;
            this.torrentList.AutoHeight = true;
            this.torrentList.BackColor = System.Drawing.Color.White;
            this.torrentList.BackgroundStretchToFit = true;
            glColumn1.ActivatedEmbeddedType = GlacialComponents.Controls.GLActivatedEmbeddedTypes.None;
            glColumn1.CheckBoxes = false;
            glColumn1.ImageIndex = -1;
            glColumn1.Name = "torrentName";
            glColumn1.NumericSort = false;
            glColumn1.Text = "Name";
            glColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            glColumn1.Width = 200;
            glColumn2.ActivatedEmbeddedType = GlacialComponents.Controls.GLActivatedEmbeddedTypes.None;
            glColumn2.CheckBoxes = false;
            glColumn2.ImageIndex = -1;
            glColumn2.Name = "torrentProgress";
            glColumn2.NumericSort = false;
            glColumn2.Text = "Progress";
            glColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            glColumn2.Width = 150;
            glColumn3.ActivatedEmbeddedType = GlacialComponents.Controls.GLActivatedEmbeddedTypes.None;
            glColumn3.CheckBoxes = false;
            glColumn3.ImageIndex = -1;
            glColumn3.Name = "downloadSpeed";
            glColumn3.NumericSort = false;
            glColumn3.Text = "Download Speed";
            glColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            glColumn3.Width = 100;
            glColumn4.ActivatedEmbeddedType = GlacialComponents.Controls.GLActivatedEmbeddedTypes.None;
            glColumn4.CheckBoxes = false;
            glColumn4.ImageIndex = -1;
            glColumn4.Name = "uploadSpeed";
            glColumn4.NumericSort = false;
            glColumn4.Text = "Upload Speed";
            glColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            glColumn4.Width = 100;
            glColumn5.ActivatedEmbeddedType = GlacialComponents.Controls.GLActivatedEmbeddedTypes.None;
            glColumn5.CheckBoxes = false;
            glColumn5.ImageIndex = -1;
            glColumn5.Name = "torrentSize";
            glColumn5.NumericSort = false;
            glColumn5.Text = "Size";
            glColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            glColumn5.Width = 100;
            glColumn6.ActivatedEmbeddedType = GlacialComponents.Controls.GLActivatedEmbeddedTypes.None;
            glColumn6.CheckBoxes = false;
            glColumn6.ImageIndex = -1;
            glColumn6.Name = "etaTime";
            glColumn6.NumericSort = false;
            glColumn6.Text = "ETA";
            glColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            glColumn6.Width = 100;
            this.torrentList.Columns.AddRange(new GlacialComponents.Controls.GLColumn[] {
            glColumn1,
            glColumn2,
            glColumn3,
            glColumn4,
            glColumn5,
            glColumn6});
            this.torrentList.ContextMenuStrip = this.Torrent;
            this.torrentList.ControlStyle = GlacialComponents.Controls.GLControlStyles.SuperFlat;
            this.torrentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.torrentList.FullRowSelect = true;
            this.torrentList.GridColor = System.Drawing.Color.White;
            this.torrentList.GridLines = GlacialComponents.Controls.GLGridLines.gridBoth;
            this.torrentList.GridLineStyle = GlacialComponents.Controls.GLGridLineStyles.gridSolid;
            this.torrentList.GridTypes = GlacialComponents.Controls.GLGridTypes.gridOnExists;
            this.torrentList.HeaderHeight = 22;
            this.torrentList.HeaderVisible = true;
            this.torrentList.HeaderWordWrap = false;
            this.torrentList.HotColumnTracking = false;
            this.torrentList.HotItemTracking = false;
            this.torrentList.HotTrackingColor = System.Drawing.Color.White;
            this.torrentList.HoverEvents = false;
            this.torrentList.HoverTime = 1;
            this.torrentList.ImageList = null;
            this.torrentList.ItemHeight = 17;
            this.torrentList.ItemWordWrap = false;
            this.torrentList.Location = new System.Drawing.Point(0, 0);
            this.torrentList.Name = "torrentList";
            this.torrentList.Selectable = true;
            this.torrentList.SelectedTextColor = System.Drawing.Color.Black;
            this.torrentList.SelectionColor = System.Drawing.SystemColors.ControlLight;
            this.torrentList.ShowBorder = true;
            this.torrentList.ShowFocusRect = false;
            this.torrentList.Size = new System.Drawing.Size(923, 275);
            this.torrentList.SortType = GlacialComponents.Controls.SortTypes.InsertionSort;
            this.torrentList.SuperFlatHeaderColor = System.Drawing.Color.White;
            this.torrentList.TabIndex = 3;
            this.torrentList.Text = "torrentList";
            this.torrentList.Click += new System.EventHandler(this.torrentList_Click);
            // 
            // Torrent
            // 
            this.Torrent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pauseMenu,
            this.stopMenu,
            this.deleteToolStripMenuItem});
            this.Torrent.Name = "contextMenuStrip1";
            this.Torrent.Size = new System.Drawing.Size(108, 70);
            this.Torrent.Text = "Torrent";
            this.Torrent.Opening += new System.ComponentModel.CancelEventHandler(this.Torrent_Opening);
            this.Torrent.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Torrent_ItemClicked);
            // 
            // pauseMenu
            // 
            this.pauseMenu.Name = "pauseMenu";
            this.pauseMenu.Size = new System.Drawing.Size(107, 22);
            this.pauseMenu.Text = "Pause";
            // 
            // stopMenu
            // 
            this.stopMenu.Name = "stopMenu";
            this.stopMenu.Size = new System.Drawing.Size(107, 22);
            this.stopMenu.Text = "Stop";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.torrentToolStripMenuItem1});
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // torrentToolStripMenuItem1
            // 
            this.torrentToolStripMenuItem1.Name = "torrentToolStripMenuItem1";
            this.torrentToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.torrentToolStripMenuItem1.Text = "Torrent";
            this.torrentToolStripMenuItem1.Click += new System.EventHandler(this.torrentToolStripMenuItem1_Click);
            // 
            // torrentTabs
            // 
            this.torrentTabs.Controls.Add(this.infoTab);
            this.torrentTabs.Controls.Add(this.filesTab);
            this.torrentTabs.Controls.Add(this.trackersTab);
            this.torrentTabs.Controls.Add(this.peersTab);
            this.torrentTabs.Controls.Add(this.speedTab);
            this.torrentTabs.Controls.Add(this.settingsTab);
            this.torrentTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.torrentTabs.Enabled = false;
            this.torrentTabs.Location = new System.Drawing.Point(0, 0);
            this.torrentTabs.Name = "torrentTabs";
            this.torrentTabs.SelectedIndex = 0;
            this.torrentTabs.Size = new System.Drawing.Size(923, 223);
            this.torrentTabs.TabIndex = 4;
            // 
            // infoTab
            // 
            this.infoTab.BackColor = System.Drawing.Color.White;
            this.infoTab.Controls.Add(this.torrentBar);
            this.infoTab.Controls.Add(this.outPathLbl);
            this.infoTab.Controls.Add(this.torrentPathLbl);
            this.infoTab.Controls.Add(this.torrentCommentLbl);
            this.infoTab.Controls.Add(this.torrentSizeLbl);
            this.infoTab.Controls.Add(this.label2);
            this.infoTab.Controls.Add(this.stateLbl);
            this.infoTab.Controls.Add(this.torrentNameLbl);
            this.infoTab.Location = new System.Drawing.Point(4, 22);
            this.infoTab.Name = "infoTab";
            this.infoTab.Padding = new System.Windows.Forms.Padding(3);
            this.infoTab.Size = new System.Drawing.Size(915, 197);
            this.infoTab.TabIndex = 0;
            this.infoTab.Text = "Info";
            // 
            // outPathLbl
            // 
            this.outPathLbl.AutoSize = true;
            this.outPathLbl.Location = new System.Drawing.Point(24, 164);
            this.outPathLbl.Name = "outPathLbl";
            this.outPathLbl.Size = new System.Drawing.Size(51, 13);
            this.outPathLbl.TabIndex = 8;
            this.outPathLbl.Text = "Out path:";
            // 
            // torrentPathLbl
            // 
            this.torrentPathLbl.AutoSize = true;
            this.torrentPathLbl.Location = new System.Drawing.Point(24, 151);
            this.torrentPathLbl.Name = "torrentPathLbl";
            this.torrentPathLbl.Size = new System.Drawing.Size(38, 13);
            this.torrentPathLbl.TabIndex = 7;
            this.torrentPathLbl.Text = "Path: -";
            // 
            // torrentCommentLbl
            // 
            this.torrentCommentLbl.AutoSize = true;
            this.torrentCommentLbl.Location = new System.Drawing.Point(24, 135);
            this.torrentCommentLbl.Name = "torrentCommentLbl";
            this.torrentCommentLbl.Size = new System.Drawing.Size(60, 13);
            this.torrentCommentLbl.TabIndex = 6;
            this.torrentCommentLbl.Text = "Comment: -";
            // 
            // torrentSizeLbl
            // 
            this.torrentSizeLbl.AutoSize = true;
            this.torrentSizeLbl.Location = new System.Drawing.Point(24, 120);
            this.torrentSizeLbl.Name = "torrentSizeLbl";
            this.torrentSizeLbl.Size = new System.Drawing.Size(36, 13);
            this.torrentSizeLbl.TabIndex = 4;
            this.torrentSizeLbl.Text = "Size: -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(23, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Torrent info:";
            // 
            // stateLbl
            // 
            this.stateLbl.Location = new System.Drawing.Point(0, 3);
            this.stateLbl.Name = "stateLbl";
            this.stateLbl.Size = new System.Drawing.Size(913, 13);
            this.stateLbl.TabIndex = 2;
            this.stateLbl.Text = "Progress";
            this.stateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // torrentNameLbl
            // 
            this.torrentNameLbl.AutoSize = true;
            this.torrentNameLbl.Location = new System.Drawing.Point(24, 104);
            this.torrentNameLbl.Name = "torrentNameLbl";
            this.torrentNameLbl.Size = new System.Drawing.Size(44, 13);
            this.torrentNameLbl.TabIndex = 0;
            this.torrentNameLbl.Text = "Name: -";
            // 
            // filesTab
            // 
            this.filesTab.Controls.Add(this.filesList);
            this.filesTab.Location = new System.Drawing.Point(4, 22);
            this.filesTab.Name = "filesTab";
            this.filesTab.Padding = new System.Windows.Forms.Padding(3);
            this.filesTab.Size = new System.Drawing.Size(915, 197);
            this.filesTab.TabIndex = 1;
            this.filesTab.Text = "Files";
            this.filesTab.UseVisualStyleBackColor = true;
            // 
            // filesList
            // 
            this.filesList.AllowColumnResize = true;
            this.filesList.AllowMultiselect = false;
            this.filesList.AlternateBackground = System.Drawing.Color.DarkGreen;
            this.filesList.AlternatingColors = false;
            this.filesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filesList.AutoHeight = true;
            this.filesList.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.filesList.BackgroundStretchToFit = true;
            glColumn7.ActivatedEmbeddedType = GlacialComponents.Controls.GLActivatedEmbeddedTypes.None;
            glColumn7.CheckBoxes = false;
            glColumn7.ImageIndex = -1;
            glColumn7.Name = "fileName";
            glColumn7.NumericSort = false;
            glColumn7.Text = "Name";
            glColumn7.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            glColumn7.Width = 200;
            glColumn8.ActivatedEmbeddedType = GlacialComponents.Controls.GLActivatedEmbeddedTypes.None;
            glColumn8.CheckBoxes = false;
            glColumn8.ImageIndex = -1;
            glColumn8.Name = "fileProgress";
            glColumn8.NumericSort = false;
            glColumn8.Text = "Progress";
            glColumn8.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            glColumn8.Width = 150;
            this.filesList.Columns.AddRange(new GlacialComponents.Controls.GLColumn[] {
            glColumn7,
            glColumn8});
            this.filesList.ContextMenuStrip = this.Torrent;
            this.filesList.ControlStyle = GlacialComponents.Controls.GLControlStyles.SuperFlat;
            this.filesList.Cursor = System.Windows.Forms.Cursors.Default;
            this.filesList.FullRowSelect = true;
            this.filesList.GridColor = System.Drawing.Color.White;
            this.filesList.GridLines = GlacialComponents.Controls.GLGridLines.gridBoth;
            this.filesList.GridLineStyle = GlacialComponents.Controls.GLGridLineStyles.gridSolid;
            this.filesList.GridTypes = GlacialComponents.Controls.GLGridTypes.gridOnExists;
            this.filesList.HeaderHeight = 22;
            this.filesList.HeaderVisible = true;
            this.filesList.HeaderWordWrap = false;
            this.filesList.HotColumnTracking = false;
            this.filesList.HotItemTracking = false;
            this.filesList.HotTrackingColor = System.Drawing.Color.LightGray;
            this.filesList.HoverEvents = false;
            this.filesList.HoverTime = 1;
            this.filesList.ImageList = null;
            this.filesList.ItemHeight = 17;
            this.filesList.ItemWordWrap = false;
            this.filesList.Location = new System.Drawing.Point(0, 0);
            this.filesList.Name = "filesList";
            this.filesList.Selectable = true;
            this.filesList.SelectedTextColor = System.Drawing.Color.White;
            this.filesList.SelectionColor = System.Drawing.Color.DarkBlue;
            this.filesList.ShowBorder = true;
            this.filesList.ShowFocusRect = false;
            this.filesList.Size = new System.Drawing.Size(915, 197);
            this.filesList.SortType = GlacialComponents.Controls.SortTypes.InsertionSort;
            this.filesList.SuperFlatHeaderColor = System.Drawing.Color.White;
            this.filesList.TabIndex = 5;
            this.filesList.Text = "glacialList1";
            // 
            // trackersTab
            // 
            this.trackersTab.Controls.Add(this.trackersList);
            this.trackersTab.Location = new System.Drawing.Point(4, 22);
            this.trackersTab.Name = "trackersTab";
            this.trackersTab.Size = new System.Drawing.Size(915, 197);
            this.trackersTab.TabIndex = 2;
            this.trackersTab.Text = "Trackers";
            this.trackersTab.UseVisualStyleBackColor = true;
            // 
            // trackersList
            // 
            this.trackersList.AllowColumnResize = true;
            this.trackersList.AllowMultiselect = false;
            this.trackersList.AlternateBackground = System.Drawing.Color.DarkGreen;
            this.trackersList.AlternatingColors = false;
            this.trackersList.AutoHeight = true;
            this.trackersList.BackColor = System.Drawing.Color.White;
            this.trackersList.BackgroundStretchToFit = true;
            glColumn9.ActivatedEmbeddedType = GlacialComponents.Controls.GLActivatedEmbeddedTypes.None;
            glColumn9.CheckBoxes = false;
            glColumn9.ImageIndex = -1;
            glColumn9.Name = "trackerAddress";
            glColumn9.NumericSort = false;
            glColumn9.Text = "Address";
            glColumn9.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            glColumn9.Width = 200;
            glColumn10.ActivatedEmbeddedType = GlacialComponents.Controls.GLActivatedEmbeddedTypes.None;
            glColumn10.CheckBoxes = false;
            glColumn10.ImageIndex = -1;
            glColumn10.Name = "trackerStatus";
            glColumn10.NumericSort = false;
            glColumn10.Text = "Status";
            glColumn10.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            glColumn10.Width = 150;
            this.trackersList.Columns.AddRange(new GlacialComponents.Controls.GLColumn[] {
            glColumn9,
            glColumn10});
            this.trackersList.ContextMenuStrip = this.Torrent;
            this.trackersList.ControlStyle = GlacialComponents.Controls.GLControlStyles.SuperFlat;
            this.trackersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackersList.FullRowSelect = true;
            this.trackersList.GridColor = System.Drawing.Color.White;
            this.trackersList.GridLines = GlacialComponents.Controls.GLGridLines.gridBoth;
            this.trackersList.GridLineStyle = GlacialComponents.Controls.GLGridLineStyles.gridSolid;
            this.trackersList.GridTypes = GlacialComponents.Controls.GLGridTypes.gridOnExists;
            this.trackersList.HeaderHeight = 22;
            this.trackersList.HeaderVisible = true;
            this.trackersList.HeaderWordWrap = false;
            this.trackersList.HotColumnTracking = false;
            this.trackersList.HotItemTracking = false;
            this.trackersList.HotTrackingColor = System.Drawing.Color.White;
            this.trackersList.HoverEvents = false;
            this.trackersList.HoverTime = 1;
            this.trackersList.ImageList = null;
            this.trackersList.ItemHeight = 17;
            this.trackersList.ItemWordWrap = false;
            this.trackersList.Location = new System.Drawing.Point(0, 0);
            this.trackersList.Name = "trackersList";
            this.trackersList.Selectable = true;
            this.trackersList.SelectedTextColor = System.Drawing.Color.Black;
            this.trackersList.SelectionColor = System.Drawing.SystemColors.ControlLight;
            this.trackersList.ShowBorder = true;
            this.trackersList.ShowFocusRect = false;
            this.trackersList.Size = new System.Drawing.Size(915, 197);
            this.trackersList.SortType = GlacialComponents.Controls.SortTypes.InsertionSort;
            this.trackersList.SuperFlatHeaderColor = System.Drawing.Color.White;
            this.trackersList.TabIndex = 5;
            this.trackersList.Text = "glacialList1";
            // 
            // peersTab
            // 
            this.peersTab.Controls.Add(this.peersList);
            this.peersTab.Location = new System.Drawing.Point(4, 22);
            this.peersTab.Name = "peersTab";
            this.peersTab.Size = new System.Drawing.Size(915, 197);
            this.peersTab.TabIndex = 3;
            this.peersTab.Text = "Peers";
            this.peersTab.UseVisualStyleBackColor = true;
            // 
            // peersList
            // 
            this.peersList.AllowColumnResize = true;
            this.peersList.AllowMultiselect = false;
            this.peersList.AlternateBackground = System.Drawing.Color.DarkGreen;
            this.peersList.AlternatingColors = false;
            this.peersList.AutoHeight = true;
            this.peersList.BackColor = System.Drawing.Color.White;
            this.peersList.BackgroundStretchToFit = true;
            glColumn11.ActivatedEmbeddedType = GlacialComponents.Controls.GLActivatedEmbeddedTypes.None;
            glColumn11.CheckBoxes = false;
            glColumn11.ImageIndex = -1;
            glColumn11.Name = "peerAddress";
            glColumn11.NumericSort = false;
            glColumn11.Text = "Address";
            glColumn11.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            glColumn11.Width = 200;
            glColumn12.ActivatedEmbeddedType = GlacialComponents.Controls.GLActivatedEmbeddedTypes.None;
            glColumn12.CheckBoxes = false;
            glColumn12.ImageIndex = -1;
            glColumn12.Name = "peerDownload";
            glColumn12.NumericSort = false;
            glColumn12.Text = "Download";
            glColumn12.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            glColumn12.Width = 100;
            glColumn13.ActivatedEmbeddedType = GlacialComponents.Controls.GLActivatedEmbeddedTypes.None;
            glColumn13.CheckBoxes = false;
            glColumn13.ImageIndex = -1;
            glColumn13.Name = "peerUpload";
            glColumn13.NumericSort = false;
            glColumn13.Text = "Upload";
            glColumn13.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            glColumn13.Width = 100;
            this.peersList.Columns.AddRange(new GlacialComponents.Controls.GLColumn[] {
            glColumn11,
            glColumn12,
            glColumn13});
            this.peersList.ContextMenuStrip = this.Torrent;
            this.peersList.ControlStyle = GlacialComponents.Controls.GLControlStyles.SuperFlat;
            this.peersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.peersList.FullRowSelect = true;
            this.peersList.GridColor = System.Drawing.Color.White;
            this.peersList.GridLines = GlacialComponents.Controls.GLGridLines.gridBoth;
            this.peersList.GridLineStyle = GlacialComponents.Controls.GLGridLineStyles.gridSolid;
            this.peersList.GridTypes = GlacialComponents.Controls.GLGridTypes.gridOnExists;
            this.peersList.HeaderHeight = 22;
            this.peersList.HeaderVisible = true;
            this.peersList.HeaderWordWrap = false;
            this.peersList.HotColumnTracking = false;
            this.peersList.HotItemTracking = false;
            this.peersList.HotTrackingColor = System.Drawing.Color.White;
            this.peersList.HoverEvents = false;
            this.peersList.HoverTime = 1;
            this.peersList.ImageList = null;
            this.peersList.ItemHeight = 17;
            this.peersList.ItemWordWrap = false;
            this.peersList.Location = new System.Drawing.Point(0, 0);
            this.peersList.Name = "peersList";
            this.peersList.Selectable = true;
            this.peersList.SelectedTextColor = System.Drawing.Color.Black;
            this.peersList.SelectionColor = System.Drawing.SystemColors.ControlLight;
            this.peersList.ShowBorder = true;
            this.peersList.ShowFocusRect = false;
            this.peersList.Size = new System.Drawing.Size(915, 197);
            this.peersList.SortType = GlacialComponents.Controls.SortTypes.InsertionSort;
            this.peersList.SuperFlatHeaderColor = System.Drawing.Color.White;
            this.peersList.TabIndex = 6;
            this.peersList.Text = "glacialList1";
            // 
            // speedTab
            // 
            this.speedTab.Controls.Add(this.speedCounter);
            this.speedTab.Location = new System.Drawing.Point(4, 22);
            this.speedTab.Name = "speedTab";
            this.speedTab.Size = new System.Drawing.Size(915, 197);
            this.speedTab.TabIndex = 4;
            this.speedTab.Text = "Speed";
            this.speedTab.UseVisualStyleBackColor = true;
            // 
            // speedCounter
            // 
            chartArea1.Name = "ChartArea1";
            this.speedCounter.ChartAreas.Add(chartArea1);
            this.speedCounter.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.speedCounter.Legends.Add(legend1);
            this.speedCounter.Location = new System.Drawing.Point(0, 0);
            this.speedCounter.Name = "speedCounter";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            series1.Legend = "Legend1";
            series1.Name = "Download (kB/s)";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(255)))));
            series2.Legend = "Legend1";
            series2.Name = "Upload (kB/s)";
            series2.YValuesPerPoint = 4;
            this.speedCounter.Series.Add(series1);
            this.speedCounter.Series.Add(series2);
            this.speedCounter.Size = new System.Drawing.Size(915, 197);
            this.speedCounter.TabIndex = 0;
            this.speedCounter.Text = "chart1";
            // 
            // settingsTab
            // 
            this.settingsTab.BackColor = System.Drawing.Color.White;
            this.settingsTab.Controls.Add(this.dhtBox);
            this.settingsTab.Controls.Add(this.preferEncyptionBox);
            this.settingsTab.Controls.Add(this.maxConnections);
            this.settingsTab.Controls.Add(this.label4);
            this.settingsTab.Controls.Add(this.maxUpload);
            this.settingsTab.Controls.Add(this.label3);
            this.settingsTab.Controls.Add(this.maximumDownload);
            this.settingsTab.Controls.Add(this.label1);
            this.settingsTab.Location = new System.Drawing.Point(4, 22);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Size = new System.Drawing.Size(915, 197);
            this.settingsTab.TabIndex = 5;
            this.settingsTab.Text = "Settings";
            // 
            // dhtBox
            // 
            this.dhtBox.AutoSize = true;
            this.dhtBox.Checked = true;
            this.dhtBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dhtBox.Location = new System.Drawing.Point(36, 140);
            this.dhtBox.Name = "dhtBox";
            this.dhtBox.Size = new System.Drawing.Size(49, 17);
            this.dhtBox.TabIndex = 7;
            this.dhtBox.Text = "DHT";
            this.dhtBox.UseVisualStyleBackColor = true;
            this.dhtBox.CheckedChanged += new System.EventHandler(this.dhtBox_CheckedChanged);
            // 
            // preferEncyptionBox
            // 
            this.preferEncyptionBox.AutoSize = true;
            this.preferEncyptionBox.Checked = true;
            this.preferEncyptionBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.preferEncyptionBox.Location = new System.Drawing.Point(36, 117);
            this.preferEncyptionBox.Name = "preferEncyptionBox";
            this.preferEncyptionBox.Size = new System.Drawing.Size(106, 17);
            this.preferEncyptionBox.TabIndex = 6;
            this.preferEncyptionBox.Text = "Prefer encryption";
            this.preferEncyptionBox.UseVisualStyleBackColor = true;
            this.preferEncyptionBox.CheckedChanged += new System.EventHandler(this.preferEncyptionBox_CheckedChanged);
            // 
            // maxConnections
            // 
            this.maxConnections.Location = new System.Drawing.Point(148, 91);
            this.maxConnections.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.maxConnections.Name = "maxConnections";
            this.maxConnections.Size = new System.Drawing.Size(78, 20);
            this.maxConnections.TabIndex = 5;
            this.maxConnections.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.maxConnections.ValueChanged += new System.EventHandler(this.maxConnections_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Max connections:";
            // 
            // maxUpload
            // 
            this.maxUpload.Location = new System.Drawing.Point(148, 67);
            this.maxUpload.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.maxUpload.Name = "maxUpload";
            this.maxUpload.Size = new System.Drawing.Size(78, 20);
            this.maxUpload.TabIndex = 3;
            this.maxUpload.Value = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.maxUpload.ValueChanged += new System.EventHandler(this.maxUpload_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Max upload (kB/s): ";
            // 
            // maximumDownload
            // 
            this.maximumDownload.Location = new System.Drawing.Point(148, 43);
            this.maximumDownload.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.maximumDownload.Name = "maximumDownload";
            this.maximumDownload.Size = new System.Drawing.Size(78, 20);
            this.maximumDownload.TabIndex = 1;
            this.maximumDownload.Value = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.maximumDownload.ValueChanged += new System.EventHandler(this.maximumDownload_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Max download (kB/s): ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.torrentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(923, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // torrentToolStripMenuItem
            // 
            this.torrentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.torrentToolStripMenuItem.Name = "torrentToolStripMenuItem";
            this.torrentToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.torrentToolStripMenuItem.Text = "File";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // taskBarIcon
            // 
            this.taskBarIcon.ContextMenuStrip = this.taskBarMenu;
            this.taskBarIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("taskBarIcon.Icon")));
            this.taskBarIcon.Text = "FTorrent";
            // 
            // taskBarMenu
            // 
            this.taskBarMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.taskBarMenu.Name = "taskBarMenu";
            this.taskBarMenu.Size = new System.Drawing.Size(104, 48);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // torrentBar
            // 
            this.torrentBar.CustomText = null;
            this.torrentBar.DisplayStyle = FTorrent.Controls.ProgressBarDisplayText.Percentage;
            this.torrentBar.Location = new System.Drawing.Point(8, 19);
            this.torrentBar.Name = "torrentBar";
            this.torrentBar.ProgressBarColor = System.Drawing.Color.YellowGreen;
            this.torrentBar.Size = new System.Drawing.Size(896, 33);
            this.torrentBar.TabIndex = 9;
            this.torrentBar.TextColor = System.Drawing.Color.Indigo;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 526);
            this.Controls.Add(this.torrentPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "FTorrent v0.1 Beta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.Resize += new System.EventHandler(this.mainForm_Resize);
            this.torrentPanel.ResumeLayout(false);
            this.torrentPanel.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.Torrent.ResumeLayout(false);
            this.torrentTabs.ResumeLayout(false);
            this.infoTab.ResumeLayout(false);
            this.infoTab.PerformLayout();
            this.filesTab.ResumeLayout(false);
            this.trackersTab.ResumeLayout(false);
            this.peersTab.ResumeLayout(false);
            this.speedTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.speedCounter)).EndInit();
            this.settingsTab.ResumeLayout(false);
            this.settingsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxConnections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxUpload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximumDownload)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.taskBarMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel torrentPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private GlacialComponents.Controls.GlacialList torrentList;
        private System.Windows.Forms.ToolStripMenuItem torrentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.TabControl torrentTabs;
        private System.Windows.Forms.TabPage infoTab;
        private System.Windows.Forms.TabPage filesTab;
        private System.Windows.Forms.Label torrentNameLbl;
        private System.Windows.Forms.Label stateLbl;
        private System.Windows.Forms.Label torrentSizeLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip Torrent;
        private System.Windows.Forms.ToolStripMenuItem pauseMenu;
        private System.Windows.Forms.ToolStripMenuItem stopMenu;
        private System.Windows.Forms.TabPage trackersTab;
        private System.Windows.Forms.Label torrentCommentLbl;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem torrentToolStripMenuItem1;
        private System.Windows.Forms.Label torrentPathLbl;
        private System.Windows.Forms.Label outPathLbl;
        private Controls.FProgressBar torrentBar;
        private GlacialComponents.Controls.GlacialList trackersList;
        private System.Windows.Forms.TabPage peersTab;
        private GlacialComponents.Controls.GlacialList filesList;
        private GlacialComponents.Controls.GlacialList peersList;
        private System.Windows.Forms.TabPage speedTab;
        private System.Windows.Forms.DataVisualization.Charting.Chart speedCounter;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage settingsTab;
        private System.Windows.Forms.NumericUpDown maxUpload;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown maximumDownload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown maxConnections;
        private System.Windows.Forms.CheckBox preferEncyptionBox;
        private System.Windows.Forms.CheckBox dhtBox;
        private System.Windows.Forms.NotifyIcon taskBarIcon;
        private System.Windows.Forms.ContextMenuStrip taskBarMenu;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

