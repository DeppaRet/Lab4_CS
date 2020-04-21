using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Configuration;

namespace Lab4_CS
{
  public partial class MainWindow : Form
  {
    static string path = ConfigurationManager.AppSettings.Get("DataBasePath");
    DataTable table = new DataTable();
    DataSet ds = new DataSet();
    SQLiteConnection conn = new SQLiteConnection("Data Source =" + path + "; Version=3;");
    SQLiteDataAdapter adapter = new SQLiteDataAdapter();

    public MainWindow()
    {
      InitializeComponent();
    }

    public void openDatabase(string cmd)
    {
      using (SQLiteConnection Connect = new SQLiteConnection("Data Source =" + path + "; Version=3;")) // @"Data Source=Lab4.db; Version=3;"
      {
        ds = Work.openDatabase(cmd);
        Table.DataSource = ds.Tables[0];
        Table.Columns["id"].ReadOnly = true;
      }
    }

    private void MainWindow_Load(object sender, EventArgs e)
    {

    }

    private void Export_Click(object sender, EventArgs e)
    {
      table = ds.Tables[0];
      Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
      Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
      Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
      //Книга.
      ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
      //Таблица.
      ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

      for (int i = 0; i < Table.Rows.Count; i++)
      {
        for (int j = 0; j < Table.ColumnCount; j++)
        {
          ExcelApp.Cells[i + 1, j + 1] = Table.Rows[i].Cells[j].Value;
        }
      }
      //Вызываем нашу созданную эксельку.
      ExcelApp.Visible = true;
      ExcelApp.UserControl = true;

    }

    private void About_Click(object sender, EventArgs e)
    {
      About about = new About();
      about.ShowDialog();
    }

