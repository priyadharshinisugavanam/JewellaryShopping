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
    public partial class AdminSite : System.Web.UI.Page
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
            Repositary repositary = new Repositary();
            string userId = idView.DataKeys[e.RowIndex].Values["UserId"].ToString();
            repositary.DeleteCustomerDetails(userId);
            DisplayDetails();
        }
        public void UpdateDetails(object sender, GridViewUpdateEventArgs e)
        {
            Repositary repositary = new Repositary();
            string userId =idView.DataKeys[e.RowIndex].Values["UserId"].ToString();
            string mail = (idView.Rows[e.RowIndex].FindControl("Mail") as TextBox).Text;
            string phone= (idView.Rows[e.RowIndex].FindControl("Phone") as TextBox).Text;
            string role= (idView.Rows[e.RowIndex].FindControl("Role") as TextBox).Text;
            repositary.UpdateCustomerDetails(userId, phone, mail, role);
            idView.EditIndex = -1;
            DisplayDetails();
        }
        protected void Editing(object sender, GridViewEditEventArgs e)
        {
            idView.EditIndex = e.NewEditIndex;
            DisplayDetails();
        }
        protected void CancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            idView.EditIndex = -1;
            DisplayDetails();
        }
    }
}