using System;
using System.Data.SqlClient;
using System.Configuration;

namespace JewellaryShopping.DAL
{
    
        class Connection
        {
            public static SqlConnection getDetails()
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                return sqlConnection;
            }
        }
    
}
