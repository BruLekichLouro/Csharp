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
        static void CriarArquivo()
        {
            var caminhoNovoArquivo = "contasExportadas.CSV";

            using(var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {
                var contaComoSting = "456,7895,4785.40, Gustavo Santos";
                var encoding = Encoding.UTF8;
                var bytes = encoding.GetBytes(contaComoSting);
                fluxoDeArquivo.Write(bytes, 0, bytes.Length);
            }
        }
       static void CriarArquivoComWriter()
        {
            var caminhoNovoArquivo = "contasExportadas.CSV";

            using(var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            using(var escritor = new StreamWriter(fluxoDeArquivo))
            {
                escritor.Write("456,65465,456.0,Pedro");
            }
            
        }
        static void TestaEscrita()
        {
            var caminhoArquivo = "Text.txt";

            using (var fluxoDoArquuivo = new FileStream(caminhoArquivo, FileMode.Create))
            using(var escritor = new StreamWriter(fluxoDoArquuivo))
            {
                for (int i = 0; i < 10000000; i++)
                {
                    escritor.Flush();

                    Console.WriteLine($"Linha {i} foi escrita no arquivo. Tecle enter p adicionar mais uma!");
                    Console.ReadLine();
                }
            }
        }
    }
}
