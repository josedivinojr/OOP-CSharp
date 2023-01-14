using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace wfaFinalProject
{
    public partial class FormAppointment : Form
    {
        public FormAppointment()
        {
            InitializeComponent();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            string data = dateTimePicker.Value.ToString("yyyy-MM-dd");

        }

        private void btnSelectAppointment_Click(object sender, EventArgs e)
        {
            string data = dateTimePicker.Value.ToString("yyyy-MM-dd");
            string time = "00:00:00";

            string strQuery = String.Format("SELECT appointment_date, appointment_time, asset_serial FROM appointment " +
                "                            WHERE appointment_date = '{0}'", data);

            Appointment appointment = new Appointment(data, time);
            DataTable dataTable = appointment.SelectAppointment(strQuery);

            dataGridViewAppointment.DataSource = dataTable;
            dataGridViewAppointment.AutoResizeColumnHeadersHeight();

            MessageBox.Show("Consulta realizada com sucesso:", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSelectAllAppointments_Click(object sender, EventArgs e)
        {           

            string strQuery = String.Format("SELECT appointment_date, appointment_time, asset_serial FROM appointment ORDER BY appointment_date");

            MDConnection conn = new MDConnection();
            DataTable dataTable = conn.getAppointmentsInformation(strQuery);

            dataGridViewAppointment.DataSource = dataTable;
            dataGridViewAppointment.AutoResizeColumnHeadersHeight();

            MessageBox.Show("Consulta realizada com sucesso:", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnInsertAppointment_Click(object sender, EventArgs e)
        {
            string data = dateTimePickerAppointment.Value.ToString("yyyy-MM-dd");
            string time = mtbNewAppointmentTime.Text + ":00";
            string serialNumber = tbAssetSerialAppointment.Text;

            Appointment appointment = new Appointment(data, time);

            string strQuery = String.Format("INSERT INTO appointment (appointment_date, appointment_time, asset_serial) " +
                                            "VALUES('{0}', '{1}', '{2}')", appointment.Date, appointment.Time, serialNumber);

            string result = appointment.InsertAppointment(strQuery);

            MessageBox.Show("Consulta realizada com sucesso:", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdateAppointment_Click(object sender, EventArgs e)
        {
            string data = dateTimePickerAppointment.Value.ToString("yyyy-MM-dd");
            string time = mtbNewAppointmentTime.Text + ":00";
            string serialNumber = tbAssetSerialAppointment.Text;

            Appointment appointment = new Appointment(data, time);
            string strQuery = String.Format("UPDATE appointment " +
                                            "SET appointment_date = '{0}', " +
                                                "appointment_time = '{1}', " +
                                                "asset_serial = '{2}' " +
                                            "WHERE " +
                                                "asset_serial = '{2}' ", appointment.Date, appointment.Time, serialNumber);

            string result = appointment.UpdateAppointment(strQuery);
        }

        private void btnDeleteAppointment_Click(object sender, EventArgs e)
        {
            string data = dateTimePickerAppointment.Value.ToString("yyyy-MM-dd");
            string time = mtbNewAppointmentTime.Text + ":00";
            string serialNumber = tbAssetSerialAppointment.Text;

            Appointment appointment = new Appointment(data, time);
            string strQuery = String.Format("DELETE FROM appointment " +
                                     "WHERE appointment_date = '{0}' " +
                                     "AND asset_serial = '{1}'", appointment.Date, serialNumber);

            string result = appointment.DeleteAppointment(strQuery);
        }
    }
}
