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

        private readonly IServicosUsuario _usuarioServico;
        private readonly IServicosEndereco _enderecoServico;
        public UsuarioController(IServicosUsuario servicosUsuario, IServicosEndereco enderecoServico)
        {
            this._usuarioServico = servicosUsuario;
            this._enderecoServico = enderecoServico;
        }
       

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult CadastroCliente()
        {

            IList<Estado> estados = this._enderecoServico.GetEstados();
            ViewBag.Estados = estados;

            return View();
        }
        public IActionResult CadastroFuncionario()
        {
            IList<Estado> estados = this._enderecoServico.GetEstados();
            ViewBag.Estados = estados;

            IList<Nivel> niveis = this._usuarioServico.GetNivels();
            ViewBag.Niveis = niveis;
            return View();
        }

        public IActionResult GerenciarUsuarios()
        {

            IList<Funcionario> funcionarios = this._usuarioServico.GetFuncionarios();
            return View();
        }

        public IActionResult ContaUsuario()
        {
            return View();
        }

        public IActionResult AdicionaCliente
            (string nome, string email, string cpf, string senha, string logradouro, string bairro, string complemento, string numero, string cidade, int estado)
        {

            Usuario usuario = new Usuario(nome, email, cpf, senha);

            Estado est = _enderecoServico.GetEstadoId(estado);
            Cidade cid = new Cidade(cidade, est);
            Endereco endereco = new Endereco(logradouro, bairro, complemento, numero, cid);


            Cliente cliente = new Cliente(usuario, endereco);
            _usuarioServico.AddCliente(cliente);

            return Redirect("CadastroCliente");
        }
    }
}