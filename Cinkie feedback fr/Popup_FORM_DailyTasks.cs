using Cinkie_feedback_fr.FeedBUFClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;

namespace Cinkie_feedback_fr
{
    public partial class Popup_FORM_DailyTasks : Form
    {
        public Form1 form1;

        public Popup_FORM_DailyTasks(Form1 frm)
        {
            InitializeComponent();


            WeeklyGoal weeklygoal = new WeeklyGoal();
            foreach (WeeklyGoal goal in weeklygoal.GetWeeklyGoalsFromClass())
            {
                PopupDaily_CB_WeeklyTask.Items.Add(goal.WeeklyGoalId + " "+ goal.Titel + " " + goal.GoalType);
            }


            this.Text = "Daily Task";
            form1= frm;
        }

        public void displaydailytask()
        {
            DailyTask dailyTask = new DailyTask();
            WeeklyGoal weeklyGoal = new WeeklyGoal();

            foreach (DailyTask dt in dailyTask.GetDailyTasksFromClass())
            {
                if (dt.Titel == Form1.selectedItem)
                {
                    dailyTask = dt;
                }
            }

            PopupDaily_TB_Title.Text = dailyTask.Titel.ToString();
            PopupDaily_TB_Description.Text = dailyTask.Description.ToString();
            PopupDaily_CB_Status.Text = dailyTask.Status.ToString();
            PopupDaily_CB_Priority.Text = dailyTask.Priority.ToString();
            PopupDaily_CB_Difficulty.Text = dailyTask.Difficulty.ToString();
            PopupDaily_CB_Type.Text = dailyTask.Type.ToString();
            PopupDaily_TB_Time.Text = dailyTask.Time.ToString();

            foreach (WeeklyGoal goal in weeklyGoal.GetWeeklyGoalsFromClass())
            {
                if (goal.WeeklyGoalId == dailyTask.WeeklyGoalId)
                {
                    weeklyGoal = goal;
                }
            }

            foreach (string item in PopupDaily_CB_WeeklyTask.Items)
            {
                if (item.Contains(weeklyGoal.Titel) || item.Contains(weeklyGoal.WeeklyGoalId.ToString()))
                {
                    PopupDaily_CB_WeeklyTask.SelectedItem = item;
                }
            }

            PopupDaily_CB_OE.Text = weeklyGoal.studyUnit.StudyUnitId;

            switch (dailyTask.Status.ToLower())
            {

                case "done":
                    PopupDaily_CB_Status.SelectedIndex = 0;
                    break;

                case "in progress":
                    PopupDaily_CB_Status.SelectedIndex = 1;
                    break;

                case "inprogress":
                    PopupDaily_CB_Status.SelectedIndex = 1;
                    break;

                case "not started":
                    PopupDaily_CB_Status.SelectedIndex = 2;
                    break;

                case "notstarted":
                    PopupDaily_CB_Status.SelectedIndex = 2;
                    break;
            }
            //
            switch (dailyTask.Difficulty.ToLower())
            {

                case "hard":
                    PopupDaily_CB_Difficulty.SelectedIndex = 0;
                    break;

                case "medium":
                    PopupDaily_CB_Difficulty.SelectedIndex = 1;
                    break;

                case "low":
                    PopupDaily_CB_Difficulty.SelectedIndex = 2;
                    break;
            }
            //
            switch (dailyTask.Priority.ToLower())
            {

                case "urgent":
                    PopupDaily_CB_Priority.SelectedIndex = 0;
                    break;

                case "high":
                    PopupDaily_CB_Priority.SelectedIndex = 1;
                    break;

                case "medium":
                    PopupDaily_CB_Priority.SelectedIndex = 2;
                    break;

                case "low":
                    PopupDaily_CB_Priority.SelectedIndex = 3;
                    break;
            }
            //
            switch (dailyTask.Type.ToLower())
            {

                case "learning":
                    PopupDaily_CB_Type.SelectedIndex = 0;
                    break;

                case "work":
                    PopupDaily_CB_Type.SelectedIndex = 1;
                    break;

                case "documentation":
                    PopupDaily_CB_Type.SelectedIndex = 2;
                    break;

                case "lesson":
                    PopupDaily_CB_Type.SelectedIndex = 3;
                    break;
            }
        }

        
        /// <summary>
        /// The save and exit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void DailyTasks_BTN_Close_Click(object sender, EventArgs e)
        {
            WeeklyGoal weeklyGoal = new WeeklyGoal();

            // Collect all data from form
            string status = PopupDaily_CB_Status.SelectedItem.ToString();
            string title = PopupDaily_TB_Title.Text;
            string description = PopupDaily_TB_Description.Text;
            string oe = PopupDaily_CB_OE.SelectedItem.ToString();
            string time = PopupDaily_TB_Time.Text;
            string priority = PopupDaily_CB_Priority.SelectedItem.ToString();
            string difficulty = PopupDaily_CB_Difficulty.SelectedItem.ToString();
            string type = PopupDaily_CB_Type.SelectedItem.ToString();
            string weeklyGoalId = PopupDaily_CB_WeeklyTask.SelectedItem.ToString();
            int goalId = 0;

            switch (type)
            {
                case ("Learning 📚"):
                    type = "Learning";
                    break;
                case ("Work 🔨"):
                    type = "Work";
                    break;
                case ("Lesson 🎓"):
                    type = "Lesson";
                    break;
                case ("Documentation 📃"):
                    type = "Documentation";
                    break;
            }

            switch (priority)
            {
                case ("Urgent ⚠️"):
                    priority = "urgent";
                    break;
                case ("High 🪂"):
                    priority = "high";
                    break;
                case ("Medium 🐄"):
                    priority = "medium";
                    break;
                case ("Low 🐇"):
                    priority = "low";
                    break;
            }

            switch (difficulty)
            {
                case ("Hard 🦑"):
                    difficulty = "hard";
                    break;
                case ("Medium 🦍"):
                    difficulty = "medium";
                    break;
                case ("Low 🐇"):
                    difficulty = "low";
                    break;
            }

            switch (status)
            {
                case ("Done ✅"):
                    status = "done";
                    break;
                case ("In Progress 🔨"):
                    status = "in progress";
                    break;
                case ("Not Started ⏳"):
                    status = "not started";
                    break;
            }


            foreach (WeeklyGoal goal in weeklyGoal.GetWeeklyGoalsFromDB())
            {
                if (weeklyGoalId.Contains(goal.WeeklyGoalId.ToString()))
                {
                    goalId = goal.WeeklyGoalId;
                    break;
                }
            }

            //create here the string for infomation display

            if (Form1.EditCheck == true)
            {
                // Update
                form1.WeeklyGoalPanel_LV_ShowAll.Clear();
                form1.UpdateDailyTask(status, title, description, goalId, time, priority, difficulty, type);
            }
            else
            {
                // Create
                form1.CreateDailyTask(status, title, description, goalId, time, priority, difficulty, type);
            }

            this.Dispose();
            Form1.Check = false;
            Form1.EditCheck = false;
            


        }


        // hide close button
        private const int WS_SYSMENU = 0x80000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style &= ~WS_SYSMENU;
                return cp;
            }
        }

        private void PopupDaily_BT_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form1.Check = false;

        }
    }
}
