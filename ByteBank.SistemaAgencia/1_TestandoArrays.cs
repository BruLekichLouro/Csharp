﻿using System;
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
            Console.ReadLine();

        } 
     }
   }


