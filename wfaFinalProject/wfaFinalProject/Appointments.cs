using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaFinalProject
{
    class Appointments 
    {
        private string date;
        public string Date { get { return date; } set { date = value; } }

        public Appointments(string date)
        {
            this.date = date;
        }

    }
}
