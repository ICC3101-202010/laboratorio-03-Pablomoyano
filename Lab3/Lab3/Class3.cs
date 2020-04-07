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
        
        public Worker(string name, string lastname, string RUT, string dateofbirth, string nationality, string job, int wage, string timeshift) : base(name, lastname, RUT, dateofbirth, nationality)
        {
            this.job = job;
            this.wage = wage;
            this.timeshift = timeshift;
        }
        public Worker()
        { }


        List<string> workername = new List<string>();
        List<string> workerlastname = new List<string>();
        List<string> workerrut = new List<string>();
        List<string> workerdob = new List<string>();
        List<string> workernat = new List<string>();
        List<string> workerjob = new List<string>();
        List<int> workerwage = new List<int>();
        List<string> workerts = new List<string>();

        
        public string findnat(int index)
        {
            string nat = workerlastname[index];
            return nat;
        }
        public void changejob(int r,string njj,int nww,string ntss)
        { workerjob.Insert(index: r, item: njj);
            workerjob.RemoveAt(index: r + 1);
            workerwage.Insert(index: r, item: nww);
            workerwage.RemoveAt(index: r + 1);
            workerts.Insert(index: r, item: ntss);
            workerts.RemoveAt(index: r + 1);

        }
        public int findworker(string wru)
        {
            int index = workerrut.BinarySearch(wru);
            return index;
        }
        public string findname(int index)
        {
            string n = workername[index];
            return n;
        }
        public string findln(int index)
        {
            string ln = workerlastname[index];
            return ln;
        }
        public string finddob(int index)
        {
            string dob = workerlastname[index];
            return dob;
        }
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

        public void cambiaempleo(string wn,string wln,string wr,string wd,string wna,string ntr,int nsal,string nho)
        { 
            Worker newj = new Worker(wn, wln, wr, wd, wna,ntr,nsal,nho);
            newj.job = ntr;
            newj.wage = nsal;
            newj.timeshift = nho;
        }
        
    }
}
