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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            inventoryGrid = new DataGridView();
            openCreateButton = new Button();
            label1 = new Label();
            createPanel = new Panel();
            label2 = new Label();
            loginBox = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            createButton = new Button();
            ((System.ComponentModel.ISupportInitialize)inventoryGrid).BeginInit();
            createPanel.SuspendLayout();
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
            createPanel.Controls.Add(label5);
            createPanel.Controls.Add(label4);
            createPanel.Controls.Add(createButton);
            createPanel.Controls.Add(label3);
            createPanel.Controls.Add(label2);
            createPanel.Controls.Add(textBox3);
            createPanel.Controls.Add(textBox2);
            createPanel.Controls.Add(textBox1);
            createPanel.Controls.Add(loginBox);
            createPanel.Location = new Point(461, 48);
            createPanel.Name = "createPanel";
            createPanel.Size = new Size(546, 519);
            createPanel.TabIndex = 7;
            createPanel.Visible = false;
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
            // loginBox
            // 
            loginBox.BorderStyle = BorderStyle.FixedSingle;
            loginBox.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginBox.Location = new Point(22, 59);
            loginBox.Name = "loginBox";
            loginBox.Size = new Size(503, 32);
            loginBox.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(22, 125);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(503, 32);
            textBox1.TabIndex = 4;
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
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(22, 196);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(503, 32);
            textBox2.TabIndex = 4;
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
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(22, 267);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(503, 32);
            textBox3.TabIndex = 4;
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
            // createButton
            // 
            createButton.BackColor = SystemColors.GradientActiveCaption;
            createButton.FlatAppearance.BorderSize = 0;
            createButton.FlatStyle = FlatStyle.Flat;
            createButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createButton.Location = new Point(162, 329);
            createButton.Name = "createButton";
            createButton.Size = new Size(210, 49);
            createButton.TabIndex = 5;
            createButton.Text = "Добавить";
            createButton.UseVisualStyleBackColor = false;
            createButton.Click += openCreateButton_Click;
            // 
            // InventoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1032, 690);
            Controls.Add(createPanel);
            Controls.Add(label1);
            Controls.Add(openCreateButton);
            Controls.Add(inventoryGrid);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InventoryForm";
            Text = "InventoryForm";
            ((System.ComponentModel.ISupportInitialize)inventoryGrid).EndInit();
            createPanel.ResumeLayout(false);
            createPanel.PerformLayout();
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
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox loginBox;
    }
}