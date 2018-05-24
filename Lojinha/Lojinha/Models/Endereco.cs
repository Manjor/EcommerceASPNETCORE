using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lojinha.Models
{
    public class Endereco
    {

        public int Id { get; private set; }
        public string Logradouro { get; private set; }
        public string Bairro { get; private set; }
        public string Complemento { get; private set; }
        public string Numero { get; private set; }

        public Cidade Cidade { get; private set; }
    }
}
