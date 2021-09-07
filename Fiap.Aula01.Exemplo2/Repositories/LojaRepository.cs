using Fiap.Aula01.Exemplo2.Exceptions;
using Fiap.Aula01.Exemplo2.Models;
using Fiap.Aula01.Exemplos.Repositories;
using System;
using System.Collections.Generic;


namespace Fiap.Aula01.Exemplo2.Repositories
{
    class LojaRepository : ILojaRepository
    {
        // declarar um atributo do tipo de lista para armazenar as loja
        IList<Loja> _lojas;

        public void Cadastrar(Loja loja)
        {
            if (loja == null)
            {
                throw new ArgumentException("A loja esta vazia");
            }
            _lojas.Add(loja);
        }

        public IList<Loja> Listar()
        {
            if (_lojas.Count == 0 || _lojas == null)
            {
                throw new EmptyCollectionException("Nenhuma lista cadastrada");
            }
            return _lojas;
        }

        // Contrutor para instanciar a lista e nao deixa ela como vazia -> ctor + tab +tab
        public LojaRepository()
        {
            _lojas = new List<Loja>();
        }
    }
}
