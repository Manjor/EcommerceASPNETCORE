﻿using Lojinha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lojinha
{
    public interface IDataService
    {
        
        //void InsereProduto(Produto produto);
        List<Produto> GetProdutos();
        List<Categoria> GetCategoria();
        Categoria GetCategoriaId(string id);
        void InsereDB();
        void InsereProduto(Produto produto);
        void AddProduto(string nome, string descricao, int quantidade, decimal valor, string arquivo, string categoria);
    }
}