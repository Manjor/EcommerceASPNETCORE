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


        




        List<Produto> produtos = new List<Produto>
        {
            new Produto(
                "Placa Mae Teste",
                "Tesde de Placa",
                120,
                300.00m,
                "Sem Arquivo até agora",
                
                )
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
        public IActionResult AdicionaProduto(Produto produto)
        {
            return 0;
        }
    }
}