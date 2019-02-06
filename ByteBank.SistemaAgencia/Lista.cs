using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class Lista<T>
    {
        private T[] _itens;
        private int _proximaPosicao;
        public int Tamanho
        {
            get
            {
                return _proximaPosicao;
            }
        }

        public Lista(int capacidadeInicial = 5)
        {
            _itens = new T[capacidadeInicial];
            _proximaPosicao = 0;
        }
        
        public void Adicionar(T item)
        {
            VerificarCapacidade(_proximaPosicao + 1);
            Console.WriteLine($"Adicionando item na posição {_proximaPosicao}");

            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }

        public void AdicionarVarios(params T[] itens)
        {
            foreach (var conta in itens)//Melhor opção para laços em array que não se importa com indices
            {
                Adicionar(conta);
            }
        }//params também podem ser usados nos indexadores

        private void VerificarCapacidade(int tamanhoNecessario)
        {
            if (_itens.Length >= tamanhoNecessario)
            {
                return;
            }
            int novoTamanho = _itens.Length * 2;
            if (novoTamanho < tamanhoNecessario)
            {
                novoTamanho = tamanhoNecessario;

            }
            T[] novoArray = new T[novoTamanho];
            //Console.WriteLine("Aumentando capacidade da lista!");
            for (int indice = 0; indice < _itens.Length; indice++)
            {
                novoArray[indice] = _itens[indice];
            }
            _itens = novoArray;

        }

        public T GetItemNoIndice(int indice)//Metodo retorna uma ContaCOrrente
        {
            if (indice < 0 || indice >= _proximaPosicao)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }
            return _itens[indice];
        }
        //Indexador
        public T this[int indice]
        {
            get
            {
                return GetItemNoIndice(indice);
            }
        }
        //public T this[string texto]
        //{
        //    get
        //    {
        //        return null;//Teste
        //    }
        //}

        public void Remover(T item)
        {
            int indiceItem = -1;

            for (int i = 0; i < _proximaPosicao; i++)
            {
                T itemAtual = _itens[i];

                if (itemAtual.Equals(item))//Comparando equivalencia entre objeetos
                {
                    indiceItem = i;
                    break;
                }
            }
            for (int i = indiceItem; i < _proximaPosicao - 1; i++)
            {
                _itens[i] = _itens[i + 1];

            }
            _proximaPosicao--;
           // _itens[_proximaPosicao] = null; //Não saabemos se o argumento T será um tipo de valor ou referÊncia 
        }

    }
}
