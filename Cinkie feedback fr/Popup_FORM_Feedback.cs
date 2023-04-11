using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinkie_feedback_fr
{
    public partial class Popup_FORM_Feedback : Form
    {
        public Form1 form1;

        public Popup_FORM_Feedback(Form1 frm)
        {
            InitializeComponent();
            this.Text = "Register Feedback";
            form1 = frm;
        }

        private void PopUpFB_BT_SaveFeedbackButton_Click(object sender, EventArgs e)
        {
           
        }

        private void PopUpFB_BT_CancelFeedbackButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form1.Check = false;
        }
    }
}
