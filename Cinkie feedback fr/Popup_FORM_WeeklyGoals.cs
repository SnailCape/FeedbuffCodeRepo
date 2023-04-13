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
                PopUpForm_Weekly_TB_WeekNr.Text = "Week: " + wg.Weeknumber.ToString();
                //PopUpForm_Weekly_TB_Title.Text = wg.Titel.ToString();
                //PopUpForm_Weekly_TB_Description.Text = wg.Description.ToString();
                PopUpForm_Weekly_CB_Status.Text = wg.Status.ToString();
                PopUpForm_Weekly_CB_Priority.Text = wg.Priority.ToString();
                PopUpForm_Weekly_CB_Difficulty.Text = wg.Difficulty.ToString();
                PopUpForm_Weekly_CB_Type.Text = wg.GoalType.ToString();
                PopUpForm_Weekly_TB_Note.Text = wg.Notes.ToString();

                switch (wg.Status)
                {

                    case "done":
                        PopUpForm_Weekly_CB_Status.SelectedIndex = 0;
                        break;

                    case "inprogress":
                        PopUpForm_Weekly_CB_Status.SelectedIndex = 1;
                        break;

                    case "notstarted":
                        PopUpForm_Weekly_CB_Status.SelectedIndex = 2;
                        break;
                }


            }
        }   

        
        private void WG_BTN_Add_Click(object sender, EventArgs e)
        {
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

        private void PopUpForm_Weekly_TB_Description_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
