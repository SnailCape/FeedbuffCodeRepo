using Cinkie_feedback_fr.FeedBUFClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinkie_feedback_fr
{
    public partial class Popup_FORM_WeeklyGoals : Form
    {
        public Form1 form1;

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
            weeklygoal.GetWeeklyGoalsFromDB();

            foreach (WeeklyGoal wg in weeklygoal.GetWeeklyGoalsFromClass())
            {
                PopUpFormWeekly_TB_WeekNr.Text = "Week: " + wg.Weeknumber.ToString();
                PopUpFormWeekly_TB_Title.Text = wg.Titel.ToString();
                PopUpFormWeekly_TB_Description.Text = wg.Description.ToString();
                PopUpFormWeekly_CB_Status.Text = wg.Status.ToString();
                PopUpFormWeekly_CB_Priority.Text = wg.Priority.ToString();
                PopUpFormWeekly_CB_Difficulty.Text = wg.Difficulty.ToString();
                PopUpFormWeekly_CB_Type.Text = wg.GoalType.ToString();
                PopUpFormWeekly_TB_Note.Text = wg.Notes.ToString();
                PopUpFormWeekly_CB_OE.Text = wg.studyUnit.StudyUnitId.ToString();
                PopUpFormWeekly_LB_Date.Text = "Created: " + wg.StartingDate.ToString();
                //
                switch (wg.Status)
                {

                    case "done":
                        PopUpFormWeekly_CB_Status.SelectedIndex = 0;
                        break;

                    case "inprogress":
                        PopUpFormWeekly_CB_Status.SelectedIndex = 1;
                        break;

                    case "notstarted":
                        PopUpFormWeekly_CB_Status.SelectedIndex = 2;
                        break;
                }
                //
                switch (wg.Difficulty)
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
                switch (wg.Priority)
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
                switch (wg.GoalType)
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

                switch (wg.studyUnit.StudyUnitId)
                {

                    case "B1C2":
                        PopUpFormWeekly_CB_OE.SelectedIndex = 0;
                        break;

                    case "B1A3":
                        PopUpFormWeekly_CB_OE.SelectedIndex = 1;
                        break;

                    case "B1F3":
                        PopUpFormWeekly_CB_OE.SelectedIndex = 2;
                        break;
                }

            }
        }   

        
        private void WG_BTN_Add_Click(object sender, EventArgs e)
        {
            string title = PopUpFormWeekly_TB_Title.Text;
            string description = PopUpFormWeekly_TB_Description.Text;
            string status = PopUpFormWeekly_CB_Status.SelectedItem.ToString();
            string priority = PopUpFormWeekly_CB_Priority.SelectedItem.ToString();
            string difficulty = PopUpFormWeekly_CB_Difficulty.SelectedItem.ToString();
            string type = PopUpFormWeekly_CB_Type.SelectedItem.ToString();
            string oe = PopUpFormWeekly_CB_OE.SelectedItem.ToString();
            string note = PopUpFormWeekly_TB_Note.Text;
            string agenda = PopUpFormWeekly_TB_WeekNr.Text;
            string startingdate = PopUpFormWeekly_LB_Date.Text;

            form1.CreateWeeklyGoal(title, description, status, priority, difficulty, type, oe, note, agenda, startingdate);
            
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

       

        private void PopUpFormWeekly_TIME_StartDate_Tick(object sender, EventArgs e)
        {
            this.PopUpFormWeekly_LB_Date.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
