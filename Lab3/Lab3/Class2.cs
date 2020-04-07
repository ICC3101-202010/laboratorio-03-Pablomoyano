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
        public Product(string productname, string brand, int price, int stock)
        { this.productname = productname;
            this.brand = brand;
            this.price = price;
            this.stock = stock;

        }
        List<string> infonpn= new List<string>();
        List<string> infobrand = new List<string>();
        List<int> infostock= new List<int>();
        List<int> infopri = new List<int>();
        public void addpro(string pn,string br,int pr,int st)
        {
            infonpn.Add(pn);
            infobrand.Add(br);
            infopri.Add(pr);
            infostock.Add(st);


        }
        public int lowerstock(int numstock,int quantbuy)
        { numstock = numstock - quantbuy;
            return numstock;
        }

    }
}
