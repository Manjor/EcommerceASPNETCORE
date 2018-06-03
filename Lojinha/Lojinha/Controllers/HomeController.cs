using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lojinha.Models;
using Microsoft.AspNetCore.Http;

namespace Lojinha.Controllers
{
    public class HomeController : Controller
    {

        
        private readonly IDataService _dataService;


        public HomeController(IDataService dataService)
        {
            this._dataService = dataService;
        }



        public IActionResult Index()
        {

            IList<Produto> produtos = this._dataService.GetProdutos();

            ViewBag.Produtos = produtos;

            return View();

        }
        public IActionResult ProdutoCategoria(string nomecategoria)
        {
            if (nomecategoria.Equals(null))
            {
                IList<Produto> produtosGerais = this._dataService.GetProdutos();
                ViewBag.Produtos = produtosGerais;
                return View();
            }
            else
            {
                IList<Produto> produtos = this._dataService.ProdutosCategoria(nomecategoria);
                ViewBag.Produtos = produtos;
                return View();
            }
        }
        
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
