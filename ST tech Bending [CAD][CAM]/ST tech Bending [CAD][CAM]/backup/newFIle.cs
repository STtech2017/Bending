using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST_tech_Bending__CAD__CAM_
{
    public partial class newFile : Form
    {
        public newFile()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            //
            // check if shapeName textbox is empty than show error
            //
            if(shapeName.Text == "")
            {
                errorProvider1.SetError(errorLable, "Please Enter Name");
                errorLable.Text = "Please Enter Name";
            }
            else
            {
                errorProvider1.SetError(errorLable, "");
                errorLable.Text = "";
                //
                // create new json file for saving data
                //
                this.Close();
            }

        }

        private void cancal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
