using System;

namespace P13_ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exedcutando projeto 13!");

            // *
            // **
            // ***
            // ****


            //escrevendo asteriscos com o BREAK
           for(int contadorLinha = 0; contadorLinha <10; contadorLinha++)
            {
                for(int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
                {
                    Console.Write("*");
                    if (contadorColuna >= contadorLinha)
                        break;
                }
                Console.WriteLine();//dessa forma pula a linha

            }
           //uma forma diferente de fazer o desenho
            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
                {
                    Console.Write("*");              
                }
                Console.WriteLine();//dessa forma pula a linha

            }


            //imprimir tabuada
            for (int numero = 1; numero <= 10; numero++)
            {
               for(int contador = 1; contador <=10; contador++)
                {
                    Console.WriteLine("Tabuada do " + numero + ":" + numero * contador);
                }
                Console.WriteLine("---");
            }
            
            //imprimir os numeros multiplos de 3, entre 1 e 100
            for (int i = 1; i <=100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            //imprimir os fatoriais de 1 a 10
            int fatorial = 1;
            for (int n = 1; n < 11; n++)
            {
                fatorial *= n;
                Console.WriteLine("Fatorial de " + n + " = " + fatorial);
            }
        }

    }
}
