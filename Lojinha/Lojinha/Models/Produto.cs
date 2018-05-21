using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lojinha.Models
{
    public class Produto
    {

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public int Quantidade { get; private set; }
        public decimal Preco { get; private set; }
        public string Arquivo { get; private set; }
        public Categoria Categoria { get; private set; }



        public Produto( int id, string nome,
            string descricao,
            int quantidade,
            decimal preco,
            string arquivo,
            Categoria categoria)
        {
            this.Nome = nome;
            this.Descricao = descricao;
            this.Quantidade = quantidade;
            this.Preco = preco;
            this.Arquivo = arquivo;
            this.Categoria = categoria; 
            this.Id = id;

           
        }


    }
}
