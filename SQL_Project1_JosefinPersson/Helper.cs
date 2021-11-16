using System;
using System.Data;
using System.Data.SqlClient;

namespace SQL_Project1_JosefinPersson
{
    class Helper     
    {
        //-------printmetod---------

        private static void PrintRow(DataTable dt)  // print metod.....
        {
            foreach (DataRow row in dt.Rows)
            {
                for (var i = 0; i < dt.Columns.Count; i++)
                {
                    Console.WriteLine(row[i] + " ");
                }
                Console.WriteLine();  // varför?
            }
        }

        // ---------GETDATATABLE-------------

        private static DataTable GetDataTable(string sql, string paramName, string paramValue)
        {
            //defienerar connection string
            var connString = "server=(localdb)\\mssqllocaldb;integrated security=true;database=MOCK_DATA";
            // skapa data table
            var dt = new DataTable();
            //förbered koppling till databasen
            using (var connection = new SqlConnection(connString))
            {
                // öppna koppling till databasen
                connection.Open();
                //förbered kommando
                using (var command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue(paramName, paramValue);
                    // förbered en adapter
                    using (var adapter = new SqlDataAdapter(command))
                    {
                        //kopierar databasdata till datatable
                        adapter.Fill(dt);
                    }
                }
            } // här förstörs kopplingen till databasen, skyddar databasen

            return dt;
        }
        // ---------------annan metod, om man inte vill returnera något...--------------
        private static void ExecuteSQL(string sql, string paramName, string paramValue)
        {
            //defienerar connection string
            var connString = "server=(localdb)\\mssqllocaldb;integrated security=true;database=MOCK_DATA";
            // skapa data table
            var dt = new DataTable();
            //förbered koppling till databasen
            using (var connection = new SqlConnection(connString))
            {
                // öppna koppling till databasen
                connection.Open();
                //förbered kommando
                using (var command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue(paramName, paramValue);
                    command.ExecuteNonQuery();
                }
            } // här förstörs kopplingen till databasen, skyddar databasen
        }
    }
}
