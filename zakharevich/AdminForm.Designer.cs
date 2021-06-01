namespace zakharevich
{
    partial class AdminForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.управлениеНомерамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.управлениеУслугамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьПоискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.показатьСвободныеКомнатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьВсеКомнатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьПарольToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dbDataSet = new zakharevich.dbDataSet();
            this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиентыTableAdapter = new zakharevich.dbDataSetTableAdapters.КлиентыTableAdapter();
            this.выбранные_услугиTableAdapter = new zakharevich.dbDataSetTableAdapters.Выбранные_услугиTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.комнатыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.комнатыTableAdapter = new zakharevich.dbDataSetTableAdapters.КомнатыTableAdapter();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.searchFClientArrivalDate = new System.Windows.Forms.ComboBox();
            this.searchClientArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.searchByRoom = new System.Windows.Forms.CheckBox();
            this.searchByArrivalDate = new System.Windows.Forms.CheckBox();
            this.searchByName = new System.Windows.Forms.CheckBox();
            this.searchClientAppartament = new System.Windows.Forms.ComboBox();
            this.searchClientName = new System.Windows.Forms.TextBox();
            this.searchClient = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Код = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Код_клиента = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Код_услуги = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодклиентаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодуслугиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.клиентыВыбранныеуслугиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодклиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерпаспортаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодкомнатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаприездаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаотбытияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientApp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.комнатыBindingSource)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыВыбранныеуслугиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.управлениеНомерамиToolStripMenuItem,
            this.управлениеУслугамиToolStripMenuItem,
            this.поискToolStripMenuItem,
            this.изменитьПарольToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(824, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // управлениеНомерамиToolStripMenuItem
            // 
            this.управлениеНомерамиToolStripMenuItem.Name = "управлениеНомерамиToolStripMenuItem";
            this.управлениеНомерамиToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.управлениеНомерамиToolStripMenuItem.Text = "Номери";
            this.управлениеНомерамиToolStripMenuItem.Click += new System.EventHandler(this.управлениеНомерамиToolStripMenuItem_Click);
            // 
            // управлениеУслугамиToolStripMenuItem
            // 
            this.управлениеУслугамиToolStripMenuItem.Name = "управлениеУслугамиToolStripMenuItem";
            this.управлениеУслугамиToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.управлениеУслугамиToolStripMenuItem.Text = "Послуги";
            this.управлениеУслугамиToolStripMenuItem.Click += new System.EventHandler(this.управлениеУслугамиToolStripMenuItem_Click);
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.показатьПоискToolStripMenuItem,
            this.toolStripMenuItem1,
            this.показатьСвободныеКомнатыToolStripMenuItem,
            this.показатьВсеКомнатыToolStripMenuItem});
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.поискToolStripMenuItem.Text = "Пошук";
            // 
            // показатьПоискToolStripMenuItem
            // 
            this.показатьПоискToolStripMenuItem.Checked = true;
            this.показатьПоискToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.показатьПоискToolStripMenuItem.Name = "показатьПоискToolStripMenuItem";
            this.показатьПоискToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.показатьПоискToolStripMenuItem.Text = "Показати пошук";
            this.показатьПоискToolStripMenuItem.Click += new System.EventHandler(this.показатьПоискToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(237, 6);
            // 
            // показатьСвободныеКомнатыToolStripMenuItem
            // 
            this.показатьСвободныеКомнатыToolStripMenuItem.Name = "показатьСвободныеКомнатыToolStripMenuItem";
            this.показатьСвободныеКомнатыToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.показатьСвободныеКомнатыToolStripMenuItem.Text = "Показати вільні кімнати";
            this.показатьСвободныеКомнатыToolStripMenuItem.Click += new System.EventHandler(this.показатьСвободныеКомнатыToolStripMenuItem_Click);
            // 
            // показатьВсеКомнатыToolStripMenuItem
            // 
            this.показатьВсеКомнатыToolStripMenuItem.Name = "показатьВсеКомнатыToolStripMenuItem";
            this.показатьВсеКомнатыToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.показатьВсеКомнатыToolStripMenuItem.Text = "Показати всі кімнати";
            this.показатьВсеКомнатыToolStripMenuItem.Click += new System.EventHandler(this.показатьВсеКомнатыToolStripMenuItem_Click);
            // 
            // изменитьПарольToolStripMenuItem
            // 
            this.изменитьПарольToolStripMenuItem.Name = "изменитьПарольToolStripMenuItem";
            this.изменитьПарольToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.изменитьПарольToolStripMenuItem.Text = "Змінити пароль";
            this.изменитьПарольToolStripMenuItem.Click += new System.EventHandler(this.изменитьПарольToolStripMenuItem_Click);
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // клиентыBindingSource
            // 
            this.клиентыBindingSource.DataMember = "Клиенты";
            this.клиентыBindingSource.DataSource = this.dbDataSet;
            // 
            // клиентыTableAdapter
            // 
            this.клиентыTableAdapter.ClearBeforeFill = true;
            // 
            // выбранные_услугиTableAdapter
            // 
            this.выбранные_услугиTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(119, 26);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(119, 26);
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            this.удалитьToolStripMenuItem1.Click += new System.EventHandler(this.удалитьToolStripMenuItem1_Click);
            // 
            // комнатыBindingSource
            // 
            this.комнатыBindingSource.DataMember = "Комнаты";
            this.комнатыBindingSource.DataSource = this.dbDataSet;
            // 
            // комнатыTableAdapter
            // 
            this.комнатыTableAdapter.ClearBeforeFill = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel5.Controls.Add(this.button4);
            this.panel5.Controls.Add(this.searchFClientArrivalDate);
            this.panel5.Controls.Add(this.searchClientArrivalDate);
            this.panel5.Controls.Add(this.searchByRoom);
            this.panel5.Controls.Add(this.searchByArrivalDate);
            this.panel5.Controls.Add(this.searchByName);
            this.panel5.Controls.Add(this.searchClientAppartament);
            this.panel5.Controls.Add(this.searchClientName);
            this.panel5.Controls.Add(this.searchClient);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 24);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(824, 115);
            this.panel5.TabIndex = 10;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(464, 82);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 23);
            this.button4.TabIndex = 63;
            this.button4.Text = "Скинути";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // searchFClientArrivalDate
            // 
            this.searchFClientArrivalDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchFClientArrivalDate.FormattingEnabled = true;
            this.searchFClientArrivalDate.Items.AddRange(new object[] {
            "=",
            ">",
            ">=",
            "<",
            "<="});
            this.searchFClientArrivalDate.Location = new System.Drawing.Point(464, 9);
            this.searchFClientArrivalDate.Name = "searchFClientArrivalDate";
            this.searchFClientArrivalDate.Size = new System.Drawing.Size(62, 21);
            this.searchFClientArrivalDate.TabIndex = 62;
            // 
            // searchClientArrivalDate
            // 
            this.searchClientArrivalDate.Location = new System.Drawing.Point(118, 34);
            this.searchClientArrivalDate.Name = "searchClientArrivalDate";
            this.searchClientArrivalDate.Size = new System.Drawing.Size(340, 20);
            this.searchClientArrivalDate.TabIndex = 61;
            // 
            // searchByRoom
            // 
            this.searchByRoom.AutoSize = true;
            this.searchByRoom.Location = new System.Drawing.Point(8, 57);
            this.searchByRoom.Name = "searchByRoom";
            this.searchByRoom.Size = new System.Drawing.Size(66, 17);
            this.searchByRoom.TabIndex = 58;
            this.searchByRoom.Text = "Кімната";
            this.searchByRoom.UseVisualStyleBackColor = true;
            // 
            // searchByArrivalDate
            // 
            this.searchByArrivalDate.AutoSize = true;
            this.searchByArrivalDate.Location = new System.Drawing.Point(8, 31);
            this.searchByArrivalDate.Name = "searchByArrivalDate";
            this.searchByArrivalDate.Size = new System.Drawing.Size(100, 17);
            this.searchByArrivalDate.TabIndex = 57;
            this.searchByArrivalDate.Text = "Дата прибуття";
            this.searchByArrivalDate.UseVisualStyleBackColor = true;
            // 
            // searchByName
            // 
            this.searchByName.AutoSize = true;
            this.searchByName.Location = new System.Drawing.Point(8, 8);
            this.searchByName.Name = "searchByName";
            this.searchByName.Size = new System.Drawing.Size(85, 17);
            this.searchByName.TabIndex = 56;
            this.searchByName.Text = "Ім\'я клієнта";
            this.searchByName.UseVisualStyleBackColor = true;
            // 
            // searchClientAppartament
            // 
            this.searchClientAppartament.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchClientAppartament.FormattingEnabled = true;
            this.searchClientAppartament.Location = new System.Drawing.Point(118, 55);
            this.searchClientAppartament.Name = "searchClientAppartament";
            this.searchClientAppartament.Size = new System.Drawing.Size(340, 21);
            this.searchClientAppartament.TabIndex = 54;
            // 
            // searchClientName
            // 
            this.searchClientName.Location = new System.Drawing.Point(118, 8);
            this.searchClientName.Name = "searchClientName";
            this.searchClientName.Size = new System.Drawing.Size(340, 20);
            this.searchClientName.TabIndex = 51;
            // 
            // searchClient
            // 
            this.searchClient.Location = new System.Drawing.Point(8, 82);
            this.searchClient.Name = "searchClient";
            this.searchClient.Size = new System.Drawing.Size(450, 23);
            this.searchClient.TabIndex = 52;
            this.searchClient.Text = "Пошук";
            this.searchClient.UseVisualStyleBackColor = true;
            this.searchClient.Click += new System.EventHandler(this.searchClient_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 563);
            this.panel1.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.comboBox3);
            this.panel3.Location = new System.Drawing.Point(163, 477);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(235, 67);
            this.panel3.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(225, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Додати послугу клієнту";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(94, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Послуга";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(3, 16);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(225, 21);
            this.comboBox3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dateTimePicker3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.dateTimePicker4);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(529, 231);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 222);
            this.panel2.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(273, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Додати нового клієнта";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(3, 172);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(273, 21);
            this.comboBox2.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Кімната";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(3, 133);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(273, 20);
            this.dateTimePicker3.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Дата від\'їзду";
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(3, 94);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(273, 20);
            this.dateTimePicker4.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Дата прибуття";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(3, 55);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(273, 20);
            this.textBox3.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Номер паспорта";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(3, 16);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(273, 20);
            this.textBox4.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ім\'я клієнта";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.dateTimePicker2);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.dateTimePicker1);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.textBox2);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Location = new System.Drawing.Point(529, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(279, 222);
            this.panel4.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Зберегти зміни";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 172);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(273, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Кімната";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.клиентыBindingSource, "Дата_отбытия", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "D"));
            this.dateTimePicker2.Location = new System.Drawing.Point(3, 133);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(273, 20);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Дата від\'їзду";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ім\'я клієнта";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.клиентыBindingSource, "Дата_приезда", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "D"));
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 94);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(273, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дата прибуття";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентыBindingSource, "Номер_паспорта", true));
            this.textBox2.Location = new System.Drawing.Point(3, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(273, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Номер паспорта";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентыBindingSource, "Имя", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textBox1.Location = new System.Drawing.Point(3, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 20);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Код,
            this.Код_клиента,
            this.Код_услуги,
            this.serviceName,
            this.serviceCost,
            this.кодDataGridViewTextBoxColumn,
            this.кодклиентаDataGridViewTextBoxColumn1,
            this.кодуслугиDataGridViewTextBoxColumn});
            this.dataGridView2.ContextMenuStrip = this.contextMenuStrip2;
            this.dataGridView2.DataSource = this.клиентыВыбранныеуслугиBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(0, 324);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(526, 129);
            this.dataGridView2.TabIndex = 8;
            // 
            // Код
            // 
            this.Код.DataPropertyName = "Код";
            this.Код.HeaderText = "Код";
            this.Код.Name = "Код";
            this.Код.ReadOnly = true;
            this.Код.Visible = false;
            // 
            // Код_клиента
            // 
            this.Код_клиента.DataPropertyName = "Код_клиента";
            this.Код_клиента.HeaderText = "Код_клиента";
            this.Код_клиента.Name = "Код_клиента";
            this.Код_клиента.ReadOnly = true;
            this.Код_клиента.Visible = false;
            // 
            // Код_услуги
            // 
            this.Код_услуги.DataPropertyName = "Код_услуги";
            this.Код_услуги.HeaderText = "Код_услуги";
            this.Код_услуги.Name = "Код_услуги";
            this.Код_услуги.ReadOnly = true;
            this.Код_услуги.Visible = false;
            // 
            // serviceName
            // 
            this.serviceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.serviceName.HeaderText = "Название услуги";
            this.serviceName.Name = "serviceName";
            this.serviceName.ReadOnly = true;
            this.serviceName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.serviceName.Width = 108;
            // 
            // serviceCost
            // 
            this.serviceCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.serviceCost.HeaderText = "Стоимость услуги за сутки";
            this.serviceCost.Name = "serviceCost";
            this.serviceCost.ReadOnly = true;
            this.serviceCost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кодклиентаDataGridViewTextBoxColumn1
            // 
            this.кодклиентаDataGridViewTextBoxColumn1.DataPropertyName = "Код_клиента";
            this.кодклиентаDataGridViewTextBoxColumn1.HeaderText = "Код_клиента";
            this.кодклиентаDataGridViewTextBoxColumn1.Name = "кодклиентаDataGridViewTextBoxColumn1";
            this.кодклиентаDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // кодуслугиDataGridViewTextBoxColumn
            // 
            this.кодуслугиDataGridViewTextBoxColumn.DataPropertyName = "Код_услуги";
            this.кодуслугиDataGridViewTextBoxColumn.HeaderText = "Код_услуги";
            this.кодуслугиDataGridViewTextBoxColumn.Name = "кодуслугиDataGridViewTextBoxColumn";
            this.кодуслугиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // клиентыВыбранныеуслугиBindingSource
            // 
            this.клиентыВыбранныеуслугиBindingSource.DataMember = "КлиентыВыбранные_услуги";
            this.клиентыВыбранныеуслугиBindingSource.DataSource = this.клиентыBindingSource;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодклиентаDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.номерпаспортаDataGridViewTextBoxColumn,
            this.кодкомнатыDataGridViewTextBoxColumn,
            this.датаприездаDataGridViewTextBoxColumn,
            this.датаотбытияDataGridViewTextBoxColumn,
            this.clientApp,
            this.clientPrice});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.DataSource = this.клиентыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(526, 320);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // кодклиентаDataGridViewTextBoxColumn
            // 
            this.кодклиентаDataGridViewTextBoxColumn.DataPropertyName = "Код_клиента";
            this.кодклиентаDataGridViewTextBoxColumn.HeaderText = "Код_клиента";
            this.кодклиентаDataGridViewTextBoxColumn.Name = "кодклиентаDataGridViewTextBoxColumn";
            this.кодклиентаDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодклиентаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.кодклиентаDataGridViewTextBoxColumn.Visible = false;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            this.имяDataGridViewTextBoxColumn.ReadOnly = true;
            this.имяDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.имяDataGridViewTextBoxColumn.Width = 54;
            // 
            // номерпаспортаDataGridViewTextBoxColumn
            // 
            this.номерпаспортаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.номерпаспортаDataGridViewTextBoxColumn.DataPropertyName = "Номер_паспорта";
            this.номерпаспортаDataGridViewTextBoxColumn.HeaderText = "Номер паспорта";
            this.номерпаспортаDataGridViewTextBoxColumn.Name = "номерпаспортаDataGridViewTextBoxColumn";
            this.номерпаспортаDataGridViewTextBoxColumn.ReadOnly = true;
            this.номерпаспортаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.номерпаспортаDataGridViewTextBoxColumn.Width = 106;
            // 
            // кодкомнатыDataGridViewTextBoxColumn
            // 
            this.кодкомнатыDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.кодкомнатыDataGridViewTextBoxColumn.DataPropertyName = "Код_комнаты";
            this.кодкомнатыDataGridViewTextBoxColumn.HeaderText = "Код_комнаты";
            this.кодкомнатыDataGridViewTextBoxColumn.Name = "кодкомнатыDataGridViewTextBoxColumn";
            this.кодкомнатыDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодкомнатыDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.кодкомнатыDataGridViewTextBoxColumn.Visible = false;
            // 
            // датаприездаDataGridViewTextBoxColumn
            // 
            this.датаприездаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.датаприездаDataGridViewTextBoxColumn.DataPropertyName = "Дата_приезда";
            this.датаприездаDataGridViewTextBoxColumn.HeaderText = "Дата приезда";
            this.датаприездаDataGridViewTextBoxColumn.Name = "датаприездаDataGridViewTextBoxColumn";
            this.датаприездаDataGridViewTextBoxColumn.ReadOnly = true;
            this.датаприездаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.датаприездаDataGridViewTextBoxColumn.Width = 95;
            // 
            // датаотбытияDataGridViewTextBoxColumn
            // 
            this.датаотбытияDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.датаотбытияDataGridViewTextBoxColumn.DataPropertyName = "Дата_отбытия";
            this.датаотбытияDataGridViewTextBoxColumn.HeaderText = "Дата отбытия";
            this.датаотбытияDataGridViewTextBoxColumn.Name = "датаотбытияDataGridViewTextBoxColumn";
            this.датаотбытияDataGridViewTextBoxColumn.ReadOnly = true;
            this.датаотбытияDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.датаотбытияDataGridViewTextBoxColumn.Width = 95;
            // 
            // clientApp
            // 
            this.clientApp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clientApp.HeaderText = "Номер комнаты";
            this.clientApp.Name = "clientApp";
            this.clientApp.ReadOnly = true;
            this.clientApp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.clientApp.Width = 105;
            // 
            // clientPrice
            // 
            this.clientPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clientPrice.HeaderText = "Стоимость проживания";
            this.clientPrice.Name = "clientPrice";
            this.clientPrice.ReadOnly = true;
            this.clientPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 695);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Готель";
            this.Activated += new System.EventHandler(this.AdminForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.комнатыBindingSource)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыВыбранныеуслугиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem управлениеНомерамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem управлениеУслугамиToolStripMenuItem;
        private dbDataSet dbDataSet;
        private System.Windows.Forms.BindingSource клиентыBindingSource;
        private dbDataSetTableAdapters.КлиентыTableAdapter клиентыTableAdapter;
        private System.Windows.Forms.BindingSource клиентыВыбранныеуслугиBindingSource;
        private dbDataSetTableAdapters.Выбранные_услугиTableAdapter выбранные_услугиTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem показатьСвободныеКомнатыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьВсеКомнатыToolStripMenuItem;
        private System.Windows.Forms.BindingSource комнатыBindingSource;
        private dbDataSetTableAdapters.КомнатыTableAdapter комнатыTableAdapter;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодклиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерпаспортаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодкомнатыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаприездаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаотбытияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientApp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientPrice;
        private System.Windows.Forms.ToolStripMenuItem показатьПоискToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.DateTimePicker searchClientArrivalDate;
        private System.Windows.Forms.CheckBox searchByRoom;
        private System.Windows.Forms.CheckBox searchByArrivalDate;
        private System.Windows.Forms.CheckBox searchByName;
        private System.Windows.Forms.ComboBox searchClientAppartament;
        private System.Windows.Forms.TextBox searchClientName;
        private System.Windows.Forms.Button searchClient;
        private System.Windows.Forms.ComboBox searchFClientArrivalDate;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripMenuItem изменитьПарольToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Код;
        private System.Windows.Forms.DataGridViewTextBoxColumn Код_клиента;
        private System.Windows.Forms.DataGridViewTextBoxColumn Код_услуги;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодклиентаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодуслугиDataGridViewTextBoxColumn;
    }
}