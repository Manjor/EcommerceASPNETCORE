using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lojinha.Controllers
{
    public class ContaController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult CadastroUsuario()
        {
            return View();
        }
        public IActionResult MinhaConta()
        {
            return View();
        }
    }
}