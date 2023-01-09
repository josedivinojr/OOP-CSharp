using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windowsFormsAppCalcForm
{
    class Triangulo : Formas
    {
        private double baseTriangulo;
        private double alturaTriangulo;

        public double BaseTriangulo { get { return baseTriangulo; } set { baseTriangulo = value; } }
        public double AlturaTriangulo { get { return alturaTriangulo;  } set { alturaTriangulo = value; } }
        public Triangulo(string nome, double baseTriangulo, double alturaTriangulo) : base(nome)
        {
            this.baseTriangulo = baseTriangulo;
            this.alturaTriangulo = alturaTriangulo;
        }

        public override double calcArea()
        {
            double area = (baseTriangulo * alturaTriangulo)/2;
            area = Math.Round(area, 2);
            return area;
        }

        public override double calcPerimetro()
        {
            double ladoTriangulo = Math.Sqrt(Math.Pow((baseTriangulo / 2), 2) + Math.Pow(alturaTriangulo, 2));
            double perimetro = baseTriangulo + (ladoTriangulo * 2);
            perimetro = Math.Round(perimetro, 2);
            return perimetro;
        }
    }
}