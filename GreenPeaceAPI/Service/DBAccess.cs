using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using GreenPeaceAPI.Models;

namespace GreenPeaceAPI.DBService
{
    public class DBAccess
    {

        public LoginRequest ReadDatabase(string Query,string connectionString,LoginRequest LoginParaeters)
        {
            LoginRequest lr = new LoginRequest();
            string queryString = Query;
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@Email", LoginParaeters.UserName);
                command.Parameters.AddWithValue("@Password", LoginParaeters.Password);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {

                        lr.UserRoleStatus = reader["UserRoleStatus"].ToString();

                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                //Console.ReadLine();
            }

            return lr;
        }

    }
}