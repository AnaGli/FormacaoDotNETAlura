using System;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9 - Escopo");

            int idadeAna = 18;
            bool acompanhado = false;
            string msgAdicional;

            if (acompanhado == true)
            {
                msgAdicional = "João está acompanhado";
            }
            else
            {
                msgAdicional = "João não está acompanhado";
            }

            if(idadeAna >= 18 && acompanhado == true)
            {
                Console.WriteLine("Pode entrar!");
                Console.WriteLine(msgAdicional);
            }
            else
            {
                Console.WriteLine("Não pode entrar");
                Console.WriteLine(msgAdicional);
            }
        }
    }
}
