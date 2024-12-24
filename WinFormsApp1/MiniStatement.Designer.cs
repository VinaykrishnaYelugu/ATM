namespace WinFormsApp1
{
    partial class MiniStatement
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
            label4 = new Label();
            button7 = new Button();
            label3 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            MiniStatementDGV = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MiniStatementDGV).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(261, 103);
            label4.Name = "label4";
            label4.Size = new Size(331, 50);
            label4.TabIndex = 23;
            label4.Text = "MINI STATEMENT";
            label4.Click += label4_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.Navy;
            button7.Location = new Point(306, 523);
            button7.Name = "button7";
            button7.Size = new Size(215, 46);
            button7.TabIndex = 25;
            button7.Text = "BACK";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
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
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(810, 100);
            panel1.TabIndex = 24;
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
            label1.Size = new Size(0, 50);
            label1.TabIndex = 2;
            // 
            // MiniStatementDGV
            // 
            MiniStatementDGV.BackgroundColor = SystemColors.GradientActiveCaption;
            MiniStatementDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MiniStatementDGV.GridColor = SystemColors.GradientActiveCaption;
            MiniStatementDGV.Location = new Point(30, 156);
            MiniStatementDGV.Name = "MiniStatementDGV";
            MiniStatementDGV.Size = new Size(758, 361);
            MiniStatementDGV.TabIndex = 26;
            // 
            // MiniStatement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(810, 581);
            Controls.Add(MiniStatementDGV);
            Controls.Add(label4);
            Controls.Add(button7);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MiniStatement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MiniStatement";
            Load += MiniStatement_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MiniStatementDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button button7;
        private Label label3;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private DataGridView MiniStatementDGV;
    }
}