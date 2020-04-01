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
    public MainWindow()
    {
      InitializeComponent();
      
    }

    public void openDatabase()
    {
      SQLiteConnection conn = new SQLiteConnection("Data Source = Lab4.db; Version=3;"); 
      string command = "SELECT * FROM Athlete";
      SQLiteDataAdapter da = new SQLiteDataAdapter(command, conn);
      var openDialog = new OpenFileDialog
      {
        Title = "Открыть",
        CheckFileExists = true,
        CheckPathExists = true,
        Filter = "Файлы DB (*.db)|*.db",
        ShowHelp = true
      };
      if (openDialog.ShowDialog() == DialogResult.OK)
        try
        {
          conn.Open();
          da.Fill(ds);
          Table.DataSource = ds.Tables[0].DefaultView;
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message);
        }
      label1.Visible = false;
    }

    private void MainWindow_Load(object sender, EventArgs e)
    {

    }

    private void Open_Click(object sender, EventArgs e)
    {
      openDatabase();
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
      SQLiteConnection conn = new SQLiteConnection("Data Source = Lab4.db; Version=3;");
      string command = " ";
      SQLiteDataAdapter da = new SQLiteDataAdapter(command, conn);
      if (ChooseTable.Text == "Спортсмен")
      {
        command = "SELECT * FROM Athlete";
        da.Fill(ds);
      }
      else if (ChooseTable.Text == "Результат")
      {
        command = "SELECT * FROM Results";
        da.Fill(ds);
      }
      else if (ChooseTable.Text == "Вид спорта")
      {
        command = "SELECT * FROM SportType";
        da.Fill(ds);
      }
    }
  }


}