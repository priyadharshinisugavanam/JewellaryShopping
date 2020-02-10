using JewellaryShopping.BL;
using JewellaryShopping.Entity;
using System;
namespace JewellaryShopping
{
    public partial class Login : System.Web.UI.Page
    {
        UserDetails userDetails = new UserDetails();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public virtual void OnClicks(Object sender, EventArgs e)
        {
            User users = new User(userId.Text, password.Text);
            
            string retRows = userDetails.Login( users);
            if (retRows == "Admin")
            {
                Response.Redirect("AdminWorkSite.aspx");
            }
            else if (retRows == "User")
            {
                Response.Redirect("ProductSite.aspx");
            }
            else
            {
                Response.Write("Login failed");
            }
        }
    
        
    }
}