using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Person
    {
        private string name;
        private string lastname;
        private string dateofbirth;
        private string RUT;
        private string nationality;
        public Person(string name,string lastname,string dateofbirth,string RUT,string nationality)
        { this.name = name;
            this.lastname = lastname;
            this.dateofbirth = dateofbirth;
            this.RUT = RUT;
            this.nationality = nationality;
        }
        public Person()
        { }
        List<string> infonames = new List<string>();
        List<string> infolastnames = new List<string>();
        List<string> infodate = new List<string>();
        List<string> inforut = new List<string>();
        List<string> infonat=new List<string>();


        public int findclient(string ru)
        { int dex= inforut.BinarySearch(ru);
            return dex;
        }
        public string namegot(int dex)
        { string n = infonames[dex];
            return n;
        }
        public string lngot(int dex)
        {
            string lan = infolastnames[dex];
            return lan;
        }

        public void addinfo(string n, string ln, string d, string r, string nat)
        {
            infonames.Add(n);
            infolastnames.Add(ln);
            infodate.Add(d);
            inforut.Add(r);
            infonat.Add(nat);
        }
        public void info(string name,string lastname,string dateofbirth,string RUT,string nationality)
        { Console.WriteLine("Nombre: "+ name + "" + lastname);
            Console.WriteLine("Fecha de nacimiento: "+dateofbirth);
            Console.WriteLine("RUT: " + RUT);
            Console.WriteLine("Nacionalidad: " + nationality);
        }
    }
}
