using LifeDental.Data;
using LifeDental.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifeDental.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly ClienteContext _clienteContext;

        public ProdutoController(ClienteContext clienteContext)
        {
            _clienteContext = clienteContext;
        }
        public IActionResult Index()
        {
            var lista = _clienteContext.Produtos.ToList();
            return View(lista);
        }

        [HttpGet]
        public IActionResult GerarProduto()
        {
            CarregaCategoria();
            var produto = new Produto();
            return View(produto);
        }
        
        [HttpPost]
        public IActionResult GerarProduto(Produto produto)
        {
            if (ModelState.IsValid)
            {
                _clienteContext.Add(produto);
                _clienteContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            else return View(produto);
        }

        [HttpGet]
        public IActionResult Atualizar(int? Id)
        {
            if (Id != null)
            {
                CarregaCategoria();
                Produto produto = _clienteContext.Produtos.Find(Id);
                return View(produto);
            }
            else return NotFound();
        }
        [HttpPost]
        public IActionResult Atualizar(int? Id, Produto produto)
        {
            if (Id != null)
            {
                _clienteContext.Update(produto);
                _clienteContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            else return NotFound();
        }

        [HttpGet]
        public IActionResult Excluir(int? Id)
        {
            if (Id != null)
            {
                CarregaCategoria();
                Produto produto = _clienteContext.Produtos.Find(Id);
                return View(produto);
            }
            else return NotFound();

        }

        [HttpPost]
        public IActionResult Excluir(int? Id, Produto produto)
        {
            if (Id != null)
            {
                _clienteContext.Remove(produto);
                _clienteContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            else return NotFound();
        }

        
        public void CarregaCategoria()
        {
            var CategoriaItem = new List<SelectListItem>
            {
                new SelectListItem {Value ="1", Text ="Superior"},
                new SelectListItem { Value = "2", Text = "Super Luxuoso" },
                new SelectListItem { Value = "3", Text = "Moderno" },
                new SelectListItem { Value = "4", Text = "Nerd e Geek" },
                new SelectListItem { Value = "5", Text = "Infantil" },
                new SelectListItem { Value = "6", Text = "Robusto" },
                new SelectListItem { Value = "7", Text = "Usado" },
                new SelectListItem { Value = "8", Text = "Couro" },
                new SelectListItem { Value = "9", Text = "Madeira" },
            };

            ViewBag.categoria = CategoriaItem;
           
        }

    }
}
