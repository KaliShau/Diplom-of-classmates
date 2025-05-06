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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            inventoryGrid = new DataGridView();
            openCreateButton = new Button();
            label1 = new Label();
            createPanel = new Panel();
            drugPanel = new Panel();
            closeButton = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            createButton = new Button();
            label3 = new Label();
            label2 = new Label();
            statusBox = new TextBox();
            roomBox = new TextBox();
            quantityBox = new TextBox();
            categoryBox = new TextBox();
            nameBox = new TextBox();
            searchBox = new TextBox();
            label7 = new Label();
            searchButton = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            updateToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            сменитьСтатусToolStripMenuItem = new ToolStripMenuItem();
            toolStripStatusBox = new ToolStripComboBox();
            updateStatusToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)inventoryGrid).BeginInit();
            createPanel.SuspendLayout();
            drugPanel.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // inventoryGrid
            // 
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLightLight;
            inventoryGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            inventoryGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            inventoryGrid.BackgroundColor = SystemColors.ControlLightLight;
            inventoryGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inventoryGrid.Dock = DockStyle.Bottom;
            inventoryGrid.GridColor = SystemColors.GradientActiveCaption;
            inventoryGrid.Location = new Point(0, 151);
            inventoryGrid.Name = "inventoryGrid";
            inventoryGrid.ReadOnly = true;
            inventoryGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.BackColor = SystemColors.GradientActiveCaption;
            inventoryGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            inventoryGrid.RowTemplate.DefaultCellStyle.BackColor = SystemColors.GradientActiveCaption;
            inventoryGrid.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            inventoryGrid.Size = new Size(1032, 539);
            inventoryGrid.TabIndex = 0;
            inventoryGrid.MouseClick += inventoryGrid_MouseClick;
            // 
            // openCreateButton
            // 
            openCreateButton.BackColor = SystemColors.GradientActiveCaption;
            openCreateButton.FlatAppearance.BorderSize = 0;
            openCreateButton.FlatStyle = FlatStyle.Flat;
            openCreateButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            openCreateButton.Location = new Point(858, 14);
            openCreateButton.Name = "openCreateButton";
            openCreateButton.Size = new Size(149, 31);
            openCreateButton.TabIndex = 5;
            openCreateButton.Text = "Добавить";
            openCreateButton.UseVisualStyleBackColor = false;
            openCreateButton.Click += openCreateButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(159, 32);
            label1.TabIndex = 6;
            label1.Text = "Инвентарь";
            // 
            // createPanel
            // 
            createPanel.BorderStyle = BorderStyle.FixedSingle;
            createPanel.Controls.Add(drugPanel);
            createPanel.Controls.Add(label6);
            createPanel.Controls.Add(label5);
            createPanel.Controls.Add(label4);
            createPanel.Controls.Add(createButton);
            createPanel.Controls.Add(label3);
            createPanel.Controls.Add(label2);
            createPanel.Controls.Add(statusBox);
            createPanel.Controls.Add(roomBox);
            createPanel.Controls.Add(quantityBox);
            createPanel.Controls.Add(categoryBox);
            createPanel.Controls.Add(nameBox);
            createPanel.Location = new Point(461, 48);
            createPanel.Name = "createPanel";
            createPanel.Size = new Size(546, 630);
            createPanel.TabIndex = 7;
            createPanel.Visible = false;
            // 
            // drugPanel
            // 
            drugPanel.Controls.Add(closeButton);
            drugPanel.Dock = DockStyle.Top;
            drugPanel.Location = new Point(0, 0);
            drugPanel.Name = "drugPanel";
            drugPanel.Size = new Size(544, 32);
            drugPanel.TabIndex = 6;
            // 
            // closeButton
            // 
            closeButton.BackColor = SystemColors.ControlLightLight;
            closeButton.Dock = DockStyle.Right;
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeButton.Location = new Point(509, 0);
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
            label5.Size = new Size(67, 19);
            label5.TabIndex = 5;
            label5.Text = "Комната";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 172);
            label4.Name = "label4";
            label4.Size = new Size(89, 19);
            label4.TabIndex = 5;
            label4.Text = "Количество";
            // 
            // createButton
            // 
            createButton.BackColor = SystemColors.GradientActiveCaption;
            createButton.FlatAppearance.BorderSize = 0;
            createButton.FlatStyle = FlatStyle.Flat;
            createButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createButton.Location = new Point(162, 391);
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
            label3.Size = new Size(79, 19);
            label3.TabIndex = 5;
            label3.Text = "Категория";
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
            // statusBox
            // 
            statusBox.BorderStyle = BorderStyle.FixedSingle;
            statusBox.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusBox.Location = new Point(22, 331);
            statusBox.Name = "statusBox";
            statusBox.Size = new Size(503, 32);
            statusBox.TabIndex = 4;
            // 
            // roomBox
            // 
            roomBox.BorderStyle = BorderStyle.FixedSingle;
            roomBox.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roomBox.Location = new Point(22, 267);
            roomBox.Name = "roomBox";
            roomBox.Size = new Size(503, 32);
            roomBox.TabIndex = 4;
            // 
            // quantityBox
            // 
            quantityBox.BorderStyle = BorderStyle.FixedSingle;
            quantityBox.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quantityBox.Location = new Point(22, 196);
            quantityBox.Name = "quantityBox";
            quantityBox.Size = new Size(503, 32);
            quantityBox.TabIndex = 4;
            // 
            // categoryBox
            // 
            categoryBox.BorderStyle = BorderStyle.FixedSingle;
            categoryBox.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            categoryBox.Location = new Point(22, 125);
            categoryBox.Name = "categoryBox";
            categoryBox.Size = new Size(503, 32);
            categoryBox.TabIndex = 4;
            // 
            // nameBox
            // 
            nameBox.BorderStyle = BorderStyle.FixedSingle;
            nameBox.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameBox.Location = new Point(22, 59);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(503, 32);
            nameBox.TabIndex = 4;
            // 
            // searchBox
            // 
            searchBox.BorderStyle = BorderStyle.FixedSingle;
            searchBox.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBox.Location = new Point(12, 86);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(256, 32);
            searchBox.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 62);
            label7.Name = "label7";
            label7.Size = new Size(51, 19);
            label7.TabIndex = 5;
            label7.Text = "Поиск";
            // 
            // searchButton
            // 
            searchButton.BackColor = SystemColors.GradientActiveCaption;
            searchButton.FlatAppearance.BorderSize = 0;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchButton.Location = new Point(284, 86);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(149, 32);
            searchButton.TabIndex = 5;
            searchButton.Text = "Найти";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem, updateToolStripMenuItem, toolStripSeparator1, сменитьСтатусToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(129, 76);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(128, 22);
            deleteToolStripMenuItem.Text = "Удалить";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // updateToolStripMenuItem
            // 
            updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            updateToolStripMenuItem.Size = new Size(128, 22);
            updateToolStripMenuItem.Text = "Обновить";
            updateToolStripMenuItem.Click += updateToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(125, 6);
            // 
            // сменитьСтатусToolStripMenuItem
            // 
            сменитьСтатусToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripStatusBox, updateStatusToolStripMenuItem });
            сменитьСтатусToolStripMenuItem.Name = "сменитьСтатусToolStripMenuItem";
            сменитьСтатусToolStripMenuItem.Size = new Size(128, 22);
            сменитьСтатусToolStripMenuItem.Text = "Статус";
            // 
            // toolStripStatusBox
            // 
            toolStripStatusBox.DropDownStyle = ComboBoxStyle.DropDownList;
            toolStripStatusBox.Items.AddRange(new object[] { "Новая", "Нужен ремонт", "Починили", "Утилизация" });
            toolStripStatusBox.Name = "toolStripStatusBox";
            toolStripStatusBox.Size = new Size(121, 23);
            toolStripStatusBox.Sorted = true;
            // 
            // updateStatusToolStripMenuItem
            // 
            updateStatusToolStripMenuItem.Name = "updateStatusToolStripMenuItem";
            updateStatusToolStripMenuItem.Size = new Size(181, 22);
            updateStatusToolStripMenuItem.Text = "Сменить";
            updateStatusToolStripMenuItem.Click += updateStatusToolStripMenuItem_Click;
            // 
            // InventoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1032, 690);
            Controls.Add(createPanel);
            Controls.Add(label1);
            Controls.Add(searchButton);
            Controls.Add(openCreateButton);
            Controls.Add(inventoryGrid);
            Controls.Add(searchBox);
            Controls.Add(label7);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InventoryForm";
            Text = "InventoryForm";
            ((System.ComponentModel.ISupportInitialize)inventoryGrid).EndInit();
            createPanel.ResumeLayout(false);
            createPanel.PerformLayout();
            drugPanel.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private TextBox quantityBox;
        private TextBox categoryBox;
        private TextBox nameBox;
        private Label label6;
        private TextBox statusBox;
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
    }
}