using Lojinha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lojinha
{
    public interface IServicosUsuario
    {
        //Interface de Usuarios
        //Metodos de Visualização Geral
        List<Usuario> GetUsuarios();
        List<Cliente> GetClientes();
        List<Funcionario> GetFuncionarios();
        List<Nivel> GetNivels();

        //Metodos de Adição nas Tabelas
        void AddUsuario(Usuario usuario);
        void AddCliente(Cliente cliente);
        void AddFuncionario(Funcionario funcionario);
        void AddNivel(Nivel nivel);

        //Metodos de Consultas por ID
        Usuario GetUsuarioId(int id);
        Cliente GetClienteId(int id);
        Funcionario GetFuncionarioId(int id);
        Nivel GetNivelId(int id);


        




    }
}
