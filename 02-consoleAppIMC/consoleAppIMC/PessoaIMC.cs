using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace consoleAppIMC
{
    internal class PessoaIMC
    {
        //Atributos
        public string nome;
        public double peso;
        public double altura;

        //Construtores
        public PessoaIMC(string nome, double peso, double altura)
        {
            this.nome = nome;
            this.peso = peso;
            this.altura = altura;
        }

        public PessoaIMC()
        {

        }

        public double getIMC()
        {
            return (peso / (altura * altura));
        }

        public void getInfo()
        {
            double imc = getIMC();
            string message = "";
            switch (imc)
            {
                case double i when (i < 18.5):
                    message = nome + " seu IMC é " + imc + " logo, caracteriza-se como: baixo peso.";
                    break;

                case double i when (i >= 18.5 && i < 25):
                    message = nome + " seu IMC é " + imc + " logo, caracteriza-se como: peso adequado.";
                    break;

                case double i when (i >= 25 && i < 30):
                    message = nome + " seu IMC é " + imc + " logo, caracteriza-se como: sobrepeso.";
                    break;

                case double i when (i >= 30 && i < 35):
                    message = nome + " seu IMC é " + imc + " logo, caracteriza-se como: obesidade de grau I.";
                    break;

                case double i when (i >= 35 && i < 40):
                    message = nome + " seu IMC é " + imc + " logo, caracteriza-se como: obesidade de grau II.";
                    break;

                case double i when (i >= 40):
                    message = nome + " seu IMC é " + imc + " logo, caracteriza-se como: obesidade de grau III.";
                    break;


            }

            Console.WriteLine(message);
        }
    }
}
