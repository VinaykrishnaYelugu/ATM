namespace WinFormsApp1
{
    partial class Change_Pin
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
            button2 = new Button();
            button1 = new Button();
            ConfirmPinTb = new TextBox();
            NewPinTb = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Navy;
            button2.Location = new Point(487, 310);
            button2.Name = "button2";
            button2.Size = new Size(178, 46);
            button2.TabIndex = 14;
            button2.Text = "BACK";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Navy;
            button1.Location = new Point(237, 310);
            button1.Name = "button1";
            button1.Size = new Size(178, 46);
            button1.TabIndex = 13;
            button1.Text = "CHANGE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ConfirmPinTb
            // 
            ConfirmPinTb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConfirmPinTb.Location = new Point(163, 246);
            ConfirmPinTb.Name = "ConfirmPinTb";
            ConfirmPinTb.Size = new Size(612, 39);
            ConfirmPinTb.TabIndex = 12;
            // 
            // NewPinTb
            // 
            NewPinTb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NewPinTb.Location = new Point(163, 146);
            NewPinTb.Name = "NewPinTb";
            NewPinTb.Size = new Size(612, 39);
            NewPinTb.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(163, 111);
            label4.Name = "label4";
            label4.Size = new Size(133, 32);
            label4.TabIndex = 10;
            label4.Text = "NEW PIN :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(163, 211);
            label3.Name = "label3";
            label3.Size = new Size(188, 32);
            label3.TabIndex = 9;
            label3.Text = "CONFIRM PIN :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlDarkDark;
            label2.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.MenuText;
            label2.Location = new Point(878, 9);
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
            panel1.Size = new Size(931, 72);
            panel1.TabIndex = 15;
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
            // Change_Pin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(931, 405);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(ConfirmPinTb);
            Controls.Add(NewPinTb);
            Controls.Add(label4);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Change_Pin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Change_Pin";
            Load += Change_Pin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox ConfirmPinTb;
        private TextBox NewPinTb;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Label label1;
    }
}