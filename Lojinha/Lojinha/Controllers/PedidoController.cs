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
        public IActionResult AdicionaProduto(string nome,string descricao,int quantidade,decimal valor,string arquivo, int categoria)
        {

            Produto produto = new Produto(nome, descricao, quantidade, valor, arquivo, _dataService.GetCategoriaId(categoria));
            _dataService.AddProduto(produto);

            return RedirectToAction("Index");
        }
    }
}