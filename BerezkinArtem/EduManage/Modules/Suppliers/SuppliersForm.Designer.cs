namespace EduManage.Modules.Suppliers
{
    partial class SuppliersForm
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
            createPanel = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            phoneBox = new TextBox();
            contactBox = new TextBox();
            nameBox = new TextBox();
            closeButton = new Button();
            createButton = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            searchButton = new Button();
            label7 = new Label();
            searchBox = new TextBox();
            label1 = new Label();
            openCreateButton = new Button();
            suppliersGrid = new DataGridView();
            createPanel.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)suppliersGrid).BeginInit();
            SuspendLayout();
            // 
            // createPanel
            // 
            createPanel.BorderStyle = BorderStyle.FixedSingle;
            createPanel.Controls.Add(label6);
            createPanel.Controls.Add(label5);
            createPanel.Controls.Add(label4);
            createPanel.Controls.Add(phoneBox);
            createPanel.Controls.Add(contactBox);
            createPanel.Controls.Add(nameBox);
            createPanel.Controls.Add(closeButton);
            createPanel.Controls.Add(createButton);
            createPanel.Location = new Point(12, 45);
            createPanel.Name = "createPanel";
            createPanel.Size = new Size(995, 420);
            createPanel.TabIndex = 21;
            createPanel.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(246, 151);
            label6.Name = "label6";
            label6.Size = new Size(119, 19);
            label6.TabIndex = 11;
            label6.Text = "Номер телефона";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(246, 87);
            label5.Name = "label5";
            label5.Size = new Size(126, 19);
            label5.TabIndex = 12;
            label5.Text = "Контактное лицо";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(246, 16);
            label4.Name = "label4";
            label4.Size = new Size(37, 19);
            label4.TabIndex = 13;
            label4.Text = "Имя";
            // 
            // phoneBox
            // 
            phoneBox.BorderStyle = BorderStyle.FixedSingle;
            phoneBox.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneBox.Location = new Point(246, 175);
            phoneBox.Name = "phoneBox";
            phoneBox.Size = new Size(503, 32);
            phoneBox.TabIndex = 6;
            // 
            // contactBox
            // 
            contactBox.BorderStyle = BorderStyle.FixedSingle;
            contactBox.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contactBox.Location = new Point(246, 111);
            contactBox.Name = "contactBox";
            contactBox.Size = new Size(503, 32);
            contactBox.TabIndex = 7;
            // 
            // nameBox
            // 
            nameBox.BorderStyle = BorderStyle.FixedSingle;
            nameBox.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameBox.Location = new Point(246, 40);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(503, 32);
            nameBox.TabIndex = 8;
            // 
            // closeButton
            // 
            closeButton.BackColor = SystemColors.ControlLightLight;
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeButton.Location = new Point(954, 3);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(36, 32);
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
            createButton.Location = new Point(392, 252);
            createButton.Name = "createButton";
            createButton.Size = new Size(210, 49);
            createButton.TabIndex = 5;
            createButton.Text = "Добавить";
            createButton.UseVisualStyleBackColor = false;
            createButton.Click += createButton_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(119, 26);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(118, 22);
            deleteToolStripMenuItem.Text = "Удалить";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // searchButton
            // 
            searchButton.BackColor = SystemColors.GradientActiveCaption;
            searchButton.FlatAppearance.BorderSize = 0;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchButton.Location = new Point(284, 80);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(149, 32);
            searchButton.TabIndex = 17;
            searchButton.Text = "Найти";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 56);
            label7.Name = "label7";
            label7.Size = new Size(51, 19);
            label7.TabIndex = 18;
            label7.Text = "Поиск";
            // 
            // searchBox
            // 
            searchBox.BorderStyle = BorderStyle.FixedSingle;
            searchBox.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBox.Location = new Point(12, 80);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(256, 32);
            searchBox.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 3);
            label1.Name = "label1";
            label1.Size = new Size(183, 32);
            label1.TabIndex = 20;
            label1.Text = "Поставщики";
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
            // suppliersGrid
            // 
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLightLight;
            suppliersGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            suppliersGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            suppliersGrid.BackgroundColor = SystemColors.ControlLightLight;
            suppliersGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            suppliersGrid.Dock = DockStyle.Bottom;
            suppliersGrid.GridColor = SystemColors.GradientActiveCaption;
            suppliersGrid.Location = new Point(0, 151);
            suppliersGrid.Name = "suppliersGrid";
            suppliersGrid.ReadOnly = true;
            suppliersGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.BackColor = SystemColors.GradientActiveCaption;
            suppliersGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            suppliersGrid.RowTemplate.DefaultCellStyle.BackColor = SystemColors.GradientActiveCaption;
            suppliersGrid.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            suppliersGrid.Size = new Size(1032, 539);
            suppliersGrid.TabIndex = 15;
            suppliersGrid.MouseClick += suppliersGrid_MouseClick;
            // 
            // SuppliersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1032, 690);
            Controls.Add(createPanel);
            Controls.Add(searchButton);
            Controls.Add(label7);
            Controls.Add(searchBox);
            Controls.Add(label1);
            Controls.Add(openCreateButton);
            Controls.Add(suppliersGrid);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SuppliersForm";
            Text = "SuppliersForm";
            createPanel.ResumeLayout(false);
            createPanel.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)suppliersGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel createPanel;
        private Button closeButton;
        private Button createButton;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Button searchButton;
        private Label label7;
        private TextBox searchBox;
        private Label label1;
        private Button openCreateButton;
        private DataGridView suppliersGrid;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox phoneBox;
        private TextBox contactBox;
        private TextBox nameBox;
    }
}