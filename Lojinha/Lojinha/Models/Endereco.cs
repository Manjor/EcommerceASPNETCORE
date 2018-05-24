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

        public Endereco(int id, string logradouro, string bairro, string complemento, string numero,Cidade cidade)
            :this(logradouro,bairro,complemento,numero,cidade)
        {
            this.Id = id;
        }

        public Endereco(string logradouro, string bairro, string complemento, string numero, Cidade cidade)
        {
            this.Logradouro = logradouro;
            this.Bairro = bairro;
            this.Complemento = complemento;
            this.Numero = numero;
            this.Cidade = cidade;
        }


    }
}
