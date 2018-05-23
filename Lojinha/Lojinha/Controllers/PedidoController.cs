using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lojinha.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lojinha.Controllers
{
    public class PedidoController : Controller
    {

        private readonly IDataService _dataService;


        public PedidoController(IDataService dataService)
        {
            this._dataService = dataService;
        }


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
        public IActionResult AdicionaProduto(string nome,string descricao,int quantidade,decimal valor,string arquivo, string categoria)
        {
            _dataService.AddProduto(nome,descricao,quantidade,valor,arquivo,categoria);
            return RedirectToAction("Index");
        }
    }
}