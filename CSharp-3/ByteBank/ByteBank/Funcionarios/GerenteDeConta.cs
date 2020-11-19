using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    class GerenteDeConta : Funcionario
    {
        public GerenteDeConta(double salario, string cpf) : base(4000, cpf)
        {
        }
        public override double AumentarSalario()
        {
            return Salario *= 1.05;
        }

        public override double GetBonificacao()
        {

            return Salario * 0.25;
        }
    }
}
