using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;

namespace JewellaryShopping
{
    class User
    {
        public string userID { get; set; }
        public string password { get; set; }
        public string conformPassword { get; set; }
        public string mailId { get; set; }
        public string role { get; set; }
        public string phoneNumber { get; set; }
        public User(string userID, string password, string phoneNumber, string mailId)
        {
            this.userID = userID;
            this.password = password;
            this.mailId = mailId;
            this.phoneNumber = phoneNumber;
           
        }
        public User(string userID, string password)
        {
            this.userID = userID;
            this.password = password;
            
        }
        public User(string userID)
        {
            this.userID = userID;
        }
    }
    class Repositary
    {

        SqlConnection sqlConnection = Connection.getDetails();
        public int AddAdmin(User user)
        {
            string sql = "AdminProcedure";

            using (SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection))
            {
                SqlParameter paramm = new SqlParameter();
                sqlCommand.CommandType = CommandType.StoredProcedure;

                paramm.ParameterName = "@UserId";
                paramm.Value = user.userID;
                paramm.SqlDbType = SqlDbType.Char;
                paramm.Size = 18;
                sqlCommand.Parameters.Add(paramm);

                paramm = new SqlParameter();
                paramm.ParameterName = "@password";
                paramm.Value = user.password;
                paramm.SqlDbType = SqlDbType.Char;
                paramm.Size = 18;
                sqlCommand.Parameters.Add(paramm);

                paramm = new SqlParameter();
                paramm.ParameterName = "@MailId";
                paramm.Value = user.mailId;
                paramm.SqlDbType = SqlDbType.Char;
                paramm.Size = 20;
                sqlCommand.Parameters.Add(paramm);

                paramm = new SqlParameter();
                paramm.ParameterName = "@PhoneNumber";
                paramm.Value = user.phoneNumber;
                paramm.SqlDbType = SqlDbType.Char;
                paramm.Size = 13;
                sqlCommand.Parameters.Add(paramm);
                paramm = new SqlParameter();
                paramm.ParameterName = "@RoleOfMemeber";
                paramm.Value = "User";
                paramm.SqlDbType = SqlDbType.VarChar;
                paramm.Size = 5;
                sqlCommand.Parameters.Add(paramm);

                sqlConnection.Open();
                int row = sqlCommand.ExecuteNonQuery();
                return row;

            }
        }
        public string Login(User user)
        {


            using (SqlCommand sqlCommand = new SqlCommand("Select_AdminProcedure", sqlConnection))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@UserId";
                sqlParameter.Value = user.userID;
                sqlParameter.SqlDbType = SqlDbType.VarChar;
                sqlParameter.Size = 18;
                sqlCommand.Parameters.Add(sqlParameter);

                sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@password";
                sqlParameter.Value = user.password;
                sqlParameter.SqlDbType = SqlDbType.VarChar;
                sqlParameter.Size = 18;
                sqlCommand.Parameters.Add(sqlParameter);
                //sqlParameter = new SqlParameter();
                sqlCommand.Parameters.Add("@RoleOfMemeber", SqlDbType.VarChar, 5);
                sqlCommand.Parameters["@RoleOfMemeber"].Direction = ParameterDirection.Output;
                sqlConnection.Open();
                sqlCommand.ExecuteReader();
                if (Convert.ToString(sqlCommand.Parameters["@RoleOfMemeber"].Value) == "User")
                    return "User";
                else
                    return "Admin";
            }


        }
        public DataTable ViewDetails()
        {

            using (SqlCommand sqlCommand = new SqlCommand("SP_VIEWCUSTOMER ", sqlConnection))
            {
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SP_VIEWCUSTOMER ", sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
        }
        public void DeleteCustomerDetails(string user)
        {
            using (SqlCommand sqlCommand = new SqlCommand("SP_DELETECUSTOMER ", sqlConnection))
            {
                SqlParameter paramm = new SqlParameter();
                sqlCommand.CommandType = CommandType.StoredProcedure;

                paramm.ParameterName = "@UserId";
                paramm.Value = user;
                paramm.SqlDbType = SqlDbType.Char;
                paramm.Size = 18;
                sqlCommand.Parameters.Add(paramm);
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SP_DELETECUSTOMER", sqlConnection);
                sqlDataAdapter.DeleteCommand = sqlCommand;
                sqlCommand.ExecuteNonQuery();

            }
        }
        public void UpdateCustomerDetails(string userID, string phoneNumber, string mailId, string role)
        {
            using (SqlCommand sqlCommand = new SqlCommand("SP_Update", sqlConnection))
            {
                SqlParameter paramm = new SqlParameter();
                sqlCommand.CommandType = CommandType.StoredProcedure;

                paramm.ParameterName = "@UserId";
                paramm.Value = userID;
                paramm.SqlDbType = SqlDbType.Char;
                paramm.Size = 18;
                sqlCommand.Parameters.Add(paramm);

                paramm = new SqlParameter();
                paramm.ParameterName = "@MailId";
                paramm.Value = mailId;
                paramm.SqlDbType = SqlDbType.Char;
                paramm.Size = 20;
                sqlCommand.Parameters.Add(paramm);

                paramm = new SqlParameter();
                paramm.ParameterName = "@PhoneNumber";
                paramm.Value = phoneNumber;
                paramm.SqlDbType = SqlDbType.Char;
                paramm.Size = 13;
                sqlCommand.Parameters.Add(paramm);
                paramm = new SqlParameter();
                paramm.ParameterName = "@RoleOfMemeber";
                paramm.Value = role;
                paramm.SqlDbType = SqlDbType.VarChar;
                paramm.Size = 5;
                sqlCommand.Parameters.Add(paramm);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }

        }
    }

    
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