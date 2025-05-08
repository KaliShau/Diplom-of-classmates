using System.Drawing;
using System.Windows.Forms;

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
            this.panel1 = new System.Windows.Forms.Panel();
            this.adminBox = new System.Windows.Forms.GroupBox();
            this.openUsersButton = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.openRolesButton = new System.Windows.Forms.Button();
            this.accountantBox = new System.Windows.Forms.GroupBox();
            this.openStaffButton = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.openPurchasesButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.openSuppliersButton = new System.Windows.Forms.Button();
            this.staffBox = new System.Windows.Forms.GroupBox();
            this.openRequestsButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.authBox = new System.Windows.Forms.GroupBox();
            this.signinButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.childrenPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.adminBox.SuspendLayout();
            this.accountantBox.SuspendLayout();
            this.staffBox.SuspendLayout();
            this.authBox.SuspendLayout();
            this.childrenPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.adminBox);
            this.panel1.Controls.Add(this.accountantBox);
            this.panel1.Controls.Add(this.staffBox);
            this.panel1.Controls.Add(this.authBox);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 761);
            this.panel1.TabIndex = 0;
            // 
            // adminBox
            // 
            this.adminBox.Controls.Add(this.openUsersButton);
            this.adminBox.Controls.Add(this.panel8);
            this.adminBox.Controls.Add(this.openRolesButton);
            this.adminBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminBox.Location = new System.Drawing.Point(0, 376);
            this.adminBox.Name = "adminBox";
            this.adminBox.Size = new System.Drawing.Size(217, 104);
            this.adminBox.TabIndex = 4;
            this.adminBox.TabStop = false;
            this.adminBox.Text = "Администрация";
            this.adminBox.Visible = false;
            // 
            // openUsersButton
            // 
            this.openUsersButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.openUsersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.openUsersButton.FlatAppearance.BorderSize = 0;
            this.openUsersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openUsersButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openUsersButton.Location = new System.Drawing.Point(3, 68);
            this.openUsersButton.Name = "openUsersButton";
            this.openUsersButton.Size = new System.Drawing.Size(211, 34);
            this.openUsersButton.TabIndex = 2;
            this.openUsersButton.Text = "Пользователи";
            this.openUsersButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openUsersButton.UseVisualStyleBackColor = false;
            this.openUsersButton.Click += new System.EventHandler(this.openUsersButton_Click);
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(3, 59);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(211, 9);
            this.panel8.TabIndex = 1;
            // 
            // openRolesButton
            // 
            this.openRolesButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.openRolesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.openRolesButton.FlatAppearance.BorderSize = 0;
            this.openRolesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openRolesButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openRolesButton.Location = new System.Drawing.Point(3, 25);
            this.openRolesButton.Name = "openRolesButton";
            this.openRolesButton.Size = new System.Drawing.Size(211, 34);
            this.openRolesButton.TabIndex = 0;
            this.openRolesButton.Text = "Роли";
            this.openRolesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openRolesButton.UseVisualStyleBackColor = false;
            this.openRolesButton.Click += new System.EventHandler(this.openRolesButton_Click);
            // 
            // accountantBox
            // 
            this.accountantBox.Controls.Add(this.openStaffButton);
            this.accountantBox.Controls.Add(this.panel6);
            this.accountantBox.Controls.Add(this.openPurchasesButton);
            this.accountantBox.Controls.Add(this.panel5);
            this.accountantBox.Controls.Add(this.openSuppliersButton);
            this.accountantBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.accountantBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountantBox.Location = new System.Drawing.Point(0, 229);
            this.accountantBox.Name = "accountantBox";
            this.accountantBox.Size = new System.Drawing.Size(217, 147);
            this.accountantBox.TabIndex = 3;
            this.accountantBox.TabStop = false;
            this.accountantBox.Text = "Бухгалтерия";
            this.accountantBox.Visible = false;
            // 
            // openStaffButton
            // 
            this.openStaffButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.openStaffButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.openStaffButton.FlatAppearance.BorderSize = 0;
            this.openStaffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openStaffButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openStaffButton.Location = new System.Drawing.Point(3, 111);
            this.openStaffButton.Name = "openStaffButton";
            this.openStaffButton.Size = new System.Drawing.Size(211, 34);
            this.openStaffButton.TabIndex = 4;
            this.openStaffButton.Text = "Персонал";
            this.openStaffButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openStaffButton.UseVisualStyleBackColor = false;
            this.openStaffButton.Click += new System.EventHandler(this.openStaffButton_Click);
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(3, 102);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(211, 9);
            this.panel6.TabIndex = 3;
            // 
            // openPurchasesButton
            // 
            this.openPurchasesButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.openPurchasesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.openPurchasesButton.FlatAppearance.BorderSize = 0;
            this.openPurchasesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openPurchasesButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openPurchasesButton.Location = new System.Drawing.Point(3, 68);
            this.openPurchasesButton.Name = "openPurchasesButton";
            this.openPurchasesButton.Size = new System.Drawing.Size(211, 34);
            this.openPurchasesButton.TabIndex = 2;
            this.openPurchasesButton.Text = "Закупки";
            this.openPurchasesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openPurchasesButton.UseVisualStyleBackColor = false;
            this.openPurchasesButton.Click += new System.EventHandler(this.openPurchasesButton_Click);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 59);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(211, 9);
            this.panel5.TabIndex = 1;
            // 
            // openSuppliersButton
            // 
            this.openSuppliersButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.openSuppliersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.openSuppliersButton.FlatAppearance.BorderSize = 0;
            this.openSuppliersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openSuppliersButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openSuppliersButton.Location = new System.Drawing.Point(3, 25);
            this.openSuppliersButton.Name = "openSuppliersButton";
            this.openSuppliersButton.Size = new System.Drawing.Size(211, 34);
            this.openSuppliersButton.TabIndex = 0;
            this.openSuppliersButton.Text = "Поставщики";
            this.openSuppliersButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openSuppliersButton.UseVisualStyleBackColor = false;
            this.openSuppliersButton.Click += new System.EventHandler(this.openSuppliersButton_Click);
            // 
            // staffBox
            // 
            this.staffBox.Controls.Add(this.openRequestsButton);
            this.staffBox.Controls.Add(this.panel3);
            this.staffBox.Controls.Add(this.button1);
            this.staffBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.staffBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffBox.Location = new System.Drawing.Point(0, 124);
            this.staffBox.Name = "staffBox";
            this.staffBox.Size = new System.Drawing.Size(217, 105);
            this.staffBox.TabIndex = 2;
            this.staffBox.TabStop = false;
            this.staffBox.Text = "Техперсонал";
            this.staffBox.Visible = false;
            // 
            // openRequestsButton
            // 
            this.openRequestsButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.openRequestsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.openRequestsButton.FlatAppearance.BorderSize = 0;
            this.openRequestsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openRequestsButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openRequestsButton.Location = new System.Drawing.Point(3, 68);
            this.openRequestsButton.Name = "openRequestsButton";
            this.openRequestsButton.Size = new System.Drawing.Size(211, 34);
            this.openRequestsButton.TabIndex = 2;
            this.openRequestsButton.Text = "Заявки";
            this.openRequestsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openRequestsButton.UseVisualStyleBackColor = false;
            this.openRequestsButton.Click += new System.EventHandler(this.openRequestsButton_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(211, 9);
            this.panel3.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Инвентарь";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // authBox
            // 
            this.authBox.Controls.Add(this.signinButton);
            this.authBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.authBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authBox.Location = new System.Drawing.Point(0, 62);
            this.authBox.Name = "authBox";
            this.authBox.Size = new System.Drawing.Size(217, 62);
            this.authBox.TabIndex = 1;
            this.authBox.TabStop = false;
            this.authBox.Text = "Авторизация";
            // 
            // signinButton
            // 
            this.signinButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.signinButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.signinButton.FlatAppearance.BorderSize = 0;
            this.signinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signinButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinButton.Location = new System.Drawing.Point(3, 25);
            this.signinButton.Name = "signinButton";
            this.signinButton.Size = new System.Drawing.Size(211, 34);
            this.signinButton.TabIndex = 0;
            this.signinButton.Text = "Вход";
            this.signinButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.signinButton.UseVisualStyleBackColor = false;
            this.signinButton.Click += new System.EventHandler(this.signinButton_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(217, 62);
            this.panel4.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(217, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(12, 761);
            this.panel2.TabIndex = 1;
            // 
            // childrenPanel
            // 
            this.childrenPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.childrenPanel.Controls.Add(this.label1);
            this.childrenPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childrenPanel.Location = new System.Drawing.Point(229, 0);
            this.childrenPanel.Name = "childrenPanel";
            this.childrenPanel.Size = new System.Drawing.Size(1155, 761);
            this.childrenPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Для продолжения войдите в систему!";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.childrenPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EduManage";
            this.panel1.ResumeLayout(false);
            this.adminBox.ResumeLayout(false);
            this.accountantBox.ResumeLayout(false);
            this.staffBox.ResumeLayout(false);
            this.authBox.ResumeLayout(false);
            this.childrenPanel.ResumeLayout(false);
            this.childrenPanel.PerformLayout();
            this.ResumeLayout(false);

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
