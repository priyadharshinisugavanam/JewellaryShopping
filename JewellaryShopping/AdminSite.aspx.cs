using JewellaryShopping.BL;
using System;
using System.Data;
using System.Web.UI.WebControls;

namespace JewellaryShopping
{
    public partial class AdminSite : System.Web.UI.Page
    {
        UserDetails userDetails = new UserDetails();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                DisplayDetails();
            }
        }
        public void DisplayDetails()
        {
           
            DataTable dataTable = new DataTable();
            dataTable = userDetails.ViewDetails();
            idView.DataSource = dataTable;
            idView.DataBind();
        }
        public void DeleteDetails(object sender, GridViewDeleteEventArgs e)
        {
            
            string userId = idView.DataKeys[e.RowIndex].Values["UserId"].ToString();
            userDetails.DeleteCustomerDetails(userId);
            DisplayDetails();
        }
        public void UpdateDetails(object sender, GridViewUpdateEventArgs e)
        {
            
            string userId =idView.DataKeys[e.RowIndex].Values["UserId"].ToString();
            string mail = (idView.Rows[e.RowIndex].FindControl("Mail") as TextBox).Text;
            string phone= (idView.Rows[e.RowIndex].FindControl("Phone") as TextBox).Text;
            string role= (idView.Rows[e.RowIndex].FindControl("Role") as TextBox).Text;
            userDetails.UpdateCustomerDetails(userId, phone, mail, role);
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