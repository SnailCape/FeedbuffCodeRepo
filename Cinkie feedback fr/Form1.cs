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
        public static bool Check = false;
        public Popup_FORM_WeeklyGoals PopUpBox;

        public Form1()
        {
            InitializeComponent();
            //GetAllDataFromDatabase();

        }

        /// <summary>
        /// Collect all data from the database
        /// </summary>
        /*private void GetAllDataFromDatabase()
        {
            Classes.Class.GetClassesFromDB();
            Classes.DailyTask.GetDailyTasksFromDB();
            Classes.Feedback.GetFeedbackFromDB();
            Classes.Student.GetStudentsFromDB();
            Classes.StudyUnit.GetStudyUnitsFromDB();
            Classes.Teacher.GetTeachersFromDB();
            Classes.WeeklyGoal.GetWeeklyGoalsFromDB();
        }
    */
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
            {
                FLMpanel.Show();
            }
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
            {
                FLMpanel.Show();
            }

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
                PanelDA_PA_DashBoardBackground.BringToFront();
                PanelDA_PA_DashBoardBackground.Show();
                BGflmPull.BringToFront();
                Login_Panel.Hide();
                PanelRE_PA_RegistryBG.Hide();
                FLMpanel.BringToFront();
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
            Login_Panel.BringToFront();
            Login_Panel.Show();
            PanelDA_PA_DashBoardBackground.Hide();
            PanelWG_PA_WeeklyGoalsBackground.Hide();
            FLMpanel.Hide();
            PanelRE_PA_RegistryBG.BringToFront();

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
            PanelDA_PA_DashBoardBackground.Hide();
            PanelWG_PA_WeeklyGoalsBackground.BringToFront();
            PanelWG_PA_WeeklyGoalsBackground.Show();
            panelDA_PA_NotificationsPanel.Show();
            BGflmPull.BringToFront();
            FLMpanel.BringToFront();

        }


        private void WeeklyGoals_BTN_AddWeekGoal_Click(object sender, EventArgs e)
        {
            if (WeeklyGoals_TB_FillInWeeklyGoal.Text != "" && WeeklyGoals_LB_SetWeeklyGoal.Text != "Fill in your WeeklyGoal" && WeeklyGoals_TB_FillInWeeklyGoal.Text != "This field cannot be empty")
            {
                WeeklyGoals_LB_SetWeeklyGoal.Text = WeeklyGoals_TB_FillInWeeklyGoal.Text;
                WeeklyGoals_TB_FillInWeeklyGoal.Visible = false;
                WeeklyGoals_BTN_AddWeekGoal.Visible= false;
            }
            else
            {
                WeeklyGoals_TB_FillInWeeklyGoal.Text = "This field cannot be empty";
            }
            
        }

        private void WeeklyGoalClick(object sender, EventArgs e)
        {
            if (Check == false)
            {
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
            /// <summary>
            /// A mass of combobox pulldowns so that whenever the user clicks on the comboboxes below it will drop down the options the user has
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void PanelRE_CMB_RegisterGender_Click(object sender, EventArgs e)
            {
                PanelRE_CMB_RegisterStudentGender.DroppedDown = true;
            }

            private void PanelRE_CMB_RegisterStudentLocation_Click(object sender, EventArgs e)
            {
                PanelRE_CMB_RegisterStudentLocation.DroppedDown = true;
            }

            private void PanelRE_BT_RegisterSave_Click(object sender, EventArgs e)
            {
            
            Login_Panel.Show();
            PanelRE_PA_RegistryBG.SendToBack();

            }

            private void PanelRE_CMB_RegisterStudentCourse_Click(object sender, EventArgs e)
            {
                PanelRE_CMB_RegisterStudentCourse.DroppedDown = true;

            }
        
        /// <summary>
        /// Brings you to the "account registration" panel 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelLogin_BT_Register_Click(object sender, EventArgs e)
        {
            Login_Panel.Hide();
            PanelRE_PA_RegistryBG.BringToFront();
            PanelRE_PA_RegistryBG.Show();
            BGflmPull.SendToBack();
        }

        private void WeeklyGoals_BTN_Monday_Click(object sender, EventArgs e)
        {

        }
        private void WeeklyGoals_BTN_Tuesday_Click(object sender, EventArgs e)
        {

        }

        private void WeeklyGoals_BTN_Wednesday_Click(object sender, EventArgs e)
        {

        }

        private void WeeklyGoals_BTN_Friday_Click(object sender, EventArgs e)
        {

        }

        private void WeeklyGoals_BTN_Saturday_Click(object sender, EventArgs e)
        {

        }

        private void WeeklyGoals_BTN_Sunday_Click(object sender, EventArgs e)
        {

        }

        private void WeeklyGoals_BTN_ShowAll_Click(object sender, EventArgs e)
        {

        }

    }
}
