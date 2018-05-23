using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lojinha.Models
{
    public class Categoria
    {

        public int Id { get; private set; }
        public string NomeCategoria { get; private set; }

        public Categoria(int id, string nomeCategoria)
            : this(nomeCategoria)
        {
            this.Id = id;
        }

        public Categoria(string nomeCategoria)
        {
            this.NomeCategoria = nomeCategoria;
        }
        public Categoria() { }


        


    }
}
