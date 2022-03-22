namespace ST_tech_Bending__CAD__CAM_
{
    partial class newFile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lable1 = new System.Windows.Forms.Label();
            this.shapeName = new System.Windows.Forms.TextBox();
            this.ok = new System.Windows.Forms.Button();
            this.cancal = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorLable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.Location = new System.Drawing.Point(6, 26);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(169, 20);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "New Shape Name :";
            // 
            // shapeName
            // 
            this.shapeName.Location = new System.Drawing.Point(181, 26);
            this.shapeName.Name = "shapeName";
            this.shapeName.Size = new System.Drawing.Size(239, 22);
            this.shapeName.TabIndex = 1;
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(12, 86);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(175, 30);
            this.ok.TabIndex = 2;
            this.ok.Text = "Ok";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // cancal
            // 
            this.cancal.Location = new System.Drawing.Point(245, 86);
            this.cancal.Name = "cancal";
            this.cancal.Size = new System.Drawing.Size(175, 30);
            this.cancal.TabIndex = 3;
            this.cancal.Text = "Cancal";
            this.cancal.UseVisualStyleBackColor = true;
            this.cancal.Click += new System.EventHandler(this.cancal_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorLable
            // 
            this.errorLable.AutoSize = true;
            this.errorLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLable.Location = new System.Drawing.Point(215, 51);
            this.errorLable.Name = "errorLable";
            this.errorLable.Size = new System.Drawing.Size(0, 20);
            this.errorLable.TabIndex = 4;
            // 
            // newFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 128);
            this.Controls.Add(this.errorLable);
            this.Controls.Add(this.cancal);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.shapeName);
            this.Controls.Add(this.lable1);
            this.Name = "newFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter New Shape Name";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.TextBox shapeName;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button cancal;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label errorLable;
    }
}