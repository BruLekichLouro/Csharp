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
    class Program
    {
        static void Main(string[] args)
        {

            var enderecoDoArquivo = "contas.txt";

            using(var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            {
                var buffer = new byte[1024];

                var numeroDeBytesLidos = -1;

                while (numeroDeBytesLidos != 0)
                {
                    numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                    EscreverBuffer(buffer);

                }
            }

            

            
            

            Console.ReadLine();
        }
        static void EscreverBuffer(byte[] buffer)
        {
            var utf8 = new UTF8Encoding();
            var texto = utf8.GetString(buffer);
            Console.Write(texto);

            //foreach (var meuByte in buffer)
            //{
            //    Console.Write(meuByte);
            //    Console.Write(" ");
            //}
        }
    

        private static void ListaGenericaExtensaoLinqLambda()
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
        static int SomarVarios(params int[] numeros)
        {
            int acumulador = 0;
            foreach (int numero in numeros)
            {
                acumulador += numero;
            }
            return acumulador;
        }
        static void TestaArrays()
        {
            //DateTime dataFimPagamento = new DateTime(2019, 12, 17);
            //DateTime dataCorrente = DateTime.Today;
            //TimeSpan diferenca = dataFimPagamento - dataCorrente;
            //TimeSpan outro = TimeSpan.FromMinutes(40);
            //string mensagem = "Vencimento em: " + TimeSpanHumanizeExtensions.Humanize(diferenca);
            //Console.WriteLine(dataCorrente);
            //Console.WriteLine(dataFimPagamento);
            //Console.WriteLine(mensagem);
            //Console.WriteLine(outro);

            //string url = "pagina?argumentos";
            //int indiceInterrogacao = url.IndexOf('?');
            //Console.WriteLine(indiceInterrogacao);
            //string argumentos = url.Substring(indiceInterrogacao + 1);
            //Console.WriteLine(argumentos);
            //string textoVazio = "";
            //string textoNulo = null;
            //string textoQualquer = "Adjfjlfj";
            //Console.WriteLine(string.IsNullOrEmpty(textoVazio));
            //Console.WriteLine(string.IsNullOrEmpty(textoNulo));
            //Console.WriteLine(string.IsNullOrEmpty(textoQualquer));

            //string testeRemocao = "primeiraParte&parteParRemover";
            //int indiceEComercial = testeRemocao.IndexOf('&');
            //Console.WriteLine(testeRemocao.Remove(indiceEComercial));

            //string termoBusca = "ra";
            //termoBusca = termoBusca.Replace('r', 'R');
            //Console.WriteLine(termoBusca);

            //string urlTeste = "https://www.bytebank.com/cambio";
            //int indiceByteBank = urlTeste.IndexOf("https://www.bytebank.com");
            ////Todos são case sensitive
            //Console.WriteLine(urlTeste.StartsWith("https://www.Bytebank.com"));
            //Console.WriteLine(urlTeste.EndsWith("cambio/"));
            //Console.WriteLine(urlTeste.Contains("Bytebank"));

            string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValorDeArgumentosURL url2 = new ExtratorValorDeArgumentosURL(urlParametros);
            string valor = url2.GetValor("moedaDestino");
            Console.WriteLine("Valor de moedaDestino: " + valor);

            string valorMoedaOrigem = url2.GetValor("moedaOrigem");
            Console.WriteLine("Valor de moedaOrigem: " + valorMoedaOrigem);

            Console.WriteLine(url2.GetValor("vALOR"));

            // string padrao =
            //"[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";//Expressão regular padrão
            // string padrao = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            // string padrao = "[0-9]{4}[-][0-9]{4}";
            //string padrao = "[0-9]{4,5}[-]{0,1}[0-9]{4}";
            string padrao = "[0-9]{4,5}-?[0-9]{4}";

            // string textoDeTeste = "Meu nome é Guilherme, me ligue 4784-4546";
            string textoDeTeste = "Ajhhfis  jaoa 4784-4546, ahfosda ahufhge ";
            Console.WriteLine(Regex.IsMatch(textoDeTeste, padrao));
            Match resultado = Regex.Match(textoDeTeste, padrao);//Buscará qq número que respeite o padrao
            Console.WriteLine(resultado.Value);

            //Testando método Equals
            Cliente carlos_1 = new Cliente();
            carlos_1.Nome = "Carlos";
            carlos_1.CPF = "458.623.120-03";
            carlos_1.Profissao = "Designer";

            Cliente carlos_2 = new Cliente();
            carlos_2.Nome = "Carlos";
            carlos_2.CPF = "458.623.120-03";
            carlos_2.Profissao = "Designer";

            if (carlos_1.Equals(carlos_2))
            {
                Console.WriteLine("São iguais!");
            }
            else
            {
                Console.WriteLine("Não são iguais!");
            }

        }
    }
}
