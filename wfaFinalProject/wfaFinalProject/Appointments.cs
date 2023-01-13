using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaFinalProject
{
    internal class Appointments : Costumer
    {
        private string date;
        public string Date { get { return date; } set { date = value; } }

        public Appointments(string date, string cnpj, string name, string address, string email, string phone) : base(cnpj, name, address, email, phone)
        {
            this.date = date;
        }

    }
}
