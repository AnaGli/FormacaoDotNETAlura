using System;
using System.Collections.Generic;
using System.Text;


namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; protected set; }
        public double Salario { get; set; }

       public Funcionario(double salario, string cpf)
        {
            Salario = salario;
            CPF = cpf;

            TotalDeFuncionarios++;
        }
        

        public virtual void AumentarSalario()
        {
            Console.WriteLine("")        }
        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }



    }
}
