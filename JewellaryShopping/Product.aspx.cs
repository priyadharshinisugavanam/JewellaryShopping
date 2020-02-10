using System;
using System.Collections.Generic;
using System.Data;
using JewellaryShopping.Entity;
using System.Web.UI.WebControls;
using JewellaryShopping.BL;

namespace JewellaryShopping
{
    public partial class Product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DisplayProduct();
            }
        }
        ProductDetails productDetails = new ProductDetails();
        public void DisplayProduct()
        {

            DataTable dataTable = new DataTable();
            dataTable = productDetails.ViewDetails();
            productView.DataSource = dataTable;
            productView.DataBind();
        }
        public void DeleteDetails(object sender, GridViewDeleteEventArgs e)
        {
            int productNumber = Convert.ToInt32(productView.DataKeys[e.RowIndex].Values["ProductNumber"]);
            productDetails.DeleteDetails(productNumber);
            DisplayProduct();
        }
        public void UpdateDetails(object sender, GridViewUpdateEventArgs e)
        {

            int productNumber = Convert.ToInt32(productView.DataKeys[e.RowIndex].Values["ProductNumber"]);
            string productName = (productView.Rows[e.RowIndex].FindControl("Product") as TextBox).Text;
            int productRate= Convert.ToInt32(productView.DataKeys[e.RowIndex].Values["Rate"]);
            productDetails.UpdateDetails(productNumber, productName, productRate);
            productView.EditIndex = -1;
            DisplayProduct();
        }
        protected void Editing(object sender, GridViewEditEventArgs e)
        {
            productView.EditIndex = e.NewEditIndex;
            DisplayProduct();
        }
        protected void CancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            productView.EditIndex = -1;
            DisplayProduct();
        }
        protected void InsertProduct(object sender,EventArgs e)
        {
            TextBox productName = productView.FooterRow.FindControl("productName") as TextBox;
            int rate=Convert.ToInt32((productView.FooterRow.FindControl("RateFooter")as TextBox).Text);
            Products products = new Products(productName.Text, rate);
            productDetails.InsertDetails(products);
            DisplayProduct();

        }
    }
}