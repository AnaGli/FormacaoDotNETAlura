using System;

namespace _3_CriandoVariaveisPontoFlutuantes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 Criando variáveis ponto flutuante");

            double salario = 1200.70; //tipo double aceita numeros decimais
            Console.WriteLine(salario);

            Console.WriteLine("Meu salário é " + salario);

            double idade = 15/2; // divisao de numeros inteiros ´resultado é inteiro (perde a casa decimal)
            Console.WriteLine(idade);

            idade = 15.0 / 2.0; //(é necessário atriuir a casa decimal para o resultado ser 7,5)
            Console.WriteLine(idade);//-- só precisa colocao o tipo da variável na primeira declaração, alterar o valor da variável não precisa 




        }
    }
}
