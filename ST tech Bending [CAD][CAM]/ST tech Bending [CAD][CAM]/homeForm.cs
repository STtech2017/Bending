using System;
using System.Drawing;
using System.IO;
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
        string gcode = string.Empty;
        //gcode += "hi fdbhfnofbrivndfv v ervd vncdksvc v dsropds cd\n fhuiefejkfnrjfnreifrfjnrif\n";
               
        public homeForm()
        {
            InitializeComponent();
        }


        private void homeForm_Load(object sender, EventArgs e)
        {
            // If directory does not exist, create it

            // change condition with try
            try
            {
                shapeSel.SelectedIndex = 0;
            }
            catch (Exception ex)
            {

            }
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

            float dia = 0;
            float radius = 0;
            float radius1 = 0;
            float radius2 = 0;
            float length = 0;
            float length1 = 0;
            float length2 = 0;
            /*
            // Create points that define polygon.
            PointF point1 = new PointF();
            PointF point2 = new PointF();
            PointF point3 = new PointF();
            PointF point4 = new PointF();
            PointF point5 = new PointF();
            PointF point6 = new PointF();
            PointF point7 = new PointF();
            PointF point8 = new PointF();
            PointF point9 = new PointF();
            PointF point10 = new PointF();
            PointF point11 = new PointF();
            */
            Pen blackpen = new Pen(Color.Black, 2);
            Pen redpen = new Pen(Color.Red, 2);
            Graphics g = e.Graphics;
            try
            {
                g.DrawLine(redpen, xCenter, 0, xCenter, xTotal);
                g.DrawLine(redpen, 0, yCenter, yTotal, yCenter);

                g.Dispose();

                Graphics gs = panel1.CreateGraphics();
                //shapeType = shapeSel.Text;

                //MessageBox.Show(shapeSel.Text);

                switch (shapeSel.SelectedIndex)
                {
                    case 0:// window
                        radius = (float)Convert.ToDouble(textBox1.Text);//float e = (float)Convert.ToDouble(e_textBox.Text);
                        length = (float)Convert.ToDouble(textBox2.Text);
                        dia = radius * 2;

                        //draw arc

                        // draw line 1
                        gs.DrawRectangle(blackpen, (xCenter - radius),(float)(yCenter - length*0.25) , dia, length);
                        gs.DrawArc(blackpen, (xCenter - radius), (float)(yCenter - length*0.25 - radius), dia, dia, 0, -180);

                        label2.Text = "Length : " + (int)((dia * Math.PI) / 2 + (length * 2) + dia) + "mm";
                        
                         break;
                    case 1:// circle
                        radius = (float)Convert.ToDouble(textBox1.Text);
                        dia = radius * 2;

                        gs.DrawEllipse(blackpen, (xCenter - radius), (yCenter - radius), dia, dia);
                        label2.Text = "Length : " + (int)(dia * Math.PI) + "mm";
                        break;
                    case 2:// eclipse
                        radius1 = (float)Convert.ToDouble(textBox1.Text);
                        radius2 = (float)Convert.ToDouble(textBox2.Text);

                        gs.DrawEllipse(blackpen, (xCenter - radius1), (yCenter - radius2), radius1 * 2, radius2 * 2);
                        break;
                    case 3:// semicircle
                        radius = (float)Convert.ToDouble(textBox1.Text);
                        dia = radius * 2;
                        gs.DrawArc(blackpen, (xCenter - radius), (float)(yCenter - radius), dia, dia, 0, -180);
                       
                        break;
                    case 4:// r-circle
                        radius = (float)Convert.ToDouble(textBox1.Text);
                        length = (float)Convert.ToDouble(textBox2.Text);
                        dia = radius * 2;

                        gs.DrawRectangle(blackpen, (xCenter - length/2), (float)(yCenter - radius), length, dia);
                        gs.DrawArc(blackpen, (float)(xCenter - length * 0.5 - radius), (float)(yCenter - radius), dia, dia, 90, 180);
                        gs.DrawArc(blackpen, (float)(xCenter + length * 0.5 - radius), (float)(yCenter - radius), dia, dia, 90, -180);
                        break;
                    case 5:// trapezoid
                        MessageBox.Show("Comming Soon");
                        break;
                    case 6:// triangle
                        length = (float)Convert.ToDouble(textBox1.Text);

                        var shape = new PointF[3];

                        //Create 6 points
                        for (int a = 0; a < 3; a++)
                        {
                            shape[a] = new PointF(
                                xCenter + length * (float)Math.Cos(a * 120 * Math.PI / 180f),
                                yCenter + length * (float)Math.Sin(a * 120 * Math.PI / 180f));
                        }

                        gs.DrawPolygon(Pens.Red, shape);

                        break;
                    case 7:// squre
                        length1 = (float)Convert.ToDouble(textBox1.Text);
                        length2 = (float)Convert.ToDouble(textBox2.Text);
                        gs.DrawRectangle(blackpen, (xCenter - length1 / 2), (yCenter - length2 / 2), length1, length2);
                        break;
                    case 8:// pentagon  

                        length = (float)Convert.ToDouble(textBox1.Text);

                        shape = new PointF[5];

                        //Create 6 points
                        for (int a = 0; a < 5; a++)
                        {
                            shape[a] = new PointF(
                                xCenter + length * (float)Math.Cos(a * 72 * Math.PI / 180f),
                                yCenter + length * (float)Math.Sin(a * 72 * Math.PI / 180f));
                        }

                        gs.DrawPolygon(Pens.Red, shape);

                        break;
                    case 9:// hexago
                        length = (float)Convert.ToDouble(textBox1.Text);

                        shape = new PointF[6];

                        //Create 6 points
                        for (int a = 0; a < 6; a++)
                        {
                            shape[a] = new PointF(
                                xCenter + length * (float)Math.Cos(a * 60 * Math.PI / 180f),
                                yCenter + length * (float)Math.Sin(a * 60 * Math.PI / 180f));
                        }

                        gs.DrawPolygon(Pens.Red, shape);

                        break;
                    case 10:// l-octagon
                        length = (float)Convert.ToDouble(textBox1.Text);

                        shape = new PointF[8];

                        //Create 6 points
                        for (int a = 0; a < 8; a++)
                        {
                            shape[a] = new PointF(
                                xCenter + length * (float)Math.Cos(a * 45 * Math.PI / 180f),
                                yCenter + length * (float)Math.Sin(a * 45 * Math.PI / 180f));
                        }

                        gs.DrawPolygon(Pens.Red, shape);

                        break;
                    case 11:// l-decagon

                        length = (float)Convert.ToDouble(textBox1.Text);

                        shape = new PointF[10];

                        //Create 6 points
                        for (int a = 0; a < 10; a++)
                        {
                            shape[a] = new PointF(
                                xCenter + length * (float)Math.Cos(a * 36 * Math.PI / 180f),
                                yCenter + length * (float)Math.Sin(a * 36 * Math.PI / 180f));
                        }

                        gs.DrawPolygon(Pens.Red, shape);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void draw_Click(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void shapeSel_TextChanged(object sender, EventArgs e)
        {
            label3.Visible = true;
            textBox1.Visible = true;
            label4.Visible = true;
            textBox2.Visible = true;
            label5.Visible = true;
            textBox3.Visible = true;
            label10.Visible = true;
            textBox8.Visible = true;
            label11.Visible = true;
            textBox9.Visible = true;

            int shape = shapeSel.SelectedIndex;
            switch (shape)
            {
                case 0://1
                    label3.Text = "RADIUS";
                    label4.Text = "LENGTH";
                    label5.Text = "RADIUS ANGEL";
                    label10.Visible = false;
                    textBox8.Visible = false;
                    label11.Visible = false;
                    textBox9.Visible = false;
                    break;
                case 1://2
                    //MessageBox.Show(shapeSel.Text);
                    label3.Text = "RADIUS";
                    label4.Text = "RADIUS ANGEL";
                    label5.Visible = false;
                    textBox3.Visible = false;
                    label10.Visible = false;
                    textBox8.Visible = false;
                    label11.Visible = false;
                    textBox9.Visible = false;
                    // find Circumfernce of circle
                    // C = 2 X PI X r | PI X D
                    /*
                     * Gcode
                     * start from here
                     * G18 G40 G49 G90 G94 G80
                     * ; set angel for X
                     * G1 X[angel] F500
                     * G1 Z[Circumfernce] F800
                     * G1 X0 F500
                     * M2
                     * M30
                     */
                    break;
                case 2://3
                    label3.Text = "RADIUS 1";
                    label4.Text = "RADIUS 2";
                    label5.Text = "RADIUS 1 ANGEL 1";
                    label10.Text = "RADIUS 2 ANGEL 2";
                    label11.Visible = false;
                    textBox9.Visible = false;
                    // find Circumfernce of circle
                    /*
                     * Gcode
                     * start from here
                     * G18 G40 G49 G90 G94 G80
                     * ; set angel for X
                     * G1 X[angel1]  F500
                     * G1 X[angel2] Z[Circumfernce * 1/4] F800
                     * G1 X[angel1] Z[Circumfernce * 2/4] F800
                     * G1 X[angel2] Z[Circumfernce * 3/4] F800
                     * G1 X[angel1] Z[Circumfernce * 4/4] F800
                     * G1 X0 F500
                     * M2
                     * M30
                     */
                    break;
                case 3://4:
                    label3.Text = "RADIUS";
                    label4.Text = "RADIUS ANGEL";
                    label5.Visible = false;
                    textBox3.Visible = false;
                    label10.Visible = false;
                    textBox8.Visible = false;
                    label11.Visible = false;
                    textBox9.Visible = false;
                    // find Circumfernce of circle
                    // C = 2 X PI X r | PI X D
                    /*
                     * Gcode
                     * start from here
                     * G18 G40 G49 G90 G94 G80
                     * ; set angel for X
                     * G1 X[angel] F500
                     * G1 Z[Circumfernce * 1/2] F800
                     * G1 X0 F500
                     * M2
                     * M30
                     */
                    break;
                case 4://
                    label3.Text = "RADIUS";
                    label4.Text = "LENGTH";
                    label5.Text = "RADIUS ANGEL";
                    label10.Visible = false;
                    textBox8.Visible = false;
                    // find total length of R-circle
                    // Total Length = (2rPI) + (2 * side)
                    /*
                     * Gcode 
                     * start form here
                     * G18 G40 G49 G90 G94 G80
                     * G1 Z[SIDE/2] F800
                     * G1 X[ANGEL] F500
                     * G1 Z[MOVE] F800
                     * ; ADD SHOCK FOR STRAIT
                     * G1 X[0] F500 
                     * G1 Z[SIDE] F800
                     * G1 X[ANGEL] F500
                     * G1 Z[MOVE] F800
                     * G1 X[0] F500
                     * G1 Z[SIDE/2] F500
                     * ; ADD SHOCK FOR STRAIT
                     * M2
                     * M30
                     */
                    break;
                case 5://6
                    label3.Text = "RADIUS";
                    label5.Text = "RADIUS ANGEL";
                    label5.Visible = false;
                    textBox3.Visible = false;
                    label10.Visible = false;
                    textBox8.Visible = false;
                    label11.Visible = false;
                    textBox9.Visible = false;
                    break;
                case 6://7
                    label3.Text = "LENGTH";
                    label4.Visible = false;
                    textBox2.Visible = false;
                    label5.Visible = false;
                    textBox3.Visible = false;
                    label10.Visible = false;
                    textBox8.Visible = false;
                    label11.Visible = false;
                    textBox9.Visible = false;
                    // find Total Length of Triangle
                    // Toltal Length = side * 3
                    // reduies movement for fix size = Die_radius * PI * 2 / 3
                    /*
                     * Gcode
                     * start from here
                     * G18 G40 G49 G90 G94 G80
                     * ; set angel for X
                     * G1 Z[MOVE] F800
                     * G1 X[angel] F500
                     * G1 X0 F500
                     * G1 Z[MOVE] F800
                     * G1 X[angel] F500
                     * G1 X0 F500
                     * G1 Z[MOVE] F800
                     * G1 X[angel] F500
                     * G1 X0 F500
                     * G1 Z[MOVE] F800
                     * M2
                     * M30
                     */
                    break;
                case 7://8
                    label3.Text = "LENGTH 1";
                    label4.Text = "LENGTH 2";
                    label5.Visible = false;
                    textBox3.Visible = false;
                    label10.Visible = false;
                    textBox8.Visible = false;
                    label11.Visible = false;
                    textBox9.Visible = false;
                    // find Total Length of Squre  
                    // Toltal Length = side * 4
                    // reduies movement for fix size = Die_radius * PI * 2 / 4
                    /*
                     * Gcode
                     * start from here
                     * G18 G40 G49 G90 G94 G80
                     * ; set angel for X
                     * G1 Z[MOVE] F800
                     * G1 X[angel] F500
                     * G1 X0 F500
                     * G1 Z[MOVE] F800
                     * G1 X[angel] F500
                     * G1 X0 F500
                     * G1 Z[MOVE] F800
                     * G1 X[angel] F500
                     * G1 X0 F500
                     * G1 Z[MOVE] F800
                     * G1 X[angel] F500
                     * G1 X0 F500
                     * G1 Z[MOVE] F800
                     * M2
                     * M30
                     */
                    break;
                case 8://9
                    label3.Text = "LENGTH";
                    label4.Visible = false;
                    textBox2.Visible = false;
                    label5.Visible = false;
                    textBox3.Visible = false;
                    label10.Visible = false;
                    textBox8.Visible = false;
                    label11.Visible = false;
                    textBox9.Visible = false;
                    // find Total Length of Squre  
                    // Toltal Length = side * 5
                    // reduies movement for fix size = Die_radius * PI * 2 / 5
                    /*
                     * Gcode
                     * start from here
                     * G18 G40 G49 G90 G94 G80
                     * ; set angel for X
                     * G1 Z[MOVE] F800
                     * G1 X[angel] F500
                     * G1 X0 F500
                     * G1 Z[MOVE] F800
                     * G1 X[angel] F500
                     * G1 X0 F500
                     * G1 Z[MOVE] F800
                     * G1 X[angel] F500
                     * G1 X0 F500
                     * G1 Z[MOVE] F800
                     * G1 X[angel] F500
                     * G1 X0 F500
                     * G1 Z[MOVE] F800
                     * G1 X[angel] F500
                     * G1 X0 F500
                     * G1 Z[MOVE] F800
                     * M2
                     * M30
                     */
                    break;
                case 9://10
                    label3.Text = "LENGTH";
                    label4.Visible = false;
                    textBox2.Visible = false;
                    label5.Visible = false;
                    textBox3.Visible = false;
                    label10.Visible = false;
                    textBox8.Visible = false;
                    label11.Visible = false;
                    textBox9.Visible = false;
                    // find Total Length of Squre  
                    // Toltal Length = side * 6
                    // reduies movement for fix size = Die_radius * PI * 2 / 6
                    /*
                     * Gcode
                     * start from here
                     * G18 G40 G49 G90 G94 G80
                     * ; set angel for X
                     * G1 Z[MOVE] F800
                     * G1 X[angel] F500
                     * G1 X0 F500
                     * G1 Z[MOVE] F800
                     * G1 X[angel] F500
                     * G1 X0 F500
                     * G1 Z[MOVE] F800
                     * G1 X[angel] F500
                     * G1 X0 F500
                     * G1 Z[MOVE] F800
                     * G1 X[angel] F500
                     * G1 X0 F500
                     * G1 Z[MOVE] F800
                     * G1 X[angel] F500
                     * G1 X0 F500
                     * G1 Z[MOVE] F800
                     * G1 X[angel] F500
                     * G1 X0 F500
                     * G1 Z[MOVE] F800
                     * M2
                     * M30
                     */
                    break;
                case 10://11
                    label3.Text = "LENGTH 1";
                    label4.Visible = false;
                    textBox2.Visible = false;
                    label5.Visible = false;
                    textBox3.Visible = false;
                    label10.Visible = false;
                    textBox8.Visible = false;
                    label11.Visible = false;
                    textBox9.Visible = false;
                    // find Total Length of Squre  
                    // Toltal Length = side * 6
                    // reduies movement for fix size = Die_radius * PI * 2 / 6
                    /*
                     * Gcode
                     * start from here
                     * G18 G40 G49 G90 G94 G80
                     * ; set angel for X
                     * G1 Z[MOVE] F800
                     * G1 X[angel] F500
                     * G1 X0 F500
                     * G1 Z[MOVE] F800
                     * G1 X[angel] F500
                     * G1 X0 F500
                     * G1 Z[MOVE] F800
                     * G1 X[angel] F500
                     * G1 X0 F500
                     * G1 Z[MOVE] F800
                     * G1 X[angel] F500
                     * G1 X0 F500
                     * G1 Z[MOVE] F800
                     * G1 X[angel] F500
                     * G1 X0 F500
                     * G1 Z[MOVE] F800
                     * G1 X[angel] F500
                     * G1 X0 F500
                     * G1 Z[MOVE] F800
                     * M2
                     * M30
                     */
                    break;
                case 11://12
                    label3.Text = "LENGTH 1";
                    label4.Visible = false;
                    textBox2.Visible = false;
                    label5.Visible = false;
                    textBox3.Visible = false;
                    label10.Visible = false;
                    textBox8.Visible = false;
                    label11.Visible = false;
                    textBox9.Visible = false;
                    // find Total Length of Squre  
                    // Toltal Length = side * 8
                    // reduies movement for fix size = Die_radius * PI * 2 / 8
                    /*
                     * Gcode
                     * start from here
                     * G18 G40 G49 G90 G94 G80
                     * ; set angel for X
                     * G1 Z[MOVE] F800
                     * G1 X[angel] F500
                     * G1 X0 F500
                     * G1 Z[MOVE] F800
                     * G1 X[angel] F500
                     * G1 X0 F500
                     * G1 Z[MOVE] F800
                     * G1 X[angel] F500
                     * G1 X0 F500
                     * G1 Z[MOVE] F800
                     * G1 X[angel] F500
                     * G1 X0 F500
                     * G1 Z[MOVE] F800
                     * G1 X[angel] F500
                     * G1 X0 F500
                     * G1 Z[MOVE] F800
                     * G1 X[angel] F500
                     * G1 X0 F500
                     * G1 Z[MOVE] F800
                     * G1 X[angel] F500
                     * G1 X0 F500
                     * G1 Z[MOVE] F800
                     * G1 X[angel] F500
                     * G1 X0 F500
                     * G1 Z[MOVE] F800
                     * M2
                     * M30
                     */
                    break;
                case 12://13
                    label3.Text = "LENGTH 1";
                    //label4.Text = "LENGTH 2";
                    label4.Visible = false;
                    textBox2.Visible = false;
                    label5.Visible = false;
                    textBox3.Visible = false;
                    label10.Visible = false;
                    textBox8.Visible = false;
                    label11.Visible = false;
                    textBox9.Visible = false;
                    // find Total Length of Squre  
                    // Toltal Length = side * 10
                    // reduies movement for fix size = Die_radius * PI * 2 / 10
                    /*
                     * Gcode
                     * start from here
                     * G18 G40 G49 G90 G94 G80
                     * ; set angel for X
                     * G1 Z[MOVE] F800
                     * G1 X[angel] F500
                     * G1 X0 F500
                     * G1 Z[MOVE] F800
                     * G1 X[angel] F500
                     * G1 X0 F500
                     * G1 Z[MOVE] F800
                     * G1 X[angel] F500
                     * G1 X0 F500
                     * G1 Z[MOVE] F800
                     * G1 X[angel] F500
                     * G1 X0 F500
                     * G1 Z[MOVE] F800
                     * G1 X[angel] F500
                     * G1 X0 F500
                     * G1 Z[MOVE] F800
                     * G1 X[angel] F500
                     * G1 X0 F500
                     * G1 Z[MOVE] F800
                     * G1 X[angel] F500
                     * G1 X0 F500
                     * G1 Z[MOVE] F800
                     * G1 X[angel] F500
                     * G1 X0 F500
                     * G1 Z[MOVE] F800
                     * G1 X[angel] F500
                     * G1 X0 F500
                     * G1 Z[MOVE] F800
                     * G1 X[angel] F500
                     * G1 X0 F500
                     * G1 Z[MOVE] F800
                     * M2
                     * M30
                     */
                    break;
                default:
                    break;
            }
        }

        private void Save_click(object sender, EventArgs e)
        {
            double angel = new double();
            double angel_2 = new double();
            double move_value = new double();
            double value_1 = new double();
            double value_2 = new double();
            double value_3 = new double();
            double value_4 = new double();
            double value_5 = new double();
            double value_6 = new double();
            double value_7 = new double();
            double value_8 = new double();
            double value_9 = new double();
            try
            {
                if (textBox1.TextLength > 0)
                {
                     value_1 = Convert.ToDouble(textBox1.Text);
                }
                if (textBox2.TextLength > 0)
                {
                     value_2 = Convert.ToDouble(textBox2.Text);
                }
                if (textBox3.TextLength > 0)
                {
                     value_3 = Convert.ToDouble(textBox3.Text);
                }
                if (textBox4.TextLength > 0)
                {
                     value_4 = Convert.ToDouble(textBox4.Text);
                }
                {
                    value_5 = 0;
                }
                if (textBox5.TextLength > 0)
                {
                    value_5 = Convert.ToDouble(textBox5.Text);
                }
                else
                {
                    value_5 = 0;
                }
                if (textBox6.TextLength > 0)
                {
                    value_6 = Convert.ToDouble(textBox6.Text);
                }
                else
                {
                    value_6 = 500;
                }
                if (textBox7.TextLength > 0)
                {
                    value_7 = Convert.ToDouble(textBox7.Text);
                }
                else
                {
                    value_7 = 300;
                }
                if (textBox8.TextLength > 0)
                {
                    value_8 = Convert.ToDouble(textBox8.Text);
                }
                else
                {
                    value_8 = 0;
                }
                if (textBox9.TextLength > 0)
                {
                    value_9 = Convert.ToDouble(textBox9.Text);
                }
                else
                {
                    value_9 = 0;
                }

                switch (shapeSel.SelectedIndex)
                {
                    case 0://window
                        gcode = "G18 G40 G49 G90 G94 G80 \n";
                        angel = (90 + value_5);
                        angel_2 = value_3;
                        //first move
                        move_value = value_1;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "G1 X" + angel + " F" + value_7 + "\n";
                        gcode += "G1 X0 " + value_6 + "\n";
                        // second move
                        move_value += value_2 + value_4;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "G1 X" + angel + " F" + value_7 + "\n";
                        gcode += "G1 X0 " + value_6 + "\n";
                        // third move
                        move_value += (double)(value_1 * Math.PI * 2);
                        gcode += "G1 X" + angel + " F" + value_7 + "\n";
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "G1 X0 " + value_6 + "\n";
                        // fourth move
                        move_value += value_2 + value_4;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "G1 X" + angel + " F" + value_7 + "\n";
                        gcode += "G1 X0 " + value_6 + "\n";
                        // last move
                        move_value += value_1 / 2;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "M2\nM30\n";
                        break;
                    case 1://round
                        angel = value_2;

                        gcode = "G18 G40 G49 G90 G94 G80 \n";
                        move_value = 0;
                        move_value = (double)(value_1 * Math.PI * 2);
                        gcode += "G1 X" + angel + " F" + value_7 + "\n";
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "G1 X0 " + value_6 + "\n";
                        gcode += "M2\nM30\n";
                        break;
                    case 2://elipce
                        var angel1 = value_3;
                        var angel2 = value_8;

                        // calulation
                        move_value = 0;
                        move_value = (double)(Math.PI * ((3 * (value_1 + value_2)) - Math.Sqrt((3 * value_1 + value_2) * (3 * value_2 + value_1))));

                        gcode = "G18 G40 G49 G90 G94 G80 \n";
                        gcode += "G1 X" + angel1 + "F" + value_6 + "\n";
                        gcode += "G1 X" + angel1 + " Z" + (move_value / 4) + " F" + value_6 + "\n";
                        gcode += "G1 X" + angel2 + " Z" + (move_value / 2) + " F" + value_6 + "\n";
                        gcode += "G1 X" + angel1 + " Z" + (move_value * 3/4) + " F" + value_6 + "\n";
                        gcode += "G1 X" + angel2 + " Z" + (move_value) + " F" + value_6 + "\n";
                        gcode += "M2\nM30\n"; 
                        break;
                    case 3://semicircle
                        angel = value_2;

                        gcode = "G18 G40 G49 G90 G94 G80 \n";
                        move_value = 0;
                        move_value = ((value_1 * Math.PI * 2)/2);
                        gcode += "G1 X" + angel + " F" + value_7 + "\n";
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "G1 X0 " + value_6 + "\n";
                        gcode += "M2\nM30\n";
                        break;
                    case 4://r-circle
                        angel = value_3;
                       
                        gcode = "G18 G40 G49 G90 G94 G80 \n";

                        move_value = 0;
                        move_value = value_2 / 2;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";

                        move_value += ((value_1 * Math.PI * 2) / 2) + value_4;
                        gcode += "G1 X" + angel + " F" + value_7 + "\n";
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "G1 X0 " + value_6 + "\n";

                        move_value = value_2 + value_9;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";

                        move_value += ((value_1 * Math.PI * 2) / 2) + value_4;
                        gcode += "G1 X" + angel + " F" + value_7 + "\n";
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "G1 X0 " + value_6 + "\n";

                        move_value = value_2 / 2;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "M2\nM30\n";
                        break;
                    case 5:// triangle
                        /* 
                         * save gcode
                         * create txt file and save 
                        */
                        angel = (120 + value_5);

                        gcode = "G18 G40 G49 G90 G94 G80 \n";
                        move_value = 0;
                        move_value = value_1 / 2;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "G1 X" + angel + " F" + value_7 + "\n";
                        gcode += "G1 X0 " + value_6 + "\n";

                        move_value += value_1 + value_4;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "G1 X" + angel + " F" + value_7 + "\n";
                        gcode += "G1 X0 " + value_6 + "\n";

                        move_value += value_1 + value_4;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "G1 X" + angel + " F" + value_7 + "\n";
                        gcode += "G1 X0 " + value_6 + "\n";

                        move_value += value_1 / 2;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "M2\nM30\n";
                        break;
                    case 6:// triangle
                        /* 
                         * save gcode
                         * create txt file and save 
                        */
                        angel = (120 + value_5);
                        
                        gcode = "G18 G40 G49 G90 G94 G80 \n";
                        move_value = 0;
                        move_value = value_1 / 2;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "G1 X" + angel + " F" + value_7 + "\n";
                        gcode += "G1 X0 " + value_6 + "\n";

                        move_value += value_1 + value_4;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "G1 X" + angel + " F" + value_7 + "\n";
                        gcode += "G1 X0 " + value_6 + "\n";

                        move_value += value_1 + value_4;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "G1 X" + angel + " F" + value_7 + "\n";
                        gcode += "G1 X0 " + value_6 + "\n";

                        move_value += value_1 / 2;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "M2\nM30\n";

                        break;
                    case 7:// squre
                        angel = (90 + value_5);
                        gcode = "G18 G40 G49 G90 G94 G80 \n";
                        //first move
                        move_value = value_1 / 2;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "G1 X" + angel + " F" + value_7 + "\n";
                        gcode += "G1 X0 " + value_6 + "\n";
                        // second move
                        move_value += value_2 + value_4;
                        gcode += "G1 Z" + move_value  + " F" + value_6 + "\n";
                        gcode += "G1 X" + angel + " F" + value_7 + "\n";
                        gcode += "G1 X0 " + value_6 + "\n";
                        // third move
                        move_value += value_1 + value_4;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "G1 X" + angel + " F" + value_7 + "\n";
                        gcode += "G1 X0 " + value_6 + "\n";
                        // fourth move
                        move_value += value_2 + value_4;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "G1 X" + angel + " F" + value_7 + "\n";
                        gcode += "G1 X0 " + value_6 + "\n";
                        // last move
                        move_value += value_1 / 2;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "M2\nM30\n";
                        break;
                    case 8:// pentagon

                        angel = (72 + value_5);
                        gcode = "G18 G40 G49 G90 G94 G80 \n";
                        //first move
                        move_value = 0;
                        move_value = value_1 / 2;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "G1 X" + angel + " F" + value_7 + "\n";
                        gcode += "G1 X0 " + value_6 + "\n";
                        // second move
                        move_value += value_1 + value_4;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "G1 X" + angel + " F" + value_7 + "\n";
                        gcode += "G1 X0 " + value_6 + "\n";
                        // third move
                        move_value += value_1 + value_4;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "G1 X" + angel + " F" + value_7 + "\n";
                        gcode += "G1 X0 " + value_6 + "\n";
                        // fourth move
                        move_value += value_1 + value_4;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n"; 
                        gcode += "G1 X" + angel + " F" + value_7 + "\n";
                        gcode += "G1 X0 " + value_6 + "\n";
                        // fifth move
                        move_value += value_1 + value_4;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "G1 X" + angel + " F" + value_7 + "\n";
                        gcode += "G1 X0 " + value_6 + "\n";
                        // last move
                        move_value += value_1 / 2;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "M2\nM30\n";
                        break;
                    case 9:// hexagone
                        angel = (60 + value_5);
                        gcode = "G18 G40 G49 G90 G94 G80 \n";
                        move_value = 0;
                        //first move
                        move_value = value_1 / 2;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "G1 X" + angel + " F" + value_7 + "\n";
                        gcode += "G1 X0 " + value_6 + "\n";
                        // second move
                        move_value += value_1 + value_4;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "G1 X" + angel + " F" + value_7 + "\n";
                        gcode += "G1 X0 " + value_6 + "\n";
                        // third move
                        move_value += value_1 + value_4;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "G1 X" + angel + " F" + value_7 + "\n";
                        gcode += "G1 X0 " + value_6 + "\n";
                        // fourth move
                        move_value += value_1 + value_4;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "G1 X" + angel + " F" + value_7 + "\n";
                        gcode += "G1 X0 " + value_6 + "\n";
                        // fifth move
                        move_value += value_1 + value_4;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "G1 X" + angel + " F" + value_7 + "\n";
                        gcode += "G1 X0 " + value_6 + "\n";
                        // sixth move
                        move_value += value_1 + value_4;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "G1 X" + angel + " F" + value_7 + "\n";
                        gcode += "G1 X0 " + value_6 + "\n";
                        // last move
                        move_value += value_1 / 2;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "M2\nM30\n";
                        break;
                    case 10:// octagone

                        angel = (45 + value_5);
                        gcode = "G18 G40 G49 G90 G94 G80 \n";
                        move_value = 0;
                        //first move
                        move_value += value_1 / 2;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "G1 X" + angel + " F" + value_7 + "\n";
                        gcode += "G1 X0 " + value_6 + "\n";
                        // second move
                        move_value += value_1 + value_4;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "G1 X" + angel + " F" + value_7 + "\n";
                        gcode += "G1 X0 " + value_6 + "\n";
                        // third move
                        move_value += value_1 + value_4;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "G1 X" + angel + " F" + value_7 + "\n";
                        gcode += "G1 X0 " + value_6 + "\n";
                        // fourth move
                        move_value += value_1 + value_4;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "G1 X" + angel + " F" + value_7 + "\n";
                        gcode += "G1 X0 " + value_6 + "\n";
                        // fifth move
                        move_value += value_1 + value_4;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "G1 X" + angel + " F" + value_7 + "\n";
                        gcode += "G1 X0 " + value_6 + "\n";
                        // sixth move
                        move_value += value_1 + value_4;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "G1 X" + angel + " F" + value_7 + "\n";
                        gcode += "G1 X0 " + value_6 + "\n";
                        // seventh move
                        move_value += value_1 + value_4;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "G1 X" + angel + " F" + value_7 + "\n";
                        gcode += "G1 X0 " + value_6 + "\n";
                        // eighth move
                        move_value += value_1 + value_4;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "G1 X" + angel + " F" + value_7 + "\n";
                        gcode += "G1 X0 " + value_6 + "\n";
                        // last move
                        move_value += value_1 / 2;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "M2\nM30\n";
                        break;
                    case 11:// decagone
                        angel = (36 + value_5);
                        gcode = "G18 G40 G49 G90 G94 G80 \n";
                        move_value = 0;
                        //first move
                        move_value += value_1 / 2;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "G1 X" + angel + " F" + value_7 + "\n";
                        gcode += "G1 X0 " + value_6 + "\n";
                        // second move
                        move_value += value_1 + value_4;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "G1 X" + angel + " F" + value_7 + "\n";
                        gcode += "G1 X0 " + value_6 + "\n";
                        // third move
                        move_value += value_1 + value_4;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "G1 X" + angel + " F" + value_7 + "\n";
                        gcode += "G1 X0 " + value_6 + "\n";
                        // fourth move
                        move_value += value_1 + value_4;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "G1 X" + angel + " F" + value_7 + "\n";
                        gcode += "G1 X0 " + value_6 + "\n";
                        // fifth move
                        move_value += value_1 + value_4;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "G1 X" + angel + " F" + value_7 + "\n";
                        gcode += "G1 X0 " + value_6 + "\n";
                        // sixth move
                        move_value += value_1 + value_4;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "G1 X" + angel + " F" + value_7 + "\n";
                        gcode += "G1 X0 " + value_6 + "\n";
                        // seventh move
                        move_value += value_1 + value_4;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "G1 X" + angel + " F" + value_7 + "\n";
                        gcode += "G1 X0 " + value_6 + "\n";
                        // eighth move
                        move_value += value_1 + value_4;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "G1 X" + angel + " F" + value_7 + "\n";
                        gcode += "G1 X0 " + value_6 + "\n";
                        // nineth move
                        move_value += value_1 + value_4;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "G1 X" + angel + " F" + value_7 + "\n";
                        gcode += "G1 X0 " + value_6 + "\n";
                        // tenth move
                        move_value += value_1 + value_4;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "G1 X" + angel + " F" + value_7 + "\n";
                        gcode += "G1 X0 " + value_6 + "\n";
                        // last move
                        move_value += value_1 / 2;
                        gcode += "G1 Z" + move_value + " F" + value_6 + "\n";
                        gcode += "M2\nM30\n";
                        break;

                    default:
                        break;
                }

                //
                // generat gcode
                //
                //
                // save gcode in tap file
                //
                SaveFileDialog saveFileDialog1 = new SaveFileDialog
                {
                    RestoreDirectory = true,
                    CheckFileExists = false,
                    CheckPathExists = true,
                    Filter = "TAP(*.tap)|*.tap"
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
            }
            catch (Exception ex)
            {

            }
        }
    }
}
