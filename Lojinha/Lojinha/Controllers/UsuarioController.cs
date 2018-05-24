using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lojinha.Controllers
{
    public class UsuarioController : Controller
    {
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
    }
}