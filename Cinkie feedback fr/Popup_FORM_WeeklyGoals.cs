using Cinkie_feedback_fr.FeedBUFClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cinkie_feedback_fr
{
    public partial class Popup_FORM_WeeklyGoals : Form
    {
        public Form1 form1;

        public int updateGoalId = 0;

        public Popup_FORM_WeeklyGoals(Form1 frm)
        {
            InitializeComponent();
            this.Text = "Weekly Goal";
            form1= frm;
        }

        public void displayweeklygoal()
        {
            ///
            //Show weekly goal information
            ///
            WeeklyGoal weeklygoal = new WeeklyGoal();
            bool selected = true;

            foreach (WeeklyGoal wg in weeklygoal.GetWeeklyGoalsFromClass())
            {
                if (Form1.selectedItem.Contains(wg.Titel) || Form1.selectedItem.Contains(wg.Description.ToString()))
                {
                    weeklygoal = wg;
                    updateGoalId = wg.WeeklyGoalId;
                    break;
                }
                else if (Form1.selectedItem == "")
                {
                    string message = "You have not selected a goal that you want to edit.\nPlease select a goal before pressing this button.";
                    string title = "No Item Selected";
                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    selected = false;
                }
            }

            if (selected == false)
            {
                Dispose();
                Form1.Check = false;
            }

            PopUpFormWeekly_TB_WeekNr.Text = weeklygoal.Agenda;
            PopUpFormWeekly_TB_Title.Text = weeklygoal.Titel;
            PopUpFormWeekly_TB_Description.Text = weeklygoal.Description;
            PopUpFormWeekly_CB_Status.Text = weeklygoal.Status.ToString();
            PopUpFormWeekly_CB_Priority.Text = weeklygoal.Priority.ToString();
            PopUpFormWeekly_CB_Difficulty.Text = weeklygoal.Difficulty.ToString();
            PopUpFormWeekly_CB_Type.Text = weeklygoal.GoalType.ToString();
            PopUpFormWeekly_TB_Note.Text = weeklygoal.Notes.ToString();
            PopUpFormWeekly_CB_OE.Text = weeklygoal.studyUnit.StudyUnitId.ToString();
            PopUpFormWeekly_LB_Date.Text = weeklygoal.StartingDate.ToString();
            //
            switch (weeklygoal.Status.ToLower())
            {

                case "done":
                    PopUpFormWeekly_CB_Status.SelectedIndex = 0;
                    break;

                case "in progress":
                    PopUpFormWeekly_CB_Status.SelectedIndex = 1;
                    break;

                case "inprogress":
                    PopUpFormWeekly_CB_Status.SelectedIndex = 1;
                    break;

                case "not started":
                    PopUpFormWeekly_CB_Status.SelectedIndex = 2;
                    break;

                case "notstarted":
                    PopUpFormWeekly_CB_Status.SelectedIndex = 2;
                    break;
            }
            //
            switch (weeklygoal.Difficulty.ToLower())
            {

                case "hard":
                    PopUpFormWeekly_CB_Difficulty.SelectedIndex = 0;
                    break;

                case "medium":
                    PopUpFormWeekly_CB_Difficulty.SelectedIndex = 1;
                    break;

                case "low":
                    PopUpFormWeekly_CB_Difficulty.SelectedIndex = 2;
                    break;
            }
            //
            switch (weeklygoal.Priority.ToLower())
            {

                case "urgent":
                    PopUpFormWeekly_CB_Priority.SelectedIndex = 0;
                    break;

                case "high":
                    PopUpFormWeekly_CB_Priority.SelectedIndex = 1;
                    break;

                case "medium":
                    PopUpFormWeekly_CB_Priority.SelectedIndex = 2;
                    break;

                case "low":
                    PopUpFormWeekly_CB_Priority.SelectedIndex = 3;
                    break;
            }
            //
            switch (weeklygoal.GoalType.ToLower())
            {

                case "learning":
                    PopUpFormWeekly_CB_Type.SelectedIndex = 0;
                    break;

                case "work":
                    PopUpFormWeekly_CB_Type.SelectedIndex = 1;
                    break;

                case "documentation":
                    PopUpFormWeekly_CB_Type.SelectedIndex = 2;
                    break;

                case "lesson":
                    PopUpFormWeekly_CB_Type.SelectedIndex = 3;
                    break;
            }

            switch (weeklygoal.studyUnit.StudyUnitId.ToLower())
            {

                case "b1c2":
                    PopUpFormWeekly_CB_OE.SelectedIndex = 0;
                    break;

                case "b1a3":
                    PopUpFormWeekly_CB_OE.SelectedIndex = 1;
                    break;

                case "b1f3":
                    PopUpFormWeekly_CB_OE.SelectedIndex = 2;
                    break;
            }
        }


        private void WG_BTN_Add_Click(object sender, EventArgs e)
        {
            string agenda = PopUpFormWeekly_TB_WeekNr.Text.ToString();
            string title = PopUpFormWeekly_TB_Title.Text;
            string description = PopUpFormWeekly_TB_Description.Text;
            string status = PopUpFormWeekly_CB_Status.SelectedItem.ToString();
            string priority = PopUpFormWeekly_CB_Priority.SelectedItem.ToString();
            string difficulty = PopUpFormWeekly_CB_Difficulty.SelectedItem.ToString();
            string type = PopUpFormWeekly_CB_Type.SelectedItem.ToString();
            string oe = PopUpFormWeekly_CB_OE.SelectedItem.ToString();
            string note = PopUpFormWeekly_TB_Note.Text.ToString();
            string startingdate = PopUpFormWeekly_LB_Date.Text;


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

            if (Form1.EditCheck == true)
            {
                //update functie
                form1.UpdateWeeklyGoal(title, description, status, priority, difficulty, type, oe, note, agenda, startingdate, updateGoalId);
            }
            else
            {
                // levi's create functie HIER: [zie hieronder] 
                form1.CreateWeeklyGoal(title, description, status, priority, difficulty, type, oe, note, agenda, startingdate);
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

       

        private void PopUpFormWeekly_TIME_StartDate_Tick(object sender, EventArgs e)
        {
            this.PopUpFormWeekly_LB_Date.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void PopUpFormWeekly_BTN_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form1.Check = false;
        }
    }
}
