namespace Cinkie_feedback_fr
{
    partial class Popup_FORM_WeeklyGoals
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Goal_TB_Title = new System.Windows.Forms.TextBox();
            this.WG_LB_Title = new System.Windows.Forms.Label();
            this.WB_TB_Desc = new System.Windows.Forms.Label();
            this.WG_TB_Description = new System.Windows.Forms.TextBox();
            this.WG_BTN_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Goal_TB_Title
            // 
            this.Goal_TB_Title.Location = new System.Drawing.Point(51, 60);
            this.Goal_TB_Title.Name = "Goal_TB_Title";
            this.Goal_TB_Title.Size = new System.Drawing.Size(462, 22);
            this.Goal_TB_Title.TabIndex = 1;
            // 
            // WG_LB_Title
            // 
            this.WG_LB_Title.AutoSize = true;
            this.WG_LB_Title.Location = new System.Drawing.Point(48, 41);
            this.WG_LB_Title.Name = "WG_LB_Title";
            this.WG_LB_Title.Size = new System.Drawing.Size(65, 16);
            this.WG_LB_Title.TabIndex = 2;
            this.WG_LB_Title.Text = "Goal Title";
            // 
            // WB_TB_Desc
            // 
            this.WB_TB_Desc.AutoSize = true;
            this.WB_TB_Desc.Location = new System.Drawing.Point(48, 112);
            this.WB_TB_Desc.Name = "WB_TB_Desc";
            this.WB_TB_Desc.Size = new System.Drawing.Size(75, 16);
            this.WB_TB_Desc.TabIndex = 3;
            this.WB_TB_Desc.Text = "Description";
            // 
            // WG_TB_Description
            // 
            this.WG_TB_Description.Location = new System.Drawing.Point(51, 131);
            this.WG_TB_Description.Multiline = true;
            this.WG_TB_Description.Name = "WG_TB_Description";
            this.WG_TB_Description.Size = new System.Drawing.Size(462, 94);
            this.WG_TB_Description.TabIndex = 4;
            // 
            // WG_BTN_Add
            // 
            this.WG_BTN_Add.Location = new System.Drawing.Point(650, 382);
            this.WG_BTN_Add.Name = "WG_BTN_Add";
            this.WG_BTN_Add.Size = new System.Drawing.Size(138, 56);
            this.WG_BTN_Add.TabIndex = 5;
            this.WG_BTN_Add.Text = "Confirm";
            this.WG_BTN_Add.UseVisualStyleBackColor = true;
            this.WG_BTN_Add.Click += new System.EventHandler(this.WG_BTN_Add_Click);
            // 
            // Popup_FORM_WeeklyGoals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WG_BTN_Add);
            this.Controls.Add(this.WG_TB_Description);
            this.Controls.Add(this.WB_TB_Desc);
            this.Controls.Add(this.WG_LB_Title);
            this.Controls.Add(this.Goal_TB_Title);
            this.Name = "Popup_FORM_WeeklyGoals";
            this.Text = "Popup_FORM_WeeklyGoals";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label WG_LB_Title;
        private System.Windows.Forms.Label WB_TB_Desc;
        public System.Windows.Forms.TextBox Goal_TB_Title;
        public System.Windows.Forms.TextBox WG_TB_Description;
        private System.Windows.Forms.Button WG_BTN_Add;
    }
}