using Cinkie_feedback_fr.FeedBUFClasses;
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
    public partial class Popup_FORM_DailyTasks : Form
    {
        public Form1 form1;

        public Popup_FORM_DailyTasks(Form1 frm)
        {
            InitializeComponent();

            WeeklyGoal goal = new WeeklyGoal();
            PopupDaily_CB_WeeklyTask.Items.Clear();
            foreach (WeeklyGoal weeklygoal in goal.GetWeeklyGoalsFromClass())
            {
                PopupDaily_CB_WeeklyTask.Items.Add($"{weeklygoal.WeeklyGoalId} | {weeklygoal.Titel}");
            }

            this.Text = "Daily Task";
            form1= frm;
        }
        
        /// <summary>
        /// The save and exit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DailyTasks_BTN_Close_Click(object sender, EventArgs e)
        {
            //create here the string for infomation display
            //form1.WeeklyGoals_LB_SetWeeklyGoal.Text

            WeeklyGoal weeklyGoal = new WeeklyGoal();

            // Collect all data from form
            string status = PopupDaily_CB_Status.SelectedText;
            string title = PopupDaily_TB_Title.Text;
            string description = PopupDaily_TB_Description.Text;
            string oe = PopupDaily_CB_OE.SelectedText;
            string time = PopupDaily_LB_Time.Text;
            string priority = PopupDaily_CB_Priority.SelectedText;
            string difficulty = PopupDaily_CB_Difficulty.SelectedText;
            string type = PopupDaily_CB_Type.SelectedText;
            string weeklyGoalId = PopupDaily_CB_WeeklyTask.SelectedText;
            int goalId = 0;

            // Set data to be able to be put in the database
            switch (type)
            {
                case ("Learning 📚"):
                    status = "Learning";
                    break;
                case ("Work 🔨"):
                    status = "Work";
                    break;
                case ("Lesson 🎓"):
                    status = "Lesson";
                    break;
                case ("Documentation 📃"):
                    status = "Documentation";
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
                MessageBox.Show($"{weeklyGoalId}\n{goal.WeeklyGoalId}", "AAAAAAAAAHHHHHHHHH", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (weeklyGoalId.Contains(goal.WeeklyGoalId.ToString()))
                {
                    goalId = goal.WeeklyGoalId;
                    MessageBox.Show($"ID: {goal.WeeklyGoalId} | Titel: {goal.Titel}", $"{weeklyGoalId}", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            form1.CreateDailyTask(status, title, description, goalId, time, priority, difficulty, type);

            this.Dispose();
            Form1.Check = false;
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
