namespace My_project_1
{
    partial class Result
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Result));
            this.buttonaddResult = new System.Windows.Forms.Button();
            this.buttonRemoveScore = new System.Windows.Forms.Button();
            this.buttonMangeScore = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelResult = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonaddResult
            // 
            this.buttonaddResult.BackColor = System.Drawing.Color.Purple;
            this.buttonaddResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonaddResult.FlatAppearance.BorderSize = 0;
            this.buttonaddResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonaddResult.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonaddResult.ForeColor = System.Drawing.Color.White;
            this.buttonaddResult.Location = new System.Drawing.Point(19, 205);
            this.buttonaddResult.Name = "buttonaddResult";
            this.buttonaddResult.Size = new System.Drawing.Size(139, 23);
            this.buttonaddResult.TabIndex = 0;
            this.buttonaddResult.Text = "Add Result";
            this.buttonaddResult.UseVisualStyleBackColor = false;
            this.buttonaddResult.Click += new System.EventHandler(this.buttonaddResult_Click);
            // 
            // buttonRemoveScore
            // 
            this.buttonRemoveScore.BackColor = System.Drawing.Color.Purple;
            this.buttonRemoveScore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemoveScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveScore.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveScore.ForeColor = System.Drawing.Color.White;
            this.buttonRemoveScore.Location = new System.Drawing.Point(18, 234);
            this.buttonRemoveScore.Name = "buttonRemoveScore";
            this.buttonRemoveScore.Size = new System.Drawing.Size(140, 23);
            this.buttonRemoveScore.TabIndex = 1;
            this.buttonRemoveScore.Text = "Remove Result";
            this.buttonRemoveScore.UseVisualStyleBackColor = false;
            this.buttonRemoveScore.Click += new System.EventHandler(this.buttonRemoveScore_Click);
            // 
            // buttonMangeScore
            // 
            this.buttonMangeScore.BackColor = System.Drawing.Color.Purple;
            this.buttonMangeScore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMangeScore.FlatAppearance.BorderSize = 0;
            this.buttonMangeScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMangeScore.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMangeScore.ForeColor = System.Drawing.Color.White;
            this.buttonMangeScore.Location = new System.Drawing.Point(18, 263);
            this.buttonMangeScore.Name = "buttonMangeScore";
            this.buttonMangeScore.Size = new System.Drawing.Size(140, 23);
            this.buttonMangeScore.TabIndex = 2;
            this.buttonMangeScore.Text = "Mange Result";
            this.buttonMangeScore.UseVisualStyleBackColor = false;
            this.buttonMangeScore.Click += new System.EventHandler(this.buttonMangeScore_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Purple;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(19, 294);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Avg Result By Courses";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(520, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "Result";
            // 
            // panelResult
            // 
            this.panelResult.Controls.Add(this.pictureBox2);
            this.panelResult.Location = new System.Drawing.Point(176, 46);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(832, 580);
            this.panelResult.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(480, 289);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(350, 290);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panelResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonMangeScore);
            this.Controls.Add(this.buttonRemoveScore);
            this.Controls.Add(this.buttonaddResult);
            this.Name = "Result";
            this.Size = new System.Drawing.Size(1009, 627);
            this.panelResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonaddResult;
        private System.Windows.Forms.Button buttonRemoveScore;
        private System.Windows.Forms.Button buttonMangeScore;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
