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
      this.Open = new System.Windows.Forms.ToolStripMenuItem();
      this.Export = new System.Windows.Forms.ToolStripMenuItem();
      this.Close = new System.Windows.Forms.ToolStripMenuItem();
      this.label1 = new System.Windows.Forms.Label();
      this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
      this.About = new System.Windows.Forms.ToolStripMenuItem();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.ChooseTable = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
      this.toolStrip1.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // Table
      // 
      this.Table.BackgroundColor = System.Drawing.Color.White;
      this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.Table.Location = new System.Drawing.Point(10, 74);
      this.Table.Name = "Table";
      this.Table.Size = new System.Drawing.Size(505, 319);
      this.Table.TabIndex = 0;
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
            this.Open,
            this.Export,
            this.Close});
      this.File.Image = ((System.Drawing.Image)(resources.GetObject("File.Image")));
      this.File.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.File.Name = "File";
      this.File.Size = new System.Drawing.Size(49, 22);
      this.File.Text = "Файл";
      // 
      // Open
      // 
      this.Open.Name = "Open";
      this.Open.Size = new System.Drawing.Size(180, 22);
      this.Open.Text = "Открыть";
      this.Open.Click += new System.EventHandler(this.Open_Click);
      // 
      // Export
      // 
      this.Export.Name = "Export";
      this.Export.Size = new System.Drawing.Size(180, 22);
      this.Export.Text = "Экспорт";
      this.Export.Click += new System.EventHandler(this.Export_Click);
      // 
      // Close
      // 
      this.Close.Name = "Close";
      this.Close.Size = new System.Drawing.Size(180, 22);
      this.Close.Text = "Выход";
      this.Close.Click += new System.EventHandler(this.Close_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 25);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(260, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Для того чтобы начать работу, откройте файл БД";
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
      this.About.Size = new System.Drawing.Size(180, 22);
      this.About.Text = "О программе";
      this.About.Click += new System.EventHandler(this.About_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.ChooseTable);
      this.groupBox1.Location = new System.Drawing.Point(540, 74);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(244, 319);
      this.groupBox1.TabIndex = 3;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Действия";
      // 
      // ChooseTable
      // 
      this.ChooseTable.FormattingEnabled = true;
      this.ChooseTable.Items.AddRange(new object[] {
            "Спортсмен",
            "Результат",
            "Вид спорта"});
      this.ChooseTable.Location = new System.Drawing.Point(6, 40);
      this.ChooseTable.Name = "ChooseTable";
      this.ChooseTable.Size = new System.Drawing.Size(95, 21);
      this.ChooseTable.TabIndex = 0;
      this.ChooseTable.SelectedIndexChanged += new System.EventHandler(this.ChooseTable_SelectedIndexChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(3, 24);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(50, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Таблица";
      // 
      // MainWindow
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.toolStrip1);
      this.Controls.Add(this.Table);
      this.Name = "MainWindow";
      this.Text = "MainWindow";
      this.Load += new System.EventHandler(this.MainWindow_Load);
      ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton File;
        private System.Windows.Forms.ToolStripMenuItem Open;
        private System.Windows.Forms.ToolStripMenuItem Export;
        private System.Windows.Forms.ToolStripMenuItem Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ChooseTable;
    }
}

