using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class ExtratorValorDeArgumentosURL
    {
        public string URL { get; }
        private readonly string _argumentos;

        public ExtratorValorDeArgumentosURL(string url)
        {

            if (String.IsNullOrEmpty(url))
            {
                throw new ArgumentException("O argumento url não pode ser nulo ou vazio.", nameof(url));
            }
            URL = url;

            int indiceInterrogacao = url.IndexOf("?");
            _argumentos = url.Substring(indiceInterrogacao + 1);
        }
        public string GetValor(string nomeParametro)
        {
            string palavra = "moedaOrigem=real&moedaDestino=dolar";
            nomeParametro = "moedaDestino";

            int indiceArgumento = palavra.IndexOf(nomeParametro);
            int indiceValor = indiceArgumento + nomeParametro.Length + 1;
            string valorArgumento = palavra.Substring(indiceValor);
            Console.WriteLine(valorArgumento);
            return valorArgumento;
        }
    }
}
