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
     *  public ->
     *  private ->
     *  protected ->
     *  internal ->
     *  protected internal ->
     *  protected private ->
     *  
     *  Tipo de dados:
     *  Não existem tipos primitivos
     *  string, int,long (são abreviações para asa classes)
     *  
     *  Padrões de Nomenclatura:
     *  Classes/Métodos -> UpperCase
     *  Atributos/Fields -> começam com "_"
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

            // Intanciar um Produto e atribuir os valores
            Produto produto = new Produto();

            produto.Nome = nome;
            produto.Id = id;
            produto.Preco = preco;

            Console.WriteLine($"Nome: {produto.Nome}, Preço(R$): {produto.Preco}, ID {produto.Id}");
        }
    }
}
