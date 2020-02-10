using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewellaryShopping.Entity
{
    public class Products
    {
        public int productNumber { get; set; }
        public string productName { get; set; }
        public int productRate { get; set; }

        public Products(int productNumber, string productName, int productRate)
        {
            this.productNumber = productNumber;
            this.productName = productName;
            this.productRate = productRate;
        }

            public Products( string productName, int productRate)
            {
               
                this.productName = productName;
                this.productRate = productRate;
            }

        }
}
