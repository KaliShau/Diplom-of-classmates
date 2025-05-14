using System.Drawing;
using System.Windows.Forms;

namespace EduManage.Modules.Purchases
{
    partial class PurchasesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addToInventoruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статусToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStatustoolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.updateStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.drugPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.createPanel = new System.Windows.Forms.Panel();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.supplierBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.unitBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openCreateButton = new System.Windows.Forms.Button();
            this.purchasesGrid = new System.Windows.Forms.DataGridView();
            this.saveToDocxButton = new System.Windows.Forms.Button();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.drugPanel.SuspendLayout();
            this.createPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesGrid)).BeginInit();
            this.SuspendLayout();
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
            this.searchButton.TabIndex = 10;
            this.searchButton.Text = "Найти";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(16, 75);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(337, 32);
            this.searchBox.TabIndex = 9;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.toolStripSeparator1,
            this.addToInventoruToolStripMenuItem,
            this.статусToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(196, 98);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.deleteToolStripMenuItem.Text = "Удалить";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.updateToolStripMenuItem.Text = "Обновить";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(192, 6);
            // 
            // addToInventoruToolStripMenuItem
            // 
            this.addToInventoruToolStripMenuItem.Name = "addToInventoruToolStripMenuItem";
            this.addToInventoruToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.addToInventoruToolStripMenuItem.Text = "Добавить в инвентарь";
            this.addToInventoruToolStripMenuItem.Click += new System.EventHandler(this.addToInventoruToolStripMenuItem_Click);
            // 
            // статусToolStripMenuItem
            // 
            this.статусToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateStatustoolStripComboBox,
            this.updateStatusToolStripMenuItem});
            this.статусToolStripMenuItem.Name = "статусToolStripMenuItem";
            this.статусToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.статусToolStripMenuItem.Text = "Статус";
            // 
            // updateStatustoolStripComboBox
            // 
            this.updateStatustoolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.updateStatustoolStripComboBox.Items.AddRange(new object[] {
            "Новая",
            "Отклонена",
            "Отправлено на склад"});
            this.updateStatustoolStripComboBox.Name = "updateStatustoolStripComboBox";
            this.updateStatustoolStripComboBox.Size = new System.Drawing.Size(121, 23);
            // 
            // updateStatusToolStripMenuItem
            // 
            this.updateStatusToolStripMenuItem.Name = "updateStatusToolStripMenuItem";
            this.updateStatusToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.updateStatusToolStripMenuItem.Text = "Обновить";
            this.updateStatusToolStripMenuItem.Click += new System.EventHandler(this.updateStatusToolStripMenuItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 49);
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
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.createButton.FlatAppearance.BorderSize = 0;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.Location = new System.Drawing.Point(484, 227);
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
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Название";
            // 
            // createPanel
            // 
            this.createPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.createPanel.Controls.Add(this.numericUpDown);
            this.createPanel.Controls.Add(this.supplierBox);
            this.createPanel.Controls.Add(this.label8);
            this.createPanel.Controls.Add(this.label9);
            this.createPanel.Controls.Add(this.label3);
            this.createPanel.Controls.Add(this.label4);
            this.createPanel.Controls.Add(this.priceBox);
            this.createPanel.Controls.Add(this.unitBox);
            this.createPanel.Controls.Add(this.drugPanel);
            this.createPanel.Controls.Add(this.createButton);
            this.createPanel.Controls.Add(this.label2);
            this.createPanel.Controls.Add(this.nameBox);
            this.createPanel.Location = new System.Drawing.Point(20, 47);
            this.createPanel.Name = "createPanel";
            this.createPanel.Size = new System.Drawing.Size(1127, 291);
            this.createPanel.TabIndex = 14;
            this.createPanel.Visible = false;
            // 
            // numericUpDown
            // 
            this.numericUpDown.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.numericUpDown.Location = new System.Drawing.Point(19, 111);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(489, 32);
            this.numericUpDown.TabIndex = 18;
            // 
            // supplierBox
            // 
            this.supplierBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.supplierBox.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.supplierBox.FormattingEnabled = true;
            this.supplierBox.Location = new System.Drawing.Point(19, 172);
            this.supplierBox.Name = "supplierBox";
            this.supplierBox.Size = new System.Drawing.Size(489, 31);
            this.supplierBox.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Количество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(581, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Единица измерения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Поставщик";
            // 
            // unitBox
            // 
            this.unitBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.unitBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitBox.Location = new System.Drawing.Point(585, 111);
            this.unitBox.Name = "unitBox";
            this.unitBox.Size = new System.Drawing.Size(517, 32);
            this.unitBox.TabIndex = 15;
            // 
            // nameBox
            // 
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(19, 51);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(1083, 32);
            this.nameBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Закупки";
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
            // purchasesGrid
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.purchasesGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.purchasesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.purchasesGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.purchasesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchasesGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.purchasesGrid.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.purchasesGrid.Location = new System.Drawing.Point(0, 135);
            this.purchasesGrid.Name = "purchasesGrid";
            this.purchasesGrid.ReadOnly = true;
            this.purchasesGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.purchasesGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.purchasesGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.purchasesGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.purchasesGrid.Size = new System.Drawing.Size(1155, 626);
            this.purchasesGrid.TabIndex = 8;
            this.purchasesGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.purchasesGrid_MouseClick);
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
            this.saveToDocxButton.TabIndex = 15;
            this.saveToDocxButton.Text = "Сохранить данные";
            this.saveToDocxButton.UseVisualStyleBackColor = false;
            this.saveToDocxButton.Click += new System.EventHandler(this.saveToDocxButton_Click);
            // 
            // priceBox
            // 
            this.priceBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceBox.Location = new System.Drawing.Point(585, 171);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(517, 32);
            this.priceBox.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(581, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "Цена за единицу";
            // 
            // PurchasesForm
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
            this.Controls.Add(this.purchasesGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PurchasesForm";
            this.Text = "PurchasesForm";
            this.contextMenuStrip1.ResumeLayout(false);
            this.drugPanel.ResumeLayout(false);
            this.createPanel.ResumeLayout(false);
            this.createPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Label label2;
        private TextBox statusBox;
        private TextBox roomBox;
        private TextBox quantityBox;
        private Panel createPanel;
        private TextBox nameBox;
        private Label label1;
        private Button openCreateButton;
        private DataGridView purchasesGrid;
        private ComboBox supplierBox;
        private Label label4;
        private NumericUpDown numericUpDown;
        private Label label8;
        private Label label3;
        private TextBox unitBox;
        private ToolStripMenuItem addToInventoruToolStripMenuItem;
        private ToolStripMenuItem updateToolStripMenuItem;
        private ToolStripMenuItem статусToolStripMenuItem;
        private ToolStripComboBox updateStatustoolStripComboBox;
        private ToolStripMenuItem updateStatusToolStripMenuItem;
        private Button saveToDocxButton;
        private Label label9;
        private TextBox priceBox;
    }
}