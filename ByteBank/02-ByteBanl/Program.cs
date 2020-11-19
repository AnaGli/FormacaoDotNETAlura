using System;

namespace _02_ByteBanl
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Gabriela";
            
            Console.WriteLine(conta.titular);
            Console.WriteLine(conta.agencia);
            Console.WriteLine(conta.saldo);

            //mesmo sem atribuir valores, os tipos double e int possuem valor padrao = zero
            //eu posso declarar um valor default na declaração das classes 
        }
    }
}
