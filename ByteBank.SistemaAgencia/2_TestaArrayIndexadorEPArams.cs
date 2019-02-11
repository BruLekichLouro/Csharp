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
        static void TestaArrayIndexadorEPArams()
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();
            ContaCorrente contaDaBru = new ContaCorrente(1111, 1111111);
            lista.Adicionar(contaDaBru);

            lista.Remover(contaDaBru);
            // Console.WriteLine("Apos remover conta da Bru");

            //lista.MeuMetodo(); //Metodo com argumentos opcionais
            //lista.MeuMetodo(numero: 10);

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


            ContaCorrente itemTeste = lista[5];
            Console.WriteLine($"Intem na posicão 5 = Conta {itemTeste.Numero}/{itemTeste.Agencia}");

            for (int i = 0; i < lista.Tamanho; i++)
            {
                //ContaCorrente teste = lista["texto"];
                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Numero}/{itemAtual.Agencia}");
            }

            Console.WriteLine(SomarVarios(24, 89, 1));
            Console.WriteLine(SomarVarios(1, 2, 3));

            Console.ReadLine();
        }
        private static int SomarVarios(params int[] numeros)
        {
            int acumulador = 0;
            foreach (int numero in numeros)
            {
                acumulador += numero;
            }
            return acumulador;
        }
    }
}

