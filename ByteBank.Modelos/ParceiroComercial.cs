using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    class ParceiroComercial : IAutenticavel
    {
        private AutenticacacoHelper _autenticacaoHelper = new AutenticacacoHelper(); 
        public string Senha { get; set; }

        public bool Autenticar(string senha)
        {
            return _autenticacaoHelper.CompararSenhas(senha, senha);
        }

    }
}
