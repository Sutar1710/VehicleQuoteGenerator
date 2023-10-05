using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace VehicleQuote.Shared
{
   public class SQLconnection
    {

        string connectionString = "Data Source=(local);Initial Catalog=VehicleDatabase2;Integrated Security=True";
        public void AddDetails(User user)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "insert into [VehicleDatabase2].[dbo].[Users](username,vehicletype,vehicleage,vehiclemake,vehiclemodel,vehiclecoverage,formula) values('" + user.username + "','" + user.vehicletype + "' ,'" + user.vehicleage + "','" + user.vehiclemake + "','" + user.vehiclemodel + "','" + user.vehiclecoverage + "','" + user.formula + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();

                con.Close();

            }
        }
    }
}
