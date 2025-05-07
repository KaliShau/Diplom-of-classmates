namespace EduManage.Modules.Staff
{
    partial class StaffForm
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
            searchButton = new Button();
            searchBox = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            label7 = new Label();
            drugPanel = new Panel();
            closeButton = new Button();
            label6 = new Label();
            label5 = new Label();
            createButton = new Button();
            label3 = new Label();
            label2 = new Label();
            phoneBox = new TextBox();
            positionBox = new TextBox();
            createPanel = new Panel();
            hireDatePicker = new DateTimePicker();
            label4 = new Label();
            departmentBox = new TextBox();
            nameBox = new TextBox();
            label1 = new Label();
            openCreateButton = new Button();
            staffGrid = new DataGridView();
            contextMenuStrip1.SuspendLayout();
            drugPanel.SuspendLayout();
            createPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)staffGrid).BeginInit();
            SuspendLayout();
            // 
            // searchButton
            // 
            searchButton.BackColor = SystemColors.GradientActiveCaption;
            searchButton.FlatAppearance.BorderSize = 0;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchButton.Location = new Point(284, 82);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(149, 32);
            searchButton.TabIndex = 10;
            searchButton.Text = "Найти";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // searchBox
            // 
            searchBox.BorderStyle = BorderStyle.FixedSingle;
            searchBox.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBox.Location = new Point(12, 82);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(256, 32);
            searchBox.TabIndex = 9;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem, toolStripSeparator1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(119, 32);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(118, 22);
            deleteToolStripMenuItem.Text = "Удалить";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(115, 6);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 58);
            label7.Name = "label7";
            label7.Size = new Size(51, 19);
            label7.TabIndex = 11;
            label7.Text = "Поиск";
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(22, 307);
            label6.Name = "label6";
            label6.Size = new Size(55, 19);
            label6.TabIndex = 5;
            label6.Text = "Статус";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(22, 243);
            label5.Name = "label5";
            label5.Size = new Size(65, 19);
            label5.TabIndex = 5;
            label5.Text = "Телефон";
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
            label3.Size = new Size(85, 19);
            label3.TabIndex = 5;
            label3.Text = "Должность";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 35);
            label2.Name = "label2";
            label2.Size = new Size(45, 19);
            label2.TabIndex = 5;
            label2.Text = "ФИО";
            // 
            // phoneBox
            // 
            phoneBox.BorderStyle = BorderStyle.FixedSingle;
            phoneBox.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneBox.Location = new Point(22, 267);
            phoneBox.Name = "phoneBox";
            phoneBox.Size = new Size(953, 32);
            phoneBox.TabIndex = 4;
            // 
            // positionBox
            // 
            positionBox.BorderStyle = BorderStyle.FixedSingle;
            positionBox.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            positionBox.Location = new Point(22, 125);
            positionBox.Name = "positionBox";
            positionBox.Size = new Size(953, 32);
            positionBox.TabIndex = 4;
            // 
            // createPanel
            // 
            createPanel.BorderStyle = BorderStyle.FixedSingle;
            createPanel.Controls.Add(hireDatePicker);
            createPanel.Controls.Add(drugPanel);
            createPanel.Controls.Add(label6);
            createPanel.Controls.Add(label4);
            createPanel.Controls.Add(label5);
            createPanel.Controls.Add(createButton);
            createPanel.Controls.Add(label3);
            createPanel.Controls.Add(label2);
            createPanel.Controls.Add(departmentBox);
            createPanel.Controls.Add(phoneBox);
            createPanel.Controls.Add(positionBox);
            createPanel.Controls.Add(nameBox);
            createPanel.Location = new Point(12, 44);
            createPanel.Name = "createPanel";
            createPanel.Size = new Size(995, 513);
            createPanel.TabIndex = 14;
            createPanel.Visible = false;
            // 
            // hireDatePicker
            // 
            hireDatePicker.Font = new Font("Times New Roman", 15.75F);
            hireDatePicker.Location = new Point(22, 332);
            hireDatePicker.Name = "hireDatePicker";
            hireDatePicker.Size = new Size(953, 32);
            hireDatePicker.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 173);
            label4.Name = "label4";
            label4.Size = new Size(51, 19);
            label4.TabIndex = 5;
            label4.Text = "Отдел";
            // 
            // departmentBox
            // 
            departmentBox.BorderStyle = BorderStyle.FixedSingle;
            departmentBox.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            departmentBox.Location = new Point(22, 197);
            departmentBox.Name = "departmentBox";
            departmentBox.Size = new Size(953, 32);
            departmentBox.TabIndex = 4;
            // 
            // nameBox
            // 
            nameBox.BorderStyle = BorderStyle.FixedSingle;
            nameBox.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameBox.Location = new Point(22, 59);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(953, 32);
            nameBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 5);
            label1.Name = "label1";
            label1.Size = new Size(140, 32);
            label1.TabIndex = 13;
            label1.Text = "Персонал";
            // 
            // openCreateButton
            // 
            openCreateButton.BackColor = SystemColors.GradientActiveCaption;
            openCreateButton.FlatAppearance.BorderSize = 0;
            openCreateButton.FlatStyle = FlatStyle.Flat;
            openCreateButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            openCreateButton.Location = new Point(858, 10);
            openCreateButton.Name = "openCreateButton";
            openCreateButton.Size = new Size(149, 31);
            openCreateButton.TabIndex = 12;
            openCreateButton.Text = "Добавить";
            openCreateButton.UseVisualStyleBackColor = false;
            openCreateButton.Click += openCreateButton_Click;
            // 
            // staffGrid
            // 
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLightLight;
            staffGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            staffGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            staffGrid.BackgroundColor = SystemColors.ControlLightLight;
            staffGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            staffGrid.Dock = DockStyle.Bottom;
            staffGrid.GridColor = SystemColors.GradientActiveCaption;
            staffGrid.Location = new Point(0, 151);
            staffGrid.Name = "staffGrid";
            staffGrid.ReadOnly = true;
            staffGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.BackColor = SystemColors.GradientActiveCaption;
            staffGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            staffGrid.RowTemplate.DefaultCellStyle.BackColor = SystemColors.GradientActiveCaption;
            staffGrid.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            staffGrid.Size = new Size(1032, 539);
            staffGrid.TabIndex = 8;
            staffGrid.MouseClick += staffGrid_MouseClick;
            // 
            // StaffForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1032, 690);
            Controls.Add(createPanel);
            Controls.Add(searchButton);
            Controls.Add(searchBox);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(openCreateButton);
            Controls.Add(staffGrid);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StaffForm";
            Text = "StaffForm";
            contextMenuStrip1.ResumeLayout(false);
            drugPanel.ResumeLayout(false);
            createPanel.ResumeLayout(false);
            createPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)staffGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button searchButton;
        private TextBox searchBox;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private Label label7;
        private Panel drugPanel;
        private Button closeButton;
        private Label label6;
        private Label label5;
        private Button createButton;
        private Label label3;
        private Label label2;
        private TextBox phoneBox;
        private TextBox positionBox;
        private Panel createPanel;
        private TextBox nameBox;
        private Label label1;
        private Button openCreateButton;
        private DataGridView staffGrid;
        private Label label4;
        private TextBox departmentBox;
        private DateTimePicker hireDatePicker;
    }
}