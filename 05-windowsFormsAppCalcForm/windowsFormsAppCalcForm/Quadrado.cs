using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windowsFormsAppCalcForm
{
    class Quadrado:Formas
    {
        private double lado;
        public double Lado { get { return lado; } set { lado = value; } }
        public Quadrado(string nome, double lado):base(nome)
        {
            this.lado = lado;
        }

        public override double calcArea()
        {
            double area =  lado * lado;
            area = Math.Round(area, 2);
            return area;
        }

        public override double calcPerimetro()
        {
            double perimetro = lado * 4;
            perimetro = Math.Round(perimetro, 2);
            return perimetro;
        }
    }
}
