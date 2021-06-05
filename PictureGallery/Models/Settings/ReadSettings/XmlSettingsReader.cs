using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PictureGallery.Models.Settings.ReadSettings
{
    public class XmlSettingsReader
    {
        XmlDocument xDoc = new XmlDocument();
        MainForm parent;

        public XmlSettingsReader(MainForm parent)
        {
            this.parent = parent;
        }

        public List<Size> GetSettings()
        {
            List<Size> sizes = new List<Size>();
            xDoc.Load("Models\\Settings\\Settings.xml");
            
            XmlElement xRoot = xDoc.DocumentElement;

            foreach (XmlNode xnode in xRoot)
            {
                int width = 0;
                int height = 0;
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "width")
                    {
                        width = int.Parse(childnode.InnerText);
                    }

                    if (childnode.Name == "height")
                    {
                        height = int.Parse(childnode.InnerText);
                    }
                }
                sizes.Add(new Size(width, height));
            }

            return sizes;
        }
    }
}
