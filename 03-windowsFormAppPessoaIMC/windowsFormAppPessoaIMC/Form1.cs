using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsFormAppPessoaIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            //Instanciando um novo objeto Pessoa com os atributos extraídos dos 'Text Box' do forms
            Pessoa objPessoa = new Pessoa(txtNome.Text, Convert.ToDouble(txtPeso.Text), Convert.ToDouble(txtAltura.Text));

            //Criando uma mensagem que será apresentada através de um Message Box
            MessageBox.Show(objPessoa.statusIMC(), "Cálculo IMC",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Text = "";
            txtNome.Text = "";
            txtPeso.Text = "";
        }
    }
}
