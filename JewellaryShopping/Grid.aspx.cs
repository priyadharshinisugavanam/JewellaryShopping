using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JewellaryShopping
{
    public partial class Grid : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                DisplayDetails();
            }
        }
        public void DisplayDetails()
        {
            Repositary repositary = new Repositary();
            DataTable dataTable = new DataTable();
            dataTable = repositary.ViewDetails();
            idView.DataSource = dataTable;
            idView.DataBind();
        }
        public void DeleteDetails(object sender, GridViewDeleteEventArgs e)
        {
            Repositary repositary =     new Repositary();
            string userId = idView.DataKeys[e.RowIndex].Values["UserId"].ToString();
            repositary.DeleteCustomerDetails(userId);
            DisplayDetails();
        }
    }
}