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
    public partial class Remove_Result : UserControl
    {
        public Remove_Result()
        {
            InitializeComponent();
        }
        Result_Class result = new Result_Class();

        private void Remove_Result_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = result.getStudentsScore();
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
            //deleteResult
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
