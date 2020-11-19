using System;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(867, 867000);

            Console.WriteLine(conta.Numero);
            Console.WriteLine(conta.Agencia);
            
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            ContaCorrente conta2 = new ContaCorrente(868, 867001);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
        }
    }
}
