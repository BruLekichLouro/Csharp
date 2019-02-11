using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Comparadores;
using ByteBank.Modelos.Funcionarios;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    partial class Program
    {
        static void ListaGenericaExtensaoLinqLambda()
        {
            //Testando lista generica, extensao de metodos, sort(), orderby,
            //Where, IComprable e IComparer

            Lista<int> idades = new Lista<int>();
            idades.Adicionar(8);
            idades.AdicionarVarios(4, 9, 6);
            int idadeSoma = 0;
            // int idadeSoma2 = null; Tipos de valor n'ao aceitam referencia nula

            for (int i = 0; i < idades.Tamanho; i++)
            {
                // Console.WriteLine($"Item na posição {i} :{idades[i]} ");
            }

            var outrasIdades = new List<int>();
            ListExtensoes.AdicionarVarios(outrasIdades, 1, 5687, 1987, 1567, 987);
            //A list do .Net não possui este metodo AdicionarVarios, estamos extendenda da nossa classe Lista<T>

            outrasIdades.AdicionarVarios(1, 8, 12, 14, 22, 18);//metodo generico
            outrasIdades.Sort();

            outrasIdades.Remove(12);
            for (int i = 0; i < outrasIdades.Count; i++)
            {
                Console.WriteLine($"Item na posição {i} :{outrasIdades[i]} ");
            }

            var nomes = new List<string>();
            nomes.AdicionarVarios("Daniela", "Bruna", "Julia", "Ana");
            nomes.Sort();

            for (int i = 0; i < nomes.Count; i++)
            {
                Console.WriteLine(nomes[i]);
            }

            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(234, 8000),
                new ContaCorrente(234, 1),
                null,
                new ContaCorrente(456, 800),
                new ContaCorrente(588, 9930)
            };
            //contas.Sort();
            // contas.Sort(new ComparadorContaCorrentePorAgencia());


            var contasOrdenadas = contas
                .Where(conta => conta != null)
                .OrderBy<ContaCorrente, int>(conta => conta.Numero);

            foreach (var conta in contasOrdenadas)
            {

                Console.WriteLine($"Conta número {conta.Numero}, ag. {conta.Agencia}");

            }

        }

    }
}
