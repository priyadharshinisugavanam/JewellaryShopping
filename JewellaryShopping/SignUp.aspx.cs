using JewellaryShopping.BL;
using JewellaryShopping.Entity;
using System;
namespace JewellaryShopping
{
    public partial class SignUp : System.Web.UI.Page
    {
        UserDetails userDetails = new UserDetails();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public virtual void SignUps(Object sender, EventArgs e)
        {
            User user = new User(userId.Text, password.Text, phone.Text, mail.Text);
            
            int retRows = userDetails.AddAdmin(user);
            if (retRows >= 1)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                Response.Write("Not Registered...");
            }
        }
    }
}