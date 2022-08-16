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
    public partial class StaticForm : UserControl
    {
        public StaticForm()
        {
            InitializeComponent();
        }
      //  Color panTotalcolor;
      //  Color panMalecolor;
       // Color panFemalecolor;

        private void StaticForm_Load(object sender, EventArgs e)
        {

            Student_Class student = new Student_Class();
            double totalStudents = Convert.ToDouble(student.totalstudent());
            double totalmalestudent = Convert.ToDouble(student.totalmalestudent());
            double totalFemalestudent = Convert.ToDouble(student.totalFemalestudent());

            //count the %
            double malePercentage = totalmalestudent * 100 / totalStudents;
            double femalePercentage = totalFemalestudent * 100 / totalStudents;

            labeltotalstudent.Text =  totalStudents.ToString();
            labelMale.Text =  malePercentage.ToString("0.00") + "%";
            labelFemale.Text =  femalePercentage.ToString("0.00") + "%";

            // panTotalcolor = paneltotalstudent.BackColor;     "Female :" +
            //  panMalecolor = panelmale.BackColor;
            //  panFemalecolor = panelFemale.BackColor;

        }

        private void paneltotalstudent_MouseEnter(object sender, EventArgs e)
        {

        }

        private void paneltotalstudent_MouseLeave(object sender, EventArgs e)
        {

        }

        private void labeltotalstudent_MouseEnter(object sender, EventArgs e)
        {
          //  paneltotalstudent.BackColor = Color.White;
           // labeltotalstudent.ForeColor = panTotalcolor;

            // Display Values
       



        }

        private void labeltotalstudent_MouseLeave(object sender, EventArgs e)
        {
           // paneltotalstudent.BackColor = panTotalcolor;
           // labeltotalstudent.ForeColor = Color.White;
        }

        private void labelMale_MouseEnter(object sender, EventArgs e)
        {
           // panelmale.BackColor = Color.White;
          //  labelMale.ForeColor = panTotalcolor;
        }

        private void labelMale_MouseLeave(object sender, EventArgs e)
        {
         //   panelmale.BackColor = panTotalcolor;
          //  labelMale.ForeColor = Color.White;
        }

        private void labelFemale_MouseEnter(object sender, EventArgs e)
        {
           // panelFemale.BackColor = Color.White;
           // labelFemale.ForeColor = panTotalcolor;
        }

        private void labelFemale_MouseLeave(object sender, EventArgs e)
        {
           // panelFemale.BackColor = panTotalcolor;
           // labelFemale.ForeColor = Color.White;
        }

        private void labeltotalstudent_Click(object sender, EventArgs e)
        {

        }

        private void paneltotalstudent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelFemale_Click(object sender, EventArgs e)
        {

        }
    }
}
