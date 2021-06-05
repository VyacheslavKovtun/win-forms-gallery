using PictureGallery.Models.Settings;
using PictureGallery.Models.Settings.ReadSettings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PictureGallery
{ 
    public partial class MainForm : Form
    {
        Settings settings = new Settings();
        public readonly List<string> IMAGE_FORMATS = new List<string>() { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };
        public string TekDir { get; set; }

        public List<string> history = new List<string>();

        public MainForm()
        { 
            InitializeComponent();
            InitControls();
            TVFilesMain.AfterSelect += TVFilesMain_AfterSelect;
            TVFilesMain.BeforeExpand += TVFilesMain_BeforeExpand;

            settings.UseMainControlsSettings += Settings_UseMainControlsSettings;
            settings.UpdateLVFilesMain += Settings_UpdateLVFilesMain;
            settings.LVFilesMainItemsAdd += Settings_LVFilesMainItemsAdd;
        }

        private void Settings_LVFilesMainItemsAdd(ListViewItem item)
        {
            LVFilesMain.Items.Add(item);
        }

        private void Settings_UpdateLVFilesMain(DirectoryInfo dirInfo)
        {
            LVFilesMain.Items.Clear();
        }

        public void SetTSSLblText(string text)
        {
            TSSLblLoadFiles.Text = text;
        }

        public void SetTSPBSettings(bool visible, int value, int maxValue)
        {
            TSPBLoadFiles.Visible = visible;
            TSPBLoadFiles.Value = value;
            TSPBLoadFiles.Maximum = maxValue;
        }

        private void Settings_UseMainControlsSettings()
        {
            XmlSettingsReader reader = new XmlSettingsReader(this);

            List<Size> controlsSizes = reader.GetSettings();

            TSMain.Size = controlsSizes[0];
            TVFilesMain.Size = controlsSizes[1];
            LVFilesMain.Size = controlsSizes[2];
            StatusStripMain.Size = controlsSizes[3];
        }

        private void TVFilesMain_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes.Count > 0)
            {
                if (e.Node.Nodes[0].Text.Equals(""))
                {
                    e.Node.Nodes.RemoveAt(0);
                    TVFilesMain.SelectedNode = e.Node;
                }
            }
        }

        private void TVFilesMain_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(e.Node.FullPath);

            if (TVFilesMain.SelectedNode.Nodes.Count <= 1)
            {
                settings.OpenSelectedTVFolder(directoryInfo, e);
            }

            settings.UpdateLVMain(directoryInfo, this);
        }

        private void InitControls()
        {
            TSTBFindName.Clear();
            TSTBFindType.Clear();
            TSTBFindSize.Clear();
            TSTBFindDate.Clear();
            TSTBFindTags.Clear();
            TVFilesMain.Nodes.Clear();
            LVFilesMain.Clear();
            TSCBBtnView.Items.Clear();

            TVFilesMain.Nodes.AddRange(settings.GetTVElements().ToArray());

            LVFilesMain.SmallImageList = settings.GetSmallImageList();

            LVFilesMain.LargeImageList = settings.GetLargeImageList();

            LVFilesMain.Columns.Add("Name", 170);
            LVFilesMain.Columns.Add("Type", 50);
            LVFilesMain.Columns.Add("Creating date", 135);
            LVFilesMain.Columns.Add("Size",100);
            LVFilesMain.Columns.Add("Tags",100);

            TSCBBtnView.Items.AddRange(Enum.GetNames(typeof(View)));
        }

        private void LVFilesMain_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (LVFilesMain.SelectedItems[0].ImageIndex == 1)
                {
                    string selDirPath = LVFilesMain.SelectedItems[0].ToolTipText;

                    DirectoryInfo dirInfo = new DirectoryInfo(selDirPath);

                    settings.UpdateLVMain(dirInfo, this);
                }
                else
                {
                    string selFilePath = string.Empty;
                    if (search)
                        selFilePath = LVFilesMain.SelectedItems[0].Text;
                    else
                        selFilePath = LVFilesMain.SelectedItems[0].ToolTipText;

                    Image image = Image.FromFile(selFilePath);

                    search = false;

                    settings.ShowImage(image, LVFilesMain.SelectedItems[0].Text, selFilePath, this);
                }
            }
            catch (Exception ex) { }
        }

        private void TSBtnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                TVFilesMain.SelectedNode = TVFilesMain.SelectedNode.Parent;
            }
            catch (Exception ex) { }
        }

        private void TSCBBtnView_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = TSCBBtnView.SelectedIndex;
            if (idx != -1)
            {
                var selItem = TSCBBtnView.SelectedItem.ToString();
                var view = (View)Enum.Parse(typeof(View), selItem);
                LVFilesMain.View = view;
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LVFilesMain.SelectedItems.Count == 0)
                MessageBox.Show("Выберите файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    string selFilePath = LVFilesMain.SelectedItems[0].ToolTipText;

                    Image image = Image.FromFile(selFilePath);

                    settings.ShowImage(image, LVFilesMain.SelectedItems[0].Text, selFilePath, this);
                }
                catch (Exception ex) { }
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LVFilesMain.SelectedItems.Count == 0)
                MessageBox.Show("Выберите файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                SaveFileDialog sdlg = new SaveFileDialog();
                sdlg.ShowDialog();

                string selFilePath = LVFilesMain.SelectedItems[0].ToolTipText;
                Image image = Image.FromFile(selFilePath);

                image.Save(sdlg.FileName);
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LVFilesMain.SelectedItems.Count == 0)
                MessageBox.Show("Выберите файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string selPath = LVFilesMain.SelectedItems[0].ToolTipText;
                LVFilesMain.SelectedItems[0].Remove();
                LVFilesMain.Update();
                if (Directory.Exists(selPath))
                    Directory.Delete(selPath, true);
                else
                    File.Delete(selPath);
            }
        }

        private void CopyFile()
        {
            if (LVFilesMain.SelectedItems.Count == 0)
                MessageBox.Show("Выберите файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string selFilePath = LVFilesMain.SelectedItems[0].ToolTipText;

                Clipboard.SetText(selFilePath);
            }
        }

        private void CopyTool_Click(object sender, EventArgs e)
        {
            CopyFile();
            cut = false;
        }

        bool cut = false;

        private void CutTool_Click(object sender, EventArgs e)
        {
            CopyFile();
            filePath = Clipboard.GetText();
            FileInfo file = new FileInfo(filePath);
            fileName = file.Name;

            Image image = Image.FromFile(filePath);
            newImage = (Image)image.Clone();

            LVFilesMain.SelectedItems[0].Remove();
            LVFilesMain.Update();
            cut = true;
        }

        Image newImage;
        string fileName = string.Empty;
        string filePath = string.Empty;

        private void PasteTool_Click(object sender, EventArgs e)
        {
            try
            {
                DirectoryInfo newDirectory = new DirectoryInfo(TekDir);
                
                string destFileName = $"{TekDir}\\{fileName}";

                newImage.Save(destFileName);

                if (cut)
                    File.Delete(filePath);

                settings.UpdateLVMain(newDirectory, this);
                cut = false;
            }
            catch (Exception ex) { }
        }

        private void LVFilesMain_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop) as string[];
            var path = data[0];

            FileInfo file = new FileInfo(path);
            Image image = Image.FromFile(path);

            settings.ShowImage(image, file.Name, file.FullName, this);
        }

        private void LVFilesMain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        bool search = false;
        private void TSTBFindName_TextChanged(object sender, EventArgs e)
        {
            if(TSTBFindName.Text.Length != 0)
            {
                LVFilesMain.View = View.List;
                DirectoryInfo directory = new DirectoryInfo(TekDir);
                LVFilesMain.Clear();
                search = true;

                LVFilesMain.Items.AddRange(settings.GetFilesBy(directory, TSTBFindName.Text, this).ToArray());
            }
        }

        private void TSBtnCancelSearch_Click(object sender, EventArgs e)
        {
            InitControls();
        }

        private void TSTBFindType_TextChanged(object sender, EventArgs e)
        {
            if (TSTBFindType.Text.Length != 0)
            {
                LVFilesMain.View = View.List;
                DirectoryInfo directory = new DirectoryInfo(TekDir);
                LVFilesMain.Clear();
                search = true;

                LVFilesMain.Items.AddRange(settings.GetFilesBy(directory, TSTBFindType.Text, this).ToArray());
            }
        }

        private void TSTBFindSize_TextChanged(object sender, EventArgs e)
        {
            if (TSTBFindSize.Text.Length != 0)
            {
                LVFilesMain.View = View.List;
                DirectoryInfo directory = new DirectoryInfo(TekDir);
                LVFilesMain.Clear();
                search = true;

                LVFilesMain.Items.AddRange(settings.GetFilesBy(directory, TSTBFindSize.Text, this).ToArray());
            }
        }

        private void TSTBFindDate_TextChanged(object sender, EventArgs e)
        {
            if (TSTBFindDate.Text.Length != 0)
            {
                LVFilesMain.View = View.List;
                DirectoryInfo directory = new DirectoryInfo(TekDir);
                LVFilesMain.Clear();
                search = true;

                LVFilesMain.Items.AddRange(settings.GetFilesBy(directory, TSTBFindDate.Text, this).ToArray());
            }
        }

        private void TSTBFindTags_TextChanged(object sender, EventArgs e)
        {
            if (TSTBFindTags.Text.Length != 0)
            {
                LVFilesMain.View = View.List;
                DirectoryInfo directory = new DirectoryInfo(TekDir);
                LVFilesMain.Clear();
                search = true;

                LVFilesMain.Items.AddRange(settings.GetFilesBy(directory, TSTBFindTags.Text, this).ToArray());
            }
        }

        private void HistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LVFilesMain.View = View.List;
            LVFilesMain.Clear();

            LVFilesMain.Items.AddRange(settings.GetHistory(this).ToArray());
        }

        private void HideTSElements()
        {
            toolStripLabel1.Visible = toolStripLabel2.Visible = toolStripLabel3.Visible = toolStripLabel4.Visible = toolStripLabel5.Visible = TSTBFindName.Visible 
                = TSTBFindType.Visible = TSTBFindSize.Visible = TSTBFindDate.Visible = TSTBFindTags.Visible = TSBtnCancelSearch.Visible = false;
        }

        private void ShowTSElements()
        {
            toolStripLabel1.Visible = toolStripLabel2.Visible = toolStripLabel3.Visible = toolStripLabel4.Visible = toolStripLabel5.Visible = TSTBFindName.Visible
                = TSTBFindType.Visible = TSTBFindSize.Visible = TSTBFindDate.Visible = TSTBFindTags.Visible = TSBtnCancelSearch.Visible = true;
        }

        private void ChangeTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LVFilesMain.SelectedItems.Count == 0)
                MessageBox.Show("Выберите файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    if (search)
                        path = LVFilesMain.SelectedItems[0].Text;
                    else
                        path = LVFilesMain.SelectedItems[0].ToolTipText;

                    HideTSElements();

                    settings.CreateSearchField(LblType, TBType, BtnOK);

                    TSMain.Items.Add(LblType);
                    TSMain.Items.Add(TBType);
                    TSMain.Items.Add(BtnOK);

                    BtnOK.Click += BtnOK_Click;
                }
                catch (Exception ex) { }

                search = false;
            }
        }

        ToolStripLabel LblType;
        ToolStripTextBox TBType;
        ToolStripButton BtnOK;
        string path = string.Empty;

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (TBType.Text.Length != 0)
            {
                try
                {
                    DirectoryInfo directory = new DirectoryInfo(TekDir);
                    Image image = Image.FromFile(path);

                    string[] pathParts = path.Split('.');

                    path = pathParts[0] + "." + TBType.Text;
                    LVFilesMain.SelectedItems[0].Remove();
                    image.Save(path);
                    InitControls();

                    LblType.Visible = TBType.Visible = BtnOK.Visible = false;

                    ShowTSElements();

                    settings.UpdateLVMain(directory, this);
                }
                catch (Exception ex) { }
            }
        }

        private void LVFilesMain_MouseClick(object sender, MouseEventArgs e)
        {
            if (LVFilesMain.SelectedItems.Count != 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    CMSMain.Show(e.Location);
                }
            }
        }

        private void RedrawControlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings.UseControlsSettings();
        }
    }
}
