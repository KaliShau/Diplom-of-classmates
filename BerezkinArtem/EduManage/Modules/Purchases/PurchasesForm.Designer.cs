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
            createButton = new Button();
            label3 = new Label();
            label2 = new Label();
            amountBox = new TextBox();
            createPanel = new Panel();
            supplierBox = new ComboBox();
            label4 = new Label();
            nameBox = new TextBox();
            label1 = new Label();
            openCreateButton = new Button();
            purchasesGrid = new DataGridView();
            contextMenuStrip1.SuspendLayout();
            drugPanel.SuspendLayout();
            createPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)purchasesGrid).BeginInit();
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
            contextMenuStrip1.Size = new Size(181, 54);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(180, 22);
            deleteToolStripMenuItem.Text = "Удалить";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
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
            drugPanel.Size = new Size(983, 32);
            drugPanel.TabIndex = 6;
            // 
            // closeButton
            // 
            closeButton.BackColor = SystemColors.ControlLightLight;
            closeButton.Dock = DockStyle.Right;
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeButton.Location = new Point(948, 0);
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
            createButton.Location = new Point(366, 259);
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
            label3.Size = new Size(89, 19);
            label3.TabIndex = 5;
            label3.Text = "Количество";
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
            // amountBox
            // 
            amountBox.BorderStyle = BorderStyle.FixedSingle;
            amountBox.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            amountBox.Location = new Point(22, 125);
            amountBox.Name = "amountBox";
            amountBox.Size = new Size(943, 32);
            amountBox.TabIndex = 4;
            // 
            // createPanel
            // 
            createPanel.BorderStyle = BorderStyle.FixedSingle;
            createPanel.Controls.Add(supplierBox);
            createPanel.Controls.Add(label4);
            createPanel.Controls.Add(drugPanel);
            createPanel.Controls.Add(createButton);
            createPanel.Controls.Add(label3);
            createPanel.Controls.Add(label2);
            createPanel.Controls.Add(amountBox);
            createPanel.Controls.Add(nameBox);
            createPanel.Location = new Point(22, 44);
            createPanel.Name = "createPanel";
            createPanel.Size = new Size(985, 336);
            createPanel.TabIndex = 14;
            createPanel.Visible = false;
            // 
            // supplierBox
            // 
            supplierBox.DropDownStyle = ComboBoxStyle.DropDownList;
            supplierBox.Font = new Font("Times New Roman", 15.75F);
            supplierBox.FormattingEnabled = true;
            supplierBox.Location = new Point(22, 199);
            supplierBox.Name = "supplierBox";
            supplierBox.Size = new Size(943, 31);
            supplierBox.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 172);
            label4.Name = "label4";
            label4.Size = new Size(84, 19);
            label4.TabIndex = 8;
            label4.Text = "Поставщик";
            // 
            // nameBox
            // 
            nameBox.BorderStyle = BorderStyle.FixedSingle;
            nameBox.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameBox.Location = new Point(22, 59);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(943, 32);
            nameBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 5);
            label1.Name = "label1";
            label1.Size = new Size(125, 32);
            label1.TabIndex = 13;
            label1.Text = "Закупки";
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
            // purchasesGrid
            // 
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLightLight;
            purchasesGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            purchasesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            purchasesGrid.BackgroundColor = SystemColors.ControlLightLight;
            purchasesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            purchasesGrid.Dock = DockStyle.Bottom;
            purchasesGrid.GridColor = SystemColors.GradientActiveCaption;
            purchasesGrid.Location = new Point(0, 151);
            purchasesGrid.Name = "purchasesGrid";
            purchasesGrid.ReadOnly = true;
            purchasesGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.BackColor = SystemColors.GradientActiveCaption;
            purchasesGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            purchasesGrid.RowTemplate.DefaultCellStyle.BackColor = SystemColors.GradientActiveCaption;
            purchasesGrid.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            purchasesGrid.Size = new Size(1032, 539);
            purchasesGrid.TabIndex = 8;
            purchasesGrid.MouseClick += purchasesGrid_MouseClick;
            // 
            // PurchasesForm
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
            Controls.Add(purchasesGrid);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PurchasesForm";
            Text = "PurchasesForm";
            contextMenuStrip1.ResumeLayout(false);
            drugPanel.ResumeLayout(false);
            createPanel.ResumeLayout(false);
            createPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)purchasesGrid).EndInit();
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
        private TextBox statusBox;
        private TextBox roomBox;
        private TextBox quantityBox;
        private TextBox amountBox;
        private Panel createPanel;
        private TextBox nameBox;
        private Label label1;
        private Button openCreateButton;
        private DataGridView purchasesGrid;
        private ComboBox supplierBox;
        private Label label4;
    }
}