namespace WinFormsApp1
{
    partial class Account
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
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            AccNumTb = new TextBox();
            AccNameTb = new TextBox();
            AccFname = new TextBox();
            AddressTb = new TextBox();
            PhoneTb = new TextBox();
            OccupationTb = new TextBox();
            PinTb = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label12 = new Label();
            SubmitBtn = new Button();
            LogoutBtn = new Button();
            EducationCb = new ComboBox();
            DOBdate = new DateTimePicker();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlDarkDark;
            label2.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.MenuText;
            label2.Location = new Point(762, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 50);
            label2.TabIndex = 3;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(204, 0);
            label1.Name = "label1";
            label1.Size = new Size(352, 50);
            label1.TabIndex = 2;
            label1.Text = "ATM APPLICATION";
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(820, 53);
            panel1.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(57, 56);
            label3.Name = "label3";
            label3.Size = new Size(165, 25);
            label3.TabIndex = 4;
            label3.Text = "Account Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(57, 120);
            label4.Name = "label4";
            label4.Size = new Size(64, 25);
            label4.TabIndex = 24;
            label4.Text = "Name";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(57, 184);
            label5.Name = "label5";
            label5.Size = new Size(137, 25);
            label5.TabIndex = 25;
            label5.Text = "Father's Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(57, 248);
            label6.Name = "label6";
            label6.Size = new Size(83, 25);
            label6.TabIndex = 26;
            label6.Text = "Address";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(57, 312);
            label7.Name = "label7";
            label7.Size = new Size(148, 25);
            label7.TabIndex = 27;
            label7.Text = "Phone Number";
            // 
            // AccNumTb
            // 
            AccNumTb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AccNumTb.Location = new Point(57, 84);
            AccNumTb.Name = "AccNumTb";
            AccNumTb.Size = new Size(314, 33);
            AccNumTb.TabIndex = 28;
            // 
            // AccNameTb
            // 
            AccNameTb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AccNameTb.Location = new Point(57, 148);
            AccNameTb.Name = "AccNameTb";
            AccNameTb.Size = new Size(314, 33);
            AccNameTb.TabIndex = 29;
            // 
            // AccFname
            // 
            AccFname.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AccFname.Location = new Point(57, 212);
            AccFname.Name = "AccFname";
            AccFname.Size = new Size(314, 33);
            AccFname.TabIndex = 30;
            // 
            // AddressTb
            // 
            AddressTb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddressTb.Location = new Point(57, 276);
            AddressTb.Name = "AddressTb";
            AddressTb.Size = new Size(314, 33);
            AddressTb.TabIndex = 31;
            // 
            // PhoneTb
            // 
            PhoneTb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PhoneTb.Location = new Point(57, 340);
            PhoneTb.Name = "PhoneTb";
            PhoneTb.Size = new Size(314, 33);
            PhoneTb.TabIndex = 32;
            // 
            // OccupationTb
            // 
            OccupationTb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OccupationTb.Location = new Point(442, 212);
            OccupationTb.Name = "OccupationTb";
            OccupationTb.Size = new Size(314, 33);
            OccupationTb.TabIndex = 41;
            // 
            // PinTb
            // 
            PinTb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PinTb.Location = new Point(442, 84);
            PinTb.Name = "PinTb";
            PinTb.Size = new Size(314, 33);
            PinTb.TabIndex = 38;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(442, 248);
            label8.Name = "label8";
            label8.Size = new Size(52, 25);
            label8.TabIndex = 37;
            label8.Text = "DOB";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(442, 184);
            label9.Name = "label9";
            label9.Size = new Size(114, 25);
            label9.TabIndex = 36;
            label9.Text = "Occupation";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(442, 120);
            label10.Name = "label10";
            label10.Size = new Size(101, 25);
            label10.TabIndex = 35;
            label10.Text = "Education";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(442, 56);
            label12.Name = "label12";
            label12.Size = new Size(45, 25);
            label12.TabIndex = 33;
            label12.Text = "PIN";
            // 
            // SubmitBtn
            // 
            SubmitBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SubmitBtn.ForeColor = Color.Navy;
            SubmitBtn.Location = new Point(213, 400);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(178, 46);
            SubmitBtn.TabIndex = 43;
            SubmitBtn.Text = "SUBMIT";
            SubmitBtn.UseVisualStyleBackColor = true;
            SubmitBtn.Click += LoginBtn_Click;
            // 
            // LogoutBtn
            // 
            LogoutBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogoutBtn.ForeColor = Color.Navy;
            LogoutBtn.Location = new Point(413, 400);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(178, 46);
            LogoutBtn.TabIndex = 44;
            LogoutBtn.Text = "LOG OUT";
            LogoutBtn.UseVisualStyleBackColor = true;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // EducationCb
            // 
            EducationCb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EducationCb.FormattingEnabled = true;
            EducationCb.Items.AddRange(new object[] { "Non Graduate", "Under Graduate", "Post Graduate" });
            EducationCb.Location = new Point(442, 148);
            EducationCb.Name = "EducationCb";
            EducationCb.Size = new Size(314, 33);
            EducationCb.TabIndex = 45;
            // 
            // DOBdate
            // 
            DOBdate.CalendarFont = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DOBdate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DOBdate.Location = new Point(442, 276);
            DOBdate.Name = "DOBdate";
            DOBdate.Size = new Size(314, 33);
            DOBdate.TabIndex = 46;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(820, 458);
            Controls.Add(DOBdate);
            Controls.Add(EducationCb);
            Controls.Add(LogoutBtn);
            Controls.Add(SubmitBtn);
            Controls.Add(OccupationTb);
            Controls.Add(PinTb);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label12);
            Controls.Add(PhoneTb);
            Controls.Add(AddressTb);
            Controls.Add(AccFname);
            Controls.Add(AccNameTb);
            Controls.Add(AccNumTb);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            ForeColor = Color.DarkGreen;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Account";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Account";
            Load += Account_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox AccNumTb;
        private TextBox AccNameTb;
        private TextBox AccFname;
        private TextBox AddressTb;
        private TextBox PhoneTb;
        private TextBox OccupationTb;
        private TextBox PinTb;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label12;
        private Button SubmitBtn;
        private Button LogoutBtn;
        private ComboBox EducationCb;
        private DateTimePicker DOBdate;
    }
}