using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula01.Exemplos.Models
{
    class Tenis : Produto
    {
        //Propriedades. Getter e Setter devem sewr em UpperCase
        public int Tamanho { get; set; }

        public string Modelo { get; set; }

        public string Cor { get; set; }

        // Construtor
        // : base -> chama o construtor da classe pai. Passa como parametros os parametros do contrutor da classe pai
        public Tenis(int id, string nome, int tamanho) : base(id, nome)
        {
            Tamanho = tamanho;
        }

        // Metodos 
        // Sobrescrita -> implementa o metodo do pai na classe filha, para assim alterar/adicionar a implementação
        public override decimal CalcularDesconto()
        {
            // Desconto de 10% para os tenis diferente do padrão que é 5%
            return Preco * 0.9m;
        }

        // Sobrescrever o metodo ded CalcularDesconto(cupom) que da 30%, adicionar o cupom FIAP50 para um desconto de 50%
        public override decimal CalcularDesconto(string cupom)
        {
            if (cupom == "FIAP50")
            {
                return Preco * 0.5m;
            }
            return Preco; 
        }

        public override void AumentarPreco(decimal inflacao)
        {
            Preco += Preco * inflacao / 100;
        }
    }
}
