using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsFormAppPessoaIMC
{
    internal class Pessoa
    {
        //Atributos
        private string nome;
        private double peso;
        private double altura;

        //Método Construtor
        public Pessoa(string nome, double peso, double altura)
        {
            this.nome = nome;
            this.peso = peso;
            this.altura = altura;
        }

        public string Nome { get { return nome; } set { nome = value; } }
        public double Peso { get { return peso; } set { peso = value; } }
        public double Altura { get { return altura; } set { altura = value; } }

        public double calcIMC()
        {
            return (peso / (altura * altura));
        }

        public string statusIMC()
        {
            string message = "";

            switch (calcIMC())
            {
                case double i when (i < 18.5):
                    message = nome + " seu IMC é " + calcIMC() + " logo, caracteriza-se como: baixo peso.";
                    break;

                case double i when (i >= 18.5 && i < 25):
                    message = nome + " seu IMC é " + calcIMC() + " logo, caracteriza-se como: peso adequado.";
                    break;

                case double i when (i >= 25 && i < 30):
                    message = nome + " seu IMC é " + calcIMC() + " logo, caracteriza-se como: sobrepeso.";
                    break;

                case double i when (i >= 30 && i < 35):
                    message = nome + " seu IMC é " + calcIMC() + " logo, caracteriza-se como: obesidade de grau I.";
                    break;

                case double i when (i >= 35 && i < 40):
                    message = nome + " seu IMC é " + calcIMC() + " logo, caracteriza-se como: obesidade de grau II.";
                    break;

                case double i when (i >= 40):
                    message = nome + " seu IMC é " + calcIMC() + " logo, caracteriza-se como: obesidade de grau III.";
                    break;

            }
            return message;
        }
    }
}
