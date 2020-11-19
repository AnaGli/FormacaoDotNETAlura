using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    class Auxiliar : Funcionario
    {
        public Auxiliar(double salario, string cpf) : base(2000, cpf)
        {

        }

        public override double AumentarSalario()
        {
            return Salario *= 1.10;
        }

        public override double GetBonificacao()
        {

            return Salario * 0.20;
        }
    }
}
