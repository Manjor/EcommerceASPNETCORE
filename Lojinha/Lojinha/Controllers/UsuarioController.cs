using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lojinha.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lojinha.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IServicosUsuario _servicosUsuarios;
        private readonly IServicosEnderecos _servicosEnderecos;


        public UsuarioController(IServicosUsuario servicosUsuario , IServicosEnderecos servicosEnderecos)
        {
            this._servicosUsuarios = servicosUsuario;
            this._servicosEnderecos = servicosEnderecos;
        }


        public IActionResult GerenciarUsuario()
        {
            return View();
        }

        public IActionResult CadastroCliente()
        {
            return View();
        }

        public IActionResult CadastroFuncionario()
        {
            return View();
        }
        public IActionResult ContaUsuario()
        {
            return View();
        }
        public IActionResult AdicionaCliente(string nome,string email,string cpf,string senha,string logradouro, string bairro,string complemento, string numero,string cidade,int estado)
        {

            
            Usuario usuario = new Usuario(nome, email, cpf, senha);
            
            Estado est = _servicosEnderecos.GetEstadoId(estado);
            Cidade cid = new Cidade(cidade, est);
            Endereco endereco = new Endereco(logradouro, bairro, complemento, numero, cid);


            Cliente cliente = new Cliente(usuario,endereco);
            _servicosUsuarios.AddCliente(cliente);

            return Redirect("Carrinho");





        }
    }
}