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
            staffBox = new GroupBox();
            button1 = new Button();
            authBox = new GroupBox();
            signinButton = new Button();
            panel4 = new Panel();
            panel2 = new Panel();
            childrenPanel = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            openRequestsButton = new Button();
            panel1.SuspendLayout();
            staffBox.SuspendLayout();
            authBox.SuspendLayout();
            childrenPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(staffBox);
            panel1.Controls.Add(authBox);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(218, 690);
            panel1.TabIndex = 0;
            // 
            // staffBox
            // 
            staffBox.Controls.Add(openRequestsButton);
            staffBox.Controls.Add(panel3);
            staffBox.Controls.Add(button1);
            staffBox.Dock = DockStyle.Top;
            staffBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            staffBox.Location = new Point(0, 144);
            staffBox.Name = "staffBox";
            staffBox.Size = new Size(218, 184);
            staffBox.TabIndex = 2;
            staffBox.TabStop = false;
            staffBox.Text = "Техперсонал";
            staffBox.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(3, 25);
            button1.Name = "button1";
            button1.Size = new Size(212, 39);
            button1.TabIndex = 0;
            button1.Text = "Инвентарь";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // authBox
            // 
            authBox.Controls.Add(signinButton);
            authBox.Dock = DockStyle.Top;
            authBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            authBox.Location = new Point(0, 72);
            authBox.Name = "authBox";
            authBox.Size = new Size(218, 72);
            authBox.TabIndex = 1;
            authBox.TabStop = false;
            authBox.Text = "Авторизация";
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
            signinButton.TextAlign = ContentAlignment.MiddleLeft;
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
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(3, 64);
            panel3.Name = "panel3";
            panel3.Size = new Size(212, 10);
            panel3.TabIndex = 1;
            // 
            // openRequestsButton
            // 
            openRequestsButton.BackColor = SystemColors.GradientActiveCaption;
            openRequestsButton.Dock = DockStyle.Top;
            openRequestsButton.FlatAppearance.BorderSize = 0;
            openRequestsButton.FlatStyle = FlatStyle.Flat;
            openRequestsButton.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            openRequestsButton.Location = new Point(3, 74);
            openRequestsButton.Name = "openRequestsButton";
            openRequestsButton.Size = new Size(212, 39);
            openRequestsButton.TabIndex = 2;
            openRequestsButton.Text = "Заявки";
            openRequestsButton.TextAlign = ContentAlignment.MiddleLeft;
            openRequestsButton.UseVisualStyleBackColor = false;
            openRequestsButton.Click += openRequestsButton_Click;
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
            staffBox.ResumeLayout(false);
            authBox.ResumeLayout(false);
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
        private GroupBox authBox;
        private Button signinButton;
        private GroupBox staffBox;
        private Button button1;
        private Button openRequestsButton;
        private Panel panel3;
    }
}
