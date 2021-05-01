using LifeDental.Data;
using LifeDental.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifeDental.Controllers
{
    public class RegistroController : Controller
    {
        private readonly ClienteContext _clienteContext;

        public RegistroController(ClienteContext clienteContext)
        {
            _clienteContext = clienteContext;
        }
        public IActionResult Index()
        {
            var lista = _clienteContext.Registros.ToList();
            return View(lista);
        }

    }
}