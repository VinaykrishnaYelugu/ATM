namespace WinFormsApp1
{
    partial class FastCash
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
            button7 = new Button();
            btn10000 = new Button();
            btn1000 = new Button();
            btn500 = new Button();
            btn5000 = new Button();
            btn2000 = new Button();
            btn100 = new Button();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label6 = new Label();
            CurBalance = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.Navy;
            button7.Location = new Point(307, 392);
            button7.Name = "button7";
            button7.Size = new Size(215, 46);
            button7.TabIndex = 22;
            button7.Text = "Back";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // btn10000
            // 
            btn10000.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn10000.ForeColor = Color.Navy;
            btn10000.Location = new Point(573, 310);
            btn10000.Name = "btn10000";
            btn10000.Size = new Size(215, 46);
            btn10000.TabIndex = 21;
            btn10000.Text = "RS: 10000";
            btn10000.UseVisualStyleBackColor = true;
            btn10000.Click += btn10000_Click;
            // 
            // btn1000
            // 
            btn1000.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn1000.ForeColor = Color.Navy;
            btn1000.Location = new Point(573, 235);
            btn1000.Name = "btn1000";
            btn1000.Size = new Size(215, 46);
            btn1000.TabIndex = 20;
            btn1000.Text = "RS: 1000";
            btn1000.UseVisualStyleBackColor = true;
            btn1000.Click += btn1000_Click;
            // 
            // btn500
            // 
            btn500.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn500.ForeColor = Color.Navy;
            btn500.Location = new Point(308, 235);
            btn500.Name = "btn500";
            btn500.Size = new Size(226, 46);
            btn500.TabIndex = 19;
            btn500.Text = "RS: 500";
            btn500.UseVisualStyleBackColor = true;
            btn500.Click += btn500_Click;
            // 
            // btn5000
            // 
            btn5000.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn5000.ForeColor = Color.Navy;
            btn5000.Location = new Point(307, 310);
            btn5000.Name = "btn5000";
            btn5000.Size = new Size(227, 46);
            btn5000.TabIndex = 18;
            btn5000.Text = "RS: 5000";
            btn5000.UseVisualStyleBackColor = true;
            btn5000.Click += btn5000_Click;
            // 
            // btn2000
            // 
            btn2000.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn2000.ForeColor = Color.Navy;
            btn2000.Location = new Point(36, 310);
            btn2000.Name = "btn2000";
            btn2000.Size = new Size(227, 46);
            btn2000.TabIndex = 17;
            btn2000.Text = "RS: 2000";
            btn2000.UseVisualStyleBackColor = true;
            btn2000.Click += btn2000_Click;
            // 
            // btn100
            // 
            btn100.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn100.ForeColor = Color.Navy;
            btn100.Location = new Point(36, 235);
            btn100.Name = "btn100";
            btn100.Size = new Size(227, 46);
            btn100.TabIndex = 16;
            btn100.Text = "RS: 100";
            btn100.UseVisualStyleBackColor = true;
            btn100.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(249, 24);
            label3.Name = "label3";
            label3.Size = new Size(352, 50);
            label3.TabIndex = 4;
            label3.Text = "ATM APPLICATION";
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
            label1.Size = new Size(0, 50);
            label1.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(332, 89);
            label4.Name = "label4";
            label4.Size = new Size(216, 50);
            label4.TabIndex = 5;
            label4.Text = "FAST CASH";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(308, 153);
            label6.Name = "label6";
            label6.Size = new Size(270, 32);
            label6.TabIndex = 23;
            label6.Text = "AVAILABLE BALANCE :";
            // 
            // CurBalance
            // 
            CurBalance.AutoSize = true;
            CurBalance.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CurBalance.ForeColor = SystemColors.ButtonHighlight;
            CurBalance.Location = new Point(269, 190);
            CurBalance.Name = "CurBalance";
            CurBalance.Size = new Size(371, 32);
            CurBalance.TabIndex = 24;
            CurBalance.Text = "Sample (AVAILABLE BALANCE )";
            // 
            // FastCash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(800, 450);
            Controls.Add(CurBalance);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(button7);
            Controls.Add(btn10000);
            Controls.Add(btn1000);
            Controls.Add(btn500);
            Controls.Add(btn5000);
            Controls.Add(btn2000);
            Controls.Add(btn100);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FastCash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FastCash";
            Load += FastCash_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button7;
        private Button btn10000;
        private Button btn1000;
        private Button btn500;
        private Button btn5000;
        private Button btn2000;
        private Button btn100;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label CurBalance;
    }
}