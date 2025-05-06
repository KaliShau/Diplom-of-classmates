namespace EduManage.Modules.Requests
{
    partial class RequestsForm
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
            contextMenuStrip1 = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            searchButton = new Button();
            label7 = new Label();
            closeButton = new Button();
            createButton = new Button();
            searchBox = new TextBox();
            label2 = new Label();
            createPanel = new Panel();
            problemBox = new TextBox();
            inventoryBox = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            openCreateButton = new Button();
            requestsGrid = new DataGridView();
            contextMenuStrip1.SuspendLayout();
            createPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)requestsGrid).BeginInit();
            SuspendLayout();
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
            searchButton.Location = new Point(284, 82);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(149, 32);
            searchButton.TabIndex = 10;
            searchButton.Text = "Найти";
            searchButton.UseVisualStyleBackColor = false;
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
            // searchBox
            // 
            searchBox.BorderStyle = BorderStyle.FixedSingle;
            searchBox.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBox.Location = new Point(12, 82);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(256, 32);
            searchBox.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 35);
            label2.Name = "label2";
            label2.Size = new Size(76, 19);
            label2.TabIndex = 5;
            label2.Text = "Проблема";
            // 
            // createPanel
            // 
            createPanel.BorderStyle = BorderStyle.FixedSingle;
            createPanel.Controls.Add(problemBox);
            createPanel.Controls.Add(inventoryBox);
            createPanel.Controls.Add(closeButton);
            createPanel.Controls.Add(createButton);
            createPanel.Controls.Add(label3);
            createPanel.Controls.Add(label2);
            createPanel.Location = new Point(12, 47);
            createPanel.Name = "createPanel";
            createPanel.Size = new Size(995, 334);
            createPanel.TabIndex = 14;
            createPanel.Visible = false;
            // 
            // problemBox
            // 
            problemBox.BorderStyle = BorderStyle.FixedSingle;
            problemBox.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            problemBox.Location = new Point(22, 65);
            problemBox.Multiline = true;
            problemBox.Name = "problemBox";
            problemBox.Size = new Size(955, 103);
            problemBox.TabIndex = 8;
            // 
            // inventoryBox
            // 
            inventoryBox.Font = new Font("Times New Roman", 15.75F);
            inventoryBox.FormattingEnabled = true;
            inventoryBox.Location = new Point(22, 198);
            inventoryBox.Name = "inventoryBox";
            inventoryBox.Size = new Size(955, 31);
            inventoryBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 171);
            label3.Name = "label3";
            label3.Size = new Size(143, 19);
            label3.TabIndex = 5;
            label3.Text = "Предмет инвенторя";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 5);
            label1.Name = "label1";
            label1.Size = new Size(109, 32);
            label1.TabIndex = 13;
            label1.Text = "Заявки";
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
            // requestsGrid
            // 
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLightLight;
            requestsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            requestsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            requestsGrid.BackgroundColor = SystemColors.ControlLightLight;
            requestsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            requestsGrid.Dock = DockStyle.Bottom;
            requestsGrid.GridColor = SystemColors.GradientActiveCaption;
            requestsGrid.Location = new Point(0, 151);
            requestsGrid.Name = "requestsGrid";
            requestsGrid.ReadOnly = true;
            requestsGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.BackColor = SystemColors.GradientActiveCaption;
            requestsGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            requestsGrid.RowTemplate.DefaultCellStyle.BackColor = SystemColors.GradientActiveCaption;
            requestsGrid.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            requestsGrid.Size = new Size(1032, 539);
            requestsGrid.TabIndex = 8;
            requestsGrid.MouseClick += requestsGrid_MouseClick;
            // 
            // RequestsForm
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
            Controls.Add(requestsGrid);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RequestsForm";
            Text = "RequestsForm";
            contextMenuStrip1.ResumeLayout(false);
            createPanel.ResumeLayout(false);
            createPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)requestsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Button searchButton;
        private Label label7;
        private Button closeButton;
        private Button createButton;
        private TextBox searchBox;
        private Label label2;
        private Panel createPanel;
        private Label label1;
        private Button openCreateButton;
        private DataGridView requestsGrid;
        private ComboBox inventoryBox;
        private Label label3;
        private TextBox problemBox;
    }
}