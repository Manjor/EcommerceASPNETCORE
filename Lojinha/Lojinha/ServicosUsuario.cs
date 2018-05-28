using Lojinha.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lojinha
{
    public class ServicosUsuario : IServicosUsuario
    {
        private readonly BancoContext _contexto;
        
        //Consultas ao Banco de Dados a respeito de Pessoas.
        //Usuario: Generico
        //Cliente: <- Usuario e Endereco
        //Funcionario: <- Usuario e Nivel
        public ServicosUsuario(BancoContext contexto)
        {
            this._contexto = contexto;
        }

        //Retorna a Lista de Usuario do Sistema em Geral
        public List<Usuario> GetUsuarios()
        {
            return this._contexto.Usuarios.ToList();
        }


        public Usuario GetLogin(string email , string senha)
        {
            return _contexto.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }

        ///////////////////////////////////////////////////////
        //Metodos que capturam um Objeto do Banco de Dados
        public Usuario GetUsuarioId(int id)
        {
            return this._contexto.Usuarios.Where(u => u.Id == id).Single();
        }
        
        ///////////////////////////////////////////////////////
        //Metodos de Adicao nas Tabelas de Pessoas

        //Metodo que adiciona um usuario ao banco de dados
        public void AddUsuario(Usuario usuario)
        {

            this._contexto.Usuarios.Add(usuario);
            this._contexto.SaveChanges();
        }

       

        



    }
}
