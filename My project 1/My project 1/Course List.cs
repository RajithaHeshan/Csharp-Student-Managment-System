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
    public partial class Remove_Course : UserControl
    {
        public Remove_Course()
        {
            InitializeComponent();
        }
        COURSE course = new COURSE();
        Class1 mydb = new Class1();
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int courseId = Convert.ToInt32(textBoxCourseid.Text);



                if (MessageBox.Show("Are You Sure You Want To Remove This Course", "Delete Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (course.deleteCourse(courseId))
                    {
                        MessageBox.Show("Course Deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MySqlCommand cmd = new MySqlCommand();
                        cmd.Connection = mydb.getConnection;
                        cmd.CommandText = ("SELECT * FROM `course` ");


                        MySqlDataAdapter adpter = new MySqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adpter.Fill(table);
                        dataGridView1.DataSource = table;

                    }
                    else
                    {
                        MessageBox.Show("Course Not Deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }


            }

            catch
            {
                MessageBox.Show("Enter A Valid Numeric ID ", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                ///textBoxCourseid.Text = "";
            }
        }

        private void Remove_Course_Load(object sender, EventArgs e)
        {

             
        
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = mydb.getConnection;
            cmd.CommandText = ("SELECT * FROM `course` ");


            MySqlDataAdapter adpter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adpter.Fill(table);
            dataGridView1.DataSource = table;
           



        }
    }
}
