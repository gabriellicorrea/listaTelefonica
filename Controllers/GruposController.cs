using System;
using System.Collections.Generic;
using ListaTelefonica.Models.Contexto;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ListaTelefonica.Models.Entidades;

namespace ListaTelefonica.Controllers
{
    public class GruposController : Controller
    {
        private readonly Contexto _contexto;

        public GruposController(Contexto contexto)
        {
            _contexto = contexto;
        }
        public IActionResult Index()
        {

            var lista = _contexto.Grupo.ToList();
            return View(lista);
           
        }

        [HttpGet]
        public IActionResult Create()
        {
            var grupo = new Grupo();

            return View(grupo);
        }

        [HttpPost]
        public IActionResult Create(Grupo grupo)
        {
            if (ModelState.IsValid)
            {
                _contexto.Grupo.Add(grupo);
                _contexto.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(grupo);
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var grupo = _contexto.Contato.Find(Id);
            if (grupo != null)
            {
            }
            return View(grupo);
        }

        [HttpPost]
        public IActionResult Edit(Grupo grupo)
        {
            if (ModelState.IsValid)
            {
                _contexto.Grupo.Update(grupo);
                _contexto.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(grupo);
            }
        }
    }
}
