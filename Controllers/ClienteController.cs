using LifeDental.Data;
using LifeDental.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace LifeDental.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ClienteContext _clienteContext;

        public ClienteController(ClienteContext clienteContext)
        {
            _clienteContext = clienteContext;
        }
        public IActionResult Index()
        {
            var lista = _clienteContext.Clientes.ToList();
             return View(lista);
        }

        [HttpGet]
        public IActionResult GerarCliente()
        {
            var cliente = new Cliente();
            return View(cliente);
        }

        [HttpPost]
        public  IActionResult GerarCliente(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                 _clienteContext.Add(cliente);
                 _clienteContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            else return View(cliente);
        }

        [HttpGet]
        public IActionResult Atualizar(int? Id)
        {
            if (Id != null)
            {
                Cliente cliente = _clienteContext.Clientes.Find(Id);
                return View(cliente);
            }
            else return NotFound();
        }
        [HttpPost]
        public  IActionResult Atualizar(int? Id, Cliente cliente)
        {
            if (Id != null)
            {
                _clienteContext.Update(cliente);
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
                Cliente cliente = _clienteContext.Clientes.Find(Id);
                return View(cliente);
            }
            else return NotFound();

        }

        [HttpPost]
        public  IActionResult Excluir(int? Id, Cliente cliente)
        {
            if (Id != null)
            {
                _clienteContext.Remove(cliente);
                _clienteContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            else return NotFound();
        }

    }
}


