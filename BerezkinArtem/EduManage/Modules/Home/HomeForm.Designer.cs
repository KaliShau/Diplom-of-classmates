namespace EduManage
{
    partial class HomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            signinButton = new Button();
            panel4 = new Panel();
            panel2 = new Panel();
            childrenPanel = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            childrenPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(218, 690);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(signinButton);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(218, 72);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Авторизация";
            // 
            // signinButton
            // 
            signinButton.BackColor = SystemColors.GradientActiveCaption;
            signinButton.Dock = DockStyle.Top;
            signinButton.FlatAppearance.BorderSize = 0;
            signinButton.FlatStyle = FlatStyle.Flat;
            signinButton.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signinButton.Location = new Point(3, 25);
            signinButton.Name = "signinButton";
            signinButton.Size = new Size(212, 39);
            signinButton.TabIndex = 0;
            signinButton.Text = "Вход";
            signinButton.UseVisualStyleBackColor = false;
            signinButton.Click += signinButton_Click;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(218, 72);
            panel4.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(218, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(14, 690);
            panel2.TabIndex = 1;
            // 
            // childrenPanel
            // 
            childrenPanel.BackColor = SystemColors.ControlLightLight;
            childrenPanel.Controls.Add(label1);
            childrenPanel.Dock = DockStyle.Fill;
            childrenPanel.Location = new Point(232, 0);
            childrenPanel.Name = "childrenPanel";
            childrenPanel.Size = new Size(1032, 690);
            childrenPanel.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 20);
            label1.Name = "label1";
            label1.Size = new Size(503, 32);
            label1.TabIndex = 0;
            label1.Text = "Для продолжения войдите в систему!";
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 690);
            Controls.Add(childrenPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "HomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            childrenPanel.ResumeLayout(false);
            childrenPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel childrenPanel;
        private Panel panel4;
        private Label label1;
        private GroupBox groupBox1;
        private Button signinButton;
    }
}
