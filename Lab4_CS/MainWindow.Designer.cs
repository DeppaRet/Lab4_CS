namespace Lab4_CS
{
  partial class MainWindow
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
      this.Table = new System.Windows.Forms.DataGridView();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.File = new System.Windows.Forms.ToolStripDropDownButton();
      this.Export = new System.Windows.Forms.ToolStripMenuItem();
      this.Close = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
      this.About = new System.Windows.Forms.ToolStripMenuItem();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.Clean = new System.Windows.Forms.Button();
      this.Sport = new System.Windows.Forms.GroupBox();
      this.label21 = new System.Windows.Forms.Label();
      this.label16 = new System.Windows.Forms.Label();
      this.label17 = new System.Windows.Forms.Label();
      this.label18 = new System.Windows.Forms.Label();
      this.label19 = new System.Windows.Forms.Label();
      this.label20 = new System.Windows.Forms.Label();
      this.AddSport = new System.Windows.Forms.Button();
      this.RecordSport = new System.Windows.Forms.TextBox();
      this.UnitSport = new System.Windows.Forms.TextBox();
      this.NameSport = new System.Windows.Forms.TextBox();
      this.idSport = new System.Windows.Forms.TextBox();
      this.Result = new System.Windows.Forms.GroupBox();
      this.KindOfSportRes = new System.Windows.Forms.TextBox();
      this.label12 = new System.Windows.Forms.Label();
      this.ResultRes = new System.Windows.Forms.TextBox();
      this.label9 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.label13 = new System.Windows.Forms.Label();
      this.label14 = new System.Windows.Forms.Label();
      this.AddRes = new System.Windows.Forms.Button();
      this.OrgRes = new System.Windows.Forms.TextBox();
      this.CountryRes = new System.Windows.Forms.TextBox();
      this.NameRes = new System.Windows.Forms.TextBox();
      this.idRes = new System.Windows.Forms.TextBox();
      this.Athlete = new System.Windows.Forms.GroupBox();
      this.Score = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.AddAth = new System.Windows.Forms.Button();
      this.Category = new System.Windows.Forms.TextBox();
      this.Gender = new System.Windows.Forms.ComboBox();
      this.CountryAth = new System.Windows.Forms.TextBox();
      this.NameAth = new System.Windows.Forms.TextBox();
      this.idAth = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.ChooseTable = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.WhatToDo = new System.Windows.Forms.ComboBox();
      this.Help = new System.Windows.Forms.Label();
      this.DateRecSport = new System.Windows.Forms.DateTimePicker();
      ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
      this.toolStrip1.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.Sport.SuspendLayout();
      this.Result.SuspendLayout();
      this.Athlete.SuspendLayout();
      this.SuspendLayout();
      // 
      // Table
      // 
      this.Table.BackgroundColor = System.Drawing.Color.White;
      this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.Table.Location = new System.Drawing.Point(10, 52);
      this.Table.Name = "Table";
      this.Table.Size = new System.Drawing.Size(354, 369);
      this.Table.TabIndex = 0;
      this.Table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_CellClick);
      // 
      // toolStrip1
      // 
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.toolStripDropDownButton1});
      this.toolStrip1.Location = new System.Drawing.Point(0, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(800, 25);
      this.toolStrip1.TabIndex = 1;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // File
      // 
      this.File.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Export,
            this.Close});
      this.File.Image = ((System.Drawing.Image)(resources.GetObject("File.Image")));
      this.File.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.File.Name = "File";
      this.File.Size = new System.Drawing.Size(49, 22);
      this.File.Text = "Файл";
      // 
      // Export
      // 
      this.Export.Name = "Export";
      this.Export.Size = new System.Drawing.Size(119, 22);
      this.Export.Text = "Экспорт";
      this.Export.Click += new System.EventHandler(this.Export_Click);
      // 
      // Close
      // 
      this.Close.Name = "Close";
      this.Close.Size = new System.Drawing.Size(119, 22);
      this.Close.Text = "Выход";
      this.Close.Click += new System.EventHandler(this.Close_Click);
      // 
      // toolStripDropDownButton1
      // 
      this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.About});
      this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
      this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
      this.toolStripDropDownButton1.Size = new System.Drawing.Size(66, 22);
      this.toolStripDropDownButton1.Text = "Справка";
      // 
      // About
      // 
      this.About.Name = "About";
      this.About.Size = new System.Drawing.Size(149, 22);
      this.About.Text = "О программе";
      this.About.Click += new System.EventHandler(this.About_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.Clean);
      this.groupBox1.Controls.Add(this.Sport);
      this.groupBox1.Controls.Add(this.Result);
      this.groupBox1.Controls.Add(this.Athlete);
      this.groupBox1.Location = new System.Drawing.Point(370, 55);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(414, 366);
      this.groupBox1.TabIndex = 3;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Редактирование";
      // 
      // Clean
      // 
      this.Clean.Location = new System.Drawing.Point(273, 336);
      this.Clean.Name = "Clean";
      this.Clean.Size = new System.Drawing.Size(129, 23);
      this.Clean.TabIndex = 43;
      this.Clean.Text = "Очистить поля ввода";
      this.Clean.UseVisualStyleBackColor = true;
      this.Clean.Click += new System.EventHandler(this.Clean_Click);
      // 
      // Sport
      // 
      this.Sport.Controls.Add(this.DateRecSport);
      this.Sport.Controls.Add(this.label21);
      this.Sport.Controls.Add(this.label16);
      this.Sport.Controls.Add(this.label17);
      this.Sport.Controls.Add(this.label18);
      this.Sport.Controls.Add(this.label19);
      this.Sport.Controls.Add(this.label20);
      this.Sport.Controls.Add(this.AddSport);
      this.Sport.Controls.Add(this.RecordSport);
      this.Sport.Controls.Add(this.UnitSport);
      this.Sport.Controls.Add(this.NameSport);
      this.Sport.Controls.Add(this.idSport);
      this.Sport.Enabled = false;
      this.Sport.Location = new System.Drawing.Point(6, 239);
      this.Sport.Name = "Sport";
      this.Sport.Size = new System.Drawing.Size(402, 91);
      this.Sport.TabIndex = 2;
      this.Sport.TabStop = false;
      this.Sport.Text = "Вид спорта";
      // 
      // label21
      // 
      this.label21.AutoSize = true;
      this.label21.Location = new System.Drawing.Point(116, 13);
      this.label21.Name = "label21";
      this.label21.Size = new System.Drawing.Size(111, 13);
      this.label21.TabIndex = 41;
      this.label21.Text = "Единицы измерения";
      // 
      // label16
      // 
      this.label16.AutoSize = true;
      this.label16.Location = new System.Drawing.Point(277, 14);
      this.label16.Name = "label16";
      this.label16.Size = new System.Drawing.Size(78, 13);
      this.label16.TabIndex = 39;
      this.label16.Text = "Дата рекорда";
      // 
      // label17
      // 
      this.label17.AutoSize = true;
      this.label17.Location = new System.Drawing.Point(230, 14);
      this.label17.Name = "label17";
      this.label17.Size = new System.Drawing.Size(44, 13);
      this.label17.TabIndex = 38;
      this.label17.Text = "Рекорд";
      // 
      // label18
      // 
      this.label18.AutoSize = true;
      this.label18.Location = new System.Drawing.Point(172, 13);
      this.label18.Name = "label18";
      this.label18.Size = new System.Drawing.Size(0, 13);
      this.label18.TabIndex = 37;
      // 
      // label19
      // 
      this.label19.AutoSize = true;
      this.label19.Location = new System.Drawing.Point(45, 14);
      this.label19.Name = "label19";
      this.label19.Size = new System.Drawing.Size(57, 13);
      this.label19.TabIndex = 36;
      this.label19.Text = "Название";
      // 
      // label20
      // 
      this.label20.AutoSize = true;
      this.label20.Location = new System.Drawing.Point(7, 14);
      this.label20.Name = "label20";
      this.label20.Size = new System.Drawing.Size(15, 13);
      this.label20.TabIndex = 35;
      this.label20.Text = "id";
      // 
      // AddSport
      // 
      this.AddSport.Enabled = false;
      this.AddSport.Location = new System.Drawing.Point(318, 56);
      this.AddSport.Name = "AddSport";
      this.AddSport.Size = new System.Drawing.Size(79, 23);
      this.AddSport.TabIndex = 34;
      this.AddSport.Text = "Выполнить";
      this.AddSport.UseVisualStyleBackColor = true;
      this.AddSport.Click += new System.EventHandler(this.AddSport_Click);
      // 
      // RecordSport
      // 
      this.RecordSport.Location = new System.Drawing.Point(233, 29);
      this.RecordSport.Name = "RecordSport";
      this.RecordSport.Size = new System.Drawing.Size(41, 20);
      this.RecordSport.TabIndex = 33;
      // 
      // UnitSport
      // 
      this.UnitSport.Location = new System.Drawing.Point(119, 29);
      this.UnitSport.Name = "UnitSport";
      this.UnitSport.Size = new System.Drawing.Size(108, 20);
      this.UnitSport.TabIndex = 32;
      // 
      // NameSport
      // 
      this.NameSport.Location = new System.Drawing.Point(48, 30);
      this.NameSport.Name = "NameSport";
      this.NameSport.Size = new System.Drawing.Size(65, 20);
      this.NameSport.TabIndex = 31;
      // 
      // idSport
      // 
      this.idSport.Enabled = false;
      this.idSport.Location = new System.Drawing.Point(4, 30);
      this.idSport.Name = "idSport";
      this.idSport.Size = new System.Drawing.Size(37, 20);
      this.idSport.TabIndex = 29;
      // 
      // Result
      // 
      this.Result.Controls.Add(this.KindOfSportRes);
      this.Result.Controls.Add(this.label12);
      this.Result.Controls.Add(this.ResultRes);
      this.Result.Controls.Add(this.label9);
      this.Result.Controls.Add(this.label10);
      this.Result.Controls.Add(this.label11);
      this.Result.Controls.Add(this.label13);
      this.Result.Controls.Add(this.label14);
      this.Result.Controls.Add(this.AddRes);
      this.Result.Controls.Add(this.OrgRes);
      this.Result.Controls.Add(this.CountryRes);
      this.Result.Controls.Add(this.NameRes);
      this.Result.Controls.Add(this.idRes);
      this.Result.Enabled = false;
      this.Result.Location = new System.Drawing.Point(6, 142);
      this.Result.Name = "Result";
      this.Result.Size = new System.Drawing.Size(402, 91);
      this.Result.TabIndex = 1;
      this.Result.TabStop = false;
      this.Result.Text = "Результат";
      // 
      // KindOfSportRes
      // 
      this.KindOfSportRes.Location = new System.Drawing.Point(3, 65);
      this.KindOfSportRes.Name = "KindOfSportRes";
      this.KindOfSportRes.Size = new System.Drawing.Size(64, 20);
      this.KindOfSportRes.TabIndex = 28;
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Location = new System.Drawing.Point(3, 49);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(64, 13);
      this.label12.TabIndex = 15;
      this.label12.Text = "Вид спорта";
      // 
      // ResultRes
      // 
      this.ResultRes.Location = new System.Drawing.Point(327, 29);
      this.ResultRes.Name = "ResultRes";
      this.ResultRes.Size = new System.Drawing.Size(69, 20);
      this.ResultRes.TabIndex = 27;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(327, 12);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(59, 13);
      this.label9.TabIndex = 26;
      this.label9.Text = "Результат";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(248, 13);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(73, 13);
      this.label10.TabIndex = 25;
      this.label10.Text = "Организатор";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(180, 12);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(43, 13);
      this.label11.TabIndex = 24;
      this.label11.Text = "Страна";
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Location = new System.Drawing.Point(45, 13);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(132, 13);
      this.label13.TabIndex = 22;
      this.label13.Text = "Название соревнования";
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.Location = new System.Drawing.Point(7, 13);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(15, 13);
      this.label14.TabIndex = 21;
      this.label14.Text = "id";
      // 
      // AddRes
      // 
      this.AddRes.Enabled = false;
      this.AddRes.Location = new System.Drawing.Point(318, 55);
      this.AddRes.Name = "AddRes";
      this.AddRes.Size = new System.Drawing.Size(79, 23);
      this.AddRes.TabIndex = 20;
      this.AddRes.Text = "Выполнить";
      this.AddRes.UseVisualStyleBackColor = true;
      this.AddRes.Click += new System.EventHandler(this.AddRes_Click);
      // 
      // OrgRes
      // 
      this.OrgRes.Location = new System.Drawing.Point(251, 28);
      this.OrgRes.Name = "OrgRes";
      this.OrgRes.Size = new System.Drawing.Size(70, 20);
      this.OrgRes.TabIndex = 18;
      // 
      // CountryRes
      // 
      this.CountryRes.Location = new System.Drawing.Point(183, 28);
      this.CountryRes.Name = "CountryRes";
      this.CountryRes.Size = new System.Drawing.Size(60, 20);
      this.CountryRes.TabIndex = 16;
      // 
      // NameRes
      // 
      this.NameRes.Location = new System.Drawing.Point(48, 29);
      this.NameRes.Name = "NameRes";
      this.NameRes.Size = new System.Drawing.Size(129, 20);
      this.NameRes.TabIndex = 15;
      // 
      // idRes
      // 
      this.idRes.Enabled = false;
      this.idRes.Location = new System.Drawing.Point(4, 29);
      this.idRes.Name = "idRes";
      this.idRes.Size = new System.Drawing.Size(37, 20);
      this.idRes.TabIndex = 14;
      // 
      // Athlete
      // 
      this.Athlete.Controls.Add(this.Score);
      this.Athlete.Controls.Add(this.label8);
      this.Athlete.Controls.Add(this.label7);
      this.Athlete.Controls.Add(this.label6);
      this.Athlete.Controls.Add(this.label5);
      this.Athlete.Controls.Add(this.label4);
      this.Athlete.Controls.Add(this.label3);
      this.Athlete.Controls.Add(this.AddAth);
      this.Athlete.Controls.Add(this.Category);
      this.Athlete.Controls.Add(this.Gender);
      this.Athlete.Controls.Add(this.CountryAth);
      this.Athlete.Controls.Add(this.NameAth);
      this.Athlete.Controls.Add(this.idAth);
      this.Athlete.Enabled = false;
      this.Athlete.Location = new System.Drawing.Point(6, 45);
      this.Athlete.Name = "Athlete";
      this.Athlete.Size = new System.Drawing.Size(402, 91);
      this.Athlete.TabIndex = 0;
      this.Athlete.TabStop = false;
      this.Athlete.Text = "Спортсмена";
      // 
      // Score
      // 
      this.Score.Location = new System.Drawing.Point(341, 36);
      this.Score.Name = "Score";
      this.Score.Size = new System.Drawing.Size(55, 20);
      this.Score.TabIndex = 6;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(338, 19);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(59, 13);
      this.label8.TabIndex = 13;
      this.label8.Text = "Результат";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(293, 19);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(44, 13);
      this.label7.TabIndex = 12;
      this.label7.Text = "Разряд";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(213, 19);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(43, 13);
      this.label6.TabIndex = 11;
      this.label6.Text = "Страна";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(175, 19);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(27, 13);
      this.label5.TabIndex = 10;
      this.label5.Text = "Пол";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(44, 19);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(29, 13);
      this.label4.TabIndex = 9;
      this.label4.Text = "Имя";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(6, 19);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(15, 13);
      this.label3.TabIndex = 8;
      this.label3.Text = "id";
      // 
      // AddAth
      // 
      this.AddAth.Enabled = false;
      this.AddAth.Location = new System.Drawing.Point(317, 61);
      this.AddAth.Name = "AddAth";
      this.AddAth.Size = new System.Drawing.Size(79, 23);
      this.AddAth.TabIndex = 7;
      this.AddAth.Text = "Выполнить";
      this.AddAth.UseVisualStyleBackColor = true;
      this.AddAth.Click += new System.EventHandler(this.AddAth_Click);
      // 
      // Category
      // 
      this.Category.Location = new System.Drawing.Point(296, 35);
      this.Category.Name = "Category";
      this.Category.Size = new System.Drawing.Size(39, 20);
      this.Category.TabIndex = 5;
      // 
      // Gender
      // 
      this.Gender.FormattingEnabled = true;
      this.Gender.Items.AddRange(new object[] {
            "М",
            "Ж"});
      this.Gender.Location = new System.Drawing.Point(175, 35);
      this.Gender.Name = "Gender";
      this.Gender.Size = new System.Drawing.Size(35, 21);
      this.Gender.TabIndex = 4;
      // 
      // CountryAth
      // 
      this.CountryAth.Location = new System.Drawing.Point(216, 35);
      this.CountryAth.Name = "CountryAth";
      this.CountryAth.Size = new System.Drawing.Size(74, 20);
      this.CountryAth.TabIndex = 3;
      // 
      // NameAth
      // 
      this.NameAth.Location = new System.Drawing.Point(47, 35);
      this.NameAth.Name = "NameAth";
      this.NameAth.Size = new System.Drawing.Size(122, 20);
      this.NameAth.TabIndex = 1;
      // 
      // idAth
      // 
      this.idAth.Enabled = false;
      this.idAth.Location = new System.Drawing.Point(3, 35);
      this.idAth.Name = "idAth";
      this.idAth.Size = new System.Drawing.Size(38, 20);
      this.idAth.TabIndex = 0;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.BackColor = System.Drawing.SystemColors.Control;
      this.label2.Location = new System.Drawing.Point(367, 12);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(50, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Таблица";
      // 
      // ChooseTable
      // 
      this.ChooseTable.FormattingEnabled = true;
      this.ChooseTable.Items.AddRange(new object[] {
            "Спортсмен",
            "Результат",
            "Вид спорта"});
      this.ChooseTable.Location = new System.Drawing.Point(370, 28);
      this.ChooseTable.Name = "ChooseTable";
      this.ChooseTable.Size = new System.Drawing.Size(95, 21);
      this.ChooseTable.TabIndex = 0;
      this.ChooseTable.SelectedIndexChanged += new System.EventHandler(this.ChooseTable_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.Color.Transparent;
      this.label1.Location = new System.Drawing.Point(528, 12);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(57, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "Действие";
      // 
      // WhatToDo
      // 
      this.WhatToDo.Enabled = false;
      this.WhatToDo.FormattingEnabled = true;
      this.WhatToDo.Items.AddRange(new object[] {
            "Добавить",
            "Изменить"});
      this.WhatToDo.Location = new System.Drawing.Point(531, 28);
      this.WhatToDo.Name = "WhatToDo";
      this.WhatToDo.Size = new System.Drawing.Size(95, 21);
      this.WhatToDo.TabIndex = 5;
      this.WhatToDo.SelectedIndexChanged += new System.EventHandler(this.WhatToDo_SelectedIndexChanged);
      // 
      // Help
      // 
      this.Help.AutoSize = true;
      this.Help.Location = new System.Drawing.Point(7, 36);
      this.Help.Name = "Help";
      this.Help.Size = new System.Drawing.Size(340, 13);
      this.Help.TabIndex = 6;
      this.Help.Text = "Для того чтобы быстро изменить запись, выберите ее в таблице";
      this.Help.Visible = false;
      // 
      // DateRecSport
      // 
      this.DateRecSport.Location = new System.Drawing.Point(279, 30);
      this.DateRecSport.Name = "DateRecSport";
      this.DateRecSport.Size = new System.Drawing.Size(117, 20);
      this.DateRecSport.TabIndex = 42;
      // 
      // MainWindow
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.Help);
      this.Controls.Add(this.WhatToDo);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.ChooseTable);
      this.Controls.Add(this.toolStrip1);
      this.Controls.Add(this.Table);
      this.Name = "MainWindow";
      this.Text = "MainWindow";
      this.Load += new System.EventHandler(this.MainWindow_Load);
      ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.Sport.ResumeLayout(false);
      this.Sport.PerformLayout();
      this.Result.ResumeLayout(false);
      this.Result.PerformLayout();
      this.Athlete.ResumeLayout(false);
      this.Athlete.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton File;
        private System.Windows.Forms.ToolStripMenuItem Export;
        private System.Windows.Forms.ToolStripMenuItem Close;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ChooseTable;
        private System.Windows.Forms.GroupBox Sport;
        private System.Windows.Forms.GroupBox Result;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button AddRes;
        private System.Windows.Forms.TextBox OrgRes;
        private System.Windows.Forms.TextBox CountryRes;
        private System.Windows.Forms.TextBox NameRes;
        private System.Windows.Forms.TextBox idRes;
        private System.Windows.Forms.GroupBox Athlete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddAth;
        private System.Windows.Forms.TextBox Category;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.TextBox CountryAth;
        private System.Windows.Forms.TextBox NameAth;
        private System.Windows.Forms.TextBox idAth;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ResultRes;
    private System.Windows.Forms.Label label16;
    private System.Windows.Forms.Label label17;
    private System.Windows.Forms.Label label18;
    private System.Windows.Forms.Label label19;
    private System.Windows.Forms.Label label20;
    private System.Windows.Forms.Button AddSport;
    private System.Windows.Forms.TextBox RecordSport;
    private System.Windows.Forms.TextBox UnitSport;
    private System.Windows.Forms.TextBox NameSport;
    private System.Windows.Forms.TextBox idSport;
    private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox KindOfSportRes;
        private System.Windows.Forms.TextBox Score;
        private System.Windows.Forms.Button Clean;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox WhatToDo;
        private System.Windows.Forms.Label Help;
    private System.Windows.Forms.DateTimePicker DateRecSport;
  }
}

