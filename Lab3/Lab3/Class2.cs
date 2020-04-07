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
        public Product()
        { }
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
        public void showproducts()
        { int i = infonpn.Count();
            int r = infobrand.Count();
            int d = 0;
        while (d < i)
            {
                
                Console.WriteLine(r+":"+"Producto:"+ infonpn[d]+"Marca:"+infobrand[d]+"Stock:"+infostock[d]+"Precio:"+infopri[d]);
                d = d + 1;
                r = r + 1;
            } }
        
        
        public int changestock(int o,int p)
        { int stockactual = infostock[p];
            int nuevostock = stockactual - o;
            return nuevostock;
        }
        public void stockchanged(int ns,int p )
        { int stocknow = infostock[p];
            infostock.Insert(index: p, item: ns);
            infostock.RemoveAt(index: p + 1);
        }
        public int summary(int p,int q)
        {int valor= infopri[p];
            int valoractual = valor * q;
            return valoractual;
        }
        public string addcarro(int p)
        { string pr = infonpn[p];
            return pr;
        }
        public string addcarro2(int p)
        { string marc = infobrand[p];
            return marc;
        }
        public int precios(int p)
        {
            int pre = infopri[p];
                return pre; }
    }
}
