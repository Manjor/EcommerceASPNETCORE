using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lojinha.Models
{
    public class Cliente
    {


        //Atributos de um cliente alem dos de um Usuario
        //Pois todo cliente é usuario

        public int Id { get; private set; }
        public Usuario Usuario { get; private set; }
        public Endereco Endereco { get; set;}

        public Cliente(int id, Usuario usuario, Endereco endereco)
            : this(usuario,endereco)
        {
            this.Id = id;
        }

        public Cliente(Usuario usuario, Endereco endereco)
        {
            this.Usuario = usuario;
            this.Endereco = endereco; 
        }

        public Cliente() { }
    }
}
