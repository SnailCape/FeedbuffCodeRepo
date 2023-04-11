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
            this.WG_BTN_Add = new System.Windows.Forms.Button();
            this.PopUpForm_Weekly_TB_Title = new System.Windows.Forms.TextBox();
            this.PopUpForm_Weekly_TB_Description = new System.Windows.Forms.TextBox();
            this.PopUpForm_Weekly_TB_Agenda = new System.Windows.Forms.TextBox();
            this.PopUpForm_Weekly_CB_Status = new System.Windows.Forms.ComboBox();
            this.PopUpForm_Weekly_TB_Status = new System.Windows.Forms.TextBox();
            this.PopUpForm_Weekly_LB_Status = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WG_BTN_Add
            // 
            this.WG_BTN_Add.Location = new System.Drawing.Point(637, 624);
            this.WG_BTN_Add.Name = "WG_BTN_Add";
            this.WG_BTN_Add.Size = new System.Drawing.Size(138, 56);
            this.WG_BTN_Add.TabIndex = 5;
            this.WG_BTN_Add.Text = "Save and Exit";
            this.WG_BTN_Add.UseVisualStyleBackColor = true;
            this.WG_BTN_Add.Click += new System.EventHandler(this.WG_BTN_Add_Click);
            // 
            // PopUpForm_Weekly_TB_Title
            // 
            this.PopUpForm_Weekly_TB_Title.BackColor = System.Drawing.SystemColors.Control;
            this.PopUpForm_Weekly_TB_Title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PopUpForm_Weekly_TB_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopUpForm_Weekly_TB_Title.Location = new System.Drawing.Point(42, 27);
            this.PopUpForm_Weekly_TB_Title.Multiline = true;
            this.PopUpForm_Weekly_TB_Title.Name = "PopUpForm_Weekly_TB_Title";
            this.PopUpForm_Weekly_TB_Title.Size = new System.Drawing.Size(379, 55);
            this.PopUpForm_Weekly_TB_Title.TabIndex = 6;
            this.PopUpForm_Weekly_TB_Title.Text = "Title";
            // 
            // PopUpForm_Weekly_TB_Description
            // 
            this.PopUpForm_Weekly_TB_Description.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PopUpForm_Weekly_TB_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopUpForm_Weekly_TB_Description.Location = new System.Drawing.Point(25, 88);
            this.PopUpForm_Weekly_TB_Description.Multiline = true;
            this.PopUpForm_Weekly_TB_Description.Name = "PopUpForm_Weekly_TB_Description";
            this.PopUpForm_Weekly_TB_Description.Size = new System.Drawing.Size(766, 158);
            this.PopUpForm_Weekly_TB_Description.TabIndex = 7;
            this.PopUpForm_Weekly_TB_Description.Text = "Discription of the weekly goal that has been set.";
            // 
            // PopUpForm_Weekly_TB_Agenda
            // 
            this.PopUpForm_Weekly_TB_Agenda.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PopUpForm_Weekly_TB_Agenda.Enabled = false;
            this.PopUpForm_Weekly_TB_Agenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopUpForm_Weekly_TB_Agenda.Location = new System.Drawing.Point(530, 26);
            this.PopUpForm_Weekly_TB_Agenda.Multiline = true;
            this.PopUpForm_Weekly_TB_Agenda.Name = "PopUpForm_Weekly_TB_Agenda";
            this.PopUpForm_Weekly_TB_Agenda.Size = new System.Drawing.Size(245, 41);
            this.PopUpForm_Weekly_TB_Agenda.TabIndex = 8;
            this.PopUpForm_Weekly_TB_Agenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PopUpForm_Weekly_CB_Status
            // 
            this.PopUpForm_Weekly_CB_Status.BackColor = System.Drawing.SystemColors.Window;
            this.PopUpForm_Weekly_CB_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PopUpForm_Weekly_CB_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopUpForm_Weekly_CB_Status.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PopUpForm_Weekly_CB_Status.FormattingEnabled = true;
            this.PopUpForm_Weekly_CB_Status.Items.AddRange(new object[] {
            "Done ✅",
            "In Progress 🔨",
            "Not Started ⏳"});
            this.PopUpForm_Weekly_CB_Status.Location = new System.Drawing.Point(127, 313);
            this.PopUpForm_Weekly_CB_Status.Name = "PopUpForm_Weekly_CB_Status";
            this.PopUpForm_Weekly_CB_Status.Size = new System.Drawing.Size(157, 28);
            this.PopUpForm_Weekly_CB_Status.TabIndex = 9;
            // 
            // PopUpForm_Weekly_TB_Status
            // 
            this.PopUpForm_Weekly_TB_Status.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PopUpForm_Weekly_TB_Status.Enabled = false;
            this.PopUpForm_Weekly_TB_Status.Location = new System.Drawing.Point(25, 283);
            this.PopUpForm_Weekly_TB_Status.Multiline = true;
            this.PopUpForm_Weekly_TB_Status.Name = "PopUpForm_Weekly_TB_Status";
            this.PopUpForm_Weekly_TB_Status.Size = new System.Drawing.Size(280, 279);
            this.PopUpForm_Weekly_TB_Status.TabIndex = 10;
            // 
            // PopUpForm_Weekly_LB_Status
            // 
            this.PopUpForm_Weekly_LB_Status.AutoSize = true;
            this.PopUpForm_Weekly_LB_Status.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PopUpForm_Weekly_LB_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopUpForm_Weekly_LB_Status.Location = new System.Drawing.Point(39, 312);
            this.PopUpForm_Weekly_LB_Status.Name = "PopUpForm_Weekly_LB_Status";
            this.PopUpForm_Weekly_LB_Status.Size = new System.Drawing.Size(68, 25);
            this.PopUpForm_Weekly_LB_Status.TabIndex = 11;
            this.PopUpForm_Weekly_LB_Status.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Priority";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Difficulty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 501);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Type";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Urgent ⚠️",
            "High 🪂",
            "Medium 🐄",
            "Low 🐇"});
            this.comboBox1.Location = new System.Drawing.Point(127, 378);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 28);
            this.comboBox1.TabIndex = 15;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Hard 🦑",
            "Medium 🦍",
            "Low 🐇"});
            this.comboBox2.Location = new System.Drawing.Point(127, 442);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(157, 28);
            this.comboBox2.TabIndex = 16;
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Learning 📚",
            "Work 🔨",
            "Documentation 📃",
            "Lesson 🎓"});
            this.comboBox3.Location = new System.Drawing.Point(127, 501);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(157, 28);
            this.comboBox3.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(346, 283);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(445, 58);
            this.textBox1.TabIndex = 18;
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "B1F5",
            "B1C3",
            "B1A3"});
            this.comboBox4.Location = new System.Drawing.Point(592, 300);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(159, 24);
            this.comboBox4.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(375, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Onderwijs Eenheid";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(346, 359);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(445, 58);
            this.textBox2.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(375, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Casus";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox3.Location = new System.Drawing.Point(463, 377);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(312, 22);
            this.textBox3.TabIndex = 23;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(346, 438);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(445, 101);
            this.textBox4.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(375, 478);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "NOTE";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox5.Location = new System.Drawing.Point(463, 453);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(312, 73);
            this.textBox5.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(540, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 22);
            this.label7.TabIndex = 27;
            this.label7.Text = "Agenda";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(619, 36);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(132, 21);
            this.textBox6.TabIndex = 28;
            this.textBox6.Text = "Blok 3 Week 8";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(25, 672);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 29);
            this.label8.TabIndex = 29;
            this.label8.Text = "Start date: 01/01/2000";
            // 
            // Popup_FORM_WeeklyGoals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(815, 710);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PopUpForm_Weekly_LB_Status);
            this.Controls.Add(this.PopUpForm_Weekly_CB_Status);
            this.Controls.Add(this.PopUpForm_Weekly_TB_Agenda);
            this.Controls.Add(this.PopUpForm_Weekly_TB_Description);
            this.Controls.Add(this.PopUpForm_Weekly_TB_Title);
            this.Controls.Add(this.WG_BTN_Add);
            this.Controls.Add(this.PopUpForm_Weekly_TB_Status);
            this.Name = "Popup_FORM_WeeklyGoals";
            this.Text = "Popup_FORM_WeeklyGoals";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button WG_BTN_Add;
        private System.Windows.Forms.TextBox PopUpForm_Weekly_TB_Title;
        private System.Windows.Forms.TextBox PopUpForm_Weekly_TB_Description;
        private System.Windows.Forms.TextBox PopUpForm_Weekly_TB_Agenda;
        private System.Windows.Forms.ComboBox PopUpForm_Weekly_CB_Status;
        private System.Windows.Forms.TextBox PopUpForm_Weekly_TB_Status;
        private System.Windows.Forms.Label PopUpForm_Weekly_LB_Status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
    }
}