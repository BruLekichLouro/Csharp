using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
    class ContaDAOEntity : IContaDAO, IDisposable
    {
        //classe DAO que faz os acessos ao banco de dados
        private BancoContext contexto;

        public ContaDAOEntity()
        {
            this.contexto = new BancoContext();
        }

        public void Adicionar(ContaCorrente c)
        {
            contexto.Contas.Add(c);
            contexto.SaveChanges();
        }

        public void Atualizar(ContaCorrente c)
        {
            contexto.Contas.Update(c);
            contexto.SaveChanges();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }

        public IList<ContaCorrente> Contas()
        {
            return contexto.Contas.ToList();
        }

        public void Remover(ContaCorrente c)
        {
            contexto.Contas.Remove(c);
            contexto.SaveChanges();
        }
    }
}
