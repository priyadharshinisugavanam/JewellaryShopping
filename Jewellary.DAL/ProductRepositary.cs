using JewellaryShopping.Entity;
using System;
using System.Data;
using System.Data.SqlClient;
namespace JewellaryShopping.DAL
{
    public class ProductRepositary
    {
        SqlConnection sqlConnection = Connection.getDetails();
        public DataTable ViewProductDetails()
        {

            using (SqlCommand sqlCommand = new SqlCommand("SP_View_Products ", sqlConnection))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SP_View_Products ", sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
        }
        public void DeleteProductDetails(int productNumber)
        {
            using (SqlCommand sqlCommand = new SqlCommand("SP_DELETE_Procedure ", sqlConnection))
            {
                SqlParameter paramm = new SqlParameter();
                sqlCommand.CommandType = CommandType.StoredProcedure;

                paramm.ParameterName = "@productNumber";
                paramm.Value = productNumber;
                paramm.SqlDbType = SqlDbType.Int;
                paramm.Size = 18;
                sqlCommand.Parameters.Add(paramm);
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SP_DELETE_Procedure", sqlConnection);
                sqlDataAdapter.DeleteCommand = sqlCommand;
                sqlCommand.ExecuteNonQuery();

            }
        }
        public void UpdateProductDetails(int productNumber, string productName, int rate)
        {
            using (SqlCommand sqlCommand = new SqlCommand("SP_UPDATE_Procedure", sqlConnection))
            {
                SqlParameter paramm = new SqlParameter();
                sqlCommand.CommandType = CommandType.StoredProcedure;

                paramm.ParameterName = "@productNumber";
                paramm.Value = productNumber;
                paramm.SqlDbType = SqlDbType.Int;
                paramm.Size = 18;
                sqlCommand.Parameters.Add(paramm);

                paramm = new SqlParameter();
                paramm.ParameterName = "@productName";
                paramm.Value = productName;
                paramm.SqlDbType = SqlDbType.Char;
                paramm.Size = 20;
                sqlCommand.Parameters.Add(paramm);

                paramm = new SqlParameter();
                paramm.ParameterName = "@productRate";
                paramm.Value = rate;
                paramm.SqlDbType = SqlDbType.Int;
                paramm.Size = 13;
                sqlCommand.Parameters.Add(paramm);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
        }
            public void InsertProductDetails(Products products)
            {
                using (SqlCommand sqlCommand = new SqlCommand("SP_InsertPRODUCTS", sqlConnection))
                {
                    SqlParameter paramm = new SqlParameter();
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    paramm.ParameterName = "@productName";
                    paramm.Value = products.productName;
                    paramm.SqlDbType = SqlDbType.Char;
                    paramm.Size = 18;
                    sqlCommand.Parameters.Add(paramm);

                    paramm = new SqlParameter();
                    paramm.ParameterName = "@productRate";
                    paramm.Value = products.productRate;
                    paramm.SqlDbType = SqlDbType.Int;
                    sqlCommand.Parameters.Add(paramm);
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();

                }
            }

    }
}
