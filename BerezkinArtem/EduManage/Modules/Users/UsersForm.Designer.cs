namespace EduManage.Modules.Users
{
    partial class UsersForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            openCreateButton = new Button();
            createPanel = new Panel();
            label4 = new Label();
            roleBox = new ComboBox();
            label8 = new Label();
            drugPanel = new Panel();
            closeButton = new Button();
            createButton = new Button();
            label3 = new Label();
            label2 = new Label();
            passwordBox = new TextBox();
            loginBox = new TextBox();
            staffBox = new ComboBox();
            label1 = new Label();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            usersGrid = new DataGridView();
            createPanel.SuspendLayout();
            drugPanel.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)usersGrid).BeginInit();
            SuspendLayout();
            // 
            // openCreateButton
            // 
            openCreateButton.BackColor = SystemColors.GradientActiveCaption;
            openCreateButton.FlatAppearance.BorderSize = 0;
            openCreateButton.FlatStyle = FlatStyle.Flat;
            openCreateButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            openCreateButton.Location = new Point(858, 8);
            openCreateButton.Name = "openCreateButton";
            openCreateButton.Size = new Size(149, 31);
            openCreateButton.TabIndex = 19;
            openCreateButton.Text = "Добавить";
            openCreateButton.UseVisualStyleBackColor = false;
            openCreateButton.Click += openCreateButton_Click;
            // 
            // createPanel
            // 
            createPanel.BorderStyle = BorderStyle.FixedSingle;
            createPanel.Controls.Add(label4);
            createPanel.Controls.Add(roleBox);
            createPanel.Controls.Add(label8);
            createPanel.Controls.Add(drugPanel);
            createPanel.Controls.Add(createButton);
            createPanel.Controls.Add(label3);
            createPanel.Controls.Add(label2);
            createPanel.Controls.Add(passwordBox);
            createPanel.Controls.Add(loginBox);
            createPanel.Controls.Add(staffBox);
            createPanel.Location = new Point(12, 42);
            createPanel.Name = "createPanel";
            createPanel.Size = new Size(995, 513);
            createPanel.TabIndex = 21;
            createPanel.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 235);
            label4.Name = "label4";
            label4.Size = new Size(129, 19);
            label4.TabIndex = 8;
            label4.Text = "ФИО Сотрудника";
            // 
            // roleBox
            // 
            roleBox.DropDownStyle = ComboBoxStyle.DropDownList;
            roleBox.Font = new Font("Times New Roman", 15.75F);
            roleBox.FormattingEnabled = true;
            roleBox.Location = new Point(22, 193);
            roleBox.Name = "roleBox";
            roleBox.Size = new Size(955, 31);
            roleBox.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(22, 166);
            label8.Name = "label8";
            label8.Size = new Size(41, 19);
            label8.TabIndex = 8;
            label8.Text = "Роль";
            // 
            // drugPanel
            // 
            drugPanel.Controls.Add(closeButton);
            drugPanel.Dock = DockStyle.Top;
            drugPanel.Location = new Point(0, 0);
            drugPanel.Name = "drugPanel";
            drugPanel.Size = new Size(993, 32);
            drugPanel.TabIndex = 6;
            // 
            // closeButton
            // 
            closeButton.BackColor = SystemColors.ControlLightLight;
            closeButton.Dock = DockStyle.Right;
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeButton.Location = new Point(958, 0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(35, 32);
            closeButton.TabIndex = 5;
            closeButton.Text = "❌";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // createButton
            // 
            createButton.BackColor = SystemColors.GradientActiveCaption;
            createButton.FlatAppearance.BorderSize = 0;
            createButton.FlatStyle = FlatStyle.Flat;
            createButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createButton.Location = new Point(394, 395);
            createButton.Name = "createButton";
            createButton.Size = new Size(210, 49);
            createButton.TabIndex = 5;
            createButton.Text = "Добавить";
            createButton.UseVisualStyleBackColor = false;
            createButton.Click += createButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 101);
            label3.Name = "label3";
            label3.Size = new Size(58, 19);
            label3.TabIndex = 5;
            label3.Text = "Пароль";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 35);
            label2.Name = "label2";
            label2.Size = new Size(52, 19);
            label2.TabIndex = 5;
            label2.Text = "Логин";
            // 
            // passwordBox
            // 
            passwordBox.BorderStyle = BorderStyle.FixedSingle;
            passwordBox.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordBox.Location = new Point(22, 125);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(953, 32);
            passwordBox.TabIndex = 4;
            // 
            // loginBox
            // 
            loginBox.BorderStyle = BorderStyle.FixedSingle;
            loginBox.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginBox.Location = new Point(22, 59);
            loginBox.Name = "loginBox";
            loginBox.Size = new Size(953, 32);
            loginBox.TabIndex = 4;
            // 
            // staffBox
            // 
            staffBox.DropDownStyle = ComboBoxStyle.DropDownList;
            staffBox.Font = new Font("Times New Roman", 15.75F);
            staffBox.FormattingEnabled = true;
            staffBox.Location = new Point(22, 262);
            staffBox.Name = "staffBox";
            staffBox.Size = new Size(955, 31);
            staffBox.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 3);
            label1.Name = "label1";
            label1.Size = new Size(196, 32);
            label1.TabIndex = 20;
            label1.Text = "Пользователи";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(180, 22);
            deleteToolStripMenuItem.Text = "Удалить";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 48);
            // 
            // usersGrid
            // 
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLightLight;
            usersGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            usersGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            usersGrid.BackgroundColor = SystemColors.ControlLightLight;
            usersGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usersGrid.Dock = DockStyle.Bottom;
            usersGrid.GridColor = SystemColors.GradientActiveCaption;
            usersGrid.Location = new Point(0, 151);
            usersGrid.Name = "usersGrid";
            usersGrid.ReadOnly = true;
            usersGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.BackColor = SystemColors.GradientActiveCaption;
            usersGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            usersGrid.RowTemplate.DefaultCellStyle.BackColor = SystemColors.GradientActiveCaption;
            usersGrid.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            usersGrid.Size = new Size(1032, 539);
            usersGrid.TabIndex = 15;
            usersGrid.MouseClick += usersGrid_MouseClick;
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1032, 690);
            Controls.Add(createPanel);
            Controls.Add(openCreateButton);
            Controls.Add(label1);
            Controls.Add(usersGrid);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UsersForm";
            Text = "UsersForm";
            createPanel.ResumeLayout(false);
            createPanel.PerformLayout();
            drugPanel.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)usersGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button openCreateButton;
        private Panel createPanel;
        private Panel drugPanel;
        private Button closeButton;
        private Button createButton;
        private Label label3;
        private Label label2;
        private TextBox passwordBox;
        private TextBox loginBox;
        private Label label1;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private DataGridView usersGrid;
        private ComboBox staffBox;
        private Label label4;
        private ComboBox roleBox;
        private Label label8;
    }
}