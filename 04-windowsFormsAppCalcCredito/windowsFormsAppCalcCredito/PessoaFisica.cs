using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace windowsFormsAppCalcCredito
{
    internal class PessoaFisica:Pessoa
    {
        private string cpf;
        private int qtdFilhos;
        private double salario;

        public string Cpf { get { return cpf; } set { cpf = value; } }
        public int QtdFilhos { get { return qtdFilhos; } set { qtdFilhos = value; } }
        public double Salario { get { return salario; } set { salario = value; } }

        public PessoaFisica(string cpf, string nome, string cidade, int qtdFilhos, double salario):base(nome, cidade)
        {
            this.cpf = cpf;
            this.qtdFilhos = qtdFilhos;
            this.salario = salario;
        }

        public override double CalcCredito()
        {
            double credito;
            credito = salario * 12 - qtdFilhos * 10;
            return credito;

        }
    }
}
