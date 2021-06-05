using PictureGallery.Models.Settings.ReadSettings;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureGallery.Models.Settings
{
    public class Settings
    {
        public event Action UseMainControlsSettings;
        public event Action<DirectoryInfo> UpdateLVFilesMain;
        public event Action<ListViewItem> LVFilesMainItemsAdd;

        public Settings() { }

        public void CreateSearchField(ToolStripLabel lbl, ToolStripTextBox tb, ToolStripButton btn)
        {
            lbl = new ToolStripLabel
            {
                Text = "New type: "
            };

            tb = new ToolStripTextBox();

            btn = new ToolStripButton
            {
                DisplayStyle = ToolStripItemDisplayStyle.Text,
                Text = "OK"
            };
        }

        public List<ListViewItem> GetHistory(MainForm parent)
        {
            List<ListViewItem> items = new List<ListViewItem>();
            foreach (var item in parent.history)
            {
                ListViewItem listViewItem = new ListViewItem(item);

                items.Add(listViewItem);
            }

            return items;
        }

        public List<ListViewItem> GetFilesBy(DirectoryInfo directory, string param, MainForm parent)
        {
            List<ListViewItem> files = new List<ListViewItem>();
            foreach (var file in directory.GetFiles())
            {
                if (file.Name.Contains(param))
                {
                    ListViewItem item = new ListViewItem(file.FullName);
                    files.Add(item);
                    
                    parent.history.Add(file.FullName);
                }
            }

            return files;
        }

        public void ShowImage(Image image, string text, string path, MainForm parent)
        {
            parent.Hide();
            ShowForm showForm = new ShowForm(parent, image, text, path);
            showForm.Show();
        }

        public void MoveImage(string filePath, bool nextImage, MainForm parent)
        {
            FileInfo fileInfo = new FileInfo(filePath);

            List<string> files = new List<string>();

            foreach (var file in Directory.GetFiles(fileInfo.DirectoryName))
            {
                foreach (var format in parent.IMAGE_FORMATS)
                {
                    if (file.Contains(format))
                    {
                        files.Add(file);
                    }
                }
            }

            try
            {
                for (int i = 0; i < files.Count; i++)
                {
                    if (files[i] == filePath)
                    {
                        FileInfo info;
                        if (nextImage)
                            info = new FileInfo(files[i + 1]);
                        else
                            info = new FileInfo(files[i - 1]);
                        Image image = Image.FromFile(info.FullName);
                        ShowImage(image, info.Name, info.FullName, parent);
                        break;
                    }
                }
            }
            catch (Exception ex) { }
        }

        public void LVItemsAdd(ListViewItem item)
        {
            LVFilesMainItemsAdd?.Invoke(item);
        }

        public void UpdateLVMain(DirectoryInfo dirInfo, MainForm parent)
        {
            UpdateLVFilesMain?.Invoke(dirInfo);

            try
            {
                List<string> folders = new List<string>(Directory.GetDirectories(dirInfo.FullName));
                bool visible = true;
                int maxValue = folders.Count;
                int value = 0;
                parent.SetTSSLblText("Загрузка папок");
                parent.SetTSPBSettings(visible, value, maxValue);
                parent.Update();

                foreach (var folder in folders)
                {
                    DirectoryInfo directory = new DirectoryInfo(folder);

                    ListViewItem item = new ListViewItem();
                    item.Text = directory.Name;
                    item.ToolTipText = directory.FullName;
                    item.ImageIndex = 1;
                    item.SubItems.Add("Папка");
                    item.SubItems.Add(directory.CreationTime.ToString());

                    LVItemsAdd(item);
                    value++;
                    parent.SetTSPBSettings(visible, value, maxValue);
                    GC.Collect();
                }
                parent.SetTSSLblText("Готово");
                visible = false;
                value = 0;
                parent.SetTSPBSettings(visible, value, maxValue);
                parent.Update();

                List<string> files = new List<string>(Directory.GetFiles(dirInfo.FullName));
                parent.SetTSSLblText("Загрузка файлов");
                visible = true;
                maxValue = files.Count;
                parent.SetTSPBSettings(visible, value, maxValue);

                parent.Update();

                foreach (var file in files)
                {
                    foreach (var format in parent.IMAGE_FORMATS)
                    {
                        if (file.Contains(format))
                        {
                            FileInfo fileInfo = new FileInfo(file);

                            ListViewItem item = new ListViewItem();
                            item.Text = fileInfo.Name;
                            item.ToolTipText = fileInfo.FullName;
                            item.ImageIndex = 0;
                            item.SubItems.Add(format);
                            item.SubItems.Add(fileInfo.CreationTime.ToString());
                            item.SubItems.Add(fileInfo.Length.ToString());

                            Image image = Image.FromFile(file);
                            item.Tag = image.Tag;

                            LVItemsAdd(item);
                            value++;
                            parent.SetTSPBSettings(visible, value, maxValue);
                            GC.Collect();
                            break;
                        }
                    }
                }
                parent.SetTSSLblText("Готово");
                visible = false;
                value = 0;
                parent.SetTSPBSettings(visible, value, maxValue);
                parent.Update();
                parent.TekDir = dirInfo.FullName;
            }
            catch (Exception ex) { }
        }

        public void OpenSelectedTVFolder(DirectoryInfo dirInfo, TreeViewEventArgs e)
        {
            try
            {
                if (dirInfo.GetFiles() != null)
                {
                    foreach (var node in dirInfo.GetDirectories())
                    {
                        var newNode = e.Node.Nodes.Add(node.ToString());
                        newNode.Nodes.Add("");
                    }
                }
            }
            catch (Exception ex) { }
        }

        public void UseControlsSettings()
        {
            UseMainControlsSettings?.Invoke();
        }

        public ImageList GetSmallImageList()
        {
            ImageList smallImageList = new ImageList();
            smallImageList.Images.AddRange(new Image[]
                {
                    Image.FromFile("Models\\Pictures\\file.png"),
                    Image.FromFile("Models\\Pictures\\folder.png")
                });
            smallImageList.ImageSize = new Size(20, 20);

            return smallImageList;
        }

        public ImageList GetLargeImageList()
        {
            ImageList largeImageList = new ImageList();
            largeImageList.Images.AddRange(new Image[]
                {
                    Image.FromFile("Models\\Pictures\\file.png"),
                    Image.FromFile("Models\\Pictures\\folder.png")
                });
            largeImageList.ImageSize = new Size(70, 70);

            return largeImageList;
        }

        public List<TreeNode> GetTVElements()
       {
            List<TreeNode> nodes = new List<TreeNode>();

            foreach(var node in Directory.GetLogicalDrives())
            {
                TreeNode treeNode = new TreeNode(node);
                treeNode.Tag = "folder";
                treeNode.Nodes.Add("");
                nodes.Add(treeNode);
            }

            return nodes;
       }
    }
}