    private void Close_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void ChooseTable_SelectedIndexChanged(object sender, EventArgs e)
    {
      WhatToDo.Enabled = true;
      DataSet ds = new DataSet();
      string command = " ";
      SQLiteDataAdapter da = new SQLiteDataAdapter(command, conn);
      if (ChooseTable.Text == "Спортсмен")
      {
        try
        {
          command = "SELECT * FROM Athlete";
          openDatabase(command);
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message);
        }
      }
      else if (ChooseTable.Text == "Результат")
      {
        try
        {
          command = "SELECT * FROM Results";
          openDatabase(command);
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message);
        }
      }
      else if (ChooseTable.Text == "Вид спорта")
      {
        try
        {
          command = "SELECT * FROM SportType";
          openDatabase(command);
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message);
        }
      }
      if (ChooseTable.Text == "Спортсмен")
      {
        Athlete.Enabled = true;
        Result.Enabled = false;
        Sport.Enabled = false;
      }
      else if (ChooseTable.Text == "Результат")
      {
        Result.Enabled = true;
        Athlete.Enabled = false;
        Sport.Enabled = false;
      }
      else if (ChooseTable.Text == "Вид спорта")
      {
        Sport.Enabled = true;
        Athlete.Enabled = false;
        Result.Enabled = false;
      }
    }

    private void AddAth_Click(object sender, EventArgs e)
    {
      if (WhatToDo.Text == "Добавить")
      {
        
        try
        {
          Work.AddAth(NameAth.Text, Gender.Text, CountryAth.Text, Category.Text, Score.Text);
          MessageBox.Show("Запись добавлена.");
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message, "Проверьте правильность ввода");
        }
      }
      else if (WhatToDo.Text == "Изменить")
      {
        try
        {
          Work.ChangeAth(idAth.Text, NameAth.Text, Gender.Text, CountryAth.Text, Category.Text, Score.Text);
          MessageBox.Show("Запись изменена.");
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message, "Проверьте правильность ввода");
        }
      }
      string command = "SELECT * FROM Athlete";
      openDatabase(command);
    }

    private void AddRes_Click(object sender, EventArgs e)
    {
     
      if (WhatToDo.Text == "Добавить")
      {
        try
        {
          Work.AddRes(NameRes.Text, CountryRes.Text, OrgRes.Text, ResultRes.Text, KindOfSportRes.Text);
          MessageBox.Show("Запись добавлена.");
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message, "Проверьте правильность ввода");
        }
      }
      else if (WhatToDo.Text == "Изменить")
      {
        
        try
        {
          Work.ChangeRes(idRes.Text, NameRes.Text, CountryRes.Text, OrgRes.Text, ResultRes.Text, KindOfSportRes.Text);
          MessageBox.Show("Запись изменена.");
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message, "Проверьте правильность ввода");
        }
      }
      string command = "SELECT * FROM Results";
      openDatabase(command);
    }

    private void AddSport_Click(object sender, EventArgs e)
    {
      if (WhatToDo.Text == "Добавить")
      {
        try
        {
          Work.AddSport(NameSport.Text, UnitSport.Text, RecordSport.Text, DateRecSport.Text);
          MessageBox.Show("Запись добавлена.");
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message, "Проверьте правильность ввода");
        }
      }
      else if (WhatToDo.Text == "Изменить")
      {
        try 
        {
          Work.ChangeSport(idSport.Text, NameSport.Text, UnitSport.Text, RecordSport.Text, DateRecSport.Text);
          MessageBox.Show("Запись изменена.");
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message, "Проверьте правильность ввода");
        }
      }
      string command = "SELECT * FROM SportType";
      openDatabase(command);
    }

    private void Clean_Click(object sender, EventArgs e)
    {
      idAth.Clear();
      idRes.Clear();
      NameAth.Clear();
      Gender.Text = " ";
      CountryAth.Clear();
      Category.Clear();
      Score.Clear();
      NameRes.Clear();
      CountryRes.Clear();
      OrgRes.Clear();
      ResultRes.Clear();
      KindOfSportRes.Clear();
      idSport.Clear();
      NameSport.Clear();
      UnitSport.Clear();
      RecordSport.Clear();

    }

    private void Table_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (ChooseTable.Text == "Спортсмен")
      {
        idAth.Text = Table.CurrentRow.Cells[0].Value.ToString();
        NameAth.Text = Table.CurrentRow.Cells[1].Value.ToString();
        Gender.Text = Table.CurrentRow.Cells[2].Value.ToString();
        CountryAth.Text = Table.CurrentRow.Cells[3].Value.ToString();
        Category.Text = Table.CurrentRow.Cells[4].Value.ToString();
        Score.Text = Table.CurrentRow.Cells[5].Value.ToString();
      }
      else if (ChooseTable.Text == "Результат")
      {
        idRes.Text = Table.CurrentRow.Cells[0].Value.ToString();
        NameRes.Text = Table.CurrentRow.Cells[1].Value.ToString();
        CountryRes.Text = Table.CurrentRow.Cells[2].Value.ToString();
        OrgRes.Text = Table.CurrentRow.Cells[3].Value.ToString();
        ResultRes.Text = Table.CurrentRow.Cells[4].Value.ToString();
        KindOfSportRes.Text = Table.CurrentRow.Cells[5].Value.ToString();
      }
      else if (ChooseTable.Text == "Вид спорта")
      {
        idSport.Text = Table.CurrentRow.Cells[0].Value.ToString();
        NameSport.Text = Table.CurrentRow.Cells[1].Value.ToString();
        UnitSport.Text = Table.CurrentRow.Cells[2].Value.ToString();
        RecordSport.Text = Table.CurrentRow.Cells[3].Value.ToString();
        DateRecSport.Text = Table.CurrentRow.Cells[4].Value.ToString();
      }
    }

    private void WhatToDo_SelectedIndexChanged(object sender, EventArgs e)
    {
      AddAth.Enabled = true;
      AddRes.Enabled = true;
      AddSport.Enabled = true;
      if (WhatToDo.Text == "Изменить")
      {
        Help.Visible = true;
      }
      else
      {
        Help.Visible = false;
      }
    }
  }
}