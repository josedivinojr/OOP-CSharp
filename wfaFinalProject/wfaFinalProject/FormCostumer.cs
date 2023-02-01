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
    public partial class FormCostumer : Form
    {
        public FormCostumer()
        {
            InitializeComponent();
        }

        private bool ValidateCostumerInfo()
        {
            bool validInfo = true;

            if (mtbCPFCNPJ.MaskCompleted == false)
            {
                ButtonMessage("CNPJ");
                validInfo = false;
            }

            return validInfo;
        }

        private bool ValidateNewCostumerInfo()
        {
            bool validInfo = true;

            if (mtbCPFCNPJNewCostumer.MaskCompleted == false)
            {
                ButtonMessage("CNPJ");
                validInfo = false;
            }

            if (mtbPhoneNewCostumer.MaskCompleted == false)
            {
                ButtonMessage("Telefone");
                validInfo = false;
            }

            //[todo] e-mail
            //[todo] telefone
            //[todo] rasao social
            //[todo] endereço

            return validInfo;
        }

        private void ButtonMessage(string labelName)
        {
            MessageBox.Show("Você deve preencher o campo: " + labelName + "!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSelectCostumer_Click(object sender, EventArgs e)
        {

            string cpfcnpj = mtbCPFCNPJ.Text.Replace(',', '.');

            if (ValidateCostumerInfo())
            {
                MDConnection connection = new MDConnection();
                string strQuery = "SELECT * FROM costumer WHERE costumer_cpfcnpj = '" + cpfcnpj + "'";

                DataTable dataTable = connection.getCostumerInformation(strQuery);

                dataGridViewCostumers.DataSource = dataTable;
                dataGridViewCostumers.AutoResizeColumnHeadersHeight();
                //dataGridViewCostumers.AutoResizeRowHeadersWidth(2, DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

            }

            MessageBox.Show("Consulta realizada com sucesso:", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClearCostumer_Click(object sender, EventArgs e)
        {
            mtbCPFCNPJ.Text = String.Empty;
        }

        private void btnSelectAllCostumers_Click(object sender, EventArgs e)
        {
            string strQuery = "SELECT * FROM costumer";
            MDConnection connection = new MDConnection();
            DataTable dataTable = connection.getCostumerInformation(strQuery);

            dataGridViewCostumers.DataSource = dataTable;
            dataGridViewCostumers.AutoResizeColumnHeadersHeight();
            dataGridViewCostumers.AutoResizeRowHeadersWidth(2, DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

        private void btnInsertNewCostumer_Click(object sender, EventArgs e)
        {
            string cpfcnpj = String.Empty;
            string strQuery = String.Empty;

            if (rbCNPJ.Checked && ValidateNewCostumerInfo())
            {
                cpfcnpj = mtbCPFCNPJNewCostumer.Text.Replace(',', '.');
                CNPJCostumer objCostumer = new CNPJCostumer(cpfcnpj, tbNomeRasaoSocialNewCostumer.Text, cbAddressNewCostumer.Text, tbEmailNewCostumer.Text, mtbPhoneNewCostumer.Text);
                strQuery = String.Format("INSERT INTO costumer (costumer_name, costumer_address, costumer_email, costumer_phone, costumer_cpfcnpj)" +
                                                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');",
                                                objCostumer.Name, objCostumer.Address, objCostumer.Email, objCostumer.Phone, objCostumer.Cnpj);

                string response = objCostumer.updateInformation(strQuery);
            }

            else if (rbCPF.Checked && ValidateNewCostumerInfo())
            {
                cpfcnpj = mtbCPFCNPJNewCostumer.Text.Replace(',', '.');
                CPFCostumer objCostumer = new CPFCostumer(cpfcnpj, tbNomeRasaoSocialNewCostumer.Text, cbAddressNewCostumer.Text, tbEmailNewCostumer.Text, mtbPhoneNewCostumer.Text);
                strQuery = String.Format("INSERT INTO costumer (costumer_name, costumer_address, costumer_email, costumer_phone, costumer_cpfcnpj)" +
                                                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');",
                                                objCostumer.Name, objCostumer.Address, objCostumer.Email, objCostumer.Phone, objCostumer.Cpf);

                string response = objCostumer.updateInformation(strQuery);
            }

            MessageBox.Show("Novo cliente cadastrado com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btUpdateCostumer_Click(object sender, EventArgs e)
        {
            string cpfcnpj = mtbCPFCNPJNewCostumer.Text.Replace(',', '.');

            if (rbCNPJ.Checked && ValidateNewCostumerInfo())
            {
                CNPJCostumer objCostumer = new CNPJCostumer(cpfcnpj, tbNomeRasaoSocialNewCostumer.Text, cbAddressNewCostumer.Text, tbEmailNewCostumer.Text, mtbPhoneNewCostumer.Text);

                string strQuery = "UPDATE costumer " +
                    "SET costumer_name = '" + objCostumer.Name + "', " +
                    "costumer_address = '" + objCostumer.Address + "', " +
                    "costumer_email = '" + objCostumer.Email + "', " +
                    "costumer_phone = '" + objCostumer.Phone + "' " +
                    "WHERE costumer_cpfcnpj = '" + objCostumer.Cnpj + "' ";

                string response = objCostumer.updateInformation(strQuery);
            }

            else if (rbCPF.Checked && ValidateNewCostumerInfo())
            {
                CPFCostumer objCostumer = new CPFCostumer(cpfcnpj, tbNomeRasaoSocialNewCostumer.Text, cbAddressNewCostumer.Text, tbEmailNewCostumer.Text, mtbPhoneNewCostumer.Text);

                string strQuery = "UPDATE costumer " +
                    "SET costumer_name = '" + objCostumer.Name + "', " +
                    "costumer_address = '" + objCostumer.Address + "', " +
                    "costumer_email = '" + objCostumer.Email + "', " +
                    "costumer_phone = '" + objCostumer.Phone + "' " +
                    "WHERE costumer_cpfcnpj = '" + objCostumer.Cpf + "' ";

                string response = objCostumer.updateInformation(strQuery);
            }
            MessageBox.Show("Dados atualizados com sucesso:", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClearNewCostumer_Click(object sender, EventArgs e)
        {
            mtbCPFCNPJNewCostumer.Text = String.Empty;
            tbNomeRasaoSocialNewCostumer.Text = String.Empty;
            tbEmailNewCostumer.Text = String.Empty;
            mtbPhoneNewCostumer.Text = String.Empty;
            cbAddressNewCostumer.Text = String.Empty;
        }

        private void deleteCostumer_Click(object sender, EventArgs e)
        {
            string cpfcnpj = mtbCPFCNPJNewCostumer.Text.Replace(',', '.');

            if (rbCNPJ.Checked)
            {
                CNPJCostumer objCostumer = new CNPJCostumer(cpfcnpj
                    , tbNomeRasaoSocialNewCostumer.Text, cbAddressNewCostumer.Text, tbEmailNewCostumer.Text, mtbPhoneNewCostumer.Text);

                if (ValidateNewCostumerInfo())
                {
                    string strQuery = String.Format("DELETE FROM costumer where costumer_cpfcnpj = '{0}'", objCostumer.Cnpj.Replace(',', '.'));

                    DataTable dataTable = new DataTable();
                    string response = objCostumer.updateInformation(strQuery);

                    MessageBox.Show("Cliente deletado com sucesso:", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else if (rbCPF.Checked)
            {
                CPFCostumer objCostumer = new CPFCostumer(cpfcnpj, tbNomeRasaoSocialNewCostumer.Text, cbAddressNewCostumer.Text, tbEmailNewCostumer.Text, mtbPhoneNewCostumer.Text);

                if (ValidateNewCostumerInfo())
                {
                    string strQuery = String.Format("DELETE FROM costumer where costumer_cpfcnpj = '{0}'", objCostumer.Cpf.Replace(',', '.'));

                    DataTable dataTable = new DataTable();
                    string response = objCostumer.updateInformation(strQuery);

                    MessageBox.Show("Cliente deletado com sucesso:", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }

        private void rbCNPJ_CheckedChanged(object sender, EventArgs e)
        {
            lbCPFCNPJ.Text = "CNPJ";
            lbNewCPFCNPJ.Text = "CNPJ";
            lbNewName.Text = "Razão Social";
            mtbCPFCNPJ.Mask = "00.000.000/0000-00";
            mtbCPFCNPJNewCostumer.Mask = "00.000.000/0000-00";
        }

        private void rbCPF_CheckedChanged(object sender, EventArgs e)
        {
            lbCPFCNPJ.Text = "CPF";
            lbNewCPFCNPJ.Text = "CPF";
            lbNewName.Text = "Nome";
            mtbCPFCNPJ.Mask = "000.000.000-00";
            mtbCPFCNPJNewCostumer.Mask = "000.000.000-00";
        }
    }
}
