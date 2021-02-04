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
    public class ApresentacaosController : Controller
    {
        private readonly Trabalho_FinalContext _context;

        public ApresentacaosController(Trabalho_FinalContext context)
        {
            _context = context;
        }

        // GET: Apresentacaos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Apresentacao.ToListAsync());
        }

        // GET: Apresentacaos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var apresentacao = await _context.Apresentacao
                .FirstOrDefaultAsync(m => m.ApresentacaoId == id);
            if (apresentacao == null)
            {
                return NotFound();
            }

            return View(apresentacao);
        }

        // GET: Apresentacaos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Apresentacaos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ApresentacaoId,Nome,Nascimento,Morada,Texto,Foto")] Apresentacao apresentacao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(apresentacao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(apresentacao);
        }

        // GET: Apresentacaos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var apresentacao = await _context.Apresentacao.FindAsync(id);
            if (apresentacao == null)
            {
                return NotFound();
            }
            return View(apresentacao);
        }

        // POST: Apresentacaos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ApresentacaoId,Nome,Nascimento,Morada,Texto,Foto")] Apresentacao apresentacao)
        {
            if (id != apresentacao.ApresentacaoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(apresentacao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ApresentacaoExists(apresentacao.ApresentacaoId))
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
            return View(apresentacao);
        }

        // GET: Apresentacaos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var apresentacao = await _context.Apresentacao
                .FirstOrDefaultAsync(m => m.ApresentacaoId == id);
            if (apresentacao == null)
            {
                return NotFound();
            }

            return View(apresentacao);
        }

        // POST: Apresentacaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var apresentacao = await _context.Apresentacao.FindAsync(id);
            _context.Apresentacao.Remove(apresentacao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ApresentacaoExists(int id)
        {
            return _context.Apresentacao.Any(e => e.ApresentacaoId == id);
        }
    }
}
