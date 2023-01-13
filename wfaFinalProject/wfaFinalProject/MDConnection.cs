using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Npgsql;
using System.Threading.Tasks;
using System.Data;

namespace wfaFinalProject
{
    class MDConnection
    {
        private string serverName = "localhost";
        private string port = "5432";
        private string userName = "postgres";
        private string password = "cubo123";
        private string dataBaseName = "POOfinalProject";

        public string connect()
        {
            var strConnection = String.Format("Server = {0}; Port = {1}; Username = {2}; " +
                                            "Password = {3}; Database = {4}",
                                            serverName, port, userName, password, dataBaseName);
            return strConnection;
        }

        public DataTable getCostumerInformation(string strQuery)
        {
            DataTable dataTable = new DataTable();
            var strConnection = String.Format("Server = {0}; Port = {1}; Username = {2}; " +
                                            "Password = {3}; Database = {4}",
                                            serverName, port, userName, password, dataBaseName);

            NpgsqlConnection objConnection = new NpgsqlConnection(strConnection);
            objConnection.Open();

            using (NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter(strQuery, objConnection))
            {
                npgsqlDataAdapter.Fill(dataTable);
            }

            objConnection.Close();
            return dataTable;
        }

        public DataTable getPartsInformation(string strQuery)
        {
            DataTable dataTable = new DataTable();
            var strConnection = String.Format("Server = {0}; Port = {1}; Username = {2}; " +
                                            "Password = {3}; Database = {4}",
                                            serverName, port, userName, password, dataBaseName);

            NpgsqlConnection objConnection = new NpgsqlConnection(strConnection);
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
