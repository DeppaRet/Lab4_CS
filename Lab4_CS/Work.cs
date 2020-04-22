using  System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Configuration;

namespace Lab4_CS
{
  public class Work
  {
    static string path = ConfigurationManager.AppSettings.Get("DataBasePath");
    static DataTable table = new DataTable();
    static DataSet ds = new DataSet();
    static SQLiteConnection conn = new SQLiteConnection("Data Source =" + path + "; Version=3;");
    static SQLiteDataAdapter adapter = new SQLiteDataAdapter();
    public static DataSet openDatabase(string cmd)
    {
      using (SQLiteConnection Connect = new SQLiteConnection("Data Source =" + path + "; Version=3;")) // @"Data Source=Lab4.db; Version=3;"
      {
        Connect.Open();
        adapter = new SQLiteDataAdapter(cmd, Connect);
        Connect.Close();
        ds = new DataSet();
        adapter.Fill(ds);
        return ds;
      }
    }
    public static void AddAth(string name, string gender, string country, string cat, string score)
    {
      SQLiteConnection Connect = new SQLiteConnection("Data Source =" + path + "; Version=3;");
      SQLiteCommand cmd = Connect.CreateCommand();
      cmd.CommandText = "Insert into Athlete (id, name, gender, country, category, score) values (NULL, @name, @gend, @country, @cat, @score)";
      cmd.Parameters.AddWithValue("@name", name);
      cmd.Parameters.AddWithValue("@gend", gender);
      cmd.Parameters.AddWithValue("@country", country);
      cmd.Parameters.AddWithValue("@cat", cat);
      cmd.Parameters.AddWithValue("@score", score);
      Connect.Open();
      cmd.ExecuteNonQuery();
      Connect.Close();
    }
    public static void ChangeAth(string id, string name, string gender, string country, string cat, string score)
    {
      SQLiteConnection Connect = new SQLiteConnection("Data Source =" + path + "; Version=3;");
      SQLiteCommand cmd = Connect.CreateCommand();
      cmd.CommandText = "update Athlete set name = @name, gender = @gend, country = @country, category = @cat, score = @score where id = @id;";
      cmd.Parameters.AddWithValue("@id", id);
      cmd.Parameters.AddWithValue("@name", name);
      cmd.Parameters.AddWithValue("@gend", gender);
      cmd.Parameters.AddWithValue("@country", country);
      cmd.Parameters.AddWithValue("@cat", cat);
      cmd.Parameters.AddWithValue("@score", score);
      Connect.Open();
      cmd.ExecuteNonQuery();
      Connect.Close();
    }
    public static void AddRes(string name, string country, string org, string res, string sport)
    {
      SQLiteConnection Connect = new SQLiteConnection("Data Source =" + path + "; Version=3;");
      SQLiteCommand cmd = Connect.CreateCommand();
      cmd.CommandText = "Insert into Results (id, contest, country, organisator, score, kind_of_sport) values (NULL, @name, @country, @org, @score, @sport)";
      cmd.Parameters.AddWithValue("@name", name);
      cmd.Parameters.AddWithValue("@country", country);
      cmd.Parameters.AddWithValue("@org", org);
      cmd.Parameters.AddWithValue("@score", res);
      cmd.Parameters.AddWithValue("@sport", sport);
      Connect.Open();
      cmd.ExecuteNonQuery();
      Connect.Close();
    }
    public static void ChangeRes(string id, string name, string country, string org, string res, string sport)
    {
      SQLiteConnection Connect = new SQLiteConnection("Data Source =" + path + "; Version=3;");
      SQLiteCommand cmd = Connect.CreateCommand();
      cmd.CommandText = "update Results set contest = @name, country = @country, organisator = @org, score = @score, kind_of_sport = @sport where id = @id;";
      cmd.Parameters.AddWithValue("@id", id);
      cmd.Parameters.AddWithValue("@name", name);
      cmd.Parameters.AddWithValue("@country", country);
      cmd.Parameters.AddWithValue("@org", org);
      cmd.Parameters.AddWithValue("@score", res);
      cmd.Parameters.AddWithValue("@sport", sport);
      Connect.Open();
      cmd.ExecuteNonQuery();
      Connect.Close();
    }
    public static void AddSport(string name, string unit, string rec, string date)
    {
      SQLiteConnection Connect = new SQLiteConnection("Data Source =" + path + "; Version=3;");
      SQLiteCommand cmd = Connect.CreateCommand();
      cmd.CommandText = "Insert into SportType (id, name, unit, record, date) values (NULL, @name, @unit, @rec, @date)";
      cmd.Parameters.AddWithValue("@name", name);
      cmd.Parameters.AddWithValue("@unit", unit);
      cmd.Parameters.AddWithValue("@rec", rec);
      cmd.Parameters.AddWithValue("@date", date);
      Connect.Open();
      cmd.ExecuteNonQuery();
      Connect.Close();
    }
    public static void ChangeSport(string id, string name, string unit, string rec, string date)
    {
      SQLiteConnection Connect = new SQLiteConnection("Data Source =" + path + "; Version=3;");
      SQLiteCommand cmd = Connect.CreateCommand();
      cmd.CommandText = "update SportType set name = @name, unit = @unit, record = @rec, date = @date where id = @id;";
      cmd.Parameters.AddWithValue("@id", id);
      cmd.Parameters.AddWithValue("@name", name);
      cmd.Parameters.AddWithValue("@unit", unit);
      cmd.Parameters.AddWithValue("@rec", rec);
      cmd.Parameters.AddWithValue("@date", date);
      Connect.Open();
      cmd.ExecuteNonQuery();
      Connect.Close();
    }
  }
}