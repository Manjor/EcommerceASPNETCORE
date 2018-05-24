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
    }
}
