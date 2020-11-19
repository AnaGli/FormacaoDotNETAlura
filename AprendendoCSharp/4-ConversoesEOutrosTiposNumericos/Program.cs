using System;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");
            double salario = 1200.50;

            int salarioEmInteiro;
            salarioEmInteiro = (int)salario;

            Console.WriteLine(salarioEmInteiro);

            int idade = 1300000000; // tipo de dado int tem limite de tamanho de 32 bit
            Console.WriteLine(idade);

            long idade_Universo = 1300000000000000000;// tipo de dado long permite numeros grandes : 64 bit
            Console.WriteLine(idade_Universo);


            short quantidadeProduto = 15000; //tipo de dado  short permite valores menores, 16 bit
            Console.WriteLine(quantidadeProduto);

            float altura = 1.80f; // diferença para o double é a precisao de casas decimais
            Console.WriteLine(altura);

            double valor1 = 0.2;
            double valor2 = 0.2;
            double total = valor1 + valor2;
            Console.WriteLine(total);

            float pontoFlutuante = 3.14f;
            Console.WriteLine(pontoFlutuante);


        }
    }
}
