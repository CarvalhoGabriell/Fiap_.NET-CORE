using System; 
using Fiap.Aula01.Exemplos.Models;
// aqui mostra os imports

namespace Fiap.Aula01.Exemplos // namespace = Nome dos pacotes antes das classes
{
    /*
     *  ALT + ENTER ou CTRL + . (sugestão de correção)
     *  Solution -> Workspace
     *  Project -> Project
     *  Namespace -> Package ou pacote
     *  using -> imports
     *  
     *  Modificadores:
     *  public -> Todos
     *  private -> Somente a classe
     *  protected -> Somente a classe e as classes filhas
     *  internal -> Todos do mesmo projeto 
     *  protected internal -> A classe, classe filha e todos do mesmo projeto
     *  protected private -> A classe, classes filhas do mesmo projeto
     *  
     *  Tipo de dados:
     *  Não existem tipos primitivos
     *  string, int,long (são abreviações para asa classes)
     *  
     *  Padrões de Nomenclatura:
     *  Classes/Métodos -> UpperCase
     *  Atributos/Fields -> começam com "_"
     *  
     *  Atalhos -> CTRL + K + C (comenta )
     */

    class Program
    {
        static void Main(string[] args)
        {
            // Instancia um Usuario
            Usuario user = new Usuario();
            user.Nome = "Gabriel .NET"; // set
            user.Id = 1;
            Console.WriteLine(user.Nome); // get
            Console.WriteLine(user.Id);

            // Ler os dados do produto
            //Atalho -> cw + tab + tab (Console.WriteLine)
            Console.WriteLine("Informe o ID do Produto: ");
            int id = int.Parse(Console.ReadLine()); // Ler uma String e converter para int

            Console.WriteLine("Informe um Nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o preço do Produto: ");
            decimal preco = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Informe o Tamanho: ");
            int tamanho = int.Parse(Console.ReadLine());
            // Intanciar um Produto e atribuir os valores
            Produto produto = new Tenis(id, nome, tamanho)
            {
                Preco = preco
            };

            Console.WriteLine($"ID {produto.Id}, Nome: {produto.Nome}, Preço(R$): {produto.Preco}, Tamanho: {tamanho}");

            // Ler Inflação do produto
            Console.WriteLine("Informe a Inflação do Produto: ");
            decimal inflacao = decimal.Parse(Console.ReadLine());

            // Aumentar o Preço do produto com a inflação
            produto.AumentarPreco(inflacao);

            // Exibir o preço atualizado
            Console.WriteLine($"Novo Preço do Produto com Inflação: {produto.Preco}");

            // Aplicar desconto de 10%
            decimal novoValor = produto.CalcularDesconto();

            // Exibir novo preço com desconto
            Console.WriteLine($"Novo Preço com desconto: {novoValor}");
            // Ler o cupom de deconto FIAP30
            Console.WriteLine("Digite um cupom: ");
            string cupom = Console.ReadLine();

            // Exibir o valor com desconto
            decimal valor = produto.CalcularDesconto(cupom);
            Console.WriteLine($"O valor de desconto é: {valor}");
        }
    }
}
