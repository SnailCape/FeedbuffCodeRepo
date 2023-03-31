using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinkie_feedback_fr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FLMpanel.Hide();
            FLMpanel.BringToFront();
        }

        private void FLMpbox_Click(object sender, EventArgs e)
        {
            if (FLMpanel.Visible) {
                FLMpanel.Hide();
            }else
                FLMpanel.Show();
        }

        private void FLMpanelZUYD_Click(object sender, EventArgs e)
        {
            if (FLMpanel.Visible)
            {
                FLMpanel.Hide();
            }
            else
                FLMpanel.Show();
        }

        private void panelDA_LA_UserCourse_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
