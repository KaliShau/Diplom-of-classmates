namespace EduManage.Modules.Buses
{
    partial class BusesForm
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
            this.saveToDocxButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.licensePlateBox = new System.Windows.Forms.TextBox();
            this.createPanel = new System.Windows.Forms.Panel();
            this.statusBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nextTechPicker = new System.Windows.Forms.DateTimePicker();
            this.lastTechPicker = new System.Windows.Forms.DateTimePicker();
            this.purchaseDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.notesBox = new System.Windows.Forms.TextBox();
            this.drugPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.modelBox = new System.Windows.Forms.TextBox();
            this.openCreateButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.busesGrid = new System.Windows.Forms.DataGridView();
            this.openPartTypesButton = new System.Windows.Forms.Button();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openBusPartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPanel.SuspendLayout();
            this.drugPanel.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // saveToDocxButton
            // 
            this.saveToDocxButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.saveToDocxButton.FlatAppearance.BorderSize = 0;
            this.saveToDocxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveToDocxButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveToDocxButton.Location = new System.Drawing.Point(815, 12);
            this.saveToDocxButton.Name = "saveToDocxButton";
            this.saveToDocxButton.Size = new System.Drawing.Size(194, 27);
            this.saveToDocxButton.TabIndex = 23;
            this.saveToDocxButton.Text = "Сохранить данные";
            this.saveToDocxButton.UseVisualStyleBackColor = false;
            this.saveToDocxButton.Click += new System.EventHandler(this.saveToDocxButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "Автобусы";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Дата покупки";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(581, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(278, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "Дата следующего технического осмотра";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(581, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Гос. номер";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Дата последнего технического осмотра\r\n";
            // 
            // licensePlateBox
            // 
            this.licensePlateBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.licensePlateBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licensePlateBox.Location = new System.Drawing.Point(585, 111);
            this.licensePlateBox.Name = "licensePlateBox";
            this.licensePlateBox.Size = new System.Drawing.Size(517, 32);
            this.licensePlateBox.TabIndex = 15;
            // 
            // createPanel
            // 
            this.createPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.createPanel.Controls.Add(this.statusBox);
            this.createPanel.Controls.Add(this.label6);
            this.createPanel.Controls.Add(this.nextTechPicker);
            this.createPanel.Controls.Add(this.lastTechPicker);
            this.createPanel.Controls.Add(this.purchaseDatePicker);
            this.createPanel.Controls.Add(this.label8);
            this.createPanel.Controls.Add(this.label5);
            this.createPanel.Controls.Add(this.label9);
            this.createPanel.Controls.Add(this.label3);
            this.createPanel.Controls.Add(this.notesBox);
            this.createPanel.Controls.Add(this.label4);
            this.createPanel.Controls.Add(this.licensePlateBox);
            this.createPanel.Controls.Add(this.drugPanel);
            this.createPanel.Controls.Add(this.createButton);
            this.createPanel.Controls.Add(this.label2);
            this.createPanel.Controls.Add(this.modelBox);
            this.createPanel.Location = new System.Drawing.Point(16, 45);
            this.createPanel.Name = "createPanel";
            this.createPanel.Size = new System.Drawing.Size(1131, 387);
            this.createPanel.TabIndex = 22;
            this.createPanel.Visible = false;
            // 
            // statusBox
            // 
            this.statusBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusBox.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.statusBox.FormattingEnabled = true;
            this.statusBox.Items.AddRange(new object[] {
            "Исправен",
            "Не работает",
            "Нужен ремонт"});
            this.statusBox.Location = new System.Drawing.Point(19, 237);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(517, 31);
            this.statusBox.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "Статус";
            // 
            // nextTechPicker
            // 
            this.nextTechPicker.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.nextTechPicker.Location = new System.Drawing.Point(585, 169);
            this.nextTechPicker.Name = "nextTechPicker";
            this.nextTechPicker.Size = new System.Drawing.Size(517, 32);
            this.nextTechPicker.TabIndex = 18;
            // 
            // lastTechPicker
            // 
            this.lastTechPicker.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.lastTechPicker.Location = new System.Drawing.Point(19, 170);
            this.lastTechPicker.Name = "lastTechPicker";
            this.lastTechPicker.Size = new System.Drawing.Size(517, 32);
            this.lastTechPicker.TabIndex = 18;
            // 
            // purchaseDatePicker
            // 
            this.purchaseDatePicker.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.purchaseDatePicker.Location = new System.Drawing.Point(19, 111);
            this.purchaseDatePicker.Name = "purchaseDatePicker";
            this.purchaseDatePicker.Size = new System.Drawing.Size(517, 32);
            this.purchaseDatePicker.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(581, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Примечания";
            // 
            // notesBox
            // 
            this.notesBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notesBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesBox.Location = new System.Drawing.Point(585, 236);
            this.notesBox.Name = "notesBox";
            this.notesBox.Size = new System.Drawing.Size(517, 32);
            this.notesBox.TabIndex = 15;
            // 
            // drugPanel
            // 
            this.drugPanel.Controls.Add(this.closeButton);
            this.drugPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.drugPanel.Location = new System.Drawing.Point(0, 0);
            this.drugPanel.Name = "drugPanel";
            this.drugPanel.Size = new System.Drawing.Size(1129, 28);
            this.drugPanel.TabIndex = 6;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(1099, 0);
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
            this.createButton.Location = new System.Drawing.Point(483, 296);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(180, 42);
            this.createButton.TabIndex = 5;
            this.createButton.Text = "Добавить";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Модель";
            // 
            // modelBox
            // 
            this.modelBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modelBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelBox.Location = new System.Drawing.Point(19, 51);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(1083, 32);
            this.modelBox.TabIndex = 4;
            // 
            // openCreateButton
            // 
            this.openCreateButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.openCreateButton.FlatAppearance.BorderSize = 0;
            this.openCreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openCreateButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openCreateButton.Location = new System.Drawing.Point(1015, 12);
            this.openCreateButton.Name = "openCreateButton";
            this.openCreateButton.Size = new System.Drawing.Size(128, 27);
            this.openCreateButton.TabIndex = 20;
            this.openCreateButton.Text = "Добавить";
            this.openCreateButton.UseVisualStyleBackColor = false;
            this.openCreateButton.Click += new System.EventHandler(this.openCreateButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Поиск";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.updateToolStripMenuItem.Text = "Обновить";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.deleteToolStripMenuItem.Text = "Удалить";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.toolStripSeparator1,
            this.openBusPartsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(194, 98);
            // 
            // searchBox
            // 
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(16, 73);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(337, 32);
            this.searchBox.TabIndex = 17;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(359, 73);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(128, 32);
            this.searchButton.TabIndex = 18;
            this.searchButton.Text = "Найти";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // busesGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.busesGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.busesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.busesGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.busesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.busesGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.busesGrid.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.busesGrid.Location = new System.Drawing.Point(0, 135);
            this.busesGrid.Name = "busesGrid";
            this.busesGrid.ReadOnly = true;
            this.busesGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.busesGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.busesGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.busesGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.busesGrid.Size = new System.Drawing.Size(1155, 626);
            this.busesGrid.TabIndex = 16;
            this.busesGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.busesGrid_MouseClick);
            // 
            // openPartTypesButton
            // 
            this.openPartTypesButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.openPartTypesButton.FlatAppearance.BorderSize = 0;
            this.openPartTypesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openPartTypesButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openPartTypesButton.Location = new System.Drawing.Point(615, 13);
            this.openPartTypesButton.Name = "openPartTypesButton";
            this.openPartTypesButton.Size = new System.Drawing.Size(194, 27);
            this.openPartTypesButton.TabIndex = 23;
            this.openPartTypesButton.Text = "Типы запчастей";
            this.openPartTypesButton.UseVisualStyleBackColor = false;
            this.openPartTypesButton.Click += new System.EventHandler(this.openPartTypesButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(190, 6);
            // 
            // openBusPartsToolStripMenuItem
            // 
            this.openBusPartsToolStripMenuItem.Name = "openBusPartsToolStripMenuItem";
            this.openBusPartsToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.openBusPartsToolStripMenuItem.Text = "Посмотреть запчасти";
            this.openBusPartsToolStripMenuItem.Click += new System.EventHandler(this.openBusPartsToolStripMenuItem_Click);
            // 
            // BusesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1155, 761);
            this.Controls.Add(this.openPartTypesButton);
            this.Controls.Add(this.saveToDocxButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createPanel);
            this.Controls.Add(this.openCreateButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.busesGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BusesForm";
            this.Text = "BusesForm";
            this.createPanel.ResumeLayout(false);
            this.createPanel.PerformLayout();
            this.drugPanel.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.busesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveToDocxButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox licensePlateBox;
        private System.Windows.Forms.Panel createPanel;
        private System.Windows.Forms.Panel drugPanel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox modelBox;
        private System.Windows.Forms.Button openCreateButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView busesGrid;
        private System.Windows.Forms.DateTimePicker purchaseDatePicker;
        private System.Windows.Forms.DateTimePicker lastTechPicker;
        private System.Windows.Forms.DateTimePicker nextTechPicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox notesBox;
        private System.Windows.Forms.ComboBox statusBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button openPartTypesButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem openBusPartsToolStripMenuItem;
    }
}