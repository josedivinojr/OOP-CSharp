using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windowsFormsAppCalcCredito
{
    internal class PessoaJuridica:Pessoa
    {
        private string cnpj;
        private int qtdFuncionarios;
        private double faturamento;
        private string nomeFantasia;

        public string Cnpj { get { return cnpj; } set { cnpj = value; } }
        public int QtdFuncionarios { get { return qtdFuncionarios; } set { qtdFuncionarios = value; } }
        public double Faturamento { get { return faturamento; } set { faturamento = value; } }
        public string NomeFantasia { get { return nomeFantasia; } set { nomeFantasia = value; } }
        public PessoaJuridica(string cnpj, string nome, string nomeFantasia, string cidade, int qtdFuncionarios, double faturamento) : base(nome, cidade)
        {
            this.cnpj = cnpj;
            this.qtdFuncionarios = qtdFuncionarios;
            this.faturamento = faturamento;
            this.nomeFantasia = nomeFantasia;
        }

        public override double CalcCredito()
        {
            double credito = faturamento * 12 + qtdFuncionarios * 10;
            return credito;
        }
    }
}
