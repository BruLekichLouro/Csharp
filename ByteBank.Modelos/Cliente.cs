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
    }
}



