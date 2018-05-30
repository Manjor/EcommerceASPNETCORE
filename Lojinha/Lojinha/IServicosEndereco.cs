using Lojinha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lojinha
{
    public interface IServicosEndereco
    {


        /**Metodos de Endereco*/
        //Interface de Enderecos
        //Metodos de Visualização Geral
        List<Endereco> GetEnderecos();
        List<Cidade> GetCidades();
        List<Estado> GetEstados();

        //Metodos de Adição nas Tabelas
        void AddEndereco(Usuario usuario);


        //Metodos de Capturas por meio de Id
        Endereco GetEnderecoId(int id);
        Cidade GetCidadeId(int id);
        Estado GetEstadoId(int id);

    }
}
