using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming;
using ListaTelefonica.Models.Contexto;
using ListaTelefonica.Models.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ListaTelefonica.Controllers
{
    public class ContatosController : Controller
    {
        private readonly Contexto _contexto;
        public ContatosController(Contexto contexto)
        {
            _contexto = contexto;

        }
        public IActionResult Index()
        {
          var lista =  _contexto.Contato.ToList();
            CarregaTipoTelefone();
            return View(lista);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var contato = new Contato();
            CarregaTipoTelefone();
            return View(contato);
        }

        [HttpPost]
        public IActionResult Create(Contato contato)
        {
            if(ModelState.IsValid)
            {
                _contexto.Contato.Add(contato);
                _contexto.SaveChanges();
                
                return RedirectToAction("index");
            }

            return View(contato);
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var contato = _contexto.Contato.Find(Id);
            if(contato != null)
            {
            }
            CarregaTipoTelefone();
            return View(contato);
        }

        [HttpPost]
        public IActionResult Edit(Contato contato)
        {
            if (ModelState.IsValid)
            {
                _contexto.Contato.Update(contato);
                _contexto.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(contato);
            }
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var contato = _contexto.Contato.Find(Id);
            CarregaTipoTelefone();
            return View(contato);
        }

        [HttpPost]
        public IActionResult Delete(Contato _contato)
        {
            var contato = _contexto.Contato.Find(_contato.Id);
            if (contato != null)
            {
                _contexto.Contato.Remove(contato);
                _contexto.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(contato);
        }

        [HttpGet]
        public IActionResult Details(int Id)
        {
            var contato = _contexto.Contato.Find(Id);
            CarregaTipoTelefone();
            return View(contato);
        }

        public void CarregaTipoTelefone()
        {
            var ItensTipoTelefone = new List<SelectListItem>
            {
                new SelectListItem{ Value = "Celular", Text = "Celular" },
                new SelectListItem{ Value = "Tefelone", Text = "Telefone Fixo" }
            };
            ViewBag.TipoTelefone = ItensTipoTelefone;
        }

    }

}
