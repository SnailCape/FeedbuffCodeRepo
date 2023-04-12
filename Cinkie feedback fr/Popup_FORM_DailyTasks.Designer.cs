namespace Cinkie_feedback_fr
{
    partial class Popup_FORM_DailyTasks
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
            this.DailyTasks_BTN_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DailyTasks_BTN_Close
            // 
            this.DailyTasks_BTN_Close.Location = new System.Drawing.Point(650, 379);
            this.DailyTasks_BTN_Close.Name = "DailyTasks_BTN_Close";
            this.DailyTasks_BTN_Close.Size = new System.Drawing.Size(110, 45);
            this.DailyTasks_BTN_Close.TabIndex = 0;
            this.DailyTasks_BTN_Close.Text = "Close";
            this.DailyTasks_BTN_Close.UseVisualStyleBackColor = true;
            this.DailyTasks_BTN_Close.Click += new System.EventHandler(this.DailyTasks_BTN_Close_Click);
            // 
            // Popup_FORM_DailyTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DailyTasks_BTN_Close);
            this.Name = "Popup_FORM_DailyTasks";
            this.Text = "Popup_FORM_DailyTasks";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DailyTasks_BTN_Close;

    }
}