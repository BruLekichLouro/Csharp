using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            //DateTime dataFimPagamento = new DateTime(2019, 12, 17);
            //DateTime dataCorrente = DateTime.Now;
            //TimeSpan diferenca = dataFimPagamento - dataCorrente;
            //TimeSpan outro = TimeSpan.FromMinutes(40);
            //string mensagem = "Vencimento em: " + TimeSpanHumanizeExtensions.Humanize(diferenca);
            //Console.WriteLine(dataCorrente);
            //Console.WriteLine(dataFimPagamento);
            //Console.WriteLine(mensagem);
            //Console.WriteLine(outro);

            ExtratorValorDeArgumentosURL url2 = new ExtratorValorDeArgumentosURL("moedaOrigem=real&moedaDestino=dolar");
            url2.GetValor("moedaDestino");
            Console.ReadLine();
        }
    }
}
