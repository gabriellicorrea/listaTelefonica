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
            CarregaEstado();
            return View(lista);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var contato = new Contato();
            CarregaTipoTelefone();
            CarregaEstado();
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
            CarregaEstado();
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
            CarregaEstado();
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
            CarregaEstado();
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
        public void CarregaEstado()
        {
            var ItensCidade = new List<SelectListItem>
            {
                new SelectListItem{ Value = "AC", Text = "Acre" },
                new SelectListItem{ Value = "AL", Text = "Alagoas" },
                new SelectListItem{ Value = "AP", Text = "Amapa" },
                new SelectListItem{ Value = "AM", Text = "Amazonas" },
                new SelectListItem{ Value = "BA", Text = "Bahia" },
                new SelectListItem{ Value = "CE", Text = "Ceará" },
                new SelectListItem{ Value = "DF", Text = "Distrito Federal" },
                new SelectListItem{ Value = "ES", Text = "Espírito Santo" },
                new SelectListItem{ Value = "GO", Text = "Goiás" },
                new SelectListItem{ Value = "MA", Text = "Maranhão" },
                new SelectListItem{ Value = "MT", Text = "Mato Grosso" },
                new SelectListItem{ Value = "MS", Text = "Mato Grosso do Sul" },
                new SelectListItem{ Value = "MG", Text = "Minas Gerais" },
                new SelectListItem{ Value = "PA", Text = "Pará" },
                new SelectListItem{ Value = "PB", Text = "Paraíba" },
                new SelectListItem{ Value = "PR", Text = "Paraná" },
                new SelectListItem{ Value = "PE", Text = "Pernambuco" },
                new SelectListItem{ Value = "PI", Text = "Piauí" },
                new SelectListItem{ Value = "RJ", Text = "Rio de Janeiro" },
                new SelectListItem{ Value = "RN", Text = "Rio Grande do Norte" },
                new SelectListItem{ Value = "RS", Text = "Rio Grande do Sul" },
                new SelectListItem{ Value = "RO", Text = "Rondônia" },
                new SelectListItem{ Value = "RR", Text = "Roraima" },
                new SelectListItem{ Value = "SC", Text = "Santa Catarina" },
                new SelectListItem{ Value = "SP", Text = "São Paulo" },
                new SelectListItem{ Value = "SE", Text = "Sergipe" },
                new SelectListItem{ Value = "TO", Text = "Tocantins" }
                

            };
            ViewBag.Cidade = ItensCidade;
        }
    }

}
