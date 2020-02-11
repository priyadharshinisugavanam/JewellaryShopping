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
            try { 
            using (SqlCommand sqlCommand = new SqlCommand("SP_View_Products ", sqlConnection))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SP_View_Products ", sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }

            }
            catch (Exception e)
            {
                DataTable dataTable = new DataTable();
                Console.WriteLine(e.Message);
                return dataTable;

            }
            finally
            {
                sqlConnection.Close();
            }
        }
        public void DeleteProductDetails(int productNumber)
        {
            try
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
            catch (Exception e)
            {

                Console.WriteLine(e.Message);

            }
            finally
            {
                sqlConnection.Close();
            }
        }
        public void UpdateProductDetails(int productNumber, string productName, int rate)
        {
            try { 
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
            catch (Exception e)
            {

                Console.WriteLine(e.Message);

            }
            finally
            {
                sqlConnection.Close();
            }
        }
            public void InsertProductDetails(Products products)
            {
            try { 
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
            catch (Exception e)
            {

                Console.WriteLine(e.Message);

            }
            finally
            {
                sqlConnection.Close();
            }
        }

    }
}
