using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Worker:Person
    {
        private string job;
        private string wage;
        private string timeshift;
        public Worker(string job,string wage,string timeshift)
        {
            this.job = job;
            this.wage = wage;
            this.timeshift = timeshift;
                }
    }
}
