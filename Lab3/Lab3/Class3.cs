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
        List<string> workername = new List<string>();
        List<string> workerlastname = new List<string>();
        List<string> workerrut = new List<string>();
        List<string> workerdob = new List<string>();
        List<string> workernat = new List<string>();
        List<string> workerjob = new List<string>();
        List<int> workerwage = new List<int>();
        List<string> workerts = new List<string>();

        public void infot(string nwo,string nlana,string wru,string wdob,string wnat,string wjo,int ww,string wots)
        { workername.Add(nwo);
            workerlastname.Add(nlana);
            workerrut.Add(wru);
            workerdob.Add(wdob);
            workernat.Add(wnat);
            workerjob.Add(wjo);
            workerwage.Add(ww);
            workerts.Add(wots);
        }

        public void cambiaempleo(string wn,string wln,string wr,string wd,string wna)
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
            Worker newj = new Worker(wn, wln, wr, wd, wna, nj, tnw, nt);
            newj.job = nj;
            newj.wage = tnw;
            newj.timeshift = nt;
        }
        
    }
}
