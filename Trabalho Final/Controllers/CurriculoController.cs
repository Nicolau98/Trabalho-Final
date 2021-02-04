using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trabalho_Final.Models;

namespace Trabalho_Final.Controllers
{
    public class CurriculoController : Controller
    {
        public List<Experiencia> Experiencia { get; internal set; }

        public IActionResult Index()
        {
            return View();
        }
    }
}
