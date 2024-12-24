namespace WinFormsApp1
{
    partial class Balance
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
            panel1 = new Panel();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            CurUser = new Label();
            CurUserBalance = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlDarkDark;
            label2.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.MenuText;
            label2.Location = new Point(846, 9);
            label2.Name = "label2";
            label2.Size = new Size(46, 50);
            label2.TabIndex = 3;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(907, 67);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(265, 9);
            label1.Name = "label1";
            label1.Size = new Size(352, 50);
            label1.TabIndex = 2;
            label1.Text = "ATM APPLICATION";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(135, 135);
            label3.Name = "label3";
            label3.Size = new Size(338, 45);
            label3.TabIndex = 8;
            label3.Text = "ACCOUNT NUMBER :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(135, 236);
            label4.Name = "label4";
            label4.Size = new Size(279, 45);
            label4.TabIndex = 9;
            label4.Text = "YOUR BALANCE :";
            // 
            // CurUser
            // 
            CurUser.AutoSize = true;
            CurUser.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CurUser.ForeColor = SystemColors.ButtonHighlight;
            CurUser.Location = new Point(507, 135);
            CurUser.Name = "CurUser";
            CurUser.Size = new Size(256, 45);
            CurUser.TabIndex = 10;
            CurUser.Text = "Sample number";
            CurUser.Click += label5_Click;
            // 
            // CurUserBalance
            // 
            CurUserBalance.AutoSize = true;
            CurUserBalance.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CurUserBalance.ForeColor = SystemColors.ButtonHighlight;
            CurUserBalance.Location = new Point(450, 236);
            CurUserBalance.Name = "CurUserBalance";
            CurUserBalance.Size = new Size(253, 45);
            CurUserBalance.TabIndex = 11;
            CurUserBalance.Text = "Sample ( 5000 )";
            CurUserBalance.Click += label6_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Navy;
            button1.Location = new Point(354, 331);
            button1.Name = "button1";
            button1.Size = new Size(244, 57);
            button1.TabIndex = 13;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Balance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(907, 472);
            Controls.Add(button1);
            Controls.Add(CurUserBalance);
            Controls.Add(CurUser);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Balance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Balance";
            Load += Balance_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label CurUser;
        private Label CurUserBalance;
        private Button button1;
    }
}