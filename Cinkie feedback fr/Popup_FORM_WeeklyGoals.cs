﻿using System;
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
    public partial class Popup_FORM_WeeklyGoals : Form
    {
        public Form1 form1;

        public Popup_FORM_WeeklyGoals(Form1 frm)
        {
            InitializeComponent();
            this.Text = "Weekly Goal";
            form1= frm;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form1.Check = false;
            
        }

        private void WG_BTN_Add_Click(object sender, EventArgs e)
        {
            form1.WeeklyGoals_LB_SetWeeklyGoal.Text = Goal_TB_Title.Text + " " + WG_TB_Description.Text;

            this.Dispose();
            Form1.Check = false;

        }
    }
}
