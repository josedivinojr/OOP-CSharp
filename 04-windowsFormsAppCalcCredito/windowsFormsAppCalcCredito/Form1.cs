using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace windowsFormsAppCalcCredito
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbNomeFantasia.Visible = false;
            txtNomeFantasia.Visible = false;

            gerarGradeListViewPF();
            gerarGradeListViewPJ();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rbPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            mtbCpfCnpj.Mask = "000,000,000-00";    //Atualiza a mascara para CPF

            //Atualizando os labels para a pessoa fisica
            lbCpfCnpj.Text = "CPF";
            lbQtdFilhosFuncionarios.Text = "Qtd Filhos";
            lbSalarioFaturamento.Text = "Salário";

            //Ocultando os labels e textBox da pessoa juridica
            lbNomeFantasia.Visible = false;
            txtNomeFantasia.Visible = false;

        }

        private void rbPessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            mtbCpfCnpj.Mask = "00,000,000/0000-00";    //Atualiza a mascara para CNPJ

            //Atualizando os labels para a pessoa juridica
            lbCpfCnpj.Text = "CNPJ";
            lbQtdFilhosFuncionarios.Text = "Qtd Funcionarios";
            lbSalarioFaturamento.Text = "Faturamento";

            //Ocultando os labels e textBox da pessoa juridica
            lbNomeFantasia.Visible = true;
            txtNomeFantasia.Visible = true;

        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            //Verifica se o rbPessoaFisica está marcado
            bool recebeValidacao = validaInformacao();
            if (rbPessoaFisica.Checked && validaInformacao() == true)
            {
                //Instanciando objeto
                PessoaFisica pessoaFisica = new PessoaFisica(mtbCpfCnpj.Text, txtNome.Text, txtCidade.Text, Convert.ToInt32(txtQtdFilhosFuncionarios.Text), Convert.ToDouble(txtSalarioFaturamento.Text));

                string[] clientePf = new string[6]; //Cria um vetor de String com 6 posições
                //Insere um atributo por objeto instanciado em uma posição determinada no vetor
                //Utilizamos o vetor pela comodidade ao trabalhar com o listview
                //Passaremos o CPF, NOME, CIDADE, FILHOS, SALARIO e CREDITO para o listview
                clientePf[0] = pessoaFisica.Cpf;
                clientePf[1] = pessoaFisica.Nome;
                clientePf[2] = pessoaFisica.Cidade;
                clientePf[3] = Convert.ToString(pessoaFisica.QtdFilhos);
                clientePf[4] = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", pessoaFisica.Salario);
                clientePf[5] = string.Format(CultureInfo.GetCultureInfo("pt-Br"), "{0:C}", pessoaFisica.CalcCredito());

                //Adicionando uma nova linha ao listview
                lvPessoaFisica.Items.Add(new ListViewItem(clientePf));

                //Criando mensagem ao realizar o cadastro
                MensagemBotao();
                limparCampos();
                //MessageBox.Show("Dados Cadastrados com Sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //Verifica se o rbPessoaJuridica está marcado
            else if (rbPessoaJuridica.Checked && validaInformacao() == true)
            {
                //Verifica se o rbPessoaFisica está marcado
                
                //Instanciando objeto
                PessoaJuridica pessoaJuridica = new PessoaJuridica(mtbCpfCnpj.Text, txtNome.Text, txtNomeFantasia.Text ,txtCidade.Text, Convert.ToInt32(txtQtdFilhosFuncionarios.Text), Convert.ToDouble(txtSalarioFaturamento.Text));

                //Cria um vetor de String com 6 posições
                //Insere um atributo por objeto instanciado em uma posição determinada no vetor
                //Utilizamos o vetor pela comodidade ao trabalhar com o listview
                //Passaremos o CPF, NOME, CIDADE, FILHOS, SALARIO e CREDITO para o listview
                string[] clientePj = new string[7];

                clientePj[0] = pessoaJuridica.Cnpj;
                clientePj[1] = pessoaJuridica.Nome;
                clientePj[2] = pessoaJuridica.NomeFantasia;
                clientePj[3] = pessoaJuridica.Cidade;
                clientePj[4] = Convert.ToString(pessoaJuridica.QtdFuncionarios);
                clientePj[5] = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", pessoaJuridica.Faturamento);
                clientePj[6] = string.Format(CultureInfo.GetCultureInfo("pt-Br"), "{0:C}", pessoaJuridica.CalcCredito());

                //Adicionando uma nova linha ao listview
                lvPessoaJuridica.Items.Add(new ListViewItem(clientePj));

                //Criando mensagem ao realizar o cadastro
                MensagemBotao();
                limparCampos();
                //MessageBox.Show("Dados Cadastrados com Sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void gerarGradeListViewPJ() //Gera as grades do list view da Pessoa Juridica
        {
            lvPessoaJuridica.Columns.Add("CNPJ", 150).TextAlign = HorizontalAlignment.Center;
            lvPessoaJuridica.Columns.Add("Nome", 150).TextAlign = HorizontalAlignment.Center;
            lvPessoaJuridica.Columns.Add("Nome Fantasia", 150).TextAlign = HorizontalAlignment.Center;
            lvPessoaJuridica.Columns.Add("Cidade", 150).TextAlign = HorizontalAlignment.Center;
            lvPessoaJuridica.Columns.Add("Qtd Funcionarios", 80).TextAlign = HorizontalAlignment.Center;
            lvPessoaJuridica.Columns.Add("Faturamento", 150).TextAlign = HorizontalAlignment.Center;
            lvPessoaJuridica.Columns.Add("Credito", 150).TextAlign = HorizontalAlignment.Center;

            lvPessoaJuridica.View = View.Details;
        }


        public void gerarGradeListViewPF() //Gera as grades do list view da Pessoa Juridica
        {
            lvPessoaFisica.Columns.Add("CPF", 150).TextAlign = HorizontalAlignment.Center;
            lvPessoaFisica.Columns.Add("Nome", 150).TextAlign = HorizontalAlignment.Center;
            lvPessoaFisica.Columns.Add("Cidade", 150).TextAlign = HorizontalAlignment.Center;
            lvPessoaFisica.Columns.Add("Qtd Filhos", 80).TextAlign = HorizontalAlignment.Center;
            lvPessoaFisica.Columns.Add("Salario", 150).TextAlign = HorizontalAlignment.Center;
            lvPessoaFisica.Columns.Add("Credito", 150).TextAlign = HorizontalAlignment.Center;

            lvPessoaFisica.View = View.Details;
        }

        public void limparCampos()
        {
            txtCidade.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtNomeFantasia.Text = string.Empty;
            mtbCpfCnpj.Text = string.Empty;
            txtQtdFilhosFuncionarios.Text = string.Empty;
            txtSalarioFaturamento.Text = string.Empty;
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void TxtQtdFilhosFuncionarios_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 202)
            {
                e.Handled = true;
            }
            //throw new System.NotImplementedException();
        }

        private void TxtSalarioFaturamento_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 44 && e.KeyChar != 8 && e.KeyChar != 202)
            {
                e.Handled = true;
            }
            //throw new System.NotImplementedException();
        }

        private void MensagemBotao()
        {
            MessageBox.Show("Dados cadastrados com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensagemBotao(string nomeLabel)
        {
            MessageBox.Show("Você deve informar o " + nomeLabel, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public bool validaInformacao()
        {
            bool validaInfo = true;

            if(mtbCpfCnpj.MaskCompleted == false)
            {
                MensagemBotao(lbCpfCnpj.Text);
                validaInfo = false;
            }
            else if (txtNome.Text.Trim() == string.Empty)
            {
                MensagemBotao(lbNome.Text);
                validaInfo = false;
            }
            else if (txtCidade.Text.Trim() == string.Empty)
            {
                MensagemBotao(lbCidade.Text);
                validaInfo = false;
            }
            else if (txtQtdFilhosFuncionarios.Text.Trim() == string.Empty)
            {
                MensagemBotao(lbQtdFilhosFuncionarios.Text);
                validaInfo = false;
            }
            else if (txtSalarioFaturamento.Text.Trim() == string.Empty)
            {
                MensagemBotao(lbSalarioFaturamento.Text);
                validaInfo = false;
            }
            if (rbPessoaJuridica.Checked == true && validaInfo != false)
            {
                if (txtNomeFantasia.Text.Trim() == string.Empty)
                {
                    MensagemBotao(lbNomeFantasia.Text);
                    validaInfo = false;
                }
                
            }
            return validaInfo;
        }
    }
}
