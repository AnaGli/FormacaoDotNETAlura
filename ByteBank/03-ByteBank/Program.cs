using System;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;

            Console.WriteLine(contaDaGabrielaCosta == contaDaGabriela);
            // apesar dos valores serem iguais, o resultado é false. 
            //Para classes não armazenamos valores, e sim referências que são diferentes entre si

            int idade = 26;
            int idade2 = 26;
            Console.WriteLine(idade == idade2);
            //variaveis armazenam valores, resultado = true

            contaDaGabriela = contaDaGabrielaCosta;
            Console.WriteLine(contaDaGabrielaCosta == contaDaGabriela);
            //eu posso atribuir um endereço de um objeto para outro, assim o comparativo se torna true

            contaDaGabriela.saldo = 300;
            Console.WriteLine(contaDaGabriela.saldo);
            Console.WriteLine(contaDaGabrielaCosta.saldo);
            // após atribuir a referência, mudando o valore de um dos objetetos, os dois são alterados, pois os dois apontam para mesma referência

           
        }
    }
}
