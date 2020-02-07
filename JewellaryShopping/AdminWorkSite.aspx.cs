using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JewellaryShopping
{
    public partial class AdminWorkSite : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void ViewCustomer(object sender, EventArgs e)
        {
            Response.Redirect("AdminSite.aspx");
        }
        public void Edit()
        {

        }
    }
}