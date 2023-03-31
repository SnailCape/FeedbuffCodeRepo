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


        private void PanelLogin_LLB_PasswordFOR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Specify that the link was visited.
            PanelLogin_LLB_PasswordFOR.LinkVisited = true;

            // Navigate to a URL.
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=xvFZjo5PgG0");
        }

        private void PanelLogin_BT_Login_Click(object sender, EventArgs e)
        {
            string message = @"Invalid Email or Password." + Environment.NewLine + "Check if your password and email are correct!" + Environment.NewLine + Environment.NewLine + "Please try again";

            string title = "Invalid Credentials";

            if (PanelLogin_TB_Email.Text == "Test@zuyd.nl" && PanelLogin_TB_Password.Text == "Test123")
            {
                Login_Panel.Visible = false;
                PanelLogin_TB_Email.Text = "";
                PanelLogin_TB_Password.Text = "";
            }
            else
            {
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
