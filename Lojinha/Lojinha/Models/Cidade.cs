using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lojinha.Models
{
    public class Cidade
    {

        public int Id { get; private set; }
        public string NomeCidade { get; private set; }
        public Estado Estado { get; private set; }

        public Cidade(int id, string nome,Estado estado)
            : this(nome,estado)
        {
            this.Id = id;
        }

        public Cidade(string nome, Estado estado)
        {
            this.NomeCidade = nome;
            this.Estado = estado;
        }


    }
}
