using System;
using System.Collections.Generic;
using Fiap.Aula01.Exemplo2.Exceptions;
using Fiap.Aula01.Exemplo2.Models;
using Fiap.Aula01.Exemplo2.Repositories;

namespace Fiap.Aula01.Exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            // instanciar uma Loja
            Loja lojatest = new Loja()
            {
                Porte = PorteLoja.Medio,
                Nome = "Loja Repo",
                Status = StatusLoja.Aberto,
                Endereco = "Av. General 23",

            };

            if (lojatest.Porte == PorteLoja.Medio)
            {
                Console.WriteLine("A Loja possui Porte Medio");
            }
            else
            {
                Console.WriteLine("A loja nao possui Porte Medio");
            }

            Console.WriteLine($"Porte da Loja {lojatest.Porte}");

            Loja loja1 = new Loja()
            {
                Porte = PorteLoja.Pequeno,
                Nome = "Loja Avenida 13",
                Status = StatusLoja.Aberto,
                Endereco = "Av. Atolfo 69",

            };

            Loja loja2 = new Loja()
            {
                Porte = PorteLoja.Grande,
                Nome = "Loja Matriz",
                Status = StatusLoja.Aberto,
                Endereco = "Av. João Kleber",

            };

            IList<Loja> lojas = new List<Loja>();
            lojas.Add(lojatest);
            lojas.Add(loja1);
            lojas.Add(loja2);
            // TAREFA
            //APRESENTAR UM MENU 1-cadastrar, 2-listar, 0- sair
            LojaRepository repo = new LojaRepository();
            int opcao;
            do
            {
                Console.WriteLine("\n [1] OPÇÃO CADASTRAR\n" +
                    " [2] OPÇÃO LISTAR \n" +
                    " [0] SAIR DO MENU \n");
                Console.WriteLine("Escolha um Opção do Menu: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        // menu 1 cadastrar
                        Console.WriteLine("Informe o Nome da Loja: ");
                        string nome = Console.ReadLine();

                        Console.WriteLine("Informe a Data de Abertura: ");
                        DateTime data = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o Porte da Loja (pequeno, medio, grande): ");
                        // parametros do .Parse(Enum, string informada, IgnoreCase(true ou false))
                        PorteLoja porte = (PorteLoja) Enum.Parse(typeof(PorteLoja), Console.ReadLine(), true); 

                        Console.WriteLine("Digite o Endereço: ");
                        string endereco = Console.ReadLine();

                        Console.WriteLine("Digite o status atual da loja (aberto ou fechado): ");
                        StatusLoja status = (StatusLoja) Enum.Parse(typeof(StatusLoja), Console.ReadLine(), true);

                        Loja loja = new Loja()
                        {
                            Status = status, DataAbertura = data, Nome = nome, Endereco = endereco, Porte = porte

                        };

                        repo.Cadastrar(loja);
                        Console.WriteLine($"Loja {loja.Nome} , {loja.Endereco}, {loja.Status}, {loja.DataAbertura} Cadastrada com sucesso!");
                        break;
                    case 2:
                        try
                        {

                            IList<Loja> lojasTotal = repo.Listar(); 
                            foreach (var itens in lojasTotal)
                            {
                                Console.WriteLine(itens);
                            }

                        }
                        catch (EmptyCollectionException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        // menu 2 listar

                        break;
                    case 0:
                        // sair
                        Console.WriteLine("Saindo do Menu.....");
                        break;

                }

            } while (opcao != 0);

        }
    }
}
