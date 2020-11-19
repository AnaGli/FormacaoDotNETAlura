using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    public class Diretor : Funcionario
    {
        public Diretor(double salario, string cpf) : base(5000, cpf)
        {

        }
        public override double AumentarSalario()
        {
            return Salario *= 1.15;
        }

        public override double GetBonificacao()
        {

            return Salario * 0.50;
        }
            
    }
}
