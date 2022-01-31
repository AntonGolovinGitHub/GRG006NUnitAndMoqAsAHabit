using System;
using System.Data.SQLite;

namespace GRG006NUnitAndMoqAsAHabit;


public class GRG006NUnitAndMoqAsAHabit_QuoteDAO
{

    private static SQLiteConnection con;

    static GRG006NUnitAndMoqAsAHabit_QuoteDAO()
    {
        string cs = "Data Source=:memory:";
        
        con = new SQLiteConnection(cs);
        con.Open();
    }

    public GRG006NUnitAndMoqAsAHabit_QuoteDAO()
    {
        try
        {

            string cs = "Data Source=:memory:";
            string stm = "SELECT SQLITE_VERSION()";

            using var con = new SQLiteConnection(cs);
            con.Open();

            using var cmd = new SQLiteCommand(stm, con);
            string version = cmd.ExecuteScalar().ToString();

            Console.WriteLine($"SQLite version: {version}");

        }
        catch (Exception ex)
        {
            throw ex;
        }

    }

}