using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JewellaryShopping
{
    public partial class Jwellary : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public virtual void OnClicks(Object sender, EventArgs e)
        {
            User users = new User(userId.Text, password.Text);
            Repositary repositary = new Repositary();
            string retRows = repositary.Login( users);
            if (retRows == "Admin")
            {
                Response.Redirect("GridButtons.aspx");
            }
            else
            {
                Response.Write("Login successfully as user");
            }
        }
    
        
    }
}