using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediaaluno //namespace nome do projeto
{
    internal class Aluno {
        public string nome;
        public string disciplina;
        public double nota1;
        public double nota2;

        //no construtor declaramos apenas métodos e atributos
        //o construtor não possui um tipo (void, int)
        public Aluno (string nome, string disciplina, double nota1, double nota2) {
            this.nome = nome;
            this.disciplina = disciplina;
            this.nota1 = nota1;
            this.nota2 = nota2;
        }

        public Aluno() //construtor vazio
        {
            //no construtor vazio é necessário atribuir cada atributo individualmente no código
        }

        private double getMedia()
        {
            double media;
            media = (nota1 + nota2) / 2;
            return media;

        }
        private string getSituacao()
        {
            string sitAluno;
            double media = getMedia();
            if (media >= 7)
            {
                sitAluno = "APROVADO(A)";
            }
            else if (media <= 6)
            {
                sitAluno = "REPROVADO(A)";
            }
            else
            {
                sitAluno = "RECUPERAÇÃO";
            }

            return sitAluno;
        }

        public void getStatus()
        {
            Console.WriteLine(nome + " sua nota média em " + disciplina + " é " + getMedia() + ", portanto você está " + getSituacao());
        }

    }
}
