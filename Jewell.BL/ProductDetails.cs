using System;
using System.Data;
using JewellaryShopping.Entity;
using JewellaryShopping.DAL;

namespace JewellaryShopping.BL
{
    public class ProductDetails
    {
        ProductRepositary productRepositary = new ProductRepositary();
        public DataTable ViewDetails()
        {
            return productRepositary.ViewProductDetails();

        }
        public void DeleteDetails(int productNumber)
        {
            productRepositary.DeleteProductDetails(productNumber);
        }
        public void UpdateDetails(int productNumber, string productName, int rate)
        {
            productRepositary.UpdateProductDetails(productNumber, productName, rate);
        }
        public void InsertDetails(Products products)
        {
            productRepositary.InsertProductDetails(products);
        }
    }
}
