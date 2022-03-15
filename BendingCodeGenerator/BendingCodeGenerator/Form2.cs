using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BendingCodeGenerator
{
    public partial class Form2 : Form
    {
        public string _shapeName, _imagePath;
        public Boolean _value1_, _value2_, _value3_, _value4_, _value5_;

        public Form2()
        {
            InitializeComponent();

            checkBox1.Text = "Disable";
            checkBox2.Text = "Disable";
            checkBox3.Text = "Disable";
            checkBox4.Text = "Disable";
            checkBox5.Text = "Disable";
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "Enable";
            }
            else
            {
                checkBox1.Text = "Disable";
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox2.Text = "Enable";
            }
            else
            {
                checkBox2.Text = "Disable";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox3.Text = "Enable";
            }
            else
            {
                checkBox3.Text = "Disable";
            }
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox4.Text = "Enable";
            }
            else
            {
                checkBox4.Text = "Disable";
            }
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                checkBox5.Text = "Enable";
            }
            else
            {
                checkBox5.Text = "Disable";
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            _shapeName = shapeName.Text;
            _imagePath = imagePath.Text;
            _value1_ = checkBox1.Checked;
            _value2_ = checkBox2.Checked;
            _value3_ = checkBox3.Checked;
            _value4_ = checkBox4.Checked;
            _value5_ = checkBox5.Checked;

            // add button to user define
            this.Close();
        }

    }
}
