using System;
namespace JewellaryShopping
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public virtual void Click(Object sender, EventArgs e)
        {


            Response.Redirect("Home.aspx");
        }
        public virtual void SignUp(Object sender, EventArgs e)
        {


            Response.Redirect("SignUp.aspx");
        }
        public virtual void OnClicks(Object sender, EventArgs e)
        {


            Response.Redirect("Login.aspx");
        }

    }
}