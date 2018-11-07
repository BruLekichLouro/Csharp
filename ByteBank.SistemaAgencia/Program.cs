using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
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

            Console.ReadLine();

        }
    }
}
