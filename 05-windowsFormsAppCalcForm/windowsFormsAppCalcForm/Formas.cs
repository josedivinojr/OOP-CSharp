using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windowsFormsAppCalcForm
{
    public abstract class Formas
    {
        protected string nome;
        public String Nome { get => nome; set => nome = value; }
        public Formas(string nome)
        {
            this.nome = nome;
        }

        public abstract double calcArea();
        public virtual double calcPerimetro()
        {
            return 0;
        }
    }
}
