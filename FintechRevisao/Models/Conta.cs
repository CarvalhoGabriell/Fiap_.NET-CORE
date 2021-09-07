using System;
using System.Collections.Generic;
using System.Text;

namespace FintechRevisao.Models
{
    abstract class  Conta
    {
        public int Agencia { get; set; }

        public int Numero { get; set; }

        public decimal Saldo { get; protected private set; }

        public DateTime DataAbertura { get; set; }

        public IList<Cliente> Clientes { get; set; }

        // escrver overrride pra aparecer as opçoes disponiveis
        public override string ToString()
        {
            var aux = "";
            foreach(var item in Clientes)
            {
                aux += $"{item} \n";
            }
            return $"{aux}Agencia: {Agencia}, Numero: {Numero}, Saldo: {Saldo}, \n Data Abertura: {DataAbertura}";
        }
        public Conta(int agencia, int numero, IList<Cliente> clientes)
        {
            Agencia = agencia;
            Numero = numero;
            Clientes = clientes;
        }

        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }


        public abstract void Retirar(decimal valor);

    }
}
