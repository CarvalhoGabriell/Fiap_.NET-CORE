using Fiap.Aula01.Exemplo2.Models;
using Fiap.Aula01.Exemplos.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula01.Exemplo2.Repositories
{
    class LojaRepository : ILojaRepository
    {
        // declarar um atributo do tipo de lista para armazenar as loja
        IList<Loja> _lojas;

        public void Cadastrar(Loja loja)
        {
            _lojas.Add(loja);
        }

        public IList<Loja> Listar()
        {
            return _lojas;
        }

        // Contrutor para instanciar a lista e nao deixa ela como vazia -> ctor + tab +tab
        public LojaRepository()
        {
            _lojas = new List<Loja>();
        }
    }
}
