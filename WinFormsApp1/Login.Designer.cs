namespace WinFormsApp1
{
    partial class Login
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
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            AccNumTb = new TextBox();
            PinTb = new TextBox();
            LoginBtn = new Button();
            SignupBtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlDarkDark;
            label5.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.MenuText;
            label5.Location = new Point(742, 9);
            label5.Name = "label5";
            label5.Size = new Size(46, 50);
            label5.TabIndex = 4;
            label5.Text = "X";
            label5.Click += label5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(243, 25);
            label1.Name = "label1";
            label1.Size = new Size(314, 50);
            label1.TabIndex = 1;
            label1.Text = "ATM Application\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(270, 103);
            label2.Name = "label2";
            label2.Size = new Size(238, 50);
            label2.TabIndex = 2;
            label2.Text = "LOGIN PAGE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(78, 178);
            label3.Name = "label3";
            label3.Size = new Size(252, 32);
            label3.TabIndex = 3;
            label3.Text = "ACCOUNT NUMBER :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(78, 278);
            label4.Name = "label4";
            label4.Size = new Size(70, 32);
            label4.TabIndex = 4;
            label4.Text = "PIN :";
            // 
            // AccNumTb
            // 
            AccNumTb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AccNumTb.Location = new Point(78, 213);
            AccNumTb.Name = "AccNumTb";
            AccNumTb.Size = new Size(612, 39);
            AccNumTb.TabIndex = 5;
            // 
            // PinTb
            // 
            PinTb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PinTb.Location = new Point(78, 313);
            PinTb.Name = "PinTb";
            PinTb.Size = new Size(612, 39);
            PinTb.TabIndex = 6;
            // 
            // LoginBtn
            // 
            LoginBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginBtn.ForeColor = Color.Navy;
            LoginBtn.Location = new Point(152, 377);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(178, 46);
            LoginBtn.TabIndex = 7;
            LoginBtn.Text = "LOGIN";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // SignupBtn
            // 
            SignupBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SignupBtn.ForeColor = Color.Navy;
            SignupBtn.Location = new Point(402, 377);
            SignupBtn.Name = "SignupBtn";
            SignupBtn.Size = new Size(178, 46);
            SignupBtn.TabIndex = 8;
            SignupBtn.Text = "SIGN UP";
            SignupBtn.UseVisualStyleBackColor = true;
            SignupBtn.Click += SignupBtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(800, 450);
            Controls.Add(SignupBtn);
            Controls.Add(LoginBtn);
            Controls.Add(PinTb);
            Controls.Add(AccNumTb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox AccNumTb;
        private TextBox PinTb;
        private Button LoginBtn;
        private Button SignupBtn;
        private Label label5;
    }
}