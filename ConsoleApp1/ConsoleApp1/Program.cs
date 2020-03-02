using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = @"Data Source=DESKTOP-M1MKO1J\SQLEXPRESS01;Initial Catalog=BD1d_cz_1B;Integrated Security=True";

            var connection = new SqlConnection(connectionString);

            var db = new DB();
            connection.Open();

            db.Select(connection);
            Console.ReadLine();

            db.Insert(connection, "NOWYY", "Testowy Tester");
            db.Select(connection);
            Console.ReadLine();
            
            db.Update(connection, "NOWYY", "Probny Probownik");
            db.Select(connection);
            Console.ReadLine();

            db.Delete(connection, "NOWYY");
            db.Select(connection);
            Console.ReadLine();

            connection.Close();

        }
    }
}
