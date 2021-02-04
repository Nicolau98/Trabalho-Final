using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trabalho_Final.Models;
using Trabalho_Final.Data;

namespace Trabalho_Final.Controllers
{
    public class CurriculoController : Controller
    {
        public List<Experiencia> Experiencias { get; internal set; }

        public IActionResult Index()
        {
            return base.View();
        }
    }
}
