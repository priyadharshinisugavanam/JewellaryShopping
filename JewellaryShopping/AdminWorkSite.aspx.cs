using System;
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
        public void ViewProduct(object sender, EventArgs e)
        {
            Response.Redirect("Product.aspx");

        }
    }
}