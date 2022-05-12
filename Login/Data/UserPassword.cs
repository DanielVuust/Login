using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Login.Data
{
    public class UserPassword
    {
        private string connectionString = "Data Source=LAPTOP-DRMV9MFV;Initial Catalog=Login;Integrated Security=True";
        public string getUserPassword(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "SELECT Password FROM Users WHERE Username = @username;";
                command.Parameters.AddWithValue("@username",  username );
                command.Connection = connection;
                SqlDataReader test = command.ExecuteReader();

                while (test.Read())
                {
                    return (string)test["Password"];
                }

            }

            return "test";
        }
    }
}