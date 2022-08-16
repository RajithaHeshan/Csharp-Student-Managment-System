namespace My_project_1
{
    partial class Student
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            this.buttonaddstudent = new System.Windows.Forms.Button();
            this.buttonstudentlist = new System.Windows.Forms.Button();
            this.buttonStatics = new System.Windows.Forms.Button();
            this.buttoneditRemove = new System.Windows.Forms.Button();
            this.buttonprint = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonaddstudent
            // 
            this.buttonaddstudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonaddstudent.FlatAppearance.BorderSize = 0;
            this.buttonaddstudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonaddstudent.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonaddstudent.ForeColor = System.Drawing.Color.White;
            this.buttonaddstudent.Image = ((System.Drawing.Image)(resources.GetObject("buttonaddstudent.Image")));
            this.buttonaddstudent.Location = new System.Drawing.Point(23, 171);
            this.buttonaddstudent.Name = "buttonaddstudent";
            this.buttonaddstudent.Size = new System.Drawing.Size(128, 23);
            this.buttonaddstudent.TabIndex = 0;
            this.buttonaddstudent.Text = "Add New Student";
            this.buttonaddstudent.UseVisualStyleBackColor = true;
            this.buttonaddstudent.Click += new System.EventHandler(this.buttonaddstudent_Click);
            // 
            // buttonstudentlist
            // 
            this.buttonstudentlist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonstudentlist.FlatAppearance.BorderSize = 0;
            this.buttonstudentlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonstudentlist.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonstudentlist.ForeColor = System.Drawing.Color.White;
            this.buttonstudentlist.Image = ((System.Drawing.Image)(resources.GetObject("buttonstudentlist.Image")));
            this.buttonstudentlist.Location = new System.Drawing.Point(23, 205);
            this.buttonstudentlist.Name = "buttonstudentlist";
            this.buttonstudentlist.Size = new System.Drawing.Size(128, 23);
            this.buttonstudentlist.TabIndex = 1;
            this.buttonstudentlist.Text = "Student List";
            this.buttonstudentlist.UseVisualStyleBackColor = true;
            this.buttonstudentlist.Click += new System.EventHandler(this.buttonstudentlist_Click);
            // 
            // buttonStatics
            // 
            this.buttonStatics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStatics.FlatAppearance.BorderSize = 0;
            this.buttonStatics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStatics.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStatics.ForeColor = System.Drawing.Color.White;
            this.buttonStatics.Image = ((System.Drawing.Image)(resources.GetObject("buttonStatics.Image")));
            this.buttonStatics.Location = new System.Drawing.Point(23, 238);
            this.buttonStatics.Name = "buttonStatics";
            this.buttonStatics.Size = new System.Drawing.Size(128, 23);
            this.buttonStatics.TabIndex = 2;
            this.buttonStatics.Text = "Statics";
            this.buttonStatics.UseVisualStyleBackColor = true;
            this.buttonStatics.Click += new System.EventHandler(this.buttonStatics_Click);
            // 
            // buttoneditRemove
            // 
            this.buttoneditRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttoneditRemove.FlatAppearance.BorderSize = 0;
            this.buttoneditRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoneditRemove.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoneditRemove.ForeColor = System.Drawing.Color.White;
            this.buttoneditRemove.Image = ((System.Drawing.Image)(resources.GetObject("buttoneditRemove.Image")));
            this.buttoneditRemove.Location = new System.Drawing.Point(23, 273);
            this.buttoneditRemove.Name = "buttoneditRemove";
            this.buttoneditRemove.Size = new System.Drawing.Size(128, 23);
            this.buttoneditRemove.TabIndex = 3;
            this.buttoneditRemove.Text = "Edit/Remove";
            this.buttoneditRemove.UseVisualStyleBackColor = true;
            this.buttoneditRemove.Click += new System.EventHandler(this.buttoneditRemove_Click);
            // 
            // buttonprint
            // 
            this.buttonprint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonprint.FlatAppearance.BorderSize = 0;
            this.buttonprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonprint.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonprint.ForeColor = System.Drawing.Color.White;
            this.buttonprint.Image = ((System.Drawing.Image)(resources.GetObject("buttonprint.Image")));
            this.buttonprint.Location = new System.Drawing.Point(23, 306);
            this.buttonprint.Name = "buttonprint";
            this.buttonprint.Size = new System.Drawing.Size(128, 23);
            this.buttonprint.TabIndex = 5;
            this.buttonprint.Text = "Print";
            this.buttonprint.UseVisualStyleBackColor = true;
            this.buttonprint.Click += new System.EventHandler(this.buttonprint_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(177, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 580);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(479, 287);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(350, 290);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(480, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Student From";
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonprint);
            this.Controls.Add(this.buttoneditRemove);
            this.Controls.Add(this.buttonStatics);
            this.Controls.Add(this.buttonstudentlist);
            this.Controls.Add(this.buttonaddstudent);
            this.Name = "Student";
            this.Size = new System.Drawing.Size(1009, 627);
            this.Load += new System.EventHandler(this.Student_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonaddstudent;
        private System.Windows.Forms.Button buttonstudentlist;
        private System.Windows.Forms.Button buttonStatics;
        private System.Windows.Forms.Button buttoneditRemove;
        private System.Windows.Forms.Button buttonprint;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}
