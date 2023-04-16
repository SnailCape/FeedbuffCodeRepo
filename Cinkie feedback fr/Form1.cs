using Cinkie_feedback_fr.FeedBUFClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cinkie_feedback_fr
{
    public partial class Form1 : Form
    {
        public static bool Check = false;
        public static bool EditCheck = false;
        public Popup_FORM_WeeklyGoals PopUpBox;
        public Popup_FORM_DailyTasks PopUpDailyTasks;
        public Popup_FORM_Feedback PopUpRegisterFeedback;
        Student activeStudent = new Student();
        public static string selectedItem = "";

        public Form1()
        {
            InitializeComponent();
            
            if (Check == false)
            {
                ShowCurrentWeeklyGoals();
                ShowAllDailyTasks();
            }

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
            string errorMessage = $"Invalid Email or Password.\nCheck if your password and email are correct!\n\nPlease try again";
            string title = "Invalid Credentials";

            Student studenttemp = new Student();

            if (PanelLogin_TB_Email.Text == "" && PanelLogin_TB_Password.Text == "")
            {
                // Log the user in
                foreach (Student student in studenttemp.GetStudentsFromClass())
                {
                    if (student.Email.ToLower() == "2202261funk@zuyd.nl")
                    {
                        activeStudent = student;
                        activeStudent.LoginStatus = true;
                    }
                }

                // Set every panel in the correct place
                PanelDA_PA_DashBoardBackground.BringToFront();
                PanelDA_PA_DashBoardBackground.Show();
                BGflmPull.BringToFront();
                Login_Panel.Hide();
                PanelRE_PA_RegistryBG.Hide();
                FLMpanel.BringToFront();
                PanelLogin_TB_Email.Text = "";
                PanelLogin_TB_Password.Text = "";

                // Sellect the correct data
                PanelCorrectionToLoggedInUser();
            }
            else
            {
                MessageBox.Show(errorMessage, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                PanelLogin_TB_Password.Text = "";
            }
        }

        /// <summary>
        /// Sets all the correct data of the logged in user
        /// </summary>
        private void PanelCorrectionToLoggedInUser()
        {
            PanelDA_LB_UserInfoName.Text = activeStudent.FirstName + " " + activeStudent.LastName;
            PanelDA_LB_UserInfoStudentNumber.Text = activeStudent.StudentId.ToString();
            PanelDA_LB_UserCourse.Text = "HBO-ICT";

            // Check all tasks from the user
            DailyTask dailyTask = new DailyTask();
            WeeklyGoal weeklyGoal = new WeeklyGoal();
            List<DailyTask> taskList = new List<DailyTask>();

            foreach (WeeklyGoal goal in weeklyGoal.GetWeeklyGoalsFromClass())
            {
                // If goal belongs to the student
                if (goal.student == activeStudent || goal.StudentId == activeStudent.StudentId)
                {
                    foreach (DailyTask task in dailyTask.GetDailyTasksFromClass())
                    {
                        // If task belongs to a task belonging to a student
                        if (task.WeeklyGoalId == goal.WeeklyGoalId || task.weeklyGoal == goal)
                        {
                            taskList.Add(task);
                        }
                    }
                }
            }
            PanelDA_LB_TasksTasksAmount.Text = taskList.Count.ToString();

            int i = 0;
            int j = 0;
            foreach (DailyTask task in taskList)
            {
                if (task.Status.ToLower() == "in progress")
                {
                    i++;
                }
                else if (task.Status.ToLower() == "done")
                {
                    j++;
                }
            }
            PanelDA_LB_TasksInProgressAmount.Text = i.ToString();
            PanelDA_LB_TasksCompletedAmount.Text = j.ToString();

            EXPCalculation(taskList);
        }

        /// <summary>
        /// Method to calculate the percentage of completed tasks and apply it to the dashboard
        /// </summary>
        private void EXPCalculation(List<DailyTask> taskList)
        {
            // Calculate the total amount of tasks
            int totaltasks = taskList.Count();

            // Calculate the amount of tasks completed
            int completedTasks = 0;
            foreach (DailyTask task in taskList)
            {
                if (task.Status.ToLower() == "done")
                {
                    completedTasks++;
                }
            }

            // Calculate the percentage of completed tasks
            // List used isn't filled --> Where is the problem? Why is the list not filled?
            int percentageCompletedTasks = (completedTasks * 100) / totaltasks;

            // Calculate the width of the label based on the percentage of completed tasks
            int usedWidth = 403 * (percentageCompletedTasks / 100);
            PanelDA_LA_TasksExpPercentage.Width = usedWidth;
        }


        /// <summary>
        /// Hides the other panels and "logs" the user "out"
        /// </summary>
        private void PanelFLM_BT_LogoutButton_Click(object sender, EventArgs e)
        {
            // Logs the logged in user out
            Student studentList = new Student();
            foreach (Student student in studentList.GetStudentsFromClass())
            {
                if (activeStudent.LoginStatus == true)
                {
                    activeStudent.LoginStatus = false;
                }
            }

            // Set every panel in the correct place
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
        private void PanelDA_TIME_ScoreboardDateAndTime_Tick(object sender, EventArgs e)
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
            WeeklyGoal_LBx_ViewGoals.Items.Clear();
            ShowCurrentWeeklyGoals();


            if(WeeklyGoal_LBx_ViewGoals.Text == "")
            {
                ShowAllDailyTasks();
                WeeklyGoalPanel_LV_ShowAll.BringToFront();
            }
        }

        private void WeeklyGoal_BTN_ShowAllGoals_Click(object sender, EventArgs e)
        {
            WeeklyGoal_LBx_ViewGoals.Items.Clear();
            ShowAllWeeklyGoals();
            WeeklyGoal_BTN_Hide.BringToFront();
            WeeklyGoal_BTN_Hide.Visible = true;
        }

        private void WeeklyGoal_BTN_Hide_Click(object sender, EventArgs e)
        {
            WeeklyGoal_LBx_ViewGoals.Items.Clear();
            ShowCurrentWeeklyGoals();
            WeeklyGoal_BTN_Hide.SendToBack();
            WeeklyGoal_BTN_Hide.Visible = false;

        }

        public void ShowAllDailyTasks()
        {
            WeeklyGoalPanel_LV_ShowAll.BringToFront();
            DailyTask dailytasks = new DailyTask();
            Student student = new Student();

            foreach (Student s in student.GetStudentsFromClass())
            {
                if (s.StudentId == activeStudent.StudentId)
                {
                    foreach (DailyTask dt in dailytasks.GetDailyTasksFromClass())
                    {
                        ListViewItem item = WeeklyGoalPanel_LV_ShowAll.Items.Add(dt.Titel.ToString());
                        item.SubItems.Add(dt.Status);
                        WeeklyGoalPanel_LV_ShowAll.Groups[0].Items.Add(item);
                    }
                }
            }
        }
    
// show all weekly goals of the active student
        public void ShowAllWeeklyGoals()
        {
            Student student = new Student();
            WeeklyGoal weeklygoal = new WeeklyGoal();
            List<WeeklyGoal> listgoal = new List<WeeklyGoal>();
            WeeklyGoal_LBx_ViewGoals.Items.Clear();

            foreach (Student s in student.GetStudentsFromClass())
            {
                if (s.StudentId == activeStudent.StudentId)
                {
                    foreach (WeeklyGoal wg in weeklygoal.GetWeeklyGoalsFromClass())
                    {
                        if (wg.StudentId == s.StudentId)
                        {
                            int idlength = 25 - wg.WeeklyGoalId.ToString().Length;
                            int titlelength = 80 - wg.Titel.ToString().Length;
                            string dataGoals = $"{wg.WeeklyGoalId.ToString().PadRight(idlength)}\t|\t{wg.Titel.ToString().PadRight(titlelength)}\t|\t{wg.Status}";

                            WeeklyGoal_LBx_ViewGoals.Items.Add(dataGoals);
                        }
                    }
                }
            }


        }
// show the current weekly goal of the active student
        public void ShowCurrentWeeklyGoals()
        {
            Student student = new Student();
            WeeklyGoal weeklygoal = new WeeklyGoal();
            List<WeeklyGoal> listgoal = new List<WeeklyGoal>();

            WeeklyGoal_LBx_ViewGoals.Items.Clear();

            foreach (Student s in student.GetStudentsFromClass())
            {
                if (s.StudentId == activeStudent.StudentId)
                {
                    foreach (WeeklyGoal wg in weeklygoal.GetWeeklyGoalsFromClass())
                    {
                        if (wg.StudentId == s.StudentId && wg.Status.ToLower() != "done")
                        {
                            int idlength = 25 - wg.WeeklyGoalId.ToString().Length;
                            int titlelength = 80 - wg.Titel.ToString().Length;
                            string dataGoals = $"{wg.WeeklyGoalId.ToString().PadRight(idlength)}\t|\t{wg.Titel.ToString().PadRight(titlelength)}\t|\t{wg.Status}";

                            WeeklyGoal_LBx_ViewGoals.Items.Add(dataGoals);
                        }
                    }
                }
            }


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
                EditCheck= true;
                this.Activate();
            }
            else
            {
                string message = "A window is already opened.";
                string title = "Warning!";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

        private void WeeklyGoalClick_Add(object sender, EventArgs e)
        {
            if (Check == false)
            {
                Popup_FORM_WeeklyGoals PopUpBox = new Popup_FORM_WeeklyGoals(this);
                PopUpBox.Show(this);
                this.BringToFront();
                Check = true;
                EditCheck = false;
                this.Activate();
            }
            else
            {
                string message = "A window is already opened.";
                string title = "Warning!";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void WeekGoals_BTN_AddTask_Click(object sender, EventArgs e)
        {
            if (Check == false)
            {
                Popup_FORM_DailyTasks PopUpDailyTasks = new Popup_FORM_DailyTasks(this);
                PopUpDailyTasks.Show(this);
                this.BringToFront();
                EditCheck = false;
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


        private void WeekGoals_BTN_EditTask_Click(object sender, EventArgs e)
        {
            if (Check == false)
            {
                Popup_FORM_DailyTasks PopUpDailyTasks = new Popup_FORM_DailyTasks(this);
                PopUpDailyTasks.Show(this);
                PopUpDailyTasks.displaydailytask();
                this.BringToFront();
                Check = true;
                EditCheck = true;
                this.Activate();
            }
            else
            {
                string message = "A window is already opened.";
                string title = "Warning!";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        public void UpdateDailyTask(string status, string title, string description, int goalId, string time, string difficulty, string priority, string type)
        {
            ///probleem met type in task zetten, dal ontvangt niks. >> GEFIXED
            //MessageBox.Show(type);
            int id = 0;
            DailyTask task = new DailyTask();
            foreach (DailyTask t in task.GetDailyTasksFromClass())
            {             
                if (title == t.Titel)
                {
                    id = t.DailyTaskId;
                }
            }

            if (id != 0)
            {
                DailyTask dailytask = new DailyTask(id, status, title, description, goalId, time, priority, difficulty, type);
                dailytask.UpdateDailyTask(dailytask);

                ShowAllDailyTasks();
            }
        }
        public void UpdateWeeklyGoal(string title, string description, string status, string priority, string difficulty, string type, string oe, string note, string agenda, string startingdate, int id)
        {
            int weeknumber = 16;
            StudyUnit studyunit = new StudyUnit();
            WeeklyGoal goal = new WeeklyGoal();

            foreach (StudyUnit su in studyunit.GetStudyUnitsFromClass())
            {
                if(su.StudyUnitId == oe)
                {
                    studyunit = su;
                }
            }

            WeeklyGoal weeklyGoal = new WeeklyGoal(id, weeknumber, title, description, status, studyunit, activeStudent.StudentId, priority, difficulty, type, startingdate, agenda, note);

            weeklyGoal.UpdateWeeklyGoal(weeklyGoal, activeStudent, studyunit);

            ShowAllWeeklyGoals();
        }

        /// <summary>
        /// Create a new weekly goal
        /// </summary>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="status"></param>
        /// <param name="priority"></param>
        /// <param name="difficulty"></param>
        /// <param name="type"></param>
        /// <param name="oe"></param>
        /// <param name="note"></param>
        public void CreateWeeklyGoal(string title, string description, string status, string priority,
                                            string difficulty, string type, string oe, string note, string agenda, string startingdate)
        {
            int weeknumber = 16;

            // collect individual data here and then create the object
            StudyUnit studyunit = new StudyUnit();
            studyunit.GetStudyUnitsFromDB();
            foreach (StudyUnit su in studyunit.listStudyUnits)
            {
                if (su.StudyUnitId == oe)
                {
                    studyunit = su;
                }
            }

            WeeklyGoal weeklygoal = new WeeklyGoal(0, weeknumber, title, description, status, studyunit, activeStudent.StudentId,
                                                   priority, difficulty, type, startingdate, agenda, note);

            weeklygoal.CreateWeeklyGoal(weeklygoal, activeStudent, studyunit);
        }

        public void CreateDailyTask(string status, string title, string desc, int goalId,
                                    string time, string prio, string diff, string type)
        {
            DailyTask task = new DailyTask(0, status, title, desc, goalId, time, prio, diff, type);
            task.CreateDailyTask(task);
        }

        private void WeeklyGoal_LBx_ViewGoals_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (WeeklyGoal_LBx_ViewGoals.SelectedIndex > 0)
            {
                var index = WeeklyGoal_LBx_ViewGoals.SelectedItems[0];
                selectedItem = index.ToString();
            }

        }

        private void WeeklyGoalPanel_LV_ShowAll_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (WeeklyGoalPanel_LV_ShowAll.SelectedItems.Count > 0)
            {
                var item = WeeklyGoalPanel_LV_ShowAll.SelectedItems[0];
                selectedItem = item.Text;
            }
        }

    }
}
