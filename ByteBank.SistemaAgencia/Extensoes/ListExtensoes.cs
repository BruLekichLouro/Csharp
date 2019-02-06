using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public static class ListExtensoes
    {
        public static void AdicionarVarios<T>(this List<T> listaDeInteiros, params T[] itens)
        {
            //o "THIS " mostra que o primeiro argumento é o tipo que queremos extender 
            foreach (T item in itens)
            {
                listaDeInteiros.Add(item);
            }
       
        }
    }
}
