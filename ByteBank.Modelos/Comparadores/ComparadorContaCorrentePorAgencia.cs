using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Comparadores
{
    public class ComparadorContaCorrentePorAgencia : IComparer<ContaCorrente>
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public int Compare(ContaCorrente x, ContaCorrente y)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            //metodo segue a mesma lógica do método ICOmparable, mas aqui
            //estamos comparando duas contas e não a instância;
            //x tiver precedência em y, o retorno será negativo;
            //x e y forem equivalentes, o retorno será 0;
            //y tiver precedência maior que x, o retorno será positivo.

            if (x == y)
            {
                return 0;
            }
            if (x == null)
            {
                return 1;
            }

            if (y == null)
            {
                return -1;
            }
            //Se reparmos, a comparação abaixo é feita pelo Sort() entre números inteiros,
            //Sabemos que o número inteiro implementa a interface IComparable, 
            //então utilizaremos CompareTo() do tipo inteiro. Considerando que 
            //Agencia é um tipo inteiro, podemos substituir o trecho abaixo por:
             return x.Agencia.CompareTo(y.Agencia);

            //Ou seja,esta é a mesma lógica que a equipe da Microsoft já implementou 
            // em CompareTo(), do tipo inteiro.
            //if (x.Agencia < y.Agencia)
            //{
            //    return -1;
            //}
            //
            //if (x.Agencia == y.Agencia)
            //{
            //    return 0;
            //}
            //
            //return 1;

        }
    }
}
