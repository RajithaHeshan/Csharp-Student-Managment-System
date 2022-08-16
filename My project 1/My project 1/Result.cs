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
    public partial class Result : UserControl
    {
        public Result()
        {
            InitializeComponent();
        }
        public void showcontrol(Control control)
        {
            panelResult.Controls.Clear();

            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();

            panelResult.Controls.Add(control);
        }
        private void buttonaddResult_Click(object sender, EventArgs e)
        {
            Add_Result AR = new Add_Result();
            showcontrol(AR);
        }

        private void buttonRemoveScore_Click(object sender, EventArgs e)
        {
            Remove_Result RRS = new Remove_Result();
            showcontrol(RRS);     }

        private void buttonMangeScore_Click(object sender, EventArgs e)
        {
            ResultMange RM = new ResultMange();
            showcontrol(RM);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Avg avg = new Avg();
            showcontrol(avg);
        }
    }
}
