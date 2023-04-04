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
        public bool Check = false;
        public Popup_FORM_WeeklyGoals PopUpBox;

        public Form1()
        {
            InitializeComponent();


        }

        /// <summary>
        /// On startup: Brings login panel to front (so its the first thing you see) and brings FLM panel to front (so it doesn't get prevented from popping up when needed)
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            Login_Panel.BringToFront();
            FLMpanel.Hide();
            FLMpanel.BringToFront();
            PanelWG_PA_WeeklyGoalsBackground.Hide();
        }
       
        /// <summary>
        /// FLM panel to be shown when the button is pressed
        /// </summary>
        private void FLMpbox_Click(object sender, EventArgs e)
        {
            if (FLMpanel.Visible) 
            {
                FLMpanel.Hide();
            }
            else
                FLMpanel.Show();
        }

        /// <summary>
        /// Allows the FLM button to be hidden when the button is pressed
        /// </summary>
        private void FLMpanelZUYD_Click(object sender, EventArgs e)
        {
            if (FLMpanel.Visible)
            {
                FLMpanel.Hide();
            }
            else
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
                PanelLogin_TB_Password.Text = "";
            }
        }

        /// <summary>
        /// Hides the other panels and "logs" the user "out"
        /// </summary>
        private void PanelFLM_BT_LogoutButton_Click(object sender, EventArgs e)
        {
            Login_Panel.Show();
            FLMpanel.Hide();
        }

        private void PanelDA_LA_UserCourse_Click(object sender, EventArgs e)
        {
            
        }
        
        /// <summary>
        /// Adds the date and time to the labels (currently at scoreboard)
        /// </summary>
        private void DigitalClockTimer_Tick(object sender, EventArgs e)
        {
            this.PanelDA_LA_ScoreboardTime.Text = DateTime.Now.ToString("HH:mm");
            this.PanelDA_LA_ScoreboardDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }


        private void PanelFLM_BT_DashboardButton_Click(object sender, EventArgs e)
        {
            PanelDA_PA_DashBoardBackground.Show();
            PanelWG_PA_WeeklyGoalsBackground.Hide();
        }

        private void PanelFLM_BT_WeeklyGoalsButton_Click(object sender, EventArgs e)
        {
            PanelWG_PA_WeeklyGoalsBackground.Show();
            panelDA_PA_NotificationsPanel.BringToFront();
        }

        private void WeeklyGoals_BTN_AddWeekGoal_Click(object sender, EventArgs e)
        {
            WeeklyGoals_LB_SetWeeklyGoal.Text = WeeklyGoals_TB_FillInWeeklyGoal.Text;
        }

        private void WeeklyGoalClick(object sender, EventArgs e)
        {
            if (Check == false) {
                Popup_FORM_WeeklyGoals PopUpBox = new Popup_FORM_WeeklyGoals(this);
                PopUpBox.Show(this);
                this.BringToFront();
                Check = true;
                this.Activate();
            }
            else
            {
                string message = "A window is already opened.";
                string title = "Warning!";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            


        }
    }
}
