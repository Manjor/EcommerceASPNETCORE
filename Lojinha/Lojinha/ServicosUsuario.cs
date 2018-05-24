using Lojinha.Models;
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

        //Retorna a lista de Clientes do Sistema
        public List<Cliente> GetClientes()
        {
            return this._contexto.Clientes.ToList();
        }
        
        //Retorna a lista de Funcionários do Sistema
        public List<Funcionario> GetFuncionarios()
        {
            return this._contexto.Funcionarios.ToList();
        }

        //Retorna a lista de Niveis para Funcionarios do Sistema
        public List<Nivel> GetNivels()
        {
            return this._contexto.Niveis.ToList();
        }


        ///////////////////////////////////////////////////////
        //Metodos que capturam um Objeto do Banco de Dados
        public Usuario GetUsuarioId(int id)
        {
            return this._contexto.Usuarios.Where(u => u.Id == id).SingleOrDefault();
        }
        public Cliente GetClienteId(int id)
        {
            return this._contexto.Clientes.Where(cl => cl.Id == id).SingleOrDefault();
        }
        public Funcionario GetFuncionarioId(int id)
        {
            return this._contexto.Funcionarios.Where(f => f.Id == id).SingleOrDefault();
        }
        public Nivel GetNivelId(int id)
        {
            return this._contexto.Niveis.Where(n => n.Id == id).SingleOrDefault();
        }

        ///////////////////////////////////////////////////////
        //Metodos de Adicao nas Tabelas de Pessoas

        //Metodo que adiciona um usuario ao banco de dados
        public void AddUsuario(Usuario usuario)
        {

            this._contexto.Usuarios.Add(usuario);
            this._contexto.SaveChanges();
        }

        //Metodo que adiciona um usuario ao banco de dados
        public void AddCliente(Cliente cliente)
        {

            this._contexto.Clientes.Add(cliente);
            this._contexto.SaveChanges();
        }

        //Metodo que adiciona um funcionario ao banco de Dados
        public void AddFuncionario(Funcionario funcionario)
        {

            this._contexto.Funcionarios.Add(funcionario);
            this._contexto.SaveChanges();
        }

        //Metodo que adiciona um metodo ao banco de dados
        public void AddNivel(Nivel nivel)
        {
            this._contexto.Niveis.Add(nivel);
            this._contexto.SaveChanges();
        }


    }
}
