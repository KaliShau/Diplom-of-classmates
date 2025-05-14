using System.Drawing;
using System.Windows.Forms;
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeActiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.drugPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.positionBox = new System.Windows.Forms.TextBox();
            this.createPanel = new System.Windows.Forms.Panel();
            this.hireDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.departmentBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openCreateButton = new System.Windows.Forms.Button();
            this.staffGrid = new System.Windows.Forms.DataGridView();
            this.saveToDocxButton = new System.Windows.Forms.Button();
            this.workScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuStrip1.SuspendLayout();
            this.drugPanel.SuspendLayout();
            this.createPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(359, 68);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(128, 32);
            this.searchButton.TabIndex = 10;
            this.searchButton.Text = "Найти";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(16, 68);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(337, 32);
            this.searchBox.TabIndex = 9;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.changeActiveToolStripMenuItem,
            this.toolStripSeparator1,
            this.workScheduleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(187, 120);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.deleteToolStripMenuItem.Text = "Удалить";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.updateToolStripMenuItem.Text = "Обновить";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // changeActiveToolStripMenuItem
            // 
            this.changeActiveToolStripMenuItem.Name = "changeActiveToolStripMenuItem";
            this.changeActiveToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.changeActiveToolStripMenuItem.Text = "Сменить активность";
            this.changeActiveToolStripMenuItem.Click += new System.EventHandler(this.changeActiveToolStripMenuItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Поиск";
            // 
            // drugPanel
            // 
            this.drugPanel.Controls.Add(this.closeButton);
            this.drugPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.drugPanel.Location = new System.Drawing.Point(0, 0);
            this.drugPanel.Name = "drugPanel";
            this.drugPanel.Size = new System.Drawing.Size(1125, 28);
            this.drugPanel.TabIndex = 6;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(1095, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 28);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "❌";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Дата приема";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Телефон";
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.createButton.FlatAppearance.BorderSize = 0;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.Location = new System.Drawing.Point(504, 347);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(180, 42);
            this.createButton.TabIndex = 5;
            this.createButton.Text = "Добавить";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Должность";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "ФИО";
            // 
            // phoneBox
            // 
            this.phoneBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneBox.Location = new System.Drawing.Point(19, 231);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(1090, 32);
            this.phoneBox.TabIndex = 4;
            // 
            // positionBox
            // 
            this.positionBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.positionBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionBox.Location = new System.Drawing.Point(19, 108);
            this.positionBox.Name = "positionBox";
            this.positionBox.Size = new System.Drawing.Size(1090, 32);
            this.positionBox.TabIndex = 4;
            // 
            // createPanel
            // 
            this.createPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.createPanel.Controls.Add(this.hireDatePicker);
            this.createPanel.Controls.Add(this.drugPanel);
            this.createPanel.Controls.Add(this.label6);
            this.createPanel.Controls.Add(this.label4);
            this.createPanel.Controls.Add(this.label5);
            this.createPanel.Controls.Add(this.createButton);
            this.createPanel.Controls.Add(this.label3);
            this.createPanel.Controls.Add(this.label2);
            this.createPanel.Controls.Add(this.departmentBox);
            this.createPanel.Controls.Add(this.phoneBox);
            this.createPanel.Controls.Add(this.positionBox);
            this.createPanel.Controls.Add(this.nameBox);
            this.createPanel.Location = new System.Drawing.Point(16, 47);
            this.createPanel.Name = "createPanel";
            this.createPanel.Size = new System.Drawing.Size(1127, 445);
            this.createPanel.TabIndex = 14;
            this.createPanel.Visible = false;
            // 
            // hireDatePicker
            // 
            this.hireDatePicker.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.hireDatePicker.Location = new System.Drawing.Point(19, 288);
            this.hireDatePicker.Name = "hireDatePicker";
            this.hireDatePicker.Size = new System.Drawing.Size(1090, 32);
            this.hireDatePicker.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Отдел";
            // 
            // departmentBox
            // 
            this.departmentBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.departmentBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentBox.Location = new System.Drawing.Point(19, 171);
            this.departmentBox.Name = "departmentBox";
            this.departmentBox.Size = new System.Drawing.Size(1090, 32);
            this.departmentBox.TabIndex = 4;
            // 
            // nameBox
            // 
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(19, 51);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(1090, 32);
            this.nameBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Персонал";
            // 
            // openCreateButton
            // 
            this.openCreateButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.openCreateButton.FlatAppearance.BorderSize = 0;
            this.openCreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openCreateButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openCreateButton.Location = new System.Drawing.Point(1015, 14);
            this.openCreateButton.Name = "openCreateButton";
            this.openCreateButton.Size = new System.Drawing.Size(128, 27);
            this.openCreateButton.TabIndex = 12;
            this.openCreateButton.Text = "Добавить";
            this.openCreateButton.UseVisualStyleBackColor = false;
            this.openCreateButton.Click += new System.EventHandler(this.openCreateButton_Click);
            // 
            // staffGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.staffGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.staffGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.staffGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.staffGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.staffGrid.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.staffGrid.Location = new System.Drawing.Point(0, 135);
            this.staffGrid.Name = "staffGrid";
            this.staffGrid.ReadOnly = true;
            this.staffGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.staffGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.staffGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.staffGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.staffGrid.Size = new System.Drawing.Size(1155, 626);
            this.staffGrid.TabIndex = 8;
            this.staffGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.staffGrid_MouseClick);
            // 
            // saveToDocxButton
            // 
            this.saveToDocxButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.saveToDocxButton.FlatAppearance.BorderSize = 0;
            this.saveToDocxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveToDocxButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveToDocxButton.Location = new System.Drawing.Point(815, 14);
            this.saveToDocxButton.Name = "saveToDocxButton";
            this.saveToDocxButton.Size = new System.Drawing.Size(194, 27);
            this.saveToDocxButton.TabIndex = 23;
            this.saveToDocxButton.Text = "Сохранить данные";
            this.saveToDocxButton.UseVisualStyleBackColor = false;
            this.saveToDocxButton.Click += new System.EventHandler(this.saveToDocxButton_Click);
            // 
            // workScheduleToolStripMenuItem
            // 
            this.workScheduleToolStripMenuItem.Name = "workScheduleToolStripMenuItem";
            this.workScheduleToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.workScheduleToolStripMenuItem.Text = "График работы";
            this.workScheduleToolStripMenuItem.Click += new System.EventHandler(this.workScheduleToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1155, 761);
            this.Controls.Add(this.saveToDocxButton);
            this.Controls.Add(this.createPanel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openCreateButton);
            this.Controls.Add(this.staffGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffForm";
            this.Text = "StaffForm";
            this.contextMenuStrip1.ResumeLayout(false);
            this.drugPanel.ResumeLayout(false);
            this.createPanel.ResumeLayout(false);
            this.createPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button searchButton;
        private TextBox searchBox;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteToolStripMenuItem;
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
        private ToolStripMenuItem updateToolStripMenuItem;
        private ToolStripMenuItem changeActiveToolStripMenuItem;
        private Button saveToDocxButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem workScheduleToolStripMenuItem;
    }
}