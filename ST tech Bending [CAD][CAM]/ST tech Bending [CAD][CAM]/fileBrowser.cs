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

namespace ST_tech_Bending__CAD__CAM_
{
    public partial class fileBrowser : Form
    {
        protected string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +"\\" + "STtechBending Shape";

        public fileBrowser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                
                InitialDirectory = path,
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = "shape files (*.json)|*.json"
            };
            openFileDialog1.ShowDialog();
        }

        private void fileBrowser_Load(object sender, EventArgs e)
        {
            List<string> listFiles = new List<string>();

            listFiles.Clear();
            listView1.Items.Clear();

            foreach (string item in Directory.GetFiles(path, "*.json"))
            {
                imageList1.Images.Add(Icon.ExtractAssociatedIcon(item));
                FileInfo fileInfo = new FileInfo(item);
                listFiles.Add(fileInfo.FullName);
                listView1.Items.Add(fileInfo.FullName, imageList1.Images.Count - 1);
            }
        }
    }
}
