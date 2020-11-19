using System;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - Criando variáveis");
            // como declarar variavel: colocar o tipo primeiro
            int idade;
            idade = 26;
            Console.WriteLine(idade);

            idade = 10;
            Console.WriteLine(idade);

            idade = 10+5;
            Console.WriteLine(idade);

            idade = 10 + 5 * 2;
            Console.WriteLine(idade);

            idade = (10 + 5) * 2;
            Console.WriteLine("Sua idade é " + idade + "!"); //concatenar string com variável
        }
    }
}
