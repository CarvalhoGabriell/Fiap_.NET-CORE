using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula01.Exemplos.Models
{
    class Usuario
    {
        //Atributos da class ou Fields
        private int _id;
        private string _nome;

  
        // Getters e Setters

        // Outra maneira de criar um novo Field com seus respectivos get e set
        public string Senha { get; set; }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Nome
        { 
            get { return _nome; }
            set { _nome = value; }
        }

    
    }
}
