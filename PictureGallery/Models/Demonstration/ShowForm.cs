using PictureGallery.Models.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureGallery
{
    public partial class ShowForm : Form
    {
        MainForm parent;
        Image image;
        public ShowForm(MainForm parent, Image image, string pictureName, string path)
        {
            InitializeComponent();
            this.parent = parent;
            this.image = image;
            this.Text = pictureName;
            this.Tag = path;
            DrawPicture();
        }

        private void DrawPicture()
        {
            Bitmap picture = new Bitmap(image, PicBoxMain.Size);
            PicBoxMain.Image = picture;
        }

        private void ShowForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void ShowForm_SizeChanged(object sender, EventArgs e)
        {
            PicBoxMain.Size = this.Size;
            this.Update();
            DrawPicture();
        }

        private void ShowForm_KeyDown(object sender, KeyEventArgs e)
        {
            Settings settings = new Settings();
            if (e.KeyData == Keys.Right || e.KeyData == Keys.Up)
            {
                Close();
                settings.MoveImage(this.Tag.ToString(), true, parent);
            }
            if(e.KeyData == Keys.Left || e.KeyData == Keys.Down)
            {
                Close();
                settings.MoveImage(this.Tag.ToString(), false, parent);
            }
        }
    }
}
