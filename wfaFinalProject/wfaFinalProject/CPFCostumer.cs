using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;


namespace wfaFinalProject
{
    class CPFCostumer : BaseCostumer
    {
        private string cpf;

        public CPFCostumer(string cpf, string name, string address, string email, string phone) : base(name, address, email, phone)
        {
            this.cpf = cpf;
            this.name = name;
            this.address = address;
            this.email = email;
            this.phone = phone;
        }

        public string Cpf { get { return cpf; } set { cpf = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Address { get { return address; } set { address = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Phone { get { return phone; } set { phone = value; } }

        public override string getNextAppointment(string date)
        {
            return "asd";
        }

        public override string updateInformation(string strQuery)
        {
            DataTable dataTable = new DataTable();
            MDConnection connection = new MDConnection();

            NpgsqlConnection objConnection = new NpgsqlConnection(connection.connect());
            objConnection.Open();

            NpgsqlCommand costumerCnpjCommand = new NpgsqlCommand(strQuery, objConnection);
            NpgsqlDataReader dr = costumerCnpjCommand.ExecuteReader();

            string result = String.Empty;
            while (dr.Read())
            {
                result = dr[0].ToString();
            }

            return result;
        }

        public override string insertInformation(string strQuery)
        {
            DataTable dataTable = new DataTable();
            MDConnection connection = new MDConnection();

            NpgsqlConnection objConnection = new NpgsqlConnection(connection.connect());
            objConnection.Open();

            NpgsqlCommand costumerCnpjCommand = new NpgsqlCommand(strQuery, objConnection);
            NpgsqlDataReader dr = costumerCnpjCommand.ExecuteReader();

            string result = String.Empty;
            while (dr.Read())
            {
                result = dr[0].ToString();
            }

            return result;
        }

    }
}