namespace PictureGallery
{
    partial class MainForm
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
            this.TVFilesMain = new System.Windows.Forms.TreeView();
            this.LVFilesMain = new System.Windows.Forms.ListView();
            this.TSMain = new System.Windows.Forms.ToolStrip();
            this.toolStripLlbFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.ChangeTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSCBBtnView = new System.Windows.Forms.ToolStripComboBox();
            this.TSBtnReturn = new System.Windows.Forms.ToolStripButton();
            this.TSLblSettings = new System.Windows.Forms.ToolStripDropDownButton();
            this.HistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RedrawControlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.TSTBFindName = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.TSTBFindType = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.TSTBFindSize = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.TSTBFindDate = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.TSTBFindTags = new System.Windows.Forms.ToolStripTextBox();
            this.TSBtnCancelSearch = new System.Windows.Forms.ToolStripButton();
            this.StatusStripMain = new System.Windows.Forms.StatusStrip();
            this.TSSLblLoadFiles = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSPBLoadFiles = new System.Windows.Forms.ToolStripProgressBar();
            this.CMSMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenCStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.CopyCStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CutCStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteCStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveAsCStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.DelCStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeFormatCStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMain.SuspendLayout();
            this.StatusStripMain.SuspendLayout();
            this.CMSMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // TVFilesMain
            // 
            this.TVFilesMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TVFilesMain.Location = new System.Drawing.Point(0, 23);
            this.TVFilesMain.Name = "TVFilesMain";
            this.TVFilesMain.Size = new System.Drawing.Size(202, 408);
            this.TVFilesMain.TabIndex = 0;
            // 
            // LVFilesMain
            // 
            this.LVFilesMain.AllowDrop = true;
            this.LVFilesMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LVFilesMain.HideSelection = false;
            this.LVFilesMain.Location = new System.Drawing.Point(200, 23);
            this.LVFilesMain.Name = "LVFilesMain";
            this.LVFilesMain.Size = new System.Drawing.Size(588, 408);
            this.LVFilesMain.TabIndex = 1;
            this.LVFilesMain.UseCompatibleStateImageBehavior = false;
            this.LVFilesMain.DragDrop += new System.Windows.Forms.DragEventHandler(this.LVFilesMain_DragDrop);
            this.LVFilesMain.DragEnter += new System.Windows.Forms.DragEventHandler(this.LVFilesMain_DragEnter);
            this.LVFilesMain.DoubleClick += new System.EventHandler(this.LVFilesMain_DoubleClick);
            this.LVFilesMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LVFilesMain_MouseClick);
            // 
            // TSMain
            // 
            this.TSMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TSMain.AutoSize = false;
            this.TSMain.Dock = System.Windows.Forms.DockStyle.None;
            this.TSMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLlbFile,
            this.TSCBBtnView,
            this.TSBtnReturn,
            this.TSLblSettings,
            this.toolStripSeparator4,
            this.toolStripLabel1,
            this.TSTBFindName,
            this.toolStripLabel2,
            this.TSTBFindType,
            this.toolStripLabel3,
            this.TSTBFindSize,
            this.toolStripLabel4,
            this.TSTBFindDate,
            this.toolStripLabel5,
            this.TSTBFindTags,
            this.TSBtnCancelSearch});
            this.TSMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.TSMain.Location = new System.Drawing.Point(0, 0);
            this.TSMain.Name = "TSMain";
            this.TSMain.Size = new System.Drawing.Size(788, 20);
            this.TSMain.TabIndex = 2;
            this.TSMain.Text = "toolStrip1";
            // 
            // toolStripLlbFile
            // 
            this.toolStripLlbFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.toolStripSeparator3,
            this.CopyToolStripMenuItem,
            this.CutToolStripMenuItem,
            this.PasteToolStripMenuItem,
            this.toolStripSeparator2,
            this.SaveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.DeleteToolStripMenuItem,
            this.toolStripSeparator8,
            this.ChangeTypeToolStripMenuItem});
            this.toolStripLlbFile.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripLlbFile.Name = "toolStripLlbFile";
            this.toolStripLlbFile.ShowDropDownArrow = false;
            this.toolStripLlbFile.Size = new System.Drawing.Size(37, 17);
            this.toolStripLlbFile.Text = "Файл";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.OpenToolStripMenuItem.Text = "Открыть";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(220, 6);
            // 
            // CopyToolStripMenuItem
            // 
            this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            this.CopyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.CopyToolStripMenuItem.Text = "Копировать";
            this.CopyToolStripMenuItem.Click += new System.EventHandler(this.CopyTool_Click);
            // 
            // CutToolStripMenuItem
            // 
            this.CutToolStripMenuItem.Name = "CutToolStripMenuItem";
            this.CutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.CutToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.CutToolStripMenuItem.Text = "Вырезать";
            this.CutToolStripMenuItem.Click += new System.EventHandler(this.CutTool_Click);
            // 
            // PasteToolStripMenuItem
            // 
            this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            this.PasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.PasteToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.PasteToolStripMenuItem.Text = "Вставить";
            this.PasteToolStripMenuItem.Click += new System.EventHandler(this.PasteTool_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(220, 6);
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.SaveAsToolStripMenuItem.Text = "Сохранить как";
            this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(220, 6);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.DeleteToolStripMenuItem.Text = "Удалить";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(220, 6);
            // 
            // ChangeTypeToolStripMenuItem
            // 
            this.ChangeTypeToolStripMenuItem.Name = "ChangeTypeToolStripMenuItem";
            this.ChangeTypeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.ChangeTypeToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.ChangeTypeToolStripMenuItem.Text = "Изменить формат";
            this.ChangeTypeToolStripMenuItem.Click += new System.EventHandler(this.ChangeTypeToolStripMenuItem_Click);
            // 
            // TSCBBtnView
            // 
            this.TSCBBtnView.Name = "TSCBBtnView";
            this.TSCBBtnView.Size = new System.Drawing.Size(75, 23);
            this.TSCBBtnView.Text = "Вид";
            this.TSCBBtnView.SelectedIndexChanged += new System.EventHandler(this.TSCBBtnView_SelectedIndexChanged);
            // 
            // TSBtnReturn
            // 
            this.TSBtnReturn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBtnReturn.Image = global::PictureGallery.Properties.Resources.return1;
            this.TSBtnReturn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBtnReturn.Name = "TSBtnReturn";
            this.TSBtnReturn.Size = new System.Drawing.Size(23, 20);
            this.TSBtnReturn.Text = "Назад";
            this.TSBtnReturn.Click += new System.EventHandler(this.TSBtnReturn_Click);
            // 
            // TSLblSettings
            // 
            this.TSLblSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HistoryToolStripMenuItem,
            this.SettingsToolStripMenuItem});
            this.TSLblSettings.Name = "TSLblSettings";
            this.TSLblSettings.ShowDropDownArrow = false;
            this.TSLblSettings.Size = new System.Drawing.Size(71, 19);
            this.TSLblSettings.Text = "Настройки";
            // 
            // HistoryToolStripMenuItem
            // 
            this.HistoryToolStripMenuItem.Name = "HistoryToolStripMenuItem";
            this.HistoryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.HistoryToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.HistoryToolStripMenuItem.Text = "История";
            this.HistoryToolStripMenuItem.Click += new System.EventHandler(this.HistoryToolStripMenuItem_Click);
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RedrawControlsToolStripMenuItem});
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.SettingsToolStripMenuItem.Text = "Настройки";
            // 
            // RedrawControlsToolStripMenuItem
            // 
            this.RedrawControlsToolStripMenuItem.Name = "RedrawControlsToolStripMenuItem";
            this.RedrawControlsToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.RedrawControlsToolStripMenuItem.Text = "Перерисовка элементов";
            this.RedrawControlsToolStripMenuItem.Click += new System.EventHandler(this.RedrawControlsToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(39, 15);
            this.toolStripLabel1.Text = "Name";
            // 
            // TSTBFindName
            // 
            this.TSTBFindName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TSTBFindName.Name = "TSTBFindName";
            this.TSTBFindName.Size = new System.Drawing.Size(70, 23);
            this.TSTBFindName.TextChanged += new System.EventHandler(this.TSTBFindName_TextChanged);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(32, 15);
            this.toolStripLabel2.Text = "Type";
            // 
            // TSTBFindType
            // 
            this.TSTBFindType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TSTBFindType.Name = "TSTBFindType";
            this.TSTBFindType.Size = new System.Drawing.Size(40, 23);
            this.TSTBFindType.TextChanged += new System.EventHandler(this.TSTBFindType_TextChanged);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(27, 15);
            this.toolStripLabel3.Text = "Size";
            // 
            // TSTBFindSize
            // 
            this.TSTBFindSize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TSTBFindSize.Name = "TSTBFindSize";
            this.TSTBFindSize.Size = new System.Drawing.Size(60, 23);
            this.TSTBFindSize.TextChanged += new System.EventHandler(this.TSTBFindSize_TextChanged);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(31, 15);
            this.toolStripLabel4.Text = "Date";
            // 
            // TSTBFindDate
            // 
            this.TSTBFindDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TSTBFindDate.Name = "TSTBFindDate";
            this.TSTBFindDate.Size = new System.Drawing.Size(70, 23);
            this.TSTBFindDate.TextChanged += new System.EventHandler(this.TSTBFindDate_TextChanged);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(31, 15);
            this.toolStripLabel5.Text = "Tags";
            // 
            // TSTBFindTags
            // 
            this.TSTBFindTags.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TSTBFindTags.Name = "TSTBFindTags";
            this.TSTBFindTags.Size = new System.Drawing.Size(70, 23);
            this.TSTBFindTags.TextChanged += new System.EventHandler(this.TSTBFindTags_TextChanged);
            // 
            // TSBtnCancelSearch
            // 
            this.TSBtnCancelSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBtnCancelSearch.Image = global::PictureGallery.Properties.Resources.cancel;
            this.TSBtnCancelSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBtnCancelSearch.Name = "TSBtnCancelSearch";
            this.TSBtnCancelSearch.Size = new System.Drawing.Size(23, 20);
            this.TSBtnCancelSearch.Text = "Сброс";
            this.TSBtnCancelSearch.Click += new System.EventHandler(this.TSBtnCancelSearch_Click);
            // 
            // StatusStripMain
            // 
            this.StatusStripMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusStripMain.AutoSize = false;
            this.StatusStripMain.Dock = System.Windows.Forms.DockStyle.None;
            this.StatusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSLblLoadFiles,
            this.TSPBLoadFiles});
            this.StatusStripMain.Location = new System.Drawing.Point(0, 431);
            this.StatusStripMain.Name = "StatusStripMain";
            this.StatusStripMain.Size = new System.Drawing.Size(788, 19);
            this.StatusStripMain.TabIndex = 3;
            this.StatusStripMain.Text = "Статус";
            // 
            // TSSLblLoadFiles
            // 
            this.TSSLblLoadFiles.Name = "TSSLblLoadFiles";
            this.TSSLblLoadFiles.Size = new System.Drawing.Size(45, 14);
            this.TSSLblLoadFiles.Text = "Готово";
            // 
            // TSPBLoadFiles
            // 
            this.TSPBLoadFiles.Name = "TSPBLoadFiles";
            this.TSPBLoadFiles.Size = new System.Drawing.Size(100, 13);
            this.TSPBLoadFiles.Step = 1;
            this.TSPBLoadFiles.Visible = false;
            // 
            // CMSMain
            // 
            this.CMSMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenCStripMenuItem,
            this.toolStripSeparator5,
            this.CopyCStripMenuItem,
            this.CutCStripMenuItem,
            this.PasteCStripMenuItem,
            this.toolStripSeparator6,
            this.SaveAsCStripMenuItem,
            this.toolStripSeparator7,
            this.DelCStripMenuItem,
            this.ChangeFormatCStripMenuItem});
            this.CMSMain.Name = "CMSMain";
            this.CMSMain.Size = new System.Drawing.Size(226, 176);
            // 
            // OpenCStripMenuItem
            // 
            this.OpenCStripMenuItem.Name = "OpenCStripMenuItem";
            this.OpenCStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenCStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.OpenCStripMenuItem.Text = "Открыть";
            this.OpenCStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(222, 6);
            // 
            // CopyCStripMenuItem
            // 
            this.CopyCStripMenuItem.Name = "CopyCStripMenuItem";
            this.CopyCStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyCStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.CopyCStripMenuItem.Text = "Копировать";
            this.CopyCStripMenuItem.Click += new System.EventHandler(this.CopyTool_Click);
            // 
            // CutCStripMenuItem
            // 
            this.CutCStripMenuItem.Name = "CutCStripMenuItem";
            this.CutCStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.CutCStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.CutCStripMenuItem.Text = "Вырезать";
            this.CutCStripMenuItem.Click += new System.EventHandler(this.CutTool_Click);
            // 
            // PasteCStripMenuItem
            // 
            this.PasteCStripMenuItem.Name = "PasteCStripMenuItem";
            this.PasteCStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.PasteCStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.PasteCStripMenuItem.Text = "Вставить";
            this.PasteCStripMenuItem.Click += new System.EventHandler(this.PasteTool_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(222, 6);
            // 
            // SaveAsCStripMenuItem
            // 
            this.SaveAsCStripMenuItem.Name = "SaveAsCStripMenuItem";
            this.SaveAsCStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.SaveAsCStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.SaveAsCStripMenuItem.Text = "Сохранить как";
            this.SaveAsCStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(222, 6);
            // 
            // DelCStripMenuItem
            // 
            this.DelCStripMenuItem.Name = "DelCStripMenuItem";
            this.DelCStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.DelCStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.DelCStripMenuItem.Text = "Удалить";
            this.DelCStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // ChangeFormatCStripMenuItem
            // 
            this.ChangeFormatCStripMenuItem.Name = "ChangeFormatCStripMenuItem";
            this.ChangeFormatCStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.ChangeFormatCStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.ChangeFormatCStripMenuItem.Text = "Изменить формат";
            this.ChangeFormatCStripMenuItem.Click += new System.EventHandler(this.ChangeTypeToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 450);
            this.Controls.Add(this.StatusStripMain);
            this.Controls.Add(this.TSMain);
            this.Controls.Add(this.LVFilesMain);
            this.Controls.Add(this.TVFilesMain);
            this.Name = "MainForm";
            this.Text = "Галерея";
            this.TSMain.ResumeLayout(false);
            this.TSMain.PerformLayout();
            this.StatusStripMain.ResumeLayout(false);
            this.StatusStripMain.PerformLayout();
            this.CMSMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView TVFilesMain;
        private System.Windows.Forms.ListView LVFilesMain;
        private System.Windows.Forms.ToolStrip TSMain;
        private System.Windows.Forms.ToolStripDropDownButton toolStripLlbFile;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.StatusStrip StatusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel TSSLblLoadFiles;
        private System.Windows.Forms.ToolStripComboBox TSCBBtnView;
        private System.Windows.Forms.ToolStripButton TSBtnReturn;
        private System.Windows.Forms.ToolStripProgressBar TSPBLoadFiles;
        private System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem CutToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox TSTBFindName;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox TSTBFindType;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox TSTBFindSize;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox TSTBFindDate;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripTextBox TSTBFindTags;
        private System.Windows.Forms.ToolStripButton TSBtnCancelSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripDropDownButton TSLblSettings;
        private System.Windows.Forms.ToolStripMenuItem HistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip CMSMain;
        private System.Windows.Forms.ToolStripMenuItem OpenCStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem CopyCStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CutCStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteCStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem SaveAsCStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem DelCStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem ChangeTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeFormatCStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RedrawControlsToolStripMenuItem;
    }
}

