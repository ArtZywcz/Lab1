using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Lab1
{
    public class DB
    {
        public void Select(SqlConnection connection)
        {
            var query = "SELECT * FROM Klienci";

            var command = new SqlCommand(query, connection);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine($"{reader.GetString(1)}");
                }
            }
        }

        public void Insert(SqlConnection connection, string id, string compName)
        {
            var query = "INSERT INTO Klienci(IDklienta, NazwaFirmy) VALUES(@id, @compName)";

            var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@compName", compName);

            command.ExecuteNonQuery();

        }

        public void Delete(SqlConnection connection, string id)
        {
            var query = "DELETE FROM Klienci WHERE IDklienta = @id";

            var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);

            command.ExecuteNonQuery();

        }

        public void Update(SqlConnection connection, string id, string compName)
        {
            var query = "UPDATE Klienci SET NazwaFirmy = @compName WHERE IDklienta = @id";

            var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@compName", compName);

            command.ExecuteNonQuery();
        }
    }
}
