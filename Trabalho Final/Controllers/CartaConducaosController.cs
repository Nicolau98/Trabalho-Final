using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Trabalho_Final.Data;
using Trabalho_Final.Models;

namespace Trabalho_Final.Controllers
{
    public class CartaConducaosController : Controller
    {
        private readonly Trabalho_FinalContext _context;

        public CartaConducaosController(Trabalho_FinalContext context)
        {
            _context = context;
        }

        // GET: CartaConducaos
        public async Task<IActionResult> Index()
        {
            return View(await _context.CartaConducao.ToListAsync());
        }

        // GET: CartaConducaos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartaConducao = await _context.CartaConducao
                .FirstOrDefaultAsync(m => m.CartaConducaoId == id);
            if (cartaConducao == null)
            {
                return NotFound();
            }

            return View(cartaConducao);
        }

        // GET: CartaConducaos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CartaConducaos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CartaConducaoId,Tipo")] CartaConducao cartaConducao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cartaConducao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cartaConducao);
        }

        // GET: CartaConducaos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartaConducao = await _context.CartaConducao.FindAsync(id);
            if (cartaConducao == null)
            {
                return NotFound();
            }
            return View(cartaConducao);
        }

        // POST: CartaConducaos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CartaConducaoId,Tipo")] CartaConducao cartaConducao)
        {
            if (id != cartaConducao.CartaConducaoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cartaConducao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CartaConducaoExists(cartaConducao.CartaConducaoId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(cartaConducao);
        }

        // GET: CartaConducaos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartaConducao = await _context.CartaConducao
                .FirstOrDefaultAsync(m => m.CartaConducaoId == id);
            if (cartaConducao == null)
            {
                return NotFound();
            }

            return View(cartaConducao);
        }

        // POST: CartaConducaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cartaConducao = await _context.CartaConducao.FindAsync(id);
            _context.CartaConducao.Remove(cartaConducao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CartaConducaoExists(int id)
        {
            return _context.CartaConducao.Any(e => e.CartaConducaoId == id);
        }
    }
}
