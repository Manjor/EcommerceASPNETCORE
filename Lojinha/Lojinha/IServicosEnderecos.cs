using Lojinha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lojinha
{
    public interface IServicosEnderecos
    {
        //Interface de Usuarios
        //Metodos de Visualização Geral
        List<Endereco> GetEnderecos();
        List<Cidade> GetCidades();
        List<Estado> GetEstados();

        //Metodos de Adição nas Tabelas
        void AddEndereco(Usuario usuario);
        void AddCidade(Cliente cliente);

        //Metodos de Capturas por meio de Id
        Endereco GetEnderecoId(int id);
        Cidade GetCidadeId(int id);
        Estado GetEstadoId(int id);
    }
}
