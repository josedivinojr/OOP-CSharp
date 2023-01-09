using mediaaluno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace aula02media
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primeiro obj Aluno - Construtor Completo");
            Aluno objAluno1 = new Aluno();
            objAluno1.nome = "Maria";
            objAluno1.disciplina = "Matemática";
            objAluno1.nota1 = 7.0;
            objAluno1.nota2 = 9.0;

            objAluno1.getStatus();

            Console.WriteLine("\n\n");
            Console.WriteLine("Segundo obj Aluno - Construtor Vazio");
            Aluno objAluno2 = new Aluno("José Divno", "POO", 9.8, 9.9);
            objAluno2.getStatus();

            Console.WriteLine("\n\n");
            Console.WriteLine("Terceiro obj Aluno - Atributos via teclado");
            Aluno objAluno3 = new Aluno();
            Console.Write("Digite o nome do aluno: ");
            objAluno3.nome = Console.ReadLine();
            Console.Write("Digite o nome da disciplina: ");
            objAluno3.disciplina = Console.ReadLine();
            Console.Write("Digite a primeira nota: ");
            objAluno3.nota1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a segunda nota: ");
            objAluno3.nota2 = Convert.ToDouble(Console.ReadLine());

            objAluno3.getStatus();

            Console.ReadKey();

        }
    }
}