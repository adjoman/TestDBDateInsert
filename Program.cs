using System;
using System.Data;
using System.Data.SqlClient;

namespace TestDateDBInsert
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello World!");

                // insert a row into the DB using a null date

                string connectionString = @"Data Source=fitforaqueen.cvsd2ftiozra.us-east-1.rds.amazonaws.com;Initial Catalog=FFAQ;User ID=ffaqadmin;Password=ffaq%%01";
                string sqlString        = "Insert into dbo.DatesTest(supply_date) Values(null)";

                SqlConnection _con = new SqlConnection(connectionString);

                SqlCommand command =
                    new SqlCommand(sqlString, _con);
                _con.Open();

                command.ExecuteNonQuery();
                _con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
