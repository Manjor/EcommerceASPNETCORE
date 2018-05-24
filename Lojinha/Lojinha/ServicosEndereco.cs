using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lojinha.Models;

namespace Lojinha
{
    public class ServicosEndereco : IServicosEnderecos
    {
        private readonly BancoContext _contexto;

        public ServicosEndereco(BancoContext contexto)
        {
            this._contexto = contexto;
        }


        //Metodos de Adição no Banco de Dados Referentes a endereço
        public void AddCidade(Cliente cliente)
        {
            this._contexto.Clientes.Add(cliente);
            this._contexto.SaveChanges();
        }

        public void AddEndereco(Usuario usuario)
        {
            this._contexto.Usuarios.Add(usuario);
            this._contexto.SaveChanges();
        }



        //Metodos de Captura de Dados por meio de Id
        //Metodo que captura uma Cidade
        public Cidade GetCidadeId(int id)
        {
            return this._contexto.Cidades.Where(c => c.Id == id).SingleOrDefault();
        }

        //Metodo que captura um Estado
        public Estado GetEstadoId(int id)
        {
            return this._contexto.Estados.Where(e => e.Id == id).SingleOrDefault();
        }
        //Metodo que captura um Endereco
        public Endereco GetEnderecoId(int id)
        {
            return this._contexto.Enderecos.Where(en => en.Id == id).SingleOrDefault();
        }

        //Metodos de Visualição para Tabelas referentes a endereço
        public List<Cidade> GetCidades()
        {
            return this._contexto.Cidades.ToList();
        }

        public List<Endereco> GetEnderecos()
        {
            return this._contexto.Enderecos.ToList();
        }

        public List<Estado> GetEstados()
        {
            return this._contexto.Estados.ToList();
        }



    }
}
