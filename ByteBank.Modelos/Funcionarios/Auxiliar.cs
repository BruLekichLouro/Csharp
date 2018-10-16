using ByteBank.Modelos.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia.Funcionarios
{
    class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(4000, cpf)
        {

        }

        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }

        internal protected override double GetBonificacao()
        {
            return Salario * 0.2;
        }
    }
}
