using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lojinha.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Session;

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

            return View();
        }

        public IActionResult ContaUsuario(int id)
        {
            //Usuario usuario = this._usuarioServico.GetUsuarioId(id);
            return View(/*usuario*/);
        }

        public IActionResult VerificaSessao()
        {
            var sessao = this.HttpContext.Session.GetInt32("logado");
            if (sessao != null)
            {

                return RedirectToAction("/Home/Index");

            }
            else {
                return RedirectToAction("Login");
            }
        }

        public IActionResult FinalizaSessao()
        {
            HttpContext.Session.Clear();

            return Redirect("Login");

        }

        public IActionResult GerenciarUsuarios()
        {

            var lista = _usuarioServico.GetFuncionarios();

            ViewBag.Usuarios = lista;
            
            return View();

        }
        public IActionResult AutenticarLogin(string email,string senha)
        {

            Usuario usuario = this._usuarioServico.GetLogin(email, senha);


            if (usuario != null && usuario.Nivel == 1)
            {
                this.HttpContext.Session.SetInt32("logado", 1);

                 return RedirectToAction("Administrador",usuario);
            }
            if (usuario != null && usuario.Nivel == 2)
            {
                this.HttpContext.Session.SetInt32("logado", 1);
                
                return RedirectToAction("Gerencia");
            }
            if(usuario != null && usuario.Nivel == 0)
            {
                this.HttpContext.Session.SetInt32("logado", 1);
               
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return Redirect("Login");
            }
        }

        public IActionResult Gerencia()
        {
            return View();
        }
        public IActionResult Administrador()
        {
            return View();
        }
        public IActionResult AdicionaCliente
            (string nome, string email, string cpf, string senha,int nivel, string logradouro, string bairro, string complemento, string numero, string cidade, int estado)
        {

            Estado est = _enderecoServico.GetEstadoId(estado);
            Cidade cid = new Cidade(cidade, est);
            Endereco endereco = new Endereco(logradouro, bairro, complemento, numero, cid);

            Usuario usuario = new Usuario(nome, email, cpf, senha, nivel,endereco);
            
            _usuarioServico.AddUsuario(usuario);

            return Redirect("CadastroCliente");
        }
        public IActionResult AdicionaFuncionario
            (string nome, string email, string cpf, string senha, int nivel, string logradouro, string bairro, string complemento, string numero, string cidade, int estado)
        {

            Estado est = _enderecoServico.GetEstadoId(estado);
            Cidade cid = new Cidade(cidade, est);
            Endereco endereco = new Endereco(logradouro, bairro, complemento, numero, cid);

            Usuario usuario = new Usuario(nome, email, cpf, senha, nivel, endereco);

            _usuarioServico.AddUsuario(usuario);

            return Redirect("CadastroFuncionario");
        }
    }
}