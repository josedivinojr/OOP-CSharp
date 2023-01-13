using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaFinalProject
{
    class Parts
    {
        private string airFilterElement;
        private string separatorElement;
        private string oilFilterElement;
        private string coolantKit;

        public string AirFilterElement { get => airFilterElement; set => airFilterElement = value; }
        public string SeparatorElement { get => separatorElement; set => separatorElement = value; }
        public string OilFilterElement { get => oilFilterElement; set => oilFilterElement = value; }
        public string CoolantKit { get => coolantKit; set => coolantKit = value; }

        public Parts(string airFilterElement, string separatorElement, string oilFilterElement, string coolantKit)
        {
            this.airFilterElement = airFilterElement;
            this.separatorElement = separatorElement;
            this.oilFilterElement = oilFilterElement;
            this.coolantKit = coolantKit;
        }

        public Parts()
        {

        }

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

        public DataTable getParts(string strQuery)
        {
            DataTable dataTable = new DataTable();
            MDConnection connection = new MDConnection();

            NpgsqlConnection objConnection = new NpgsqlConnection(connection.connect());
            objConnection.Open();

            using (NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter(strQuery, objConnection))
            {
                npgsqlDataAdapter.Fill(dataTable);
            }

            objConnection.Close();
            return dataTable;
        }

    }
}
