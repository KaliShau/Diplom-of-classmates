namespace EduManage.Modules.WorkSchedule
{
    partial class WorkScheduleForm
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.drugPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.saveToDocxButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.createPanel = new System.Windows.Forms.Panel();
            this.dateWorkPicker = new System.Windows.Forms.DateTimePicker();
            this.endTimeBox = new System.Windows.Forms.ComboBox();
            this.startTimeBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.zoneBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openCreateButton = new System.Windows.Forms.Button();
            this.workScheduleGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.searchPicker = new System.Windows.Forms.DateTimePicker();
            this.contextMenuStrip1.SuspendLayout();
            this.drugPanel.SuspendLayout();
            this.createPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workScheduleGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.toolStripSeparator1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(119, 32);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.deleteToolStripMenuItem.Text = "Удалить";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(115, 6);
            // 
            // drugPanel
            // 
            this.drugPanel.Controls.Add(this.closeButton);
            this.drugPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.drugPanel.Location = new System.Drawing.Point(0, 0);
            this.drugPanel.Name = "drugPanel";
            this.drugPanel.Size = new System.Drawing.Size(466, 28);
            this.drugPanel.TabIndex = 6;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(436, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 28);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "❌";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.createButton.FlatAppearance.BorderSize = 0;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.Location = new System.Drawing.Point(139, 292);
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
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Тип работы";
            // 
            // saveToDocxButton
            // 
            this.saveToDocxButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.saveToDocxButton.FlatAppearance.BorderSize = 0;
            this.saveToDocxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveToDocxButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveToDocxButton.Location = new System.Drawing.Point(815, 10);
            this.saveToDocxButton.Name = "saveToDocxButton";
            this.saveToDocxButton.Size = new System.Drawing.Size(194, 27);
            this.saveToDocxButton.TabIndex = 12;
            this.saveToDocxButton.Text = "Сохранить данные";
            this.saveToDocxButton.UseVisualStyleBackColor = false;
            this.saveToDocxButton.Click += new System.EventHandler(this.saveToDocxButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Зона ответственности";
            // 
            // typeBox
            // 
            this.typeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.typeBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeBox.Location = new System.Drawing.Point(19, 108);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(431, 32);
            this.typeBox.TabIndex = 4;
            // 
            // createPanel
            // 
            this.createPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.createPanel.Controls.Add(this.dateWorkPicker);
            this.createPanel.Controls.Add(this.endTimeBox);
            this.createPanel.Controls.Add(this.startTimeBox);
            this.createPanel.Controls.Add(this.label4);
            this.createPanel.Controls.Add(this.drugPanel);
            this.createPanel.Controls.Add(this.label6);
            this.createPanel.Controls.Add(this.label5);
            this.createPanel.Controls.Add(this.createButton);
            this.createPanel.Controls.Add(this.label3);
            this.createPanel.Controls.Add(this.label2);
            this.createPanel.Controls.Add(this.typeBox);
            this.createPanel.Controls.Add(this.zoneBox);
            this.createPanel.Location = new System.Drawing.Point(675, 43);
            this.createPanel.Name = "createPanel";
            this.createPanel.Size = new System.Drawing.Size(468, 546);
            this.createPanel.TabIndex = 15;
            this.createPanel.Visible = false;
            // 
            // dateWorkPicker
            // 
            this.dateWorkPicker.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.dateWorkPicker.Location = new System.Drawing.Point(23, 234);
            this.dateWorkPicker.Name = "dateWorkPicker";
            this.dateWorkPicker.Size = new System.Drawing.Size(427, 26);
            this.dateWorkPicker.TabIndex = 16;
            // 
            // endTimeBox
            // 
            this.endTimeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.endTimeBox.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.endTimeBox.FormattingEnabled = true;
            this.endTimeBox.Location = new System.Drawing.Point(261, 173);
            this.endTimeBox.Name = "endTimeBox";
            this.endTimeBox.Size = new System.Drawing.Size(189, 31);
            this.endTimeBox.TabIndex = 10;
            // 
            // startTimeBox
            // 
            this.startTimeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startTimeBox.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.startTimeBox.FormattingEnabled = true;
            this.startTimeBox.Location = new System.Drawing.Point(19, 173);
            this.startTimeBox.Name = "startTimeBox";
            this.startTimeBox.Size = new System.Drawing.Size(189, 31);
            this.startTimeBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(261, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Конец работы";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Начало работы";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Дата работы";
            // 
            // zoneBox
            // 
            this.zoneBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zoneBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoneBox.Location = new System.Drawing.Point(19, 51);
            this.zoneBox.Name = "zoneBox";
            this.zoneBox.Size = new System.Drawing.Size(431, 32);
            this.zoneBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "График работы";
            // 
            // openCreateButton
            // 
            this.openCreateButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.openCreateButton.FlatAppearance.BorderSize = 0;
            this.openCreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openCreateButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openCreateButton.Location = new System.Drawing.Point(1015, 10);
            this.openCreateButton.Name = "openCreateButton";
            this.openCreateButton.Size = new System.Drawing.Size(128, 27);
            this.openCreateButton.TabIndex = 13;
            this.openCreateButton.Text = "Добавить";
            this.openCreateButton.UseVisualStyleBackColor = false;
            this.openCreateButton.Click += new System.EventHandler(this.openCreateButton_Click);
            // 
            // workScheduleGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.workScheduleGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.workScheduleGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.workScheduleGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.workScheduleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workScheduleGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.workScheduleGrid.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.workScheduleGrid.Location = new System.Drawing.Point(0, 135);
            this.workScheduleGrid.Name = "workScheduleGrid";
            this.workScheduleGrid.ReadOnly = true;
            this.workScheduleGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.workScheduleGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.workScheduleGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.workScheduleGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.workScheduleGrid.Size = new System.Drawing.Size(1155, 626);
            this.workScheduleGrid.TabIndex = 8;
            this.workScheduleGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.workScheduleGrid_MouseClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(16, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 26);
            this.button1.TabIndex = 12;
            this.button1.Text = "Все дни";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchPicker
            // 
            this.searchPicker.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.searchPicker.Location = new System.Drawing.Point(131, 95);
            this.searchPicker.Name = "searchPicker";
            this.searchPicker.Size = new System.Drawing.Size(264, 26);
            this.searchPicker.TabIndex = 16;
            this.searchPicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // WorkScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1155, 761);
            this.Controls.Add(this.searchPicker);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.saveToDocxButton);
            this.Controls.Add(this.createPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openCreateButton);
            this.Controls.Add(this.workScheduleGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WorkScheduleForm";
            this.Text = "WorkScheduleForm";
            this.contextMenuStrip1.ResumeLayout(false);
            this.drugPanel.ResumeLayout(false);
            this.createPanel.ResumeLayout(false);
            this.createPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workScheduleGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel drugPanel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveToDocxButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.Panel createPanel;
        private System.Windows.Forms.TextBox zoneBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openCreateButton;
        private System.Windows.Forms.DataGridView workScheduleGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker searchPicker;
        private System.Windows.Forms.ComboBox endTimeBox;
        private System.Windows.Forms.ComboBox startTimeBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateWorkPicker;
    }
}