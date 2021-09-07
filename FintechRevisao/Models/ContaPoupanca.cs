using FintechRevisao.Exceptions;
using FintechRevisao.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace FintechRevisao.Models
{
    class ContaPoupanca : Conta, IContaIvestimentos
    {
        public decimal Taxa { get; set; }
        public ContaPoupanca(int agencia, int numero, IList<Cliente> clientes, decimal taxa) : base(agencia, numero, clientes)
        {
            Taxa = taxa;
        }


        public decimal CalculoRetornoInvestimento()
        {
            return Saldo * 0.04m;
        }

        public override void Retirar(decimal valor)
        {
            if (valor + Taxa > Saldo)
            {
                throw new NegativeContaException($"Saldo insuficiente. Disponivel no Momento: {Saldo - Taxa}");
            }
            Saldo -= valor + Taxa;
        }
    }
}
