using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Person
    {
        public string name;
        public string lastname;
        public string dateofbirth;
        public string RUT;
        public Person(string name,string lastname,string dateofbirth,string RUT)
        { this.name = name;
            this.lastname = lastname;
            this.dateofbirth = dateofbirth;
            this.RUT = RUT;
        }
        public void info(string name,string lastname,string dateofbirth,string RUT)
        { Console.WriteLine("Nombre: "+ name + "" + lastname);
            Console.WriteLine("Fecha de nacimiento: "+dateofbirth);
            Console.WriteLine("RUT: " + RUT);
        }
    }
}
