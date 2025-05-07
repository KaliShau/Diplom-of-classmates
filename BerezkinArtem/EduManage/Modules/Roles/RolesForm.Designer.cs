namespace EduManage.Modules.Roles
{
    partial class RolesForm
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
            label1 = new Label();
            rolesGrid = new DataGridView();
            createPanel = new Panel();
            drugPanel = new Panel();
            closeButton = new Button();
            createButton = new Button();
            label3 = new Label();
            label2 = new Label();
            descriptionBox = new TextBox();
            nameBox = new TextBox();
            openCreateButton = new Button();
            toolStripSeparator1 = new ToolStripSeparator();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)rolesGrid).BeginInit();
            createPanel.SuspendLayout();
            drugPanel.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 3);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 20;
            label1.Text = "Роли";
            // 
            // rolesGrid
            // 
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLightLight;
            rolesGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            rolesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            rolesGrid.BackgroundColor = SystemColors.ControlLightLight;
            rolesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rolesGrid.Dock = DockStyle.Bottom;
            rolesGrid.GridColor = SystemColors.GradientActiveCaption;
            rolesGrid.Location = new Point(0, 151);
            rolesGrid.Name = "rolesGrid";
            rolesGrid.ReadOnly = true;
            rolesGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.BackColor = SystemColors.GradientActiveCaption;
            rolesGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            rolesGrid.RowTemplate.DefaultCellStyle.BackColor = SystemColors.GradientActiveCaption;
            rolesGrid.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            rolesGrid.Size = new Size(1032, 539);
            rolesGrid.TabIndex = 15;
            rolesGrid.MouseClick += rolesGrid_MouseClick;
            // 
            // createPanel
            // 
            createPanel.BorderStyle = BorderStyle.FixedSingle;
            createPanel.Controls.Add(drugPanel);
            createPanel.Controls.Add(createButton);
            createPanel.Controls.Add(label3);
            createPanel.Controls.Add(label2);
            createPanel.Controls.Add(descriptionBox);
            createPanel.Controls.Add(nameBox);
            createPanel.Location = new Point(609, 42);
            createPanel.Name = "createPanel";
            createPanel.Size = new Size(398, 513);
            createPanel.TabIndex = 21;
            createPanel.Visible = false;
            // 
            // drugPanel
            // 
            drugPanel.Controls.Add(closeButton);
            drugPanel.Dock = DockStyle.Top;
            drugPanel.Location = new Point(0, 0);
            drugPanel.Name = "drugPanel";
            drugPanel.Size = new Size(396, 32);
            drugPanel.TabIndex = 6;
            // 
            // closeButton
            // 
            closeButton.BackColor = SystemColors.ControlLightLight;
            closeButton.Dock = DockStyle.Right;
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeButton.Location = new Point(361, 0);
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
            createButton.Location = new Point(90, 185);
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
            label3.Size = new Size(78, 19);
            label3.TabIndex = 5;
            label3.Text = "Описание";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 35);
            label2.Name = "label2";
            label2.Size = new Size(73, 19);
            label2.TabIndex = 5;
            label2.Text = "Название";
            // 
            // descriptionBox
            // 
            descriptionBox.BorderStyle = BorderStyle.FixedSingle;
            descriptionBox.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descriptionBox.Location = new Point(22, 125);
            descriptionBox.Name = "descriptionBox";
            descriptionBox.Size = new Size(328, 32);
            descriptionBox.TabIndex = 4;
            // 
            // nameBox
            // 
            nameBox.BorderStyle = BorderStyle.FixedSingle;
            nameBox.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameBox.Location = new Point(22, 59);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(328, 32);
            nameBox.TabIndex = 4;
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
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(115, 6);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(118, 22);
            deleteToolStripMenuItem.Text = "Удалить";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem, toolStripSeparator1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(119, 32);
            // 
            // RolesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1032, 690);
            Controls.Add(createPanel);
            Controls.Add(label1);
            Controls.Add(rolesGrid);
            Controls.Add(openCreateButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RolesForm";
            Text = "RolesForm";
            ((System.ComponentModel.ISupportInitialize)rolesGrid).EndInit();
            createPanel.ResumeLayout(false);
            createPanel.PerformLayout();
            drugPanel.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView rolesGrid;
        private Panel createPanel;
        private Panel drugPanel;
        private Button closeButton;
        private Button createButton;
        private Label label3;
        private Label label2;
        private TextBox descriptionBox;
        private TextBox nameBox;
        private Button openCreateButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
    }
}