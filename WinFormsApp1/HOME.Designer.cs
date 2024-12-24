namespace WinFormsApp1
{
    partial class HOME
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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            label3 = new Label();
            CurrentUser = new Label();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlDarkDark;
            label2.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.MenuText;
            label2.Location = new Point(742, 9);
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
            label1.Location = new Point(152, 24);
            label1.Name = "label1";
            label1.Size = new Size(458, 50);
            label1.TabIndex = 2;
            label1.Text = "Select your choice please";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Navy;
            button1.Location = new Point(96, 194);
            button1.Name = "button1";
            button1.Size = new Size(227, 46);
            button1.TabIndex = 8;
            button1.Text = "DEPOSIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Navy;
            button3.Location = new Point(96, 263);
            button3.Name = "button3";
            button3.Size = new Size(227, 46);
            button3.TabIndex = 10;
            button3.Text = "CHANGE PIN";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Navy;
            button4.Location = new Point(395, 194);
            button4.Name = "button4";
            button4.Size = new Size(215, 46);
            button4.TabIndex = 11;
            button4.Text = "WITHDRAW";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Navy;
            button5.Location = new Point(395, 263);
            button5.Name = "button5";
            button5.Size = new Size(215, 46);
            button5.TabIndex = 12;
            button5.Text = "MINI STATEMENT";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.Navy;
            button6.Location = new Point(96, 327);
            button6.Name = "button6";
            button6.Size = new Size(227, 46);
            button6.TabIndex = 13;
            button6.Text = "BALANCE";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.Navy;
            button7.Location = new Point(281, 392);
            button7.Name = "button7";
            button7.Size = new Size(215, 46);
            button7.TabIndex = 14;
            button7.Text = "LOG OUT";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(27, 119);
            label3.Name = "label3";
            label3.Size = new Size(348, 50);
            label3.TabIndex = 4;
            label3.Text = "Account Number : ";
            // 
            // CurrentUser
            // 
            CurrentUser.AutoSize = true;
            CurrentUser.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CurrentUser.ForeColor = SystemColors.ButtonHighlight;
            CurrentUser.Location = new Point(355, 119);
            CurrentUser.Name = "CurrentUser";
            CurrentUser.Size = new Size(495, 50);
            CurrentUser.TabIndex = 15;
            CurrentUser.Text = "( Sample Account Number)";
            CurrentUser.Click += CurrentUser_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Navy;
            button2.Location = new Point(395, 327);
            button2.Name = "button2";
            button2.Size = new Size(215, 46);
            button2.TabIndex = 16;
            button2.Text = "FAST CASH";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // HOME
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(CurrentUser);
            Controls.Add(label3);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(panel1);
            ForeColor = SystemColors.HighlightText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "HOME";
            Text = "HOME";
            Load += HOME_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label2;
        private Button button7;
        private Label label3;
        private Label CurrentUser;
        private Button button2;
    }
}