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
        [HttpGet]
        public IActionResult Create()
        {
            var telefones = new Telefones();
            CarregaTipoTelefone();
         
            return View(telefones);
        }

        [HttpPost]
        public IActionResult Create(Telefones telefones)
        {
            if (ModelState.IsValid)
            {
                _contexto.Telefones.Add(telefones);
                _contexto.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(telefones);
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var telefones = _contexto.Contato.Find(Id);
            if (telefones != null)
            {
            }
            CarregaTipoTelefone();
            return View(telefones);
        }

        [HttpPost]
        public IActionResult Edit(Telefones telefones)
        {
            if (ModelState.IsValid)
            {
                _contexto.Telefones.Update(telefones);
                _contexto.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(telefones);
            }
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var telefones = _contexto.Telefones.Find(Id);
            CarregaTipoTelefone();
            return View(telefones);
        }

        [HttpPost]
        public IActionResult Delete(Telefones _telefones)
        {
            var telefones = _contexto.Telefones.Find(_telefones.Id);
            if (telefones != null)
            {
                _contexto.Telefones.Remove(telefones);
                _contexto.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(telefones);
        }

        [HttpGet]
        public IActionResult Details(int Id)
        {
            var telefones = _contexto.Telefones.Find(Id);
            CarregaTipoTelefone();
            return View(telefones);
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
