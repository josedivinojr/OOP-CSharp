using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;

namespace wfaFinalProject
{
    class Appointment
    {
        private string date;
        private string time;
        public string Date { get { return date; } set { date = value; } }
        public string Time { get { return time; } set { time = value; } }

        public Appointment(string date, string time) 
        {
            this.date = date;
            this.time = time;
        }
        public DataTable SelectAppointment(string strQuery)
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
        public string UpdateAppointment(string strQuery)
        {
            MDConnection connection = new MDConnection();

            NpgsqlConnection objConnection = new NpgsqlConnection(connection.connect());
            objConnection.Open();

            NpgsqlCommand appointmentUpdate = new NpgsqlCommand(strQuery, objConnection);
            NpgsqlDataReader dr = appointmentUpdate.ExecuteReader();

            string result = String.Empty;
            while (dr.Read())
            {
                result = dr[0].ToString();
            }

            objConnection.Close();

            return result;
        }

        public string InsertAppointment(string strQuery)
        {
            MDConnection connection = new MDConnection();

            NpgsqlConnection objConnection = new NpgsqlConnection(connection.connect());
            objConnection.Open();

            NpgsqlCommand appointmentInsert = new NpgsqlCommand(strQuery, objConnection);
            NpgsqlDataReader dr = appointmentInsert.ExecuteReader();

            string result = String.Empty;
            while (dr.Read())
            {
                result = dr[0].ToString();
            }

            objConnection.Close();

            return result;
        }

        public string DeleteAppointment(string strQuery)
        {
            MDConnection connection = new MDConnection();

            NpgsqlConnection objConnection = new NpgsqlConnection(connection.connect());
            objConnection.Open();

            NpgsqlCommand appointmentDelete = new NpgsqlCommand(strQuery, objConnection);
            NpgsqlDataReader dr = appointmentDelete.ExecuteReader();

            string result = String.Empty;
            while (dr.Read())
            {
                result = dr[0].ToString();
            }

            objConnection.Close();

            return result;
        }
    }
}
