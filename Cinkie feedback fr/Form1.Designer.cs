namespace Cinkie_feedback_fr
{
    partial class Form1
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
            this.BGpanel = new System.Windows.Forms.Panel();
            this.BGflmPull = new System.Windows.Forms.PictureBox();
            this.FLMpanelZUYD = new System.Windows.Forms.PictureBox();
            this.panelFMBDashboard = new System.Windows.Forms.Button();
            this.panelFLMweektaken = new System.Windows.Forms.Button();
            this.FLMpanel = new System.Windows.Forms.Panel();
            this.BGpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BGflmPull)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FLMpanelZUYD)).BeginInit();
            this.FLMpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BGpanel
            // 
            this.BGpanel.BackColor = System.Drawing.Color.Silver;
            this.BGpanel.Controls.Add(this.BGflmPull);
            this.BGpanel.Location = new System.Drawing.Point(1, 0);
            this.BGpanel.Name = "BGpanel";
            this.BGpanel.Size = new System.Drawing.Size(1905, 1043);
            this.BGpanel.TabIndex = 0;
            // 
            // BGflmPull
            // 
            this.BGflmPull.BackColor = System.Drawing.Color.Silver;
            this.BGflmPull.Image = global::Cinkie_feedback_fr.Properties.Resources.LogoZUYDRodeLetters;
            this.BGflmPull.Location = new System.Drawing.Point(0, 12);
            this.BGflmPull.Name = "BGflmPull";
            this.BGflmPull.Size = new System.Drawing.Size(63, 55);
            this.BGflmPull.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BGflmPull.TabIndex = 0;
            this.BGflmPull.TabStop = false;
            this.BGflmPull.Click += new System.EventHandler(this.FLMpbox_Click);
            // 
            // FLMpanelZUYD
            // 
            this.FLMpanelZUYD.Image = global::Cinkie_feedback_fr.Properties.Resources.LogoZUYD1;
            this.FLMpanelZUYD.Location = new System.Drawing.Point(0, 12);
            this.FLMpanelZUYD.Name = "FLMpanelZUYD";
            this.FLMpanelZUYD.Size = new System.Drawing.Size(164, 109);
            this.FLMpanelZUYD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FLMpanelZUYD.TabIndex = 0;
            this.FLMpanelZUYD.TabStop = false;
            this.FLMpanelZUYD.Click += new System.EventHandler(this.FLMpanelZUYD_Click);
            // 
            // panelFMBDashboard
            // 
            this.panelFMBDashboard.BackColor = System.Drawing.Color.Red;
            this.panelFMBDashboard.BackgroundImage = global::Cinkie_feedback_fr.Properties.Resources.HomeIcon;
            this.panelFMBDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelFMBDashboard.FlatAppearance.BorderSize = 0;
            this.panelFMBDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.panelFMBDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelFMBDashboard.ForeColor = System.Drawing.Color.Transparent;
            this.panelFMBDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.panelFMBDashboard.Location = new System.Drawing.Point(0, 136);
            this.panelFMBDashboard.Name = "panelFMBDashboard";
            this.panelFMBDashboard.Size = new System.Drawing.Size(164, 77);
            this.panelFMBDashboard.TabIndex = 1;
            this.panelFMBDashboard.Text = "Dashboard";
            this.panelFMBDashboard.UseVisualStyleBackColor = false;
            // 
            // panelFLMweektaken
            // 
            this.panelFLMweektaken.BackgroundImage = global::Cinkie_feedback_fr.Properties.Resources.pngegg;
            this.panelFLMweektaken.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelFLMweektaken.FlatAppearance.BorderSize = 0;
            this.panelFLMweektaken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.panelFLMweektaken.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelFLMweektaken.ForeColor = System.Drawing.Color.Transparent;
            this.panelFLMweektaken.Location = new System.Drawing.Point(0, 238);
            this.panelFLMweektaken.Name = "panelFLMweektaken";
            this.panelFLMweektaken.Size = new System.Drawing.Size(164, 77);
            this.panelFLMweektaken.TabIndex = 2;
            this.panelFLMweektaken.Text = "Weektaken";
            this.panelFLMweektaken.UseVisualStyleBackColor = true;
            // 
            // FLMpanel
            // 
            this.FLMpanel.BackColor = System.Drawing.Color.Red;
            this.FLMpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FLMpanel.Controls.Add(this.panelFLMweektaken);
            this.FLMpanel.Controls.Add(this.panelFMBDashboard);
            this.FLMpanel.Controls.Add(this.FLMpanelZUYD);
            this.FLMpanel.Location = new System.Drawing.Point(1, 12);
            this.FLMpanel.Name = "FLMpanel";
            this.FLMpanel.Size = new System.Drawing.Size(167, 939);
            this.FLMpanel.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.FLMpanel);
            this.Controls.Add(this.BGpanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BGpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BGflmPull)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FLMpanelZUYD)).EndInit();
            this.FLMpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel BGpanel;
        private System.Windows.Forms.PictureBox BGflmPull;
        private System.Windows.Forms.PictureBox FLMpanelZUYD;
        private System.Windows.Forms.Button panelFMBDashboard;
        private System.Windows.Forms.Button panelFLMweektaken;
        private System.Windows.Forms.Panel FLMpanel;
    }
}

