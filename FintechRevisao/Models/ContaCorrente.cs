using FintechRevisao.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace FintechRevisao.Models
{
    class ContaCorrente : Conta
    {
        public decimal Limite { get; set; }

        public TipoConta Tipos { get; set; }
        public ContaCorrente(int agencia, int numero, IList<Cliente> clientes, TipoConta tipo) : base(agencia, numero, clientes)
        {
            Tipos = tipo;
            if (tipo == TipoConta.Comum)
            {
                Limite = 0;
            }else if (tipo == TipoConta.Especial)
            {
                Limite = 500;
            }else
            {
                Limite = 1000;
            }
        }
        // escrver overrride pra aparecer as opçoes disponiveis
        public override string ToString()
        {
            return base.ToString()+ $" Tipo: {Tipos}, Limite: {Limite}";
        }

        public override void Retirar(decimal valor)
        {
            if (valor > Saldo + Limite)
            {
                throw new NegativeContaException($"Saldo Indisponivel na sua conta. Saldo Disponivel: {Saldo + Limite}");
            }
            Saldo -= valor;
        }
    }
    enum TipoConta
    {
        Comum, Especial, Premium
    }
}
