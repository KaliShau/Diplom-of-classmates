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
            adminBox = new GroupBox();
            openUsersButton = new Button();
            panel8 = new Panel();
            openRolesButton = new Button();
            accountantBox = new GroupBox();
            openStaffButton = new Button();
            panel6 = new Panel();
            openPurchasesButton = new Button();
            panel5 = new Panel();
            openSuppliersButton = new Button();
            staffBox = new GroupBox();
            openRequestsButton = new Button();
            panel3 = new Panel();
            button1 = new Button();
            authBox = new GroupBox();
            signinButton = new Button();
            panel4 = new Panel();
            panel2 = new Panel();
            childrenPanel = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            adminBox.SuspendLayout();
            accountantBox.SuspendLayout();
            staffBox.SuspendLayout();
            authBox.SuspendLayout();
            childrenPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(adminBox);
            panel1.Controls.Add(accountantBox);
            panel1.Controls.Add(staffBox);
            panel1.Controls.Add(authBox);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(218, 690);
            panel1.TabIndex = 0;
            // 
            // adminBox
            // 
            adminBox.Controls.Add(openUsersButton);
            adminBox.Controls.Add(panel8);
            adminBox.Controls.Add(openRolesButton);
            adminBox.Dock = DockStyle.Top;
            adminBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminBox.Location = new Point(0, 435);
            adminBox.Name = "adminBox";
            adminBox.Size = new Size(218, 120);
            adminBox.TabIndex = 4;
            adminBox.TabStop = false;
            adminBox.Text = "Администрация";
            adminBox.Visible = false;
            // 
            // openUsersButton
            // 
            openUsersButton.BackColor = SystemColors.GradientActiveCaption;
            openUsersButton.Dock = DockStyle.Top;
            openUsersButton.FlatAppearance.BorderSize = 0;
            openUsersButton.FlatStyle = FlatStyle.Flat;
            openUsersButton.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            openUsersButton.Location = new Point(3, 74);
            openUsersButton.Name = "openUsersButton";
            openUsersButton.Size = new Size(212, 39);
            openUsersButton.TabIndex = 2;
            openUsersButton.Text = "Пользователи";
            openUsersButton.TextAlign = ContentAlignment.MiddleLeft;
            openUsersButton.UseVisualStyleBackColor = false;
            openUsersButton.Click += openUsersButton_Click;
            // 
            // panel8
            // 
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(3, 64);
            panel8.Name = "panel8";
            panel8.Size = new Size(212, 10);
            panel8.TabIndex = 1;
            // 
            // openRolesButton
            // 
            openRolesButton.BackColor = SystemColors.GradientActiveCaption;
            openRolesButton.Dock = DockStyle.Top;
            openRolesButton.FlatAppearance.BorderSize = 0;
            openRolesButton.FlatStyle = FlatStyle.Flat;
            openRolesButton.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            openRolesButton.Location = new Point(3, 25);
            openRolesButton.Name = "openRolesButton";
            openRolesButton.Size = new Size(212, 39);
            openRolesButton.TabIndex = 0;
            openRolesButton.Text = "Роли";
            openRolesButton.TextAlign = ContentAlignment.MiddleLeft;
            openRolesButton.UseVisualStyleBackColor = false;
            openRolesButton.Click += openRolesButton_Click;
            // 
            // accountantBox
            // 
            accountantBox.Controls.Add(openStaffButton);
            accountantBox.Controls.Add(panel6);
            accountantBox.Controls.Add(openPurchasesButton);
            accountantBox.Controls.Add(panel5);
            accountantBox.Controls.Add(openSuppliersButton);
            accountantBox.Dock = DockStyle.Top;
            accountantBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accountantBox.Location = new Point(0, 265);
            accountantBox.Name = "accountantBox";
            accountantBox.Size = new Size(218, 170);
            accountantBox.TabIndex = 3;
            accountantBox.TabStop = false;
            accountantBox.Text = "Бухгалтерия";
            accountantBox.Visible = false;
            // 
            // openStaffButton
            // 
            openStaffButton.BackColor = SystemColors.GradientActiveCaption;
            openStaffButton.Dock = DockStyle.Top;
            openStaffButton.FlatAppearance.BorderSize = 0;
            openStaffButton.FlatStyle = FlatStyle.Flat;
            openStaffButton.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            openStaffButton.Location = new Point(3, 123);
            openStaffButton.Name = "openStaffButton";
            openStaffButton.Size = new Size(212, 39);
            openStaffButton.TabIndex = 4;
            openStaffButton.Text = "Персонал";
            openStaffButton.TextAlign = ContentAlignment.MiddleLeft;
            openStaffButton.UseVisualStyleBackColor = false;
            openStaffButton.Click += openStaffButton_Click;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(3, 113);
            panel6.Name = "panel6";
            panel6.Size = new Size(212, 10);
            panel6.TabIndex = 3;
            // 
            // openPurchasesButton
            // 
            openPurchasesButton.BackColor = SystemColors.GradientActiveCaption;
            openPurchasesButton.Dock = DockStyle.Top;
            openPurchasesButton.FlatAppearance.BorderSize = 0;
            openPurchasesButton.FlatStyle = FlatStyle.Flat;
            openPurchasesButton.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            openPurchasesButton.Location = new Point(3, 74);
            openPurchasesButton.Name = "openPurchasesButton";
            openPurchasesButton.Size = new Size(212, 39);
            openPurchasesButton.TabIndex = 2;
            openPurchasesButton.Text = "Закупки";
            openPurchasesButton.TextAlign = ContentAlignment.MiddleLeft;
            openPurchasesButton.UseVisualStyleBackColor = false;
            openPurchasesButton.Click += openPurchasesButton_Click;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(3, 64);
            panel5.Name = "panel5";
            panel5.Size = new Size(212, 10);
            panel5.TabIndex = 1;
            // 
            // openSuppliersButton
            // 
            openSuppliersButton.BackColor = SystemColors.GradientActiveCaption;
            openSuppliersButton.Dock = DockStyle.Top;
            openSuppliersButton.FlatAppearance.BorderSize = 0;
            openSuppliersButton.FlatStyle = FlatStyle.Flat;
            openSuppliersButton.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            openSuppliersButton.Location = new Point(3, 25);
            openSuppliersButton.Name = "openSuppliersButton";
            openSuppliersButton.Size = new Size(212, 39);
            openSuppliersButton.TabIndex = 0;
            openSuppliersButton.Text = "Поставщики";
            openSuppliersButton.TextAlign = ContentAlignment.MiddleLeft;
            openSuppliersButton.UseVisualStyleBackColor = false;
            openSuppliersButton.Click += openSuppliersButton_Click;
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
            staffBox.Size = new Size(218, 121);
            staffBox.TabIndex = 2;
            staffBox.TabStop = false;
            staffBox.Text = "Техперсонал";
            staffBox.Visible = false;
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
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(3, 64);
            panel3.Name = "panel3";
            panel3.Size = new Size(212, 10);
            panel3.TabIndex = 1;
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
            Text = "EduManage";
            panel1.ResumeLayout(false);
            adminBox.ResumeLayout(false);
            accountantBox.ResumeLayout(false);
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
        private GroupBox accountantBox;
        private Button openPurchasesButton;
        private Panel panel5;
        private Button openSuppliersButton;
        private Button openStaffButton;
        private Panel panel6;
        private GroupBox adminBox;
        private Button openUsersButton;
        private Panel panel8;
        private Button openRolesButton;
    }
}
