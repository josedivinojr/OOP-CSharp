using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaFinalProject
{
    public abstract class BaseCostumer
    {
        protected string name;
        protected string address;
        protected string email;
        protected string phone;

        public BaseCostumer(string name, string address, string email, string phone)
        {
            this.name = name;
            this.address = address;
            this.email = email;
            this.phone = phone;
        }

        public string Name { get { return name; } set { name = value; } }
        public string Address { get { return address; } set { address = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Phone { get { return phone; } set { phone = value; } }

        public abstract string getNextAppointment(string date);
        public abstract string updateInformation(string strQuery);
        public abstract string insertInformation(string strQuery);
    }
}
