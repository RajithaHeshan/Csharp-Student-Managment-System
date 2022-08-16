using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_project_1
{
    public partial class Student : UserControl
    {
        public Student()
        {
            InitializeComponent();
        }

        private void buttonaddstudent_Click(object sender, EventArgs e)
        {
            Add_New_Student b = new Add_New_Student();
            showcontrol(b);
        }
        public void showcontrol(Control control)
        {
            panel1.Controls.Clear();

            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();

            panel1.Controls.Add(control);  // conect control panel
        }

        private void buttonstudentlist_Click(object sender, EventArgs e)
        {
            StudentList_Form c = new StudentList_Form();
            showcontrol(c);
        }

        private void Student_Load(object sender, EventArgs e)
        {
            
        }

        private void buttoneditRemove_Click(object sender, EventArgs e)
        {
            Update_delet_student_Form d = new Update_delet_student_Form();
            showcontrol(d);
        }

        private void buttonStatics_Click(object sender, EventArgs e)
        {
            StaticForm stf = new StaticForm();
            showcontrol(stf);
        }

        private void buttonManage_Click(object sender, EventArgs e)
        {
           // ManageStudentsForm Ms = new ManageStudentsForm();
           // showcontrol(Ms);
        }

        private void buttonprint_Click(object sender, EventArgs e)
        {
            PrinttStudentForm PF = new PrinttStudentForm();
            showcontrol(PF);
        }
    }
}
