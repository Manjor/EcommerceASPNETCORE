using Lojinha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lojinha
{
    public class DataService : IDataService
    {

        private readonly BancoContext _contexto;

        


        public DataService(BancoContext contexto)
        {
            this._contexto = contexto;
        }



        //Retorna a lista de Produtos
        public List<Produto> GetProdutos()
        {
            return this._contexto.Produtos.ToList();
        }


        //Retorna a lista de Categorias
        public List<Categoria> GetCategoria()
        {
            return this._contexto.Categorias.ToList();
        }

        public void InsereDB()
        {
            List<Produto> produtos = new List<Produto>
            {
                new Produto()
            }
        }



     



        public void InsereProduto(Produto produto)
        {
            this._contexto.Produtos.Add(produto);
            this._contexto.SaveChanges();
        }

        
        


        
    }
}
