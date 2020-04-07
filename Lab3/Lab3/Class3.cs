using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Worker : Person
    {
        private string job { get; set; }
        private int wage { get; set; }
        private string timeshift { get; set; }
        public Worker(string name,string lastname,string RUT,string dateofbirth,string nationality,string job, int wage, string timeshift):base(name,lastname,RUT,dateofbirth,nationality)
        {
            this.job = job;
            this.wage = wage;
            this.timeshift = timeshift;
        }
        
        public void cambiaempleo()
        { Console.WriteLine("Introduzca el nuevo empleo:");
            string nj;
            nj = Console.ReadLine();
            Console.WriteLine("Introduzca su pago:");
            string nw;
            nw = Console.ReadLine();
            int tnw = Int32.Parse(nw);
            Console.WriteLine("Introduzca el horario de trabajo:");
            string nt;
            nt = Console.ReadLine();
        }
        public void workerinfo()
        {
                }
    }
}
