using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula01.Exemplos.Models
{   // Uma classe abstrata -> não poode ser instanciada e PODE conter metodos com implementação ou sem
    abstract class Produto
    {
        /*
         * Atalho para gerar propriedades -> escrever "prop" + tab + tab
         * Atlaho gerar construtor -> escrever "ctor" + tab + tab
         */

        // Propriedades (Getters e Setters)
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        // Contrutores
        public Produto(int id, string nome)
        {
            Id = id;
            Nome = nome;

        }

        // Metodos da classe produto
        public void Cadastrar()
        {
            Console.WriteLine($"{Nome} Cadastrado com sucesso!");
        }

        // Sobrecargas de metodos -> metodo da mesma classe com mesmo nome e com parametros de tipos diferentes ou quantidades de parametros ou a ordem
        public decimal CalcularDesconto(decimal porcentagem)
        {
            return Preco * (100 - porcentagem) /100;
        }

        public virtual decimal CalcularDesconto(string cupom)
        {
            // O cupom FIAP30 dá 30% de desconto
            if (cupom == "FIAP30")
            {
                return Preco * 0.70m;

            }
            return Preco;
        }
        // O modificador "Virtual" Habilita que esse metodo possa ser sobrescrito pelas classes filhas da classe pai
        public virtual decimal CalcularDesconto()
        {
            return Preco * 0.95m; // "m" no final de um numero para definir ele como decimal
        }

        // Metodo abstrato -> Sem implementtação, termina com ;
        // Metodo aumenta a inflação em 5%, 10%, 20%....
        public abstract void AumentarPreco(decimal inflacao);
    }
}

