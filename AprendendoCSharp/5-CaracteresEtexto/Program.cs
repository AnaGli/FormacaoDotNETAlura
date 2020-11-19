using System;

namespace _5_CaracteresEtexto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e textos");

            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura " + 2020;
            Console.WriteLine(titulo);

            string vazia = "";
            //para quebrar linha em string utilizar @
            string cursos =
@"-.NET
-JAVA
-PYTHON";
            Console.WriteLine(cursos);
        }
    }
}
