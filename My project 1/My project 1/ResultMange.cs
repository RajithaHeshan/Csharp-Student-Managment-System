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
    public partial class ResultMange : UserControl
    {
        public ResultMange()
        {
            InitializeComponent();
        }

        Result_Class result = new Result_Class();
        COURSE course = new COURSE();
        Student_Class student_class = new Student_Class();
        string data = "result";
        private void ResultMange_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = course.getAllCourses();
            comboBox1.DisplayMember = "label";
            comboBox1.ValueMember = "id";

            dataGridView1.DataSource = result.getStudentsScore();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data = "student";
            MySqlCommand cmd = new MySqlCommand("SELECT `id`, `First_Name`, `Last_Name`, `Birth_date` FROM `add_student`");
            dataGridView1.DataSource = student_class.getStudents(cmd);
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            data = "result";
            dataGridView1.DataSource = result.getStudentsScore();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            getDataFromDatagridview();
        }

        public void getDataFromDatagridview()
        {
            
            

            if(data=="student")
            {
                textBoxStudioid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }
            else if(data=="result")
            {
                textBoxStudioid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                comboBox1.SelectedValue = dataGridView1.CurrentRow.Cells[3].Value;
            }
            else
            {

            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {

                int studentId = Convert.ToInt32(textBoxStudioid.Text);
                int courseId = Convert.ToInt32(comboBox1.SelectedValue);
                double ResultValue = Convert.ToDouble(textBoxResult.Text);
                string description = textBoxDescription.Text;


                if (!result.studentScoreExists(studentId, courseId))
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int studentId = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            int courseId = int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());


            if (MessageBox.Show("Do You Want To Delete This Result", "Delete Result", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (result.deleteResult(courseId, studentId))
                {
                    MessageBox.Show("Result Deleted", "Delete Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = result.getStudentsScore();

                    textBoxStudioid.Text = "";
                    textBoxResult.Text = "";
                    textBoxDescription.Text = "";

                }
                else
                {
                    MessageBox.Show("Result Not Deleted", "Delete Result", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void buttonAvg_Click(object sender, EventArgs e)
        {

        }
    }
    }

