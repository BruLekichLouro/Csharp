using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public class Cliente
    {
        public string Nome { get; set; }
        private string _cpf;
        public string Profissao { get; set; }

        public string CPF
        {
            get
            {
                return _cpf;
            }
            set
            {
                // Escrevo a lógica de validação de CPF
                _cpf = value;
            }
        }

        //Testando méodo Equals
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            // Cliente outroCliente = (Cliente)obj;
            Cliente outroCliente = obj as Cliente;

            if (outroCliente == null)
            {
                return false;
            }


            return
                    CPF == outroCliente.CPF;
      
        }
    }
}



