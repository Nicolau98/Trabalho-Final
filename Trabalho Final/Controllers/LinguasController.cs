using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Trabalho_Final.Data;
using Trabalho_Final.Models;

namespace Trabalho_Final.Controllers
{
    public class LinguasController : Controller
    {
        private readonly Trabalho_FinalContext _context;

        public LinguasController(Trabalho_FinalContext context)
        {
            _context = context;
        }

        [Authorize]
        // GET: Linguas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Lingua.ToListAsync());
        }

        // GET: Linguas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lingua = await _context.Lingua
                .FirstOrDefaultAsync(m => m.LinguaId == id);
            if (lingua == null)
            {
                return NotFound();
            }

            return View(lingua);
        }

        [Authorize]
        // GET: Linguas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Linguas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LinguaId,Nome,Coral,Leitura,Poral,Ioral,Escrita")] Lingua lingua)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lingua);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lingua);
        }

        // GET: Linguas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lingua = await _context.Lingua.FindAsync(id);
            if (lingua == null)
            {
                return NotFound();
            }
            return View(lingua);
        }

        // POST: Linguas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LinguaId,Nome,Coral,Leitura,Poral,Ioral,Escrita")] Lingua lingua)
        {
            if (id != lingua.LinguaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lingua);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LinguaExists(lingua.LinguaId))
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
            return View(lingua);
        }

        // GET: Linguas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lingua = await _context.Lingua
                .FirstOrDefaultAsync(m => m.LinguaId == id);
            if (lingua == null)
            {
                return NotFound();
            }

            return View(lingua);
        }

        // POST: Linguas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lingua = await _context.Lingua.FindAsync(id);
            _context.Lingua.Remove(lingua);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LinguaExists(int id)
        {
            return _context.Lingua.Any(e => e.LinguaId == id);
        }
    }
}
