using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ListaTelefonica.Models.Contexto;


namespace ListaTelefonica.Controllers
{
    public class TelefonesController : Controller
    {
        private readonly Contexto _contexto;
        public TelefonesController(Contexto contexto)
        {
            _contexto = contexto;

        }
        public IActionResult Index()
        {
            var lista = _contexto.Telefones.ToList();
            return View(lista);
        }
    }
}
