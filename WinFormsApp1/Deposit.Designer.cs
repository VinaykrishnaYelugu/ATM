namespace WinFormsApp1
{
    partial class Deposit
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
            LogoutBtn = new Button();
            DepositBtn = new Button();
            DepositAmtTb = new TextBox();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlDarkDark;
            label2.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.MenuText;
            label2.Location = new Point(862, 9);
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
            label1.Location = new Point(313, 9);
            label1.Name = "label1";
            label1.Size = new Size(352, 50);
            label1.TabIndex = 2;
            label1.Text = "ATM APPLICATION";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(920, 72);
            panel1.TabIndex = 22;
            // 
            // LogoutBtn
            // 
            LogoutBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogoutBtn.ForeColor = Color.Navy;
            LogoutBtn.Location = new Point(526, 285);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(178, 46);
            LogoutBtn.TabIndex = 21;
            LogoutBtn.Text = "LOG OUT";
            LogoutBtn.UseVisualStyleBackColor = true;
            // 
            // DepositBtn
            // 
            DepositBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DepositBtn.ForeColor = Color.Navy;
            DepositBtn.Location = new Point(256, 285);
            DepositBtn.Name = "DepositBtn";
            DepositBtn.Size = new Size(178, 46);
            DepositBtn.TabIndex = 20;
            DepositBtn.Text = "DEPOSIT";
            DepositBtn.UseVisualStyleBackColor = true;
            DepositBtn.Click += button1_Click;
            // 
            // DepositAmtTb
            // 
            DepositAmtTb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DepositAmtTb.Location = new Point(176, 202);
            DepositAmtTb.Name = "DepositAmtTb";
            DepositAmtTb.Size = new Size(612, 39);
            DepositAmtTb.TabIndex = 18;
            DepositAmtTb.TextChanged += DepositAmtTb_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(242, 127);
            label5.Name = "label5";
            label5.Size = new Size(477, 50);
            label5.TabIndex = 4;
            label5.Text = "ENTER DEPOSIT AMOUNT";
            // 
            // Deposit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(920, 450);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(LogoutBtn);
            Controls.Add(DepositBtn);
            Controls.Add(DepositAmtTb);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Deposit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Deposit";
            Load += Deposit_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Panel panel1;
        private Button LogoutBtn;
        private Button DepositBtn;
        private TextBox DepositAmtTb;
        private Label label5;
    }
}