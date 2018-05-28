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


        //Metodos de Adição nas Tabelas
        void AddUsuario(Usuario usuario);


        //Metodos de Consultas por ID
        //Usuario GetUsuarioId(int id);
        Usuario GetLogin(string email, string senha);
    }
}
