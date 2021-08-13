using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula01.Exemplo2.Models
{
    class Loja
    {

        public string Nome { get; set; }

        public DateTime DataAbertura { get; set; }

        public string Endereco { get; set; }

        public PorteLoja Porte { get; set; }

        public StatusLoja status { get; set; }

    }

    enum StatusLoja 
    { 
        Aberto,Fechado
    }


    enum PorteLoja
    {
        Pequeno,Medio,Grande
    }
}
