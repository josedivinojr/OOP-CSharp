using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace wfaFinalProject
{
    class Asset
    {
        private string serialNumber;
        private string model;
        private string costumerCNPJ;

        public Asset (string costumerCNPJ, string model, string serialNumber)
        {
            this.costumerCNPJ = costumerCNPJ;
            this.model = model;
            this.serialNumber = serialNumber;
        }

        public string SerialNumber { get { return serialNumber; } set { serialNumber = value; } }
        public string Model { get { return model; } set { model = value; } }
        public string CostumerCNPJ { get { return costumerCNPJ; } set { costumerCNPJ = value; } }

        public string updateInformation(string strQuery)
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

        public string insertInformation(string strQuery)
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