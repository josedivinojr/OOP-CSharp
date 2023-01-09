using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windowsFormsAppCalcCredito
{
    public abstract class Pessoa
    {
        private string nome;
        private string cidade;

        public string Nome { get => nome; set => nome = value; }
        public string Cidade { get => cidade; set => cidade = value; }

        protected Pessoa (string nome, string cidade)
        {
            this.nome = nome;
            this.cidade = cidade;
        }
        public abstract double CalcCredito();
    }
}
