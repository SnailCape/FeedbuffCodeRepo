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
            this.Text = "Daily Task";
            form1= frm;
        }
        private void DailyTasks_BTN_Close_Click(object sender, EventArgs e)
        {
            //create here the string for infomation display
            //form1.WeeklyGoals_LB_SetWeeklyGoal.Text
            this.Dispose();
            Form1.Check = false;

        }
    }
}
