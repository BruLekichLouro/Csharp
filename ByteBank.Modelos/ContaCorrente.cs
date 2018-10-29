﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    /// <summary>
    /// Esta classe define uma Conta Corrente do banco ByteBank.
    /// </summary>
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int Numero { get; } //atributo que só é atribuído uma vez e dps SÒ pode ser lido!"Readonly"
        public static int TotalDeContasCriadas { get; private set; }
        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciasNaoPermitidas { get; private set; }
        public static double TaxaOperacao { get; private set; }
        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        public int Agencia { get; }


        /// <summary>
        /// Cria uma instância de ContaCorrente com os argumentos utilizados;
        /// </summary>
        /// <param name="agencia">Representa o valor da proprieddae <see cref="Agencia"/> e deve possuir valor maior que zero.</param>
        /// <param name="numero">Representa o valor da propriedade <see cref="Numero"/> e deve possuir valor maior que zero.</param>
        public ContaCorrente(int agencia, int numero)
        {
            if (agencia <= 0)
            {
                throw new ArgumentException("O argumento agencia deve ser maior que 0.", nameof(agencia));
            }

            if (numero <= 0)
            {
                throw new ArgumentException("O argumento numero deve ser maior que 0.", nameof(numero));
            }

            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }
        /// <summary>
        /// Realiza o saque e atualiza o valor da propriedade <see cref="Saldo"/>
        /// </summary>
        /// <exception cref="ArgumentException">Exeção lançada quando um valor negativo é utilizado no argumento <paramref name="valor"/>.</exception>
        /// <exception cref="SaldoInsuficienteException">Exceção lançada quando o <see cref="Saldo"/>é menor que o valor utilizado no argumento <paramref name="valor"</exception>
        /// <param name="valor">Representa o valor do saque.Deve ser maior que 0 e menor que o <see cref="Saldo"/></param>
        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para o saque.", nameof(valor));
            }
            if (_saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(_saldo, valor);

            }

            _saldo -= valor;

        }
        /// <summary>
        /// Realiza o depósito e atualiza o valor da propriedade <see cref="Saldo"/>
        /// </summary>
        /// <param name="valor">Representa o valor que será acrescentado à propriedade <see cref="Saldo"/></param>
        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        /// <summary>
        /// Realiza o saque e me retorna uma  conta e depósito na segunda. Atualiza o valor da propriedade <see cref="Saldo"/>
        /// </summary>
        /// <exception cref="ArgumentException">Exeção lançada quando um valor negativo é utilizado no argumento <paramref name="valor"</exception>
        /// <exception cref="SaldoInsuficienteException">Exceção lançada quando o <see cref="Saldo"/>é menor que o valor utilizado no argumento <paramref name="valor"</exception>
        /// <param name="valor">Representa o valor que será sacado de uma conta e acrescentado à <paramref name="contaDestino"/></param>
        /// <param name="contaDestino">"Representa a conta que receberá o <paramref name="valor"/>sacado.</param>
        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para a transferência.", nameof(valor));
            }
            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException ex)
            {
                ContadorTransferenciasNaoPermitidas++;
                throw new OperacaoFinanceiraException("Operação não realizada.", ex);
            }

            contaDestino.Depositar(valor);
        }
        //Testando método ToString
        public override string ToString()
        {
            return $"Número {Numero}, Agência {300*5}, Saldo {Saldo}";
            // return "Número " + Numero + ", Agência " + Agencia + ", Saldo " + Saldo;

        }
    }
}

