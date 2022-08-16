namespace My_project_1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonstudent = new System.Windows.Forms.Button();
            this.buttoncourse = new System.Windows.Forms.Button();
            this.buttonResult = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonstudent
            // 
            resources.ApplyResources(this.buttonstudent, "buttonstudent");
            this.buttonstudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonstudent.FlatAppearance.BorderSize = 0;
            this.buttonstudent.ForeColor = System.Drawing.Color.White;
            this.buttonstudent.Name = "buttonstudent";
            this.buttonstudent.UseVisualStyleBackColor = true;
            this.buttonstudent.Click += new System.EventHandler(this.buttonstudent_Click);
            // 
            // buttoncourse
            // 
            resources.ApplyResources(this.buttoncourse, "buttoncourse");
            this.buttoncourse.FlatAppearance.BorderSize = 0;
            this.buttoncourse.ForeColor = System.Drawing.Color.White;
            this.buttoncourse.Name = "buttoncourse";
            this.buttoncourse.UseVisualStyleBackColor = true;
            this.buttoncourse.Click += new System.EventHandler(this.buttoncourse_Click);
            // 
            // buttonResult
            // 
            resources.ApplyResources(this.buttonResult, "buttonResult");
            this.buttonResult.ForeColor = System.Drawing.Color.White;
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.buttoncourse);
            this.Controls.Add(this.buttonstudent);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonstudent;
        private System.Windows.Forms.Button buttoncourse;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}