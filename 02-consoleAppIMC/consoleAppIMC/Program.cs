using consoleAppIMC;

PessoaIMC objPessoa = new PessoaIMC();
Console.WriteLine("Digite seu nome: ");
objPessoa.nome = Console.ReadLine();
Console.WriteLine("Digite seu peso: ");
objPessoa.peso = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite sua altura: ");
objPessoa.altura = Convert.ToDouble(Console.ReadLine());

objPessoa.getInfo();
Console.ReadKey();