using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
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
            string time = mtbTime.Text + ":00";

            MessageBox.Show("data: " + data + "time: " + time, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
