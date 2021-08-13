using System;
using Fiap.Aula01.Exemplo2.Models;

namespace Fiap.Aula01.Exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            // instanciar uma Loja
            Loja loja = new Loja()
            {
                Porte = PorteLoja.Medio
            };

            if (loja.Porte == PorteLoja.Medio )
            {
                Console.WriteLine("A Loja possui Porte Medio");
            } 
            else
            {
                Console.WriteLine("A loja nao possui Porte Medio");
            }

            Console.WriteLine($"Porte da Loja {loja.Porte}");

            // TAREFA
            //APRESENTAR UM MENU 1-cadastrar, 2-lisrar, 0- sair
        }
    }
}
