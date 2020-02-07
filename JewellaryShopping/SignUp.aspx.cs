using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JewellaryShopping
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public virtual void SignUps(Object sender, EventArgs e)
        {
            User user = new User(userId.Text, password.Text, phone.Text, mail.Text);
            Repositary repositary = new Repositary();
            int retRows = repositary.AddAdmin(user);
            if (retRows >= 1)
            {
                Response.Redirect("Jwellary.aspx");
            }
            else
            {
                Response.Write("Not Registered...");
            }
        }
    }
}