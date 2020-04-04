using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Product
    {
        private string productname;
        private string brand;
        private int price;
        private int stock;
        public Product(string productname,string brand,int price,int stock)
        { this.productname = productname;
            this.brand = brand;
            this.price = price;
            this.stock = stock;

        }

    }
}
