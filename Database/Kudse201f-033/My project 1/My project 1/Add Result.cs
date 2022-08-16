using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace My_project_1
{
    public partial class Add_Result : UserControl
    {
        public Add_Result()
        {
            InitializeComponent();
        }

        Result_Class result = new Result_Class();
        COURSE course = new COURSE();
        Student_Class student_class = new Student_Class();
        private void Add_Result_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = course.getAllCourses();
            comboBox1.DisplayMember = "label";
            comboBox1.ValueMember = "id";



            MySqlCommand cmd = new MySqlCommand("SELECT `id`,`First_Name`,`Last_Name` FROM `add_student`");
            dataGridView1.DataSource = student_class.getStudents(cmd);
            
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBoxStudioid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void buttonAddResult_Click(object sender, EventArgs e)
        {
            try
            {

                int studentId = Convert.ToInt32(textBoxStudioid.Text);
                int courseId = Convert.ToInt32(comboBox1.SelectedValue);
                double ResultValue= Convert.ToDouble(textBoxResult.Text);
                string description = textBoxDescription.Text;


                if(!result.studentScoreExists(studentId,courseId))
                {
                    if (result.insertResult(studentId, courseId, ResultValue, description))
                    {
                        MessageBox.Show("Student Result Inserted ", "Add Result", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    else
                    {
                        MessageBox.Show("Student Result Not Inserted ", "Add Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("The Score for this course Are Already set", "Add Result", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
