namespace EduManage.Modules.PartOperations
{
    partial class PartOperationsForm
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
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.operationGrid = new System.Windows.Forms.DataGridView();
            this.quantityUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.openBusPartsButton = new System.Windows.Forms.Button();
            this.openCreateButton = new System.Windows.Forms.Button();
            this.createBuyButton = new System.Windows.Forms.Button();
            this.defectLabel = new System.Windows.Forms.Label();
            this.drugPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.partTypeBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buyPanel = new System.Windows.Forms.Panel();
            this.unitBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.operationBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.suppliersBox = new System.Windows.Forms.ComboBox();
            this.notesBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.addPanel = new System.Windows.Forms.Panel();
            this.addQuantityUpDown = new System.Windows.Forms.NumericUpDown();
            this.addStaffBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.addTypePartBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.createAddButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.addNotesBox = new System.Windows.Forms.TextBox();
            this.addUnitBox = new System.Windows.Forms.TextBox();
            this.delPanel = new System.Windows.Forms.Panel();
            this.delQuantityupDown = new System.Windows.Forms.NumericUpDown();
            this.delStaffBox = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.delPartBox = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.createDelButton = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.delNotesBox = new System.Windows.Forms.TextBox();
            this.delUnitBox = new System.Windows.Forms.TextBox();
            this.exportButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.operationGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDown)).BeginInit();
            this.drugPanel.SuspendLayout();
            this.buyPanel.SuspendLayout();
            this.addPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addQuantityUpDown)).BeginInit();
            this.panel2.SuspendLayout();
            this.delPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delQuantityupDown)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.updateToolStripMenuItem.Text = "Обновить";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.deleteToolStripMenuItem.Text = "Удалить";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(129, 48);
            // 
            // operationGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.operationGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.operationGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.operationGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.operationGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.operationGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.operationGrid.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.operationGrid.Location = new System.Drawing.Point(0, 145);
            this.operationGrid.Name = "operationGrid";
            this.operationGrid.ReadOnly = true;
            this.operationGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.operationGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.operationGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.operationGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.operationGrid.Size = new System.Drawing.Size(1155, 616);
            this.operationGrid.TabIndex = 43;
            this.operationGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.operationGrid_MouseClick);
            // 
            // quantityUpDown
            // 
            this.quantityUpDown.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.quantityUpDown.Location = new System.Drawing.Point(21, 125);
            this.quantityUpDown.Name = "quantityUpDown";
            this.quantityUpDown.Size = new System.Drawing.Size(517, 32);
            this.quantityUpDown.TabIndex = 19;
            this.quantityUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Тип запчасти";
            // 
            // openBusPartsButton
            // 
            this.openBusPartsButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.openBusPartsButton.FlatAppearance.BorderSize = 0;
            this.openBusPartsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openBusPartsButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openBusPartsButton.Location = new System.Drawing.Point(344, 7);
            this.openBusPartsButton.Name = "openBusPartsButton";
            this.openBusPartsButton.Size = new System.Drawing.Size(121, 27);
            this.openBusPartsButton.TabIndex = 51;
            this.openBusPartsButton.Text = "Назад";
            this.openBusPartsButton.UseVisualStyleBackColor = false;
            this.openBusPartsButton.Click += new System.EventHandler(this.openBusPartsButton_Click);
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
            this.openCreateButton.TabIndex = 52;
            this.openCreateButton.Text = "Добавить";
            this.openCreateButton.UseVisualStyleBackColor = false;
            this.openCreateButton.Click += new System.EventHandler(this.openCreateButton_Click);
            // 
            // createBuyButton
            // 
            this.createBuyButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.createBuyButton.FlatAppearance.BorderSize = 0;
            this.createBuyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBuyButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBuyButton.Location = new System.Drawing.Point(185, 553);
            this.createBuyButton.Name = "createBuyButton";
            this.createBuyButton.Size = new System.Drawing.Size(180, 42);
            this.createBuyButton.TabIndex = 5;
            this.createBuyButton.Text = "Добавить";
            this.createBuyButton.UseVisualStyleBackColor = false;
            this.createBuyButton.Click += new System.EventHandler(this.createBuyButton_Click);
            // 
            // defectLabel
            // 
            this.defectLabel.AutoSize = true;
            this.defectLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defectLabel.Location = new System.Drawing.Point(17, 230);
            this.defectLabel.Name = "defectLabel";
            this.defectLabel.Size = new System.Drawing.Size(122, 19);
            this.defectLabel.TabIndex = 5;
            this.defectLabel.Text = "Цена за единицу";
            // 
            // drugPanel
            // 
            this.drugPanel.Controls.Add(this.closeButton);
            this.drugPanel.Controls.Add(this.label3);
            this.drugPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.drugPanel.Location = new System.Drawing.Point(0, 0);
            this.drugPanel.Name = "drugPanel";
            this.drugPanel.Size = new System.Drawing.Size(556, 28);
            this.drugPanel.TabIndex = 6;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(526, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 28);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "❌";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 32);
            this.label1.TabIndex = 53;
            this.label1.Text = "Операции с запчастями";
            // 
            // partTypeBox
            // 
            this.partTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.partTypeBox.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.partTypeBox.FormattingEnabled = true;
            this.partTypeBox.Location = new System.Drawing.Point(21, 64);
            this.partTypeBox.Name = "partTypeBox";
            this.partTypeBox.Size = new System.Drawing.Size(517, 31);
            this.partTypeBox.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 19);
            this.label9.TabIndex = 5;
            this.label9.Text = "Единица измерения";
            // 
            // priceBox
            // 
            this.priceBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceBox.Location = new System.Drawing.Point(21, 254);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(517, 32);
            this.priceBox.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "Количество";
            // 
            // buyPanel
            // 
            this.buyPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buyPanel.Controls.Add(this.quantityUpDown);
            this.buyPanel.Controls.Add(this.suppliersBox);
            this.buyPanel.Controls.Add(this.label4);
            this.buyPanel.Controls.Add(this.partTypeBox);
            this.buyPanel.Controls.Add(this.label5);
            this.buyPanel.Controls.Add(this.drugPanel);
            this.buyPanel.Controls.Add(this.createBuyButton);
            this.buyPanel.Controls.Add(this.label6);
            this.buyPanel.Controls.Add(this.defectLabel);
            this.buyPanel.Controls.Add(this.label9);
            this.buyPanel.Controls.Add(this.label8);
            this.buyPanel.Controls.Add(this.notesBox);
            this.buyPanel.Controls.Add(this.priceBox);
            this.buyPanel.Controls.Add(this.unitBox);
            this.buyPanel.Location = new System.Drawing.Point(589, 43);
            this.buyPanel.Name = "buyPanel";
            this.buyPanel.Size = new System.Drawing.Size(558, 675);
            this.buyPanel.TabIndex = 54;
            this.buyPanel.Visible = false;
            // 
            // unitBox
            // 
            this.unitBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.unitBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitBox.Location = new System.Drawing.Point(21, 191);
            this.unitBox.Name = "unitBox";
            this.unitBox.Size = new System.Drawing.Size(517, 32);
            this.unitBox.TabIndex = 4;
            this.unitBox.Text = "штук";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Тип операции";
            // 
            // operationBox
            // 
            this.operationBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.operationBox.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.operationBox.FormattingEnabled = true;
            this.operationBox.Items.AddRange(new object[] {
            "Закупка",
            "Установка",
            "Списание"});
            this.operationBox.Location = new System.Drawing.Point(20, 104);
            this.operationBox.Name = "operationBox";
            this.operationBox.Size = new System.Drawing.Size(445, 31);
            this.operationBox.TabIndex = 18;
            this.operationBox.SelectedIndexChanged += new System.EventHandler(this.operationBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Закупка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Поставщик";
            // 
            // suppliersBox
            // 
            this.suppliersBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.suppliersBox.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.suppliersBox.FormattingEnabled = true;
            this.suppliersBox.Location = new System.Drawing.Point(20, 315);
            this.suppliersBox.Name = "suppliersBox";
            this.suppliersBox.Size = new System.Drawing.Size(517, 31);
            this.suppliersBox.TabIndex = 18;
            // 
            // notesBox
            // 
            this.notesBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notesBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesBox.Location = new System.Drawing.Point(21, 378);
            this.notesBox.Multiline = true;
            this.notesBox.Name = "notesBox";
            this.notesBox.Size = new System.Drawing.Size(517, 104);
            this.notesBox.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Примечание";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(12, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(326, 38);
            this.label7.TabIndex = 17;
            this.label7.Text = "Все операции выполняются с текущим автобусом";
            // 
            // addPanel
            // 
            this.addPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addPanel.Controls.Add(this.addQuantityUpDown);
            this.addPanel.Controls.Add(this.addStaffBox);
            this.addPanel.Controls.Add(this.label10);
            this.addPanel.Controls.Add(this.addTypePartBox);
            this.addPanel.Controls.Add(this.label11);
            this.addPanel.Controls.Add(this.panel2);
            this.addPanel.Controls.Add(this.createAddButton);
            this.addPanel.Controls.Add(this.label13);
            this.addPanel.Controls.Add(this.label15);
            this.addPanel.Controls.Add(this.label16);
            this.addPanel.Controls.Add(this.addNotesBox);
            this.addPanel.Controls.Add(this.addUnitBox);
            this.addPanel.Location = new System.Drawing.Point(588, 43);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(558, 675);
            this.addPanel.TabIndex = 55;
            this.addPanel.Visible = false;
            // 
            // addQuantityUpDown
            // 
            this.addQuantityUpDown.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.addQuantityUpDown.Location = new System.Drawing.Point(21, 125);
            this.addQuantityUpDown.Name = "addQuantityUpDown";
            this.addQuantityUpDown.Size = new System.Drawing.Size(517, 32);
            this.addQuantityUpDown.TabIndex = 19;
            this.addQuantityUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // addStaffBox
            // 
            this.addStaffBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addStaffBox.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.addStaffBox.FormattingEnabled = true;
            this.addStaffBox.Location = new System.Drawing.Point(20, 261);
            this.addStaffBox.Name = "addStaffBox";
            this.addStaffBox.Size = new System.Drawing.Size(517, 31);
            this.addStaffBox.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(262, 19);
            this.label10.TabIndex = 17;
            this.label10.Text = "Сотрудник, выполнившый установку";
            // 
            // addTypePartBox
            // 
            this.addTypePartBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addTypePartBox.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.addTypePartBox.FormattingEnabled = true;
            this.addTypePartBox.Location = new System.Drawing.Point(21, 64);
            this.addTypePartBox.Name = "addTypePartBox";
            this.addTypePartBox.Size = new System.Drawing.Size(517, 31);
            this.addTypePartBox.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 19);
            this.label11.TabIndex = 17;
            this.label11.Text = "Тип запчасти";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(556, 28);
            this.panel2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(526, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "❌";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 21);
            this.label12.TabIndex = 17;
            this.label12.Text = "Установка";
            // 
            // createAddButton
            // 
            this.createAddButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.createAddButton.FlatAppearance.BorderSize = 0;
            this.createAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createAddButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAddButton.Location = new System.Drawing.Point(185, 451);
            this.createAddButton.Name = "createAddButton";
            this.createAddButton.Size = new System.Drawing.Size(180, 42);
            this.createAddButton.TabIndex = 5;
            this.createAddButton.Text = "Добавить";
            this.createAddButton.UseVisualStyleBackColor = false;
            this.createAddButton.Click += new System.EventHandler(this.createAddButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(17, 300);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 19);
            this.label13.TabIndex = 5;
            this.label13.Text = "Примечание";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(17, 167);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(145, 19);
            this.label15.TabIndex = 5;
            this.label15.Text = "Единица измерения";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(17, 101);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 19);
            this.label16.TabIndex = 5;
            this.label16.Text = "Количество";
            // 
            // addNotesBox
            // 
            this.addNotesBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addNotesBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNotesBox.Location = new System.Drawing.Point(21, 324);
            this.addNotesBox.Multiline = true;
            this.addNotesBox.Name = "addNotesBox";
            this.addNotesBox.Size = new System.Drawing.Size(517, 104);
            this.addNotesBox.TabIndex = 4;
            // 
            // addUnitBox
            // 
            this.addUnitBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addUnitBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUnitBox.Location = new System.Drawing.Point(21, 191);
            this.addUnitBox.Name = "addUnitBox";
            this.addUnitBox.Size = new System.Drawing.Size(517, 32);
            this.addUnitBox.TabIndex = 4;
            this.addUnitBox.Text = "штук";
            // 
            // delPanel
            // 
            this.delPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.delPanel.Controls.Add(this.delQuantityupDown);
            this.delPanel.Controls.Add(this.delStaffBox);
            this.delPanel.Controls.Add(this.label14);
            this.delPanel.Controls.Add(this.delPartBox);
            this.delPanel.Controls.Add(this.label17);
            this.delPanel.Controls.Add(this.panel3);
            this.delPanel.Controls.Add(this.createDelButton);
            this.delPanel.Controls.Add(this.label19);
            this.delPanel.Controls.Add(this.label20);
            this.delPanel.Controls.Add(this.label21);
            this.delPanel.Controls.Add(this.delNotesBox);
            this.delPanel.Controls.Add(this.delUnitBox);
            this.delPanel.Location = new System.Drawing.Point(588, 43);
            this.delPanel.Name = "delPanel";
            this.delPanel.Size = new System.Drawing.Size(558, 675);
            this.delPanel.TabIndex = 55;
            this.delPanel.Visible = false;
            // 
            // delQuantityupDown
            // 
            this.delQuantityupDown.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.delQuantityupDown.Location = new System.Drawing.Point(21, 125);
            this.delQuantityupDown.Name = "delQuantityupDown";
            this.delQuantityupDown.Size = new System.Drawing.Size(517, 32);
            this.delQuantityupDown.TabIndex = 19;
            this.delQuantityupDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // delStaffBox
            // 
            this.delStaffBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.delStaffBox.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.delStaffBox.FormattingEnabled = true;
            this.delStaffBox.Location = new System.Drawing.Point(20, 261);
            this.delStaffBox.Name = "delStaffBox";
            this.delStaffBox.Size = new System.Drawing.Size(517, 31);
            this.delStaffBox.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(16, 237);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(259, 19);
            this.label14.TabIndex = 17;
            this.label14.Text = "Сотрудник, выполнившый списание";
            // 
            // delPartBox
            // 
            this.delPartBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.delPartBox.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.delPartBox.FormattingEnabled = true;
            this.delPartBox.Location = new System.Drawing.Point(21, 64);
            this.delPartBox.Name = "delPartBox";
            this.delPartBox.Size = new System.Drawing.Size(517, 31);
            this.delPartBox.TabIndex = 18;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(17, 40);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 19);
            this.label17.TabIndex = 17;
            this.label17.Text = "Запчасть";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(556, 28);
            this.panel3.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(526, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "❌";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(16, 6);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 21);
            this.label18.TabIndex = 17;
            this.label18.Text = "Списание";
            // 
            // createDelButton
            // 
            this.createDelButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.createDelButton.FlatAppearance.BorderSize = 0;
            this.createDelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createDelButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createDelButton.Location = new System.Drawing.Point(185, 451);
            this.createDelButton.Name = "createDelButton";
            this.createDelButton.Size = new System.Drawing.Size(180, 42);
            this.createDelButton.TabIndex = 5;
            this.createDelButton.Text = "Добавить";
            this.createDelButton.UseVisualStyleBackColor = false;
            this.createDelButton.Click += new System.EventHandler(this.createDelButton_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(17, 300);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(94, 19);
            this.label19.TabIndex = 5;
            this.label19.Text = "Примечание";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(17, 167);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(145, 19);
            this.label20.TabIndex = 5;
            this.label20.Text = "Единица измерения";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(17, 101);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(89, 19);
            this.label21.TabIndex = 5;
            this.label21.Text = "Количество";
            // 
            // delNotesBox
            // 
            this.delNotesBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.delNotesBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delNotesBox.Location = new System.Drawing.Point(21, 324);
            this.delNotesBox.Multiline = true;
            this.delNotesBox.Name = "delNotesBox";
            this.delNotesBox.Size = new System.Drawing.Size(517, 104);
            this.delNotesBox.TabIndex = 4;
            // 
            // delUnitBox
            // 
            this.delUnitBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.delUnitBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delUnitBox.Location = new System.Drawing.Point(21, 191);
            this.delUnitBox.Name = "delUnitBox";
            this.delUnitBox.Size = new System.Drawing.Size(517, 32);
            this.delUnitBox.TabIndex = 4;
            this.delUnitBox.Text = "штук";
            // 
            // exportButton
            // 
            this.exportButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.exportButton.FlatAppearance.BorderSize = 0;
            this.exportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportButton.Location = new System.Drawing.Point(757, 10);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(252, 27);
            this.exportButton.TabIndex = 52;
            this.exportButton.Text = "Акт установки запасных частей";
            this.exportButton.UseVisualStyleBackColor = false;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // PartOperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1155, 761);
            this.Controls.Add(this.delPanel);
            this.Controls.Add(this.addPanel);
            this.Controls.Add(this.buyPanel);
            this.Controls.Add(this.operationGrid);
            this.Controls.Add(this.operationBox);
            this.Controls.Add(this.openBusPartsButton);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.openCreateButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PartOperationsForm";
            this.Text = "PartOperationsForm";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.operationGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDown)).EndInit();
            this.drugPanel.ResumeLayout(false);
            this.drugPanel.PerformLayout();
            this.buyPanel.ResumeLayout(false);
            this.buyPanel.PerformLayout();
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addQuantityUpDown)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.delPanel.ResumeLayout(false);
            this.delPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delQuantityupDown)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView operationGrid;
        private System.Windows.Forms.NumericUpDown quantityUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button openBusPartsButton;
        private System.Windows.Forms.Button openCreateButton;
        private System.Windows.Forms.Button createBuyButton;
        private System.Windows.Forms.Label defectLabel;
        private System.Windows.Forms.Panel drugPanel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox partTypeBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel buyPanel;
        private System.Windows.Forms.TextBox unitBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox operationBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox suppliersBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox notesBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.NumericUpDown addQuantityUpDown;
        private System.Windows.Forms.ComboBox addStaffBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox addTypePartBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button createAddButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox addNotesBox;
        private System.Windows.Forms.TextBox addUnitBox;
        private System.Windows.Forms.Panel delPanel;
        private System.Windows.Forms.NumericUpDown delQuantityupDown;
        private System.Windows.Forms.ComboBox delStaffBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox delPartBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button createDelButton;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox delNotesBox;
        private System.Windows.Forms.TextBox delUnitBox;
        private System.Windows.Forms.Button exportButton;
    }
}