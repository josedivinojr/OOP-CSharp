using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windowsFormsAppCalcForm
{
    
    class Retangulo:Formas
    {
        private double baseRetangulo;
        private double alturaRetangulo;
        public double BaseRetangulo { get { return baseRetangulo; } set { baseRetangulo = value; } }
        public double AlturaRetangulo { get { return alturaRetangulo; } set { alturaRetangulo = value; } }

        public Retangulo(string nome, double baseRetangulo, double alturaRetangulo) : base(nome)
        {
            this.baseRetangulo = baseRetangulo;
            this.alturaRetangulo = alturaRetangulo;
        }

        public override double calcArea()
        {
            double area = baseRetangulo * alturaRetangulo;
            area = Math.Round(area, 2);
            return area;
        }

        public override double calcPerimetro()
        {
            double perimetro = (baseRetangulo + alturaRetangulo) * 2;
            perimetro = Math.Round(perimetro, 2);
            return perimetro;
        }
    }
}
