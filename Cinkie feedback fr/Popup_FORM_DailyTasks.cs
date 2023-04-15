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
            this.Text = "Daily Task";
            form1= frm;
        }
        private void DailyTasks_BTN_Close_Click(object sender, EventArgs e)
        {
            WeeklyGoal weeklyGoal = new WeeklyGoal();

            // Collect all data from form
            string status = PopupDaily_CB_Status.SelectedItem.ToString();
            string title = PopupDaily_TB_Title.Text;
            string description = PopupDaily_TB_Description.Text;
            //string oe = PopupDaily_CB_OE.SelectedItem.ToString();
            string time = PopupDaily_LB_Time.Text;
            string priority = PopupDaily_CB_Priority.SelectedItem.ToString();
            string difficulty = PopupDaily_CB_Difficulty.SelectedItem.ToString();
            string type = PopupDaily_CB_Type.SelectedItem.ToString();
            string weeklyGoalId = PopupDaily_CB_WeeklyTask.SelectedItem.ToString();
            int goalId = 0;

            string message = type;
            MessageBox.Show(message, "tester popupform");
            //create here the string for infomation display
            if (Form1.EditCheck == true)
            {
                foreach (WeeklyGoal goal in weeklyGoal.GetWeeklyGoalsFromDB())
                {
                    if (weeklyGoalId.Contains(goal.WeeklyGoalId.ToString()))
                    {
                        goalId = goal.WeeklyGoalId;
                    }
                }
                form1.WeeklyGoalPanel_LV_ShowAll.Clear();                         
                form1.UpdateDailyTask(status, title, description, goalId, time, priority, difficulty, type);
            }
            else
            {
                // levi's create functie HIER: [zie hieronder] 
                //foreach (WeeklyGoal goal in weeklyGoal.GetWeeklyGoalsFromDB())
                //{
                  //  if (weeklyGoalId.Contains(goal.WeeklyGoalId.ToString()))
                   // {
                    //    goalId = goal.WeeklyGoalId;
                  //  }
              //  }

              //  form1.CreateDailyTask(status, title, description, goalId, time, priority, difficulty, type);
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
