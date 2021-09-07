using FintechRevisao.Models;
using System;
using System.Collections.Generic;

namespace FintechRevisao
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ler a quantidade de Clientes que serao adicionados
            Console.WriteLine("Informa a quantidade de clientes:");

            int quantidade = int.Parse(Console.ReadLine());
            // criar a lista de clientes

            IList<Cliente> clientes = new List<Cliente>();
            
            // laço para ler os clientes
            for(int i = 0; i < quantidade;i ++ )
            {
                Console.WriteLine("Informe o ID:");
                var id = int.Parse(Console.ReadLine());

                Console.WriteLine("Informa o CPF:");
                var cpf = Console.ReadLine();
                
                Console.WriteLine("Informa o Nome:");
                var nome = Console.ReadLine();

                var cliente = new Cliente(id, nome) { Cpf = cpf };

                clientes.Add(cliente);
            }
            foreach(var user in clientes)
            {
                Console.WriteLine(user);
            }

            // Ler os dados da conta corrente (Agencia, Numero, Data abertura, Tipo)
            Console.WriteLine("Informe sua Agencia: ");
            var agencia = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o numero da conta: ");
            var numConta = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite a Data de abertura: ");
            var data = DateTime.Parse(Console.ReadLine());
            
            Console.WriteLine("Informe o tipo da conta (especial, comum, premium)");
            var tipoConta =(TipoConta)Enum.Parse(typeof(TipoConta), Console.ReadLine(), true);
            // instanciar a conta corrente
            var contaCorrente = new ContaCorrente(agencia, numConta , clientes, tipoConta) { DataAbertura = data};

            // exibir os dados da conta corrente
            Console.WriteLine(contaCorrente);
            // variavel para armazenar a escolha do usuario
            int escolha;
            // menu com as opções 1-depositor 2-retirar, 3-exibir 0-sair

        }
    }
}
