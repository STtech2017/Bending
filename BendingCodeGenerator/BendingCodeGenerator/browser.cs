using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BendingCodeGenerator
{
    public partial class browser : Form
    {
        List<string> listFiles = new List<string>();
        protected static string fixPath = @"C:\Users\PC\Documents\bendingShape";
        public browser()
        {
            InitializeComponent();
        }


        private void browser_Load(object sender, EventArgs e)
        {
            listFiles.Clear();
            listView.Items.Clear();

            foreach (string item in Directory.GetFiles(fixPath, "*.shp"))
            {
                imageList.Images.Add(Icon.ExtractAssociatedIcon(item));
                FileInfo fileInfo = new FileInfo(item);
                listFiles.Add(fileInfo.FullName);
                listView.Items.Add(fileInfo.FullName, imageList.Images.Count - 1);
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.FocusedItem != null)
            {
                MessageBox.Show(listView.FocusedItem.ToString());
                
                //open shape in software
            }
        }
    }
}
