using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ListaTelefonica.Controllers
{
    public class TelefonesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
