using System.Drawing;
using System.Windows.Forms;

namespace EduManage.Modules.Inventory
{
    partial class InventoryForm
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
            this.inventoryGrid = new System.Windows.Forms.DataGridView();
            this.openCreateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.createPanel = new System.Windows.Forms.Panel();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.statusBox = new System.Windows.Forms.ComboBox();
            this.drugPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roomBox = new System.Windows.Forms.TextBox();
            this.unitBox = new System.Windows.Forms.TextBox();
            this.categoryBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.сменитьСтатусToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusBox = new System.Windows.Forms.ToolStripComboBox();
            this.updateStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToDocxButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGrid)).BeginInit();
            this.createPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.drugPanel.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inventoryGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.inventoryGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.inventoryGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inventoryGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.inventoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.inventoryGrid.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.inventoryGrid.Location = new System.Drawing.Point(0, 135);
            this.inventoryGrid.Name = "inventoryGrid";
            this.inventoryGrid.ReadOnly = true;
            this.inventoryGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.inventoryGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.inventoryGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.inventoryGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.inventoryGrid.Size = new System.Drawing.Size(1155, 626);
            this.inventoryGrid.TabIndex = 0;
            this.inventoryGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.inventoryGrid_MouseClick);
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
            this.openCreateButton.TabIndex = 5;
            this.openCreateButton.Text = "Добавить";
            this.openCreateButton.UseVisualStyleBackColor = false;
            this.openCreateButton.Click += new System.EventHandler(this.openCreateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Инвентарь";
            // 
            // createPanel
            // 
            this.createPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.createPanel.Controls.Add(this.numericUpDown);
            this.createPanel.Controls.Add(this.statusBox);
            this.createPanel.Controls.Add(this.drugPanel);
            this.createPanel.Controls.Add(this.label6);
            this.createPanel.Controls.Add(this.label5);
            this.createPanel.Controls.Add(this.label8);
            this.createPanel.Controls.Add(this.label4);
            this.createPanel.Controls.Add(this.createButton);
            this.createPanel.Controls.Add(this.label3);
            this.createPanel.Controls.Add(this.label2);
            this.createPanel.Controls.Add(this.roomBox);
            this.createPanel.Controls.Add(this.unitBox);
            this.createPanel.Controls.Add(this.categoryBox);
            this.createPanel.Controls.Add(this.nameBox);
            this.createPanel.Location = new System.Drawing.Point(675, 47);
            this.createPanel.Name = "createPanel";
            this.createPanel.Size = new System.Drawing.Size(468, 546);
            this.createPanel.TabIndex = 7;
            this.createPanel.Visible = false;
            // 
            // numericUpDown
            // 
            this.numericUpDown.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.numericUpDown.Location = new System.Drawing.Point(19, 170);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(189, 32);
            this.numericUpDown.TabIndex = 8;
            // 
            // statusBox
            // 
            this.statusBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusBox.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.statusBox.FormattingEnabled = true;
            this.statusBox.Items.AddRange(new object[] {
            "Новая",
            "Нужен ремонт",
            "Починили",
            "Утилизация"});
            this.statusBox.Location = new System.Drawing.Point(19, 285);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(432, 31);
            this.statusBox.TabIndex = 10;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Статус";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Комната";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "Количество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(229, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Единица измерения";
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.createButton.FlatAppearance.BorderSize = 0;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.Location = new System.Drawing.Point(139, 339);
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
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Категория";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Название";
            // 
            // roomBox
            // 
            this.roomBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomBox.Location = new System.Drawing.Point(19, 231);
            this.roomBox.Name = "roomBox";
            this.roomBox.Size = new System.Drawing.Size(431, 32);
            this.roomBox.TabIndex = 4;
            // 
            // unitBox
            // 
            this.unitBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.unitBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitBox.Location = new System.Drawing.Point(229, 170);
            this.unitBox.Name = "unitBox";
            this.unitBox.Size = new System.Drawing.Size(221, 32);
            this.unitBox.TabIndex = 4;
            // 
            // categoryBox
            // 
            this.categoryBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categoryBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryBox.Location = new System.Drawing.Point(19, 108);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(431, 32);
            this.categoryBox.TabIndex = 4;
            // 
            // nameBox
            // 
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(19, 51);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(431, 32);
            this.nameBox.TabIndex = 4;
            // 
            // searchBox
            // 
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(16, 75);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(337, 32);
            this.searchBox.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "Поиск";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(359, 75);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(128, 32);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Найти";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.toolStripSeparator1,
            this.сменитьСтатусToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(129, 76);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.deleteToolStripMenuItem.Text = "Удалить";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.updateToolStripMenuItem.Text = "Обновить";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(125, 6);
            // 
            // сменитьСтатусToolStripMenuItem
            // 
            this.сменитьСтатусToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusBox,
            this.updateStatusToolStripMenuItem});
            this.сменитьСтатусToolStripMenuItem.Name = "сменитьСтатусToolStripMenuItem";
            this.сменитьСтатусToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.сменитьСтатусToolStripMenuItem.Text = "Статус";
            // 
            // toolStripStatusBox
            // 
            this.toolStripStatusBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripStatusBox.Items.AddRange(new object[] {
            "Новая",
            "Нужен ремонт",
            "Починили",
            "Утилизация"});
            this.toolStripStatusBox.Name = "toolStripStatusBox";
            this.toolStripStatusBox.Size = new System.Drawing.Size(121, 23);
            this.toolStripStatusBox.Sorted = true;
            // 
            // updateStatusToolStripMenuItem
            // 
            this.updateStatusToolStripMenuItem.Name = "updateStatusToolStripMenuItem";
            this.updateStatusToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.updateStatusToolStripMenuItem.Text = "Сменить";
            this.updateStatusToolStripMenuItem.Click += new System.EventHandler(this.updateStatusToolStripMenuItem_Click);
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
            this.saveToDocxButton.TabIndex = 5;
            this.saveToDocxButton.Text = "Сохранить данные";
            this.saveToDocxButton.UseVisualStyleBackColor = false;
            this.saveToDocxButton.Click += new System.EventHandler(this.saveToDocxButton_Click);
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1155, 761);
            this.Controls.Add(this.createPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.saveToDocxButton);
            this.Controls.Add(this.openCreateButton);
            this.Controls.Add(this.inventoryGrid);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventoryForm";
            this.Text = "InventoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGrid)).EndInit();
            this.createPanel.ResumeLayout(false);
            this.createPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.drugPanel.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView inventoryGrid;
        private Button openCreateButton;
        private Label label1;
        private Panel createPanel;
        private Label label5;
        private Label label4;
        private Button createButton;
        private Label label3;
        private Label label2;
        private TextBox roomBox;
        private TextBox unitBox;
        private TextBox categoryBox;
        private TextBox nameBox;
        private Label label6;
        private TextBox searchBox;
        private Label label7;
        private Button searchButton;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Button closeButton;
        private ToolStripMenuItem updateToolStripMenuItem;
        private Panel drugPanel;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem сменитьСтатусToolStripMenuItem;
        private ToolStripComboBox toolStripStatusBox;
        private ToolStripMenuItem updateStatusToolStripMenuItem;
        private ComboBox statusBox;
        private NumericUpDown numericUpDown;
        private Label label8;
        private Button saveToDocxButton;
    }
}