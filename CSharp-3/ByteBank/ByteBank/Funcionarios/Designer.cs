using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    class Designer : Funcionario
    {
        public Designer(double salario, string cpf) : base(3000, cpf)
        {
        }

        public override double AumentarSalario()
        {
            return Salario *= 1.11;
        }

        public override double GetBonificacao()
        {

            return Salario * 0.17;
        }
    }
}
