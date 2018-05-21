using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lojinha.Controllers
{
    public class PedidoController : Controller
    {
        public IActionResult Carrinho()
        {
            return View();
        }
        public IActionResult Cadastro()
        {
            return View();
        }
        public IActionResult Resumo()
        {
            return View();
        }
    }
}