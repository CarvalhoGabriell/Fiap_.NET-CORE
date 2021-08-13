using Fiap.Aula01.Exemplo2.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace Fiap.Aula01.Exemplos.Repositories
{
    interface ILojaRepository
    {
        void Cadastrar(Loja loja);

        IList<Loja> Listar();


    }
}
