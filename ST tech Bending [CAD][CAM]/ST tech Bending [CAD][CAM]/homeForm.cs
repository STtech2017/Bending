using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using Button = System.Windows.Forms.Button;

namespace ST_tech_Bending__CAD__CAM_
{
    public partial class homeForm : Form
    {
        //
        // create new folder in side document library for saving shape
        //
        string dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + "STtechBending Shape";
        public homeForm()
        {
            InitializeComponent(); 
        }
        private void homeForm_Load(object sender, EventArgs e)
        {
            // If directory does not exist, create it
            //MessageBox.Show(dir);            
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            else
            {
                //MessageBox.Show("Folder Found");
                shapeSel.Items.Clear();
                string[] files = Directory.GetFiles(dir, "*.json");
                //DirectoryInfo dir = new DirectoryInfo(path);
                //FileInfo[] files = dir.GetFiles("*.txt");
                shapeSel.Items.AddRange(files.Select((string filePath) => Path.GetFileNameWithoutExtension(filePath)).ToArray());
            }
            updataGrid();
            //
            // load canvas 
            //
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
            // open new form for open saved file
            //
            Form fb = new fileBrowser();
            fb.ShowDialog();
        }


        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ns = new newFile();
            ns.ShowDialog();
        }

        private void updataGrid()
        {
            splitContainer1.SplitterWidth = 10;

            dataGridView1.ColumnCount = 3;

            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;

            dataGridView1.Columns[0].Name = "Line Number";
            dataGridView1.Columns[1].Name = "Liner";
            dataGridView1.Columns[2].Name = "Angle";
            //add rows 
            ArrayList row = new ArrayList();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //
            // center point value
            //
            int xCenter = panel1.Width / 2;
            int yCenter = panel1.Height / 2;
            int xTotal = panel1.Height;
            int yTotal = panel1.Width;

            Pen blackpen = new Pen(Color.Black);
            Pen redpen = new Pen(Color.Red, 2);
            Graphics g = e.Graphics;

            g.DrawLine(redpen, xCenter, 0, xCenter, xTotal);
            g.DrawLine(redpen, 0, yCenter, yTotal, yCenter);

            g.Dispose();

            Graphics gs = panel1.CreateGraphics();

            if (shapeSel.Text == "circle" & textBox1.Text != "")
            {
                int dia = Convert.ToInt32(textBox1.Text);
                int radius = dia / 2;

                SolidBrush sb = new SolidBrush(Color.Red);
                gs.DrawEllipse(blackpen, (xCenter - radius), (yCenter - radius), dia, dia);
            }
            if (shapeSel.Text == "squre" & textBox1.Text != "")
            {
                int dia = Convert.ToInt32(textBox1.Text);
                int radius = dia / 2;

                SolidBrush sb = new SolidBrush(Color.Red);
                gs.DrawRectangle(blackpen, (xCenter - radius), (yCenter - radius), dia, dia);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //
            // generat gcode
            //
            string gcode = string.Empty;
            gcode += "hi fdbhfnofbrivndfv v ervd vncdksvc v dsropds cd\n fhuiefejkfnrjfnreifrfjnrif\n";
            //
            // save gcode in tap file
            //
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                InitialDirectory = dir,
                RestoreDirectory = true,
                CheckFileExists = false,
                CheckPathExists = true,
                Filter = "Text files (*.txt)|*.txt |TAP(*.tap)|*.tap |All files (*.*)|*.*"
            };
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                MessageBox.Show(path);
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.WriteLine(gcode);
                }
            }
            //
            // open file in notepad
            //
        }
    }
}
