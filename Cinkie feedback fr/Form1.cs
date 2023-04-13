﻿using Cinkie_feedback_fr.FeedBUFClasses;
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
        public Popup_FORM_DailyTasks PopUpDailyTasks;
        public Popup_FORM_Feedback PopUpRegisterFeedback;

        public Form1()
        {
            InitializeComponent();
            GetAllDataFromDatabase();

        }

        /// <summary>
        /// Collect all data from the database
        /// </summary>
        private void GetAllDataFromDatabase()
        {
            // Make an instance of every object
            FeedBUFClasses.DailyTask dailytask = new FeedBUFClasses.DailyTask();
            FeedBUFClasses.Feedback feedback = new FeedBUFClasses.Feedback();
            FeedBUFClasses.SchoolClass schoolclass = new FeedBUFClasses.SchoolClass();
            FeedBUFClasses.Student student = new FeedBUFClasses.Student();
            FeedBUFClasses.StudyUnit studyunit = new FeedBUFClasses.StudyUnit();
            FeedBUFClasses.Teacher teacher = new FeedBUFClasses.Teacher();
            FeedBUFClasses.WeeklyGoal weeklygoal = new FeedBUFClasses.WeeklyGoal();

            // Get all data
            dailytask.GetDailyTasksFromDB();
            feedback.GetFeedbackFromDB();
            schoolclass.GetClassesFromDB();
            student.GetStudentsFromDB();
            studyunit.GetStudyUnitsFromDB();
            teacher.GetTeachersFromDB();
            weeklygoal.GetWeeklyGoalsFromDB();

            // Connect incomplete data
            student.ConnectStudentsWithClasses();
            weeklygoal.ConnectGoalWithStudent();
            dailytask.ConnectTaskWithGoal();
        }

        /// <summary>
        /// On startup: Brings login panel to front (so its the first thing you see) and brings FLM panel to front (so it doesn't get prevented from popping up when needed)
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            Login_Panel.BringToFront();
            FLMpanel.Hide();
            FLMpanel.BringToFront();

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
        /// <summary>
        /// Rick Rolls the user if they were dumb enough to forget their password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelLogin_LLB_PasswordFOR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Specify that the link was visited.
            PanelLogin_LLB_PasswordFOR.LinkVisited = true;

            // Navigate to a URL.
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=xvFZjo5PgG0");
        }

        /// <summary>
        /// Logs the user into the system if they use the correct combination of email and password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            PanelFB_PA_FeedbackBG.Hide();

        }


        /// <summary>
        /// Adds the date and time to the labels (currently at scoreboard)
        /// </summary>
        private void DigitalClockTimer_Tick(object sender, EventArgs e)
        {
            this.PanelDA_LA_ScoreboardTime.Text = DateTime.Now.ToString("HH:mm");
            this.PanelDA_LA_ScoreboardDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        /// <summary>
        /// Brings user to Dashboard panel and hides unnecesary elements
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelFLM_BT_DashboardButton_Click(object sender, EventArgs e)
        {
            PanelDA_PA_DashBoardBackground.Show();
            PanelWG_PA_WeeklyGoalsBackground.Hide();
            PanelFB_PA_FeedbackBG.Hide();
        }

        private void PanelFLM_BT_WeeklyGoalsButton_Click(object sender, EventArgs e)
        {
            PanelDA_PA_DashBoardBackground.Hide();
            PanelWG_PA_WeeklyGoalsBackground.BringToFront();
            PanelWG_PA_WeeklyGoalsBackground.Show();
            panelDA_PA_NotificationsPanel.Show();
            panelDA_PA_NotificationsPanel.BringToFront();
            BGflmPull.BringToFront();
            FLMpanel.BringToFront();
            Visable_Week();
            WeeklyGoalPanel_LV_ShowAll.BringToFront();
            WeeklyGoalPanel_LV_ShowAll.Visible = true;

        }

        private void PanelFLM_BT_FeedbackButton_Click(object sender, EventArgs e)
        {
            PanelFB_PA_FeedbackBG.Show();
            PanelFB_PA_FeedbackBG.BringToFront();
            PanelWG_PA_WeeklyGoalsBackground.Hide();
            PanelDA_PA_DashBoardBackground.Hide();
            BGflmPull.BringToFront();
            BGflmPull.Show();
            FLMpanel.BringToFront();
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


            WeeklyGoals_LB_SetWeeklyGoal.Text = "";
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
        
        /// <summary>
        /// Save the new Student 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelRE_BT_RegisterSave_Click(object sender, EventArgs e)
        {
            // Has not been completed yet --> Needs to send data to the database

            int studentId = Int32.Parse(PanelRE_TB_RegisterStudentNumber.Text);
            string firstname = PanelRE_TB_RegisterStudentName.Text;
            string lastname = PanelRE_TB_RegisterStudentSurname.Text;
            string gender = "";
            if (PanelRE_CMB_RegisterStudentGender.Text.ToLower() == "male")
            {
                gender = "M";
            }
            else if (PanelRE_CMB_RegisterStudentGender.Text.ToLower() == "female")
            {
                gender = "V";
            }
            else if (PanelRE_CMB_RegisterStudentGender.Text.ToLower() == "other")
            {
                gender = "O";
            }
            string email = PanelRE_TB_RegisterStudentEmail.Text;
            string phonenumber = PanelRE_TB_RegisterStudentPhonenumber.Text;
            string postalcode = PanelRE_TB_RegisterStudentPostalcode.Text;
            string country = PanelRE_TB_RegisterStudentCountry.Text;
            string city = PanelRE_TB_RegisterStudentCity.Text;
            string street = PanelRE_TB_RegisterStudentStreet.Text;
            string housenumber = PanelRE_TB_RegisterStudentUnitNumber.Text;
            string schoollocation = PanelRE_CMB_RegisterStudentLocation.Text;
            int studentclassid = Int32.Parse(PanelRE_CMB_RegisterStudentClass.Text);

            Student student = new Student(studentId, firstname, lastname, gender, email, phonenumber, postalcode, country, city,
                                          street, housenumber, schoollocation, false, studentclassid);

            student.CreateStudent(student);

            Login_Panel.Show();
            PanelRE_PA_RegistryBG.SendToBack();
        }

        private void PanelRE_CMB_RegisterStudentCourse_Click(object sender, EventArgs e)
        {
            PanelRE_CMB_RegisterStudentClass.DroppedDown = true;
        }
        


        private void PanelFB_BT_RegisterFeedback_Click(object sender, EventArgs e)
        {
            if (Check == false)
            {
                Popup_FORM_Feedback PopUpBox = new Popup_FORM_Feedback(this);
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
            Visable_Week();
            WeeklygoalPanel_LV_Monday.BringToFront();
            WeeklygoalPanel_LV_Monday.Visible = true;
        }
        private void WeeklyGoals_BTN_Tuesday_Click(object sender, EventArgs e)
        {
            Visable_Week();
            WeeklygoalPanel_LV_Tuesday.BringToFront();
            WeeklygoalPanel_LV_Tuesday.Visible = true;
        }

        private void WeeklyGoals_BTN_Wednesday_Click(object sender, EventArgs e)
        {
            Visable_Week();
            WeeklygoalPanel_LV_Wednesday.BringToFront();
            WeeklygoalPanel_LV_Wednesday.Visible= true;
        }
        private void WeeklyGoals_BTN_Thursday_Click(object sender, EventArgs e)
        {
            Visable_Week();
            WeeklygoalPanel_LV_Thursday.BringToFront();
            WeeklygoalPanel_LV_Thursday.Visible = true;
        }

        private void WeeklyGoals_BTN_Friday_Click(object sender, EventArgs e)
        {
            Visable_Week();
            WeeklygoalPanel_LV_Friday.BringToFront();
            WeeklygoalPanel_LV_Friday.Visible= true;
        }

        private void WeeklyGoals_BTN_Saturday_Click(object sender, EventArgs e)
        {
            Visable_Week();
            WeeklygoalPanel_LV_Saturday.BringToFront();
            WeeklygoalPanel_LV_Saturday.Visible = true;
        }

        private void WeeklyGoals_BTN_Sunday_Click(object sender, EventArgs e)
        {
            Visable_Week();
            WeeklygoalPanel_LV_Sunday.BringToFront();
            WeeklygoalPanel_LV_Sunday.Visible= true;
        }

        private void WeeklyGoals_BTN_ShowAll_Click(object sender, EventArgs e)
        {
            Visable_Week();
            WeeklyGoalPanel_LV_ShowAll.Visible = true;
        }

        private void Visable_Week()
        {
            WeeklygoalPanel_LV_Monday.Visible = false;
            WeeklygoalPanel_LV_Tuesday.Visible = false;
            WeeklygoalPanel_LV_Wednesday.Visible = false;
            WeeklygoalPanel_LV_Thursday.Visible = false;
            WeeklygoalPanel_LV_Friday.Visible = false;
            WeeklygoalPanel_LV_Saturday.Visible = false;
            WeeklygoalPanel_LV_Sunday.Visible = false;
            WeeklyGoalPanel_LV_ShowAll.Visible=false;
        }

        private void WeeklyGoalClick_View(object sender, EventArgs e)
        {
            if (Check == false)
            {
                Popup_FORM_WeeklyGoals PopUpBox = new Popup_FORM_WeeklyGoals(this);
                PopUpBox.Show(this);
                PopUpBox.displayweeklygoal();
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


            WeeklyGoals_LB_SetWeeklyGoal.Text = "";

        }


        private void WeeklyGoalClick_Add(object sender, EventArgs e)
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


            WeeklyGoals_LB_SetWeeklyGoal.Text = "";

        private void WeeklygoalPanel_LV_SelectedIndexChanged(object sender, ItemCheckedEventArgs e)
        {
            // Moet alle data opvragen voor de juiste dailytask
        }

        private void WeekGoals_BTN_EditTask_Click(object sender, EventArgs e)
        {
            // Gebruikt de data bij methode hieboven voor het openen van een popup (evt overbodig indien dubbel click ook kan)

        }
    }
}
