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
    public partial class FormAsset : Form
    {
        public FormAsset()
        {
            InitializeComponent();
        }



        private bool ValidateAssetInfo()
        {
            bool validInfo = true;

            if (mtbAssetSerial.MaskCompleted == false)
            {
                ButtonMessage("Nº de Sperue");
                validInfo = false;
            }

            return validInfo;
        }

        private bool ValidateNewAssetInfo()
        {
            bool validInfo = true;

            if (mtbNewAssetSerial.MaskCompleted == false)
            {
                ButtonMessage("Nº de Série");
                validInfo = false;
            }

            if (mtbNewAssetCPFCNPJ.MaskCompleted == false)
            {
                ButtonMessage("CNPJ");
                validInfo = false;
            }

            if (tbNewAssetModel.Text == String.Empty)
            {
                ButtonMessage("Modelo");
                validInfo = false;
            }

            return validInfo;
        }



        private void ButtonMessage(string labelName)
        {
            MessageBox.Show("Você deve preencher o campo: " + labelName + "!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSelectAsset_Click(object sender, EventArgs e)
        {
            string serialNumber = mtbAssetSerial.Text;

            if (ValidateAssetInfo())
            {

                DataTable dataTable = new DataTable();

                string strQuery = "SELECT * FROM asset WHERE asset_serial = '" + serialNumber + "'";

                dataGridViewAssets.DataSource = dataTable;

                MessageBox.Show("Consulta realizada com sucesso:", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClearAsset_Click(object sender, EventArgs e)
        {
            mtbAssetSerial.Text = String.Empty;
        }

        private void btUpdateAsset_Click(object sender, EventArgs e)
        {
            string cpfcnpj = mtbNewAssetCPFCNPJ.Text.Replace(',', '.');
            if (ValidateNewAssetInfo())
            {
                Asset objAsset = new Asset(cpfcnpj, tbNewAssetModel.Text, mtbNewAssetSerial.Text);

                string strQuery = "UPDATE asset " +
                    "SET asset_serial = '" + objAsset.SerialNumber + "', " +
                    "asset_model = '" + objAsset.Model + "', " +
                    "costumer_cnpj = '" + objAsset.CostumerCPFCNPJ + "'";

                DataTable dataTable = new DataTable();
                string response = objAsset.updateInformation(strQuery);

                MessageBox.Show("Dados atualizados com sucesso:", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnInsertNewAsset_Click(object sender, EventArgs e)
        {
            if (ValidateNewAssetInfo())
            {
                string cnpj = mtbNewAssetCPFCNPJ.Text.Replace(',', '.');
                Asset objAsset = new Asset(cnpj, tbNewAssetModel.Text, mtbNewAssetSerial.Text);

                string strQuery = String.Format("INSERT INTO asset (asset_serial, asset_model, costumer_cnpj" +
                                                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');",
                                                objAsset.SerialNumber, objAsset.Model, objAsset.CostumerCPFCNPJ);
                DataTable dataTable = new DataTable();
                string response = objAsset.updateInformation(strQuery);

                MessageBox.Show("Novo cliente cadastrado com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rbCNPJ_CheckedChanged(object sender, EventArgs e)
        {
            mtbNewAssetCPFCNPJ.Mask = "00.000.000/0000-00";
            lbCPFCNPJ.Text = "CNPJ do Cliente";
        }

        private void rbCPF_CheckedChanged(object sender, EventArgs e)
        {
            mtbNewAssetCPFCNPJ.Mask = "000.000.000-00";
            lbCPFCNPJ.Text = "CPF do Cliente";
        }
    }
}
