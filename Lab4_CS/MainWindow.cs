using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Lab4_CS
{
  public partial class MainWindow : Form
  {
    DataTable table = new DataTable();
    DataSet ds = new DataSet();
    SQLiteConnection conn = new SQLiteConnection("Data Source = Lab4.db; Version=3;");
    SQLiteDataAdapter adapter = new SQLiteDataAdapter();
    public MainWindow()
    {
      InitializeComponent();
    }

    public void openDatabase(string cmd)
    {
      using (SQLiteConnection Connect = new SQLiteConnection(@"Data Source=Lab4.db; Version=3;"))
      {
        Connect.Open();
        adapter = new SQLiteDataAdapter(cmd, Connect);
        Connect.Close();
        ds = new DataSet();
        adapter.Fill(ds);
        Table.DataSource = ds.Tables[0];
        Table.Columns["id"].ReadOnly = true;
      }
    }
    
    public void insertDB(string cmd)
    {
      using (SQLiteConnection Connect = new SQLiteConnection(@"Data Source=Lab4.db; Version=3;"))
      {
        SQLiteCommand Command = new SQLiteCommand(cmd, Connect);
        Connect.Open();
        Command.ExecuteNonQuery();
        Connect.Close();
      }
    }

    public void updateDB(string cmd)
    {
      using (SQLiteConnection Connect = new SQLiteConnection(@"Data Source=Lab4.db; Version=3;"))
      {
        SQLiteCommand Command = new SQLiteCommand(cmd, Connect);
        Connect.Open();
        Command.ExecuteNonQuery();
        Connect.Close();
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
      DataSet ds = new DataSet();
      string command = " ";
      SQLiteDataAdapter da = new SQLiteDataAdapter(command, conn);
      if (ChooseTable.Text == "Спортсмен")
      {
        try
        {
          command = "SELECT * FROM Athlete";
          openDatabase(command);
         // da.Fill(ds);
         // Table.DataSource = ds.Tables[0].DefaultView;
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
    }

    private void checkAth_CheckedChanged(object sender, EventArgs e)
    {
      Athlete.Enabled = true;
      Result.Enabled = false;
      Sport.Enabled = false;
      checkRes.Checked = false;
      checkSport.Checked = false;
    }

    private void checkRes_CheckedChanged(object sender, EventArgs e)
    {
      Result.Enabled = true;
      Athlete.Enabled = false;
      Sport.Enabled = false;
      checkAth.Checked = false;
      checkSport.Checked = false;
    }

    private void checkSport_CheckedChanged(object sender, EventArgs e)
    {
      Sport.Enabled = true;
      Athlete.Enabled = false;
      Result.Enabled = false;
      checkRes.Checked = false;
      checkAth.Checked = false;
    }

    private void AddAth_Click(object sender, EventArgs e)
    {
      if (WhatToDo.Text == "Добавить")
      {
        string cmd = String.Format("Insert into Athlete (id, name, gender, country, category, score) values ({0}, '{1}', '{2}', '{3}', {4}, {5})", idAth.Text, NameAth.Text, Gender.Text, CountryAth.Text, Category.Text, Score.Text);
        try
        {
          insertDB(cmd);
          MessageBox.Show("Запись добавлена.");
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message);
        }
      }
      else if (WhatToDo.Text == "Изменить")
      {
        string cmd = String.Format("update Athlete set name = '{1}', gender = '{2}', country = '{3} ', category = {4}, score = {5} where id = {0};", idAth.Text, NameAth.Text, Gender.Text, CountryAth.Text, Category.Text, Score.Text);
        try
        {
          updateDB(cmd);
          MessageBox.Show("Запись изменена.");
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message);
        }
      }
    }

    private void AddRes_Click(object sender, EventArgs e)
    {
      if (WhatToDo.Text == "Добавить")
      {
        string cmd = String.Format("Insert into Results (id, contest, country, organisator, score, kind_of_sport) values ({0}, '{1}', '{2}', '{3}', {4}, {5})", idRes.Text, NameRes.Text, CountryRes.Text, OrgRes.Text, ResultRes.Text, KindOfSportRes.Text);
        try
        {
          insertDB(cmd);
          MessageBox.Show("Запись добавлена.");
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message);
        }
      }
      else if (WhatToDo.Text == "Изменить")
      {
        string cmd = String.Format("update Results set contest = '{1}', country = '{2}', organisator = '{3}', score = {4}, kind_of_sport = {5} where id = {0};", idRes.Text, NameRes.Text, CountryRes.Text, OrgRes.Text, ResultRes.Text, KindOfSportRes.Text);
        try
        {
          updateDB(cmd);
          MessageBox.Show("Запись изменена.");
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message);
        }
      }
    }

    private void AddSport_Click(object sender, EventArgs e)
    {
      if (WhatToDo.Text == "Добавить")
      {
        string cmd = String.Format("Insert into SportType (id, name, unit, record, date) values ({0}, '{1}', '{2}', {3}, '{4}')", idSport.Text, NameSport.Text, UnitSport.Text, RecordSport.Text, DateRecSport.Text);
        try
        {
          insertDB(cmd);
          MessageBox.Show("Запись добавлена.");
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message);
        }
      }
      else if (WhatToDo.Text == "Изменить")
      {
        string cmd = String.Format("update SportType set name = '{1}', unit = '{2}', record = {3}, date = '{4}' where id = {0};", idSport.Text, NameSport.Text, UnitSport.Text, RecordSport.Text, DateRecSport.Text);
        try
        {
          updateDB(cmd);
          MessageBox.Show("Запись изменена.");
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message);
        }
      }
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
      DateRecSport.Clear();
    }
  }


}