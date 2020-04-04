using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public abstract class Person
    {
        abstract public string name();
        abstract public string lastname();
        abstract public string dateofbirth();
        abstract public int RUT();
        public void info()
        { Console.WriteLine("Nombre: "+ name() + "" + lastname());
            Console.WriteLine("Fecha de nacimiento: "+dateofbirth());
            Console.WriteLine("RUT: " + RUT());
        }
    }
}
