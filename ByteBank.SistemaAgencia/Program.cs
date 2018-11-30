using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank.SistemaAgencia.Comparadores;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var outrasIdades = new List<int>();
            outrasIdades.Add(2);
            ListExtensoes.AdicionarVarios(outrasIdades, 1, 5687, 1987, 1567, 987);
            outrasIdades.AdicionarVarios(1, 8, 12, 14, 22, 18);
            outrasIdades.Remove(12);
            outrasIdades.Sort();

            for (int i = 0; i < outrasIdades.Count; i++)
            {
                Console.WriteLine($"Item na posição {i} :{outrasIdades[i]} ");
            }

            var nomesClientes = new List<string>();
            nomesClientes.AdicionarVarios("Julia","Ana","Bruna" , "Daniela");
            nomesClientes.Sort();

            for (int i = 0; i < nomesClientes.Count; i++)
            {
                Console.WriteLine(nomesClientes[i]);
            }

            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(456, 800),
                null,
                new ContaCorrente(234, 8000),
                new ContaCorrente(234, 1),
                new ContaCorrente(588, 9930)
            };
            //contas.Sort(new ComparadorContaCorrentePorAgencia());

            var contasOrdenadas = contas
                .Where(conta => conta != null)
                .OrderBy<ContaCorrente, int>(conta => conta.Numero);

            foreach (var conta in contasOrdenadas)
            {

                Console.WriteLine($"Conta número {conta.Numero}, ag. {conta.Agencia}");

            }

            Console.ReadLine();
        }
        static void OutrosTestes()
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();
            ContaCorrente contaDaBru = new ContaCorrente(1111, 1111111);

            lista.AdicionarVarios(contaDaBru,
              new ContaCorrente(874, 5679787),
              new ContaCorrente(874, 5679754),
              new ContaCorrente(874, 5679745),
              new ContaCorrente(874, 5679754),
              new ContaCorrente(874, 5679745),
              new ContaCorrente(874, 5679754),
              new ContaCorrente(874, 5679745),
              new ContaCorrente(874, 5679754),
              new ContaCorrente(874, 5679745));

            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Numero}/{itemAtual.Agencia}");
            }

            lista.Remover(contaDaBru);
            Lista<string> clientes = new Lista<string>();

            clientes.AdicionarVarios("Bruna", "Guilherme", "Romulo", "Denise");
            for (int i = 0; i < clientes.Tamanho; i++)
            {
                Console.WriteLine($"Cliente na posição {i} :{clientes[i]} ");
            }

        }

    }
}
