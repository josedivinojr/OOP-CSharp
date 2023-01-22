using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaFinalProject
{
    public partial class FormParts : Form
    {
        public FormParts()
        {
            InitializeComponent();
        }

        private void btnSelectParts_Click(object sender, EventArgs e)
        {
            if(!(cbParts.SelectedIndex == -1))
            {
                string strQuery = "SELECT * FROM parts WHERE asset_model = '" + cbParts.SelectedItem + "'";
                Parts objParts = new Parts();
                DataTable dataTable = objParts.getParts(strQuery);
                dataGridViewParts.DataSource = dataTable;
                dataGridViewParts.AutoResizeColumnHeadersHeight();
                
                MessageBox.Show("Consulta realizada com sucesso:", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }   
        }

        private void btnSelectAllParts_Click(object sender, EventArgs e)
        {

            MDConnection connection = new MDConnection();

            string strQuery = "SELECT * FROM parts";
            DataTable dataTable = connection.getPartsInformation(strQuery);

            dataGridViewParts.DataSource = dataTable;
            dataGridViewParts.AutoResizeColumnHeadersHeight();
            dataGridViewParts.AutoResizeRowHeadersWidth(2, DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);;

            MessageBox.Show("Consulta realizada com sucesso:", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbParts_MouseClick(object sender, MouseEventArgs e)
        {
            MDConnection conn = new MDConnection();
            string strConnection = conn.connect();
            NpgsqlConnection objConnection = new NpgsqlConnection(strConnection);
            objConnection.Open();

            string strQuery = "SELECT DISTINCT asset_model FROM asset ORDER BY asset_model";
            NpgsqlCommand costumerCnpjCommand = new NpgsqlCommand(strQuery, objConnection);
            NpgsqlDataReader dr = costumerCnpjCommand.ExecuteReader();

            List<string> queryResult = new List<string>();

            string costumerId = String.Empty;
            while (dr.Read())
            {
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    cbParts.Items.Add(dr[i].ToString());
                }
            }

            objConnection.Close();
        }
    }
}
