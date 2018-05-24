using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lojinha.Models
{
    public class Funcionario
    {

        public int Id { get; private set; }
        public Usuario Usuario {get; private set;}
        public Nivel Nivel { get; private set; }



        public Funcionario(int id, Usuario usuario, Nivel nivel)
            :this(usuario,nivel)
        {
            this.Id = id;
        }

        public Funcionario(Usuario usuario, Nivel nivel)
        {
            this.Usuario = usuario;
            this.Nivel = nivel;
        }
        public Funcionario() { }
    }
}
