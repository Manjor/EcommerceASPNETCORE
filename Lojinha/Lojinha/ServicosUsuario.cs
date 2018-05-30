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
            try
            {

                return _contexto.Usuarios.Where(u => u.Email == email && u.Senha == senha).Single();
            }
            catch (Exception erro)
            {
                return null;
            }
        }

        ///////////////////////////////////////////////////////
        //Metodos que capturam um Objeto do Banco de Dados
        //public Usuario GetUsuarioId(int id)
        //{
        //    return this._contexto.Usuarios.Where(u => u.Id == id).Single();
        //}
        
        ///////////////////////////////////////////////////////
        //Metodos de Adicao nas Tabelas de Pessoas

        //Metodo que adiciona um usuario ao banco de dados
        public void AddUsuario(Usuario usuario)
        {

            this._contexto.Usuarios.Add(usuario);
            this._contexto.SaveChanges();
        }

        public List<Usuario> GetFuncionarios()
        {
            var pegaFuncionarios = from u in _contexto.Usuarios where u.Nivel == 1 select u;
            List<Usuario> funcionarios = new List<Usuario>();

            foreach (var fun in pegaFuncionarios)
            {

                funcionarios.Add(fun);
            }
            return funcionarios;

        }


        public void RemoveUsuario(int id,Usuario usuario)
        {

            var pegaUsuario = from u in _contexto.Usuarios where u.Id == id select u;

            foreach (var del in pegaUsuario)
            {
                _contexto.Usuarios.Remove(del);
            }
            try
            {
                _contexto.SaveChanges();

            }
            catch(Exception erro)
            {
                Console.WriteLine("Não Foi possivel remover o Usuario. Erro :" + erro);
            }








        }

        


    }
}
