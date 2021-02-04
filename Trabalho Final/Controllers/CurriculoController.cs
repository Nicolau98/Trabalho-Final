using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trabalho_Final.Models;
using Trabalho_Final.Data;
using Microsoft.EntityFrameworkCore;

namespace Trabalho_Final.Controllers
{
    public class CurriculoController : Controller
    {
        private readonly Trabalho_FinalContext _context;

        public CurriculoController(Trabalho_FinalContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> IndexAsync()
        {
            List<Experiencia> Experiencias = await _context.Experiencia.ToListAsync();

            List<Educacao> Educacaos = await _context.Educacao.ToListAsync();

            List<Lingua> Linguas = await _context.Lingua.ToListAsync();

            List<CartaConducao> CartaConducaos = await _context.CartaConducao.ToListAsync();

            Curriculo modelo = new Curriculo
            {

                Experiencias = Experiencias,
                Educacaos = Educacaos,
                Linguas = Linguas,
                CartaConducaos = CartaConducaos,
            };

            return View(modelo);


            
        }
    }
}
