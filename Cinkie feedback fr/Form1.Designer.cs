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
            this.components = new System.ComponentModel.Container();
            this.FLMpanel = new System.Windows.Forms.Panel();
            this.BGpanel = new System.Windows.Forms.Panel();
            this.FLMpbox = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.FLMpanel.SuspendLayout();
            this.BGpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FLMpbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // FLMpanel
            // 
            this.FLMpanel.BackColor = System.Drawing.Color.Red;
            this.FLMpanel.Controls.Add(this.panel1);
            this.FLMpanel.Location = new System.Drawing.Point(1, 0);
            this.FLMpanel.Name = "FLMpanel";
            this.FLMpanel.Size = new System.Drawing.Size(187, 1080);
            this.FLMpanel.TabIndex = 0;
            // 
            // BGpanel
            // 
            this.BGpanel.BackColor = System.Drawing.Color.Silver;
            this.BGpanel.Controls.Add(this.FLMpbox);
            this.BGpanel.Location = new System.Drawing.Point(194, 0);
            this.BGpanel.Name = "BGpanel";
            this.BGpanel.Size = new System.Drawing.Size(1842, 1043);
            this.BGpanel.TabIndex = 0;
            // 
            // FLMpbox
            // 
            this.FLMpbox.BackColor = System.Drawing.Color.Silver;
            this.FLMpbox.Image = global::Cinkie_feedback_fr.Properties.Resources.LogoZUYD;
            this.FLMpbox.Location = new System.Drawing.Point(0, 0);
            this.FLMpbox.Name = "FLMpbox";
            this.FLMpbox.Size = new System.Drawing.Size(112, 105);
            this.FLMpbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FLMpbox.TabIndex = 0;
            this.FLMpbox.TabStop = false;
            this.FLMpbox.Click += new System.EventHandler(this.FLMpbox_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(11, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 100);
            this.panel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.BGpanel);
            this.Controls.Add(this.FLMpanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FLMpanel.ResumeLayout(false);
            this.BGpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FLMpbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FLMpanel;
        private System.Windows.Forms.Panel BGpanel;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.PictureBox FLMpbox;
        private System.Windows.Forms.Panel panel1;
    }
}

