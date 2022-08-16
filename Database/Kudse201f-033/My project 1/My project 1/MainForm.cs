using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_project_1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        public void showcontrol(Control control)
        {
            panel1.Controls.Clear();

            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();

            panel1.Controls.Add(control);
        }

        private void buttonstudent_Click(object sender, EventArgs e)
        {
            Student a = new Student();
            showcontrol(a);

        }

        private void buttoncourse_Click(object sender, EventArgs e)
        {
            CourseForm cf = new CourseForm();
            showcontrol(cf);
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            Result Rt = new Result();
            showcontrol(Rt);
        }
    }
}
