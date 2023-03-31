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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BGpanel = new System.Windows.Forms.Panel();
            this.FLMpbox = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Login_Panel = new System.Windows.Forms.Panel();
            this.LoginPanel_LB_Coeus = new System.Windows.Forms.Label();
            this.PanelLogin_BT_Login = new System.Windows.Forms.Button();
            this.PanelLogin_LLB_PasswordFOR = new System.Windows.Forms.LinkLabel();
            this.LoginPanel_LB_Password = new System.Windows.Forms.Label();
            this.PanelLogin_TB_Password = new System.Windows.Forms.TextBox();
            this.PanelLogin_LB_Email = new System.Windows.Forms.Label();
            this.PanelLogin_TB_Email = new System.Windows.Forms.TextBox();
            this.FLMpanel.SuspendLayout();
            this.BGpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FLMpbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.Login_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FLMpanel
            // 
            this.FLMpanel.BackColor = System.Drawing.Color.Red;
            this.FLMpanel.Controls.Add(this.panel1);
            this.FLMpanel.Location = new System.Drawing.Point(1, 0);
            this.FLMpanel.Margin = new System.Windows.Forms.Padding(4);
            this.FLMpanel.Name = "FLMpanel";
            this.FLMpanel.Size = new System.Drawing.Size(249, 1329);
            this.FLMpanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(15, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 123);
            this.panel1.TabIndex = 0;
            // 
            // BGpanel
            // 
            this.BGpanel.BackColor = System.Drawing.Color.Silver;
            this.BGpanel.Controls.Add(this.FLMpbox);
            this.BGpanel.Location = new System.Drawing.Point(259, 0);
            this.BGpanel.Margin = new System.Windows.Forms.Padding(4);
            this.BGpanel.Name = "BGpanel";
            this.BGpanel.Size = new System.Drawing.Size(2456, 1284);
            this.BGpanel.TabIndex = 0;
            // 
            // FLMpbox
            // 
            this.FLMpbox.BackColor = System.Drawing.Color.Silver;
            this.FLMpbox.Image = global::Cinkie_feedback_fr.Properties.Resources.LogoZUYD;
            this.FLMpbox.Location = new System.Drawing.Point(0, 0);
            this.FLMpbox.Margin = new System.Windows.Forms.Padding(4);
            this.FLMpbox.Name = "FLMpbox";
            this.FLMpbox.Size = new System.Drawing.Size(149, 129);
            this.FLMpbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FLMpbox.TabIndex = 0;
            this.FLMpbox.TabStop = false;
            this.FLMpbox.Click += new System.EventHandler(this.FLMpbox_Click);
            // 
            // Login_Panel
            // 
            this.Login_Panel.BackColor = System.Drawing.Color.Silver;
            this.Login_Panel.Controls.Add(this.LoginPanel_LB_Coeus);
            this.Login_Panel.Controls.Add(this.PanelLogin_BT_Login);
            this.Login_Panel.Controls.Add(this.PanelLogin_LLB_PasswordFOR);
            this.Login_Panel.Controls.Add(this.LoginPanel_LB_Password);
            this.Login_Panel.Controls.Add(this.PanelLogin_TB_Password);
            this.Login_Panel.Controls.Add(this.PanelLogin_LB_Email);
            this.Login_Panel.Controls.Add(this.PanelLogin_TB_Email);
            this.Login_Panel.Location = new System.Drawing.Point(0, 0);
            this.Login_Panel.Name = "Login_Panel";
            this.Login_Panel.Size = new System.Drawing.Size(2542, 1281);
            this.Login_Panel.TabIndex = 1;
            // 
            // LoginPanel_LB_Coeus
            // 
            this.LoginPanel_LB_Coeus.AutoSize = true;
            this.LoginPanel_LB_Coeus.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPanel_LB_Coeus.Location = new System.Drawing.Point(1189, 295);
            this.LoginPanel_LB_Coeus.Name = "LoginPanel_LB_Coeus";
            this.LoginPanel_LB_Coeus.Size = new System.Drawing.Size(132, 42);
            this.LoginPanel_LB_Coeus.TabIndex = 6;
            this.LoginPanel_LB_Coeus.Text = "Coeus";
            // 
            // PanelLogin_BT_Login
            // 
            this.PanelLogin_BT_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelLogin_BT_Login.Location = new System.Drawing.Point(1107, 880);
            this.PanelLogin_BT_Login.Name = "PanelLogin_BT_Login";
            this.PanelLogin_BT_Login.Size = new System.Drawing.Size(314, 57);
            this.PanelLogin_BT_Login.TabIndex = 5;
            this.PanelLogin_BT_Login.Text = "Login";
            this.PanelLogin_BT_Login.UseVisualStyleBackColor = true;
            this.PanelLogin_BT_Login.Click += new System.EventHandler(this.PanelLogin_BT_Login_Click);
            // 
            // PanelLogin_LLB_PasswordFOR
            // 
            this.PanelLogin_LLB_PasswordFOR.AutoSize = true;
            this.PanelLogin_LLB_PasswordFOR.Location = new System.Drawing.Point(1050, 807);
            this.PanelLogin_LLB_PasswordFOR.Name = "PanelLogin_LLB_PasswordFOR";
            this.PanelLogin_LLB_PasswordFOR.Size = new System.Drawing.Size(134, 16);
            this.PanelLogin_LLB_PasswordFOR.TabIndex = 4;
            this.PanelLogin_LLB_PasswordFOR.TabStop = true;
            this.PanelLogin_LLB_PasswordFOR.Text = "Password Forgotten?";
            this.PanelLogin_LLB_PasswordFOR.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PanelLogin_LLB_PasswordFOR_LinkClicked);
            // 
            // LoginPanel_LB_Password
            // 
            this.LoginPanel_LB_Password.AutoSize = true;
            this.LoginPanel_LB_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPanel_LB_Password.Location = new System.Drawing.Point(1048, 705);
            this.LoginPanel_LB_Password.Name = "LoginPanel_LB_Password";
            this.LoginPanel_LB_Password.Size = new System.Drawing.Size(98, 25);
            this.LoginPanel_LB_Password.TabIndex = 3;
            this.LoginPanel_LB_Password.Text = "Password";
            // 
            // PanelLogin_TB_Password
            // 
            this.PanelLogin_TB_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelLogin_TB_Password.Location = new System.Drawing.Point(1039, 743);
            this.PanelLogin_TB_Password.Multiline = true;
            this.PanelLogin_TB_Password.Name = "PanelLogin_TB_Password";
            this.PanelLogin_TB_Password.PasswordChar = '*';
            this.PanelLogin_TB_Password.Size = new System.Drawing.Size(448, 40);
            this.PanelLogin_TB_Password.TabIndex = 2;
            // 
            // PanelLogin_LB_Email
            // 
            this.PanelLogin_LB_Email.AutoSize = true;
            this.PanelLogin_LB_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelLogin_LB_Email.Location = new System.Drawing.Point(1048, 472);
            this.PanelLogin_LB_Email.Name = "PanelLogin_LB_Email";
            this.PanelLogin_LB_Email.Size = new System.Drawing.Size(68, 25);
            this.PanelLogin_LB_Email.TabIndex = 1;
            this.PanelLogin_LB_Email.Text = "E-Mail";
            // 
            // PanelLogin_TB_Email
            // 
            this.PanelLogin_TB_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelLogin_TB_Email.Location = new System.Drawing.Point(1039, 515);
            this.PanelLogin_TB_Email.Multiline = true;
            this.PanelLogin_TB_Email.Name = "PanelLogin_TB_Email";
            this.PanelLogin_TB_Email.Size = new System.Drawing.Size(448, 40);
            this.PanelLogin_TB_Email.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2539, 1281);
            this.Controls.Add(this.Login_Panel);
            this.Controls.Add(this.FLMpanel);
            this.Controls.Add(this.BGpanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FLMpanel.ResumeLayout(false);
            this.BGpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FLMpbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.Login_Panel.ResumeLayout(false);
            this.Login_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FLMpanel;
        private System.Windows.Forms.Panel BGpanel;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.PictureBox FLMpbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Login_Panel;
        private System.Windows.Forms.Label PanelLogin_LB_Email;
        private System.Windows.Forms.TextBox PanelLogin_TB_Email;
        private System.Windows.Forms.Label LoginPanel_LB_Password;
        private System.Windows.Forms.TextBox PanelLogin_TB_Password;
        private System.Windows.Forms.LinkLabel PanelLogin_LLB_PasswordFOR;
        private System.Windows.Forms.Button PanelLogin_BT_Login;
        private System.Windows.Forms.Label LoginPanel_LB_Coeus;
    }
}

