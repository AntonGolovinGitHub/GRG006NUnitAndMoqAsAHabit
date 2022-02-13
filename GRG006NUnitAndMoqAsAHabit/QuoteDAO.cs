using System;
using System.Data.SQLite;

namespace GRG006NUnitAndMoqAsAHabit
{
    public class QuoteDAO
    {

        private static bool DEBUG = false;
        private static int NUMBER_QUOTES = 100;

        private SQLiteConnection conn;

        private int totalQuotes;
        private int currentQuote;

        public QuoteDAO()
        {
            connect();
            load();
            totalQuotes = this.total();
            if (DEBUG) 
                Console.WriteLine("Found rows: " + totalQuotes);
            currentQuote = 1;

        }


        private void connect()
        {
            try
            {

                string cs = "Data Source=:memory:";
                
                conn = new SQLiteConnection(cs);
                conn.Open();

                string stm = "SELECT SQLITE_VERSION()";
                var cmd = new SQLiteCommand(stm, conn);

                string version = cmd.ExecuteScalar().ToString();

                if (DEBUG) 
                    Console.WriteLine($"SQLite version: {version}");

            }
            catch (Exception ex)
            {
                throw ex;
            }

            
        }

        private void disconnect()
        {
            try
            {
                if (conn != null)
                    conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void load()
        {

            try
            {


                // string stm0 = "DROP TABLE IF EXISTS QUOTES";
                // var cmd0 = new SQLiteCommand(stm0, conn);

                // string table0 = cmd0.ExecuteNonQuery().ToString();

                // if (DEBUG)
                //    Console.WriteLine($"Dropped table: {table0}");


                string stm1 = "CREATE TABLE IF NOT EXISTS QUOTES (ID INT NOT NULL, QUOTE VARCHAR(255) NOT NULL)";
                var cmd1 = new SQLiteCommand(stm1, conn);

                string table1 = cmd1.ExecuteNonQuery().ToString();

                if (DEBUG)
                    Console.WriteLine($"Created table: {table1}");

                for (var i = 1; i <= NUMBER_QUOTES; i++)
                {
                    var cmd2 = new SQLiteCommand(
                        $"INSERT INTO QUOTES (ID, QUOTE) VALUES ({i}, 'Quote {i} is being displayed.')", conn);
                    int table2 = Convert.ToInt32(cmd2.ExecuteScalar());

                    if (DEBUG)
                        Console.WriteLine($"Inserted quote under index {i}");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void unload()
        {
            try
            {

                string stm = "DELETE FROM QUOTES;";
                var cmd = new SQLiteCommand(stm, conn);

                string table = cmd.ExecuteNonQuery().ToString();

                if (DEBUG)
                    Console.WriteLine($"Deleted table: {table}");

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private int total()
        {
            try
            {

                string stm = "SELECT COUNT(A.ID) as NUM_QUOTES FROM QUOTES A;";
                var cmd = new SQLiteCommand(stm, conn);

                int numberQuotes = Convert.ToInt32(cmd.ExecuteScalar());

                if (DEBUG)
                    Console.WriteLine($"Found # quotes: {numberQuotes}");

                return Convert.ToInt32(numberQuotes);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Quote fetch(int numberQuote)
        {

            if (numberQuote < 1 || numberQuote > this.totalQuotes)
                throw new Exception("invalid quoteIndex value passed in");

            string stm = "SELECT A.ID, A.QUOTE FROM QUOTES A WHERE A.ID = " + numberQuote;
            var cmd = new SQLiteCommand(stm, conn);

            var reader = cmd.ExecuteReader();
            reader.Read();


            var quote = new Quote(this.totalQuotes);
            quote.Id = reader.GetInt32(0);
            quote.Text = reader.GetString(1);

            if (DEBUG)
                Console.WriteLine($"Found quote: {quote.Text}");

            return quote;
        }

        private int random(int numberQuotes)
        {
            Random r = new Random();
            return r.Next(1, numberQuotes);
        }


        public void reset()
        {
            try
            {
                this.currentQuote = 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Quote roundrobin()
        {
            try
            {
                if (currentQuote > totalQuotes)
                    currentQuote = 1;
                return this.fetch(currentQuote++);
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public Quote random()
        {
            try
            {
                int quoteIndex = this.random(this.totalQuotes);
                return this.fetch(quoteIndex);
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public void stop()
        {
            try
            {
                this.unload();
                this.disconnect();
            }
            catch (Exception ex) {
                throw ex;
            }
            }


    }
}