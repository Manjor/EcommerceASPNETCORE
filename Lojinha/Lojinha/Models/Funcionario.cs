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

    }
}
