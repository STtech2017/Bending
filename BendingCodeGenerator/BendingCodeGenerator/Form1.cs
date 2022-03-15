using System.Runtime.InteropServices;
using Newtonsoft.Json;

namespace BendingCodeGenerator
{
    public partial class Form1 : Form
    {
        /**
         * Unit used for mm , inch value
         */
        Boolean MeasurementUnit = true;

        private string shapeName, imagePath;
        private Boolean _value1, _value2, _value3, _value4, _value5;
        private string showing;

        // maths value 
        const double pi = 3.14;
        double unit_multipler;
        double value1, value2, value3, value4, value5;
        // doing maths 
        double length;
        int shape = 0;

        Form2 frm2 = new Form2();

        // pre define shape
        RectangleF circle = new RectangleF(100, 100, 200, 200);
        Rectangle squre = new Rectangle(100, 100, 200, 300);
        Rectangle polygon = new Rectangle(100, 100, 200, 300);

        SaveFileDialog saveFileDialog = new SaveFileDialog();

        //---------------------------------------------------------------------------------------------------
        //
        // saving user data TODO
        
        public Form1()
        {
            InitializeComponent();
            MaximizeBox = false;

            MeasurementUnit_check();
            addToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.U;
            addToolStripMenuItem.ShortcutKeyDisplayString = "ctrl + U";

            // set default circle selection
            //circleToolStripMenuItem.Checked = true;
            _shapeName_.Text = "Circle";
            LL1.Visible = true;
            LL2.Visible = false;
            LL3.Visible = false;
            LL4.Visible = false;
            LL5.Visible = false;

            textBox1.Visible = true;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;

            unit2.Visible = true;
            unit2.Visible = false;
            unit3.Visible = false;
            unit4.Visible = false;
            unit5.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // load user define shape
            GetTodoItems();

        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (!(char.IsWhiteSpace(e.KeyChar)) && !(char.IsControl(e.KeyChar)) && !(char.IsNumber(e.KeyChar))))
            {
                errorProvider1.SetError(label2, "Only Numeric Value!");
                label2.Text = "Only Numeric Value!";
            }
            else
            {
                if (textBox1.Text == null) { textBox1.Text = ""; }
                errorProvider1.SetError(label2, "");
                label2.Text = "";
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (!(char.IsWhiteSpace(e.KeyChar)) && !(char.IsControl(e.KeyChar)) && !(char.IsNumber(e.KeyChar))))
            {
                errorProvider1.SetError(label2, "Only Numeric Value!");
                label2.Text = "Only Numeric Value!";
            }
            else
            {
                if (textBox2.Text == null) { textBox2.Text = ""; }
                errorProvider1.SetError(label2, "");
                label2.Text = "";
            }
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (!(char.IsWhiteSpace(e.KeyChar)) && !(char.IsControl(e.KeyChar)) && !(char.IsNumber(e.KeyChar))))
            {
                errorProvider1.SetError(label2, "Only Numeric Value!");
                label2.Text = "Only Numeric Value!";
            }
            else
            {
                if (textBox3.Text == null) { textBox3.Text = ""; }
                errorProvider1.SetError(label2, "");
                label2.Text = "";
            }
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (!(char.IsWhiteSpace(e.KeyChar)) && !(char.IsControl(e.KeyChar)) && !(char.IsNumber(e.KeyChar))))
            {
                errorProvider1.SetError(label2, "Only Numeric Value!");
                label2.Text = "Only Numeric Value!";
            }
            else
            {
                if (textBox4.Text == null) { textBox4.Text = ""; }
                errorProvider1.SetError(label2, "");
                label2.Text = "";
            }
        }
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (!(char.IsWhiteSpace(e.KeyChar)) && !(char.IsControl(e.KeyChar)) && !(char.IsNumber(e.KeyChar))))
            {
                errorProvider1.SetError(label2, "Only Numeric Value!");
                label2.Text = "Only Numeric Value!";
            }
            else
            {
                if (textBox5.Text == null) { textBox5.Text = ""; }
                errorProvider1.SetError(label2, "");
                label2.Text = "";
            }
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (circleToolStripMenuItem.Checked)
            //{
            //    squerToolStripMenuItem.Checked = false;
            //    rectangleToolStripMenuItem.Checked = false;
            //    hexagonalToolStripMenuItem.Checked = false;
            //    circleSlotToolStripMenuItem.Checked = false;
            _shapeName_.Text = "Circle";
            shape = 0;

                //load image from folder
                pictureBox1.Image = Properties.Resources.circle;

                LL1.Text = "Radius";

                LL1.Visible = true;
                LL2.Visible = false;
                LL3.Visible = false;
                LL4.Visible = false;
                LL5.Visible = false;

                textBox1.Visible = true;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;

                unit2.Visible = true;
                unit2.Visible = false;
                unit3.Visible = false;
                unit4.Visible = false;
                unit5.Visible = false;
            //}
        }
        private void squerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (squerToolStripMenuItem.Checked)
            //{
            //    circleToolStripMenuItem.Checked = false;
            //    rectangleToolStripMenuItem.Checked = false;
            //    hexagonalToolStripMenuItem.Checked = false;
            //    circleSlotToolStripMenuItem.Checked = false;
            _shapeName_.Text = "Squre";
            shape = 1;

                //load image from folder
                pictureBox1.Image = Properties.Resources.squre;

                LL1.Text = "Length";

                LL1.Visible = true;
                LL2.Visible = false;
                LL3.Visible = false;
                LL4.Visible = false;
                LL5.Visible = false;

                textBox1.Visible = true;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;

                unit2.Visible = true;
                unit2.Visible = false;
                unit3.Visible = false;
                unit4.Visible = false;
                unit5.Visible = false;
            //}
        }
        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (rectangleToolStripMenuItem.Checked)
            //{
            //    squerToolStripMenuItem.Checked = false;
            //    circleToolStripMenuItem.Checked = false;
            //    hexagonalToolStripMenuItem.Checked = false;
            //    circleSlotToolStripMenuItem.Checked = false;
            _shapeName_.Text = "Rectangle";
            shape = 2;

                //load image from folder
                pictureBox1.Image = Properties.Resources.rectangle1;

                LL1.Text = "Length";
                LL2.Text = "Width";

                LL1.Visible = true;
                LL2.Visible = true;
                LL3.Visible = false;
                LL4.Visible = false;
                LL5.Visible = false;

                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;

                unit2.Visible = true;
                unit2.Visible = true;
                unit3.Visible = false;
                unit4.Visible = false;
                unit5.Visible = false;
            //}
        }
        private void hexagonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (hexagonalToolStripMenuItem.Checked)
            //{
            //    squerToolStripMenuItem.Checked = false;
            //    rectangleToolStripMenuItem.Checked = false;
            //    circleToolStripMenuItem.Checked = false;
            //    circleSlotToolStripMenuItem.Checked = false;
            _shapeName_.Text = "Hexagonal";
            shape = 3;

                //load image from folder
                pictureBox1.Image = Properties.Resources.hexagonal;

                LL1.Text = "Length";

                LL1.Visible = true;
                LL2.Visible = false;
                LL3.Visible = false;
                LL4.Visible = false;
                LL5.Visible = false;

                textBox1.Visible = true;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;

                unit2.Visible = true;
                unit2.Visible = false;
                unit3.Visible = false;
                unit4.Visible = false;
                unit5.Visible = false;
            //}
        }
        private void circleSlotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (circleSlotToolStripMenuItem.Checked)
            //{
            //    squerToolStripMenuItem.Checked = false;
            //    rectangleToolStripMenuItem.Checked = false;
            //    hexagonalToolStripMenuItem.Checked = false;
            //    circleToolStripMenuItem.Checked = false;
            _shapeName_.Text = "Eclips";
            shape = 4;

                //load image from folder
                pictureBox1.Image = Properties.Resources.slot;

                LL1.Text = "Radius";
                LL2.Text = "Width";

                LL1.Visible = true;
                LL2.Visible = true;
                LL3.Visible = false;
                LL4.Visible = false;
                LL5.Visible = false;

                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;

                unit2.Visible = true;
                unit2.Visible = true;
                unit3.Visible = false;
                unit4.Visible = false;
                unit5.Visible = false;
            //}
        }


        // unit selection for gcode
        private void MeasurementUnit_check()
        {
            if (MeasurementUnit)
            {
                metricToolStripMenuItem.Checked = true;
            }
            else
            {
                inchToolStripMenuItem.Checked = true;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form browser = new browser();
            browser.ShowDialog();
        }

        private void metricToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MeasurementUnit = true;
            units.Text = "mm";
            changeUnit();
            inchToolStripMenuItem.Checked = !metricToolStripMenuItem.Checked;
        }

        private void inchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MeasurementUnit = false;
            units.Text = "in";
            changeUnit();
            metricToolStripMenuItem.Checked = !inchToolStripMenuItem.Checked;
        }

        // saving text from rich tect box to tap or txt file for mach3 gcode
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "TAP(*.tap)|*.tap |TXT(*.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void changeUnit()
        {
            unit1.Text = units.Text;
            unit2.Text = units.Text;
            unit3.Text = units.Text;
            unit4.Text = units.Text;
            unit5.Text = units.Text;
        }

        private void quitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form about_us = new AboutBox1();
            about_us.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String firstLine = new String("(\nThis Software made by roboendure\nthis software is not for sale\nno one can collect money for this software without permition of roboendure company\n'https://roboendure.com'\n" +
                        "gcode generated for mach3 bending machine\nmade by suzan natural tech pvt ltd\n'https://suzantech.com')\n");

            // draw cuicul in pictureBox
            //radiusvalue.Text = value1.ToString();
            switch (shape)
            {
                case 0:
                    value1 = Convert.ToInt64(this.textBox1.Text);
                    length = 2 * (pi * value1);
                    //richTextBox1.Text = "(\nThis Software made by Roboendure\nThis Software is not for sale\nNo one can collect money for this software without permition of Roboendure Company\n'https://roboendure.com'\n" +
                    //    "Gcode Generated for mach3 bending machine\nMade by suzan natural tech pvt ltd\n'https://suzantech.com')\n"
                    //    + length.ToString() + "\n)";
                    //label5.Text = length.ToString();
                    break;
                case 1:
                    value1 = Convert.ToInt64(this.textBox1.Text);
                    length = 4 * value1;
                    //richTextBox1.Text = "(\nThis Software made by Roboendure\nThis Software is not for sale\nNo one can collect money for this software without permition of Roboendure Company\n'https://roboendure.com'\n" +
                    //    "Gcode Generated for mach3 bending machine\nMade by suzan natural tech pvt ltd\n'https://suzantech.com')\n"
                    //    + length.ToString() + "\n)";
                    //label5.Text = length.ToString();
                    break;
                case 2:
                    value1 = Convert.ToInt64(this.textBox1.Text);
                    value2 = Convert.ToInt64(this.textBox2.Text);
                    length = ((2 * value1) + (2 * value2));
                    //richTextBox1.Text = "(\nThis Software made by Roboendure\nThis Software is not for sale\nNo one can collect money for this software without permition of Roboendure Company\n'https://roboendure.com'\n" +
                    //    "Gcode Generated for mach3 bending machine\nMade by suzan natural tech pvt ltd\n'https://suzantech.com')\n"
                    //    + length.ToString() + "\n)";
                    //label5.Text = length.ToString();
                    break;
                case 3:
                    value1 = Convert.ToInt64(this.textBox1.Text);
                    length = (6 * value1);
                    //richTextBox1.Text = "(\nThis Software made by Roboendure\nThis Software is not for sale\nNo one can collect money for this software without permition of Roboendure Company\n'https://roboendure.com'\n" +
                    //    "Gcode Generated for mach3 bending machine\nMade by suzan natural tech pvt ltd\n'https://suzantech.com')\n"
                    //    + length.ToString() + "\n)";
                    //label5.Text = length.ToString();
                    break;
                case 4:
                    value1 = Convert.ToInt64(this.textBox1.Text);
                    value2 = Convert.ToInt64(this.textBox2.Text);
                    length = ((2 * pi * value1) + (2 * value2));
                    //richTextBox1.Text = "(\nThis Software made by Roboendure\nThis Software is not for sale\nNo one can collect money for this software without permition of Roboendure Company\n'https://roboendure.com'\n" +
                    //    "Gcode Generated for mach3 bending machine\nMade by suzan natural tech pvt ltd\n'https://suzantech.com')\n"
                    //    + length.ToString() + "\n)";
                    //label5.Text = length.ToString();
                    break;
            }
            richTextBox1.Text = firstLine + length.ToString() + "\n)";

            label5.Text = length.ToString();

        }
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frm2.ShowDialog();
            // Application.OpenForms(Form2);
            //this.Close();
            //add button to shape.
            shapeName = frm2._shapeName;
            imagePath = frm2._imagePath;
            _value1 = frm2._value1_;
            _value2 = frm2._value2_;
            _value3 = frm2._value3_;
            _value4 = frm2._value4_;
            _value5 = frm2._value5_;

            showing = "shape name : " + shapeName + "\n" + "image path : " + imagePath + "\n" + "value 1 : " + _value1 + "\n" + "value 2 : " + _value2 + "\n" + "value 3 : " + _value3 + "\n" + "value 4 : " + _value4 + "\n" + "value 5 : " + _value5 + "\n";
            MessageBox.Show(showing);

            //add shape button to shape menu Strip
            shapeToolStripMenuItem.DropDownItems.Add(shapeName);

            //ToolStripDropDownItem.ToolStripItemAccessibleObject = shapeToolStripMenuItem;
            // save data for another time
            //File.AppendAllText("shape.json", showing);
        
        }
        List<datamodel> m;
        string _imagepath;
        private void GetTodoItems()
        {
            string path = @"C:\Users\PC\Documents\bendingShape\shape.json";
            StreamReader r = new StreamReader(path);

            string jsonString = r.ReadToEnd();
            m = JsonConvert.DeserializeObject<List<datamodel>>(jsonString);

            foreach (var items in m)
            {
                ToolStripMenuItem item = new ToolStripMenuItem(items._shapeName);
                _imagepath = @"C:\Users\PC\Documents\bendingShape\image\" +  items._imagePath;

                item.Tag = items._shapeId;

                //add shape button to shape menu Strip
                shapeToolStripMenuItem.DropDownItems.Add(item);

                item.Click += new EventHandler(Item_Click);
            }
        }


        private void Item_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            //MessageBox.Show(item.Text + " " + item.Tag);
            _shapeName_.Text = item.Text;

            pictureBox1.Load(_imagepath);
        }

        public class datamodel
        {
            public string _shapeName { get; set; }
            public string _imagePath { get; set; }
            public Boolean _value1 { get; set; }
            public Boolean _value2 { get; set; }
            public Boolean _value3 { get; set; }
            public Boolean _value4 { get; set; }
            public Boolean _value5 { get; set; }
            public int _shapeId { get; set; }
        }

    }
}
