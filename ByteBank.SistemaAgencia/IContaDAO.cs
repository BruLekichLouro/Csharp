using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    interface IContaDAO
    {
        void Adicionar(ContaCorrente c);
        void Atualizar(ContaCorrente c);
        void Remover(ContaCorrente c);
        IList<ContaCorrente> Contas();
    }
}
