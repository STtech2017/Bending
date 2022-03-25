using Newtonsoft.Json;
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
using TextBox = System.Windows.Forms.TextBox;
using Label = System.Windows.Forms.Label;

namespace ST_tech_Bending__CAD__CAM_
{
    public partial class homeForm : Form
    {
        //
        // create new folder in side document library for saving shape
        //
        protected string dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + "STtechBending Shape";
        protected string codeDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + "STtechBending Shape\\code";
        string shapeType = string.Empty;
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
                Directory.CreateDirectory(codeDir);
            }
            else
            {
                shapeSel.Items.Clear();
                string[] files = Directory.GetFiles(dir, "*.json");
                //DirectoryInfo dir = new DirectoryInfo(path);
                //FileInfo[] files = dir.GetFiles("*.txt");
                shapeSel.Items.AddRange(files.Select((string filePath) => Path.GetFileNameWithoutExtension(filePath)).ToArray());
            }
            updataGrid();
            shapeSel.SelectedIndex = 0;
            shapeSel.DropDownStyle = ComboBoxStyle.DropDownList;
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

            //
            // draw shape 
            //
            int i = 0;
            string[] message = new string[32];
            int dia = 0;
            int radius = 0;
            int radius2 = 0;
            int length = 0;

            switch (shapeType)
            {
                case "circle":
                    foreach (TextBox textBox in panel3.Controls.OfType<TextBox>())
                    {
                        message[i] = textBox.Text;
                        //MessageBox.Show(message[i]);
                        i++;
                    }
                    dia = Convert.ToInt32(message[0].ToString());
                    radius = dia / 2;

                    gs.DrawEllipse(blackpen, (xCenter - radius), (yCenter - radius), dia, dia);
                    break;

                case "squre":
                    foreach (TextBox textBox in panel3.Controls.OfType<TextBox>())
                    {
                        message[i] = textBox.Text;
                        //MessageBox.Show(message[i]);
                        i++;
                    }
                    length = Convert.ToInt32(message[0].ToString());

                    gs.DrawRectangle(blackpen, (xCenter - length / 2), (yCenter - length / 2), length, length);
                    break;

                case "eclips":
                    foreach (TextBox textBox in panel3.Controls.OfType<TextBox>())
                    {
                        message[i] = textBox.Text;
                        //MessageBox.Show(message[i]);
                        i++;
                    }
                    radius = Convert.ToInt32(message[0].ToString());
                    radius2 = Convert.ToInt32(message[1].ToString());

                    gs.DrawEllipse(blackpen, (xCenter - radius), (yCenter - radius2), radius*2, radius2*2);
                    break;
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
                InitialDirectory = codeDir,
                RestoreDirectory = true,
                CheckFileExists = false,
                CheckPathExists = true,
                Filter = "Text files (*.txt)|*.txt |TAP(*.tap)|*.tap |All files (*.*)|*.*"
            };
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                //MessageBox.Show(path);
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.WriteLine(gcode);
                }
            }
            //
            // open file in notepad
            //
        }

        private void load_Click(object sender, EventArgs e)
        {
            //
            // remove pervius loaded object
            //
            panel3.Controls.Clear();
            int drawButtonPoint = 0;
            //List<ShapeView> shapeViews = new List<ShapeView>();
            //
            // read json file selected and show desing according
            //
            string jsonString = string.Empty;
            using (StreamReader sr = new StreamReader(dir + "\\" + shapeSel.Text + ".json"))
            {
                jsonString = sr.ReadToEnd();
                //MessageBox.Show(jsonString);
                sr.Close();
            }
            //shapeViews = JsonConvert.DeserializeObject<List<ShapeView>>(jsonString);
            ShapeView shapeViews = JsonConvert.DeserializeObject<ShapeView>(jsonString);

            shapeType = shapeViews.shapeType;
            //
            // adding label to tabpage1 according to json file
            //
            string[] labelText = new string[32];
            for (int i = 0; i < shapeViews.labelCount; i++)
            {
                labelText[i] = shapeViews.labels[i].labelText;
                Label label = new Label();
                label.Location = new Point(10, (25 * (i+1)));
                label.Size = new Size(80, 20);
                label.Name = "label_" + (i + 1);
                label.Text = labelText[i];
                panel3.Controls.Add(label);
            }
            //
            // adding textBox to tabpage1 according to json file
            //
            string[] textBoxName = new string[32];
            for (int i = 0; i < shapeViews.textBoxCount; i++)
            {
                textBoxName[i] = shapeViews.textBoxs[i].textBoxName;
                TextBox textbox = new TextBox();
                textbox.Location = new Point(95, (25 * (i + 1)));
                textbox.Size = new Size(80, 20);
                textbox.Name = "txt_" + (i + 1);
                panel3.Controls.Add(textbox);
                drawButtonPoint = 25 * i;
            }

            //Create the dynamic Button to draw item in panel1
            Button button = new Button();
            button.Location = new System.Drawing.Point(95, drawButtonPoint + 50);
            button.Size = new System.Drawing.Size(60, 20);
            button.Name = "btnDraw_" + 2;
            button.Text = "Draw";
            button.Click += new System.EventHandler(btnDraw_Click);
            panel3.Controls.Add(button);
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            //
            // update drawing
            //
            panel1.Invalidate();
        }
    }
}
