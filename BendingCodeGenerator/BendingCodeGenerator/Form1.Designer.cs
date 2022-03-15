namespace BendingCodeGenerator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LL1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.radiusValue = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metricToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.squerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hexagonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circleSlotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userDefineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radiusDisplay = new System.Windows.Forms.Label();
            this.units = new System.Windows.Forms.Label();
            this.unit1 = new System.Windows.Forms.Label();
            this.unit2 = new System.Windows.Forms.Label();
            this.LL2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.unit3 = new System.Windows.Forms.Label();
            this.LL3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.unit4 = new System.Windows.Forms.Label();
            this.LL4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.unit5 = new System.Windows.Forms.Label();
            this.LL5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this._shapeName_ = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.CausesValidation = false;
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox1.Location = new System.Drawing.Point(91, 82);
            this.textBox1.MaxLength = 999999999;
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "0";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // LL1
            // 
            this.LL1.AutoSize = true;
            this.LL1.Location = new System.Drawing.Point(18, 86);
            this.LL1.Name = "LL1";
            this.LL1.Size = new System.Drawing.Size(53, 20);
            this.LL1.TabIndex = 1;
            this.LL1.Text = "Radius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 2;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // radiusValue
            // 
            this.radiusValue.AutoSize = true;
            this.radiusValue.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.radiusValue.ForeColor = System.Drawing.Color.White;
            this.radiusValue.Location = new System.Drawing.Point(596, 68);
            this.radiusValue.Name = "radiusValue";
            this.radiusValue.Size = new System.Drawing.Size(0, 20);
            this.radiusValue.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox1.Image = global::BendingCodeGenerator.Properties.Resources.circle;
            this.pictureBox1.Location = new System.Drawing.Point(350, 37);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(750, 750);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(400, 400);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(580, 580);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 557);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "profile length";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 557);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "0";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(12, 664);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBox1.Size = new System.Drawing.Size(918, 237);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 583);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "GCode";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.shapeToolStripMenuItem,
            this.userDefineToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(942, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.quitToolStripMenuItem,
            this.quitToolStripMenuItem1,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.metricToolStripMenuItem,
            this.inchToolStripMenuItem});
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quitToolStripMenuItem.Text = "Unit";
            // 
            // metricToolStripMenuItem
            // 
            this.metricToolStripMenuItem.CheckOnClick = true;
            this.metricToolStripMenuItem.Name = "metricToolStripMenuItem";
            this.metricToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.metricToolStripMenuItem.Text = "Metric";
            this.metricToolStripMenuItem.Click += new System.EventHandler(this.metricToolStripMenuItem_Click);
            // 
            // inchToolStripMenuItem
            // 
            this.inchToolStripMenuItem.CheckOnClick = true;
            this.inchToolStripMenuItem.Name = "inchToolStripMenuItem";
            this.inchToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.inchToolStripMenuItem.Text = "Inch";
            this.inchToolStripMenuItem.Click += new System.EventHandler(this.inchToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem1
            // 
            this.quitToolStripMenuItem1.Name = "quitToolStripMenuItem1";
            this.quitToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.quitToolStripMenuItem1.Text = "Quit";
            this.quitToolStripMenuItem1.Click += new System.EventHandler(this.quitToolStripMenuItem1_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // shapeToolStripMenuItem
            // 
            this.shapeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.circleToolStripMenuItem,
            this.squerToolStripMenuItem,
            this.rectangleToolStripMenuItem,
            this.hexagonalToolStripMenuItem,
            this.circleSlotToolStripMenuItem});
            this.shapeToolStripMenuItem.Name = "shapeToolStripMenuItem";
            this.shapeToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.shapeToolStripMenuItem.Text = "Shape";
            // 
            // circleToolStripMenuItem
            // 
            this.circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            this.circleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.circleToolStripMenuItem.Text = "Circle";
            this.circleToolStripMenuItem.Click += new System.EventHandler(this.circleToolStripMenuItem_Click);
            // 
            // squerToolStripMenuItem
            // 
            this.squerToolStripMenuItem.Name = "squerToolStripMenuItem";
            this.squerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.squerToolStripMenuItem.Text = "Squer";
            this.squerToolStripMenuItem.Click += new System.EventHandler(this.squerToolStripMenuItem_Click);
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.rectangleToolStripMenuItem.Text = "Rectangle";
            this.rectangleToolStripMenuItem.Click += new System.EventHandler(this.rectangleToolStripMenuItem_Click);
            // 
            // hexagonalToolStripMenuItem
            // 
            this.hexagonalToolStripMenuItem.Name = "hexagonalToolStripMenuItem";
            this.hexagonalToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hexagonalToolStripMenuItem.Text = "Hexagonal";
            this.hexagonalToolStripMenuItem.Click += new System.EventHandler(this.hexagonalToolStripMenuItem_Click);
            // 
            // circleSlotToolStripMenuItem
            // 
            this.circleSlotToolStripMenuItem.Name = "circleSlotToolStripMenuItem";
            this.circleSlotToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.circleSlotToolStripMenuItem.Text = "Circle Slot";
            this.circleSlotToolStripMenuItem.Click += new System.EventHandler(this.circleSlotToolStripMenuItem_Click);
            // 
            // userDefineToolStripMenuItem
            // 
            this.userDefineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.userDefineToolStripMenuItem.Name = "userDefineToolStripMenuItem";
            this.userDefineToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.userDefineToolStripMenuItem.Text = "User Define";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.aboutUsToolStripMenuItem.Text = "About us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // radiusDisplay
            // 
            this.radiusDisplay.AutoSize = true;
            this.radiusDisplay.BackColor = System.Drawing.SystemColors.InfoText;
            this.radiusDisplay.ForeColor = System.Drawing.Color.White;
            this.radiusDisplay.Location = new System.Drawing.Point(537, 68);
            this.radiusDisplay.Name = "radiusDisplay";
            this.radiusDisplay.Size = new System.Drawing.Size(0, 20);
            this.radiusDisplay.TabIndex = 11;
            // 
            // units
            // 
            this.units.AutoSize = true;
            this.units.Location = new System.Drawing.Point(252, 557);
            this.units.Name = "units";
            this.units.Size = new System.Drawing.Size(35, 20);
            this.units.TabIndex = 12;
            this.units.Text = "mm";
            // 
            // unit1
            // 
            this.unit1.AutoSize = true;
            this.unit1.Location = new System.Drawing.Point(246, 85);
            this.unit1.Name = "unit1";
            this.unit1.Size = new System.Drawing.Size(35, 20);
            this.unit1.TabIndex = 13;
            this.unit1.Text = "mm";
            // 
            // unit2
            // 
            this.unit2.AutoSize = true;
            this.unit2.Location = new System.Drawing.Point(246, 115);
            this.unit2.Name = "unit2";
            this.unit2.Size = new System.Drawing.Size(35, 20);
            this.unit2.TabIndex = 16;
            this.unit2.Text = "mm";
            // 
            // LL2
            // 
            this.LL2.AutoSize = true;
            this.LL2.Location = new System.Drawing.Point(18, 116);
            this.LL2.Name = "LL2";
            this.LL2.Size = new System.Drawing.Size(0, 20);
            this.LL2.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(91, 112);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "0";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 14;
            this.textBox2.Text = "0";
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // unit3
            // 
            this.unit3.AutoSize = true;
            this.unit3.Location = new System.Drawing.Point(246, 148);
            this.unit3.Name = "unit3";
            this.unit3.Size = new System.Drawing.Size(35, 20);
            this.unit3.TabIndex = 19;
            this.unit3.Text = "mm";
            // 
            // LL3
            // 
            this.LL3.AutoSize = true;
            this.LL3.Location = new System.Drawing.Point(18, 149);
            this.LL3.Name = "LL3";
            this.LL3.Size = new System.Drawing.Size(0, 20);
            this.LL3.TabIndex = 18;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(91, 145);
            this.textBox3.Name = "textBox3";
            this.textBox3.PlaceholderText = "0";
            this.textBox3.Size = new System.Drawing.Size(125, 27);
            this.textBox3.TabIndex = 17;
            this.textBox3.Text = "0";
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // unit4
            // 
            this.unit4.AutoSize = true;
            this.unit4.Location = new System.Drawing.Point(246, 181);
            this.unit4.Name = "unit4";
            this.unit4.Size = new System.Drawing.Size(35, 20);
            this.unit4.TabIndex = 22;
            this.unit4.Text = "mm";
            // 
            // LL4
            // 
            this.LL4.AutoSize = true;
            this.LL4.Location = new System.Drawing.Point(18, 182);
            this.LL4.Name = "LL4";
            this.LL4.Size = new System.Drawing.Size(0, 20);
            this.LL4.TabIndex = 21;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(91, 178);
            this.textBox4.Name = "textBox4";
            this.textBox4.PlaceholderText = "0";
            this.textBox4.Size = new System.Drawing.Size(125, 27);
            this.textBox4.TabIndex = 20;
            this.textBox4.Text = "0";
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // unit5
            // 
            this.unit5.AutoSize = true;
            this.unit5.Location = new System.Drawing.Point(246, 214);
            this.unit5.Name = "unit5";
            this.unit5.Size = new System.Drawing.Size(35, 20);
            this.unit5.TabIndex = 25;
            this.unit5.Text = "mm";
            // 
            // LL5
            // 
            this.LL5.AutoSize = true;
            this.LL5.Location = new System.Drawing.Point(18, 215);
            this.LL5.Name = "LL5";
            this.LL5.Size = new System.Drawing.Size(0, 20);
            this.LL5.TabIndex = 24;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(91, 211);
            this.textBox5.Name = "textBox5";
            this.textBox5.PlaceholderText = "0";
            this.textBox5.Size = new System.Drawing.Size(125, 27);
            this.textBox5.TabIndex = 23;
            this.textBox5.Text = "0";
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(326, 68);
            this.button1.TabIndex = 26;
            this.button1.Text = "Generat Gcode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _shapeName_
            // 
            this._shapeName_.AutoSize = true;
            this._shapeName_.Location = new System.Drawing.Point(126, 37);
            this._shapeName_.Name = "_shapeName_";
            this._shapeName_.Size = new System.Drawing.Size(44, 20);
            this._shapeName_.TabIndex = 28;
            this._shapeName_.Text = "circle";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(942, 913);
            this.Controls.Add(this._shapeName_);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.unit5);
            this.Controls.Add(this.LL5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.unit4);
            this.Controls.Add(this.LL4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.unit3);
            this.Controls.Add(this.LL3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.unit2);
            this.Controls.Add(this.LL2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.unit1);
            this.Controls.Add(this.units);
            this.Controls.Add(this.radiusDisplay);
            this.Controls.Add(this.radiusValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LL1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Bending Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Label LL1;
        private Label label2;
        private ErrorProvider errorProvider1;
        private Label radiusValue;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label4;
        private Label label6;
        protected RichTextBox richTextBox1;
        private SaveFileDialog saveFileDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem shapeToolStripMenuItem;
        private ToolStripMenuItem circleToolStripMenuItem;
        private ToolStripMenuItem squerToolStripMenuItem;
        private ToolStripMenuItem rectangleToolStripMenuItem;
        private ToolStripMenuItem hexagonalToolStripMenuItem;
        private ToolStripMenuItem circleSlotToolStripMenuItem;
        private ToolStripMenuItem userDefineToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutUsToolStripMenuItem;
        private Label radiusDisplay;
        private Label units;
        private Label unit1;
        private ToolStripMenuItem metricToolStripMenuItem;
        private ToolStripMenuItem inchToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem1;
        private Label unit5;
        private Label LL5;
        private TextBox textBox5;
        private Label unit4;
        private Label LL4;
        private TextBox textBox4;
        private Label unit3;
        private Label LL3;
        private TextBox textBox3;
        private Label unit2;
        private Label LL2;
        private TextBox textBox2;
        public Button button1;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private Label _shapeName_;
    }
}