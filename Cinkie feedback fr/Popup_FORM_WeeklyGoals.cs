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
    public partial class Popup_FORM_WeeklyGoals : Form
    {
        public Form1 form1;

        public Popup_FORM_WeeklyGoals(Form frm)
        {
            InitializeComponent();
            this.Text = "Weekly Goal"; 
        }

        public void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
