using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lojinha.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lojinha.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IDataService _dataService;


        public ProdutoController(IDataService dataService)
        {
            this._dataService = dataService;
        }

        public IActionResult CadastroProduto()
        {
            IList<Categoria> categorias = this._dataService.GetCategoria();

            ViewBag.Categorias = categorias;

            return View();
            
        }
        //Metodo de remoção de produto
        public IActionResult RemoveProduto(int id)
        {
            this._dataService.RemoveProduto(id);

            return Redirect("GerenciarProdutos");
        }

        public IActionResult AlteraProduto(int id)
        {
            Produto p = this._dataService.GetProdutoId(id);
            IList<Categoria> categorias = this._dataService.GetCategoria();
            ViewBag.Categorias = categorias;
            ViewBag.Id = id;
            ViewBag.Produto = p;
            return View(id);
        }

        public IActionResult Alterar(int id, string nome, string descricao,
            int quantidade, decimal valor, string arquivo, int categoria)
        {
            Categoria cat = this._dataService.GetCategoriaId(categoria);
            Produto produto = new Produto(nome, descricao, quantidade, valor, arquivo, cat);

            this._dataService.AlteraProduto(id, produto);

            return RedirectToAction("GerenciarProdutos");
        }
        public IActionResult GerenciarProdutos()
        {


            IList<Produto> produtos = this._dataService.GetProdutos();
            ViewBag.Produtos = produtos;

            return View();

        }

       
        public IActionResult AdicionaProduto(string nome, string descricao, int quantidade, decimal valor, string arquivo, int categoria)
        {
            Categoria cat = this._dataService.GetCategoriaId(categoria);
            Produto produto = new Produto(nome, descricao, quantidade, valor, arquivo, cat);

            _dataService.AddProduto(produto);
            
            return RedirectToAction("CadastroProduto");
        }

        
    }
}