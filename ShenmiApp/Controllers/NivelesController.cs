using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShenmiApp.Data;
using ShenmiApp.Models;

namespace ShenmiApp.Controllers
{
    public class NivelesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NivelesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Niveles
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Niveles.Include(n => n.MundosIdMundosNavigation);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Niveles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var niveles = await _context.Niveles
                .Include(n => n.MundosIdMundosNavigation)
                .FirstOrDefaultAsync(m => m.IdNiveles == id);
            if (niveles == null)
            {
                return NotFound();
            }

            return View(niveles);
        }

        // GET: Niveles/Create
        public IActionResult Create()
        {
            ViewData["MundosIdMundos"] = new SelectList(_context.Set<Mundos>(), "IdMundos", "IdMundos");
            return View();
        }

        // POST: Niveles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdNiveles,NombreNivel,Descripcion,PuntajeMinimo,PuntajeMaximo,Completado,MundosIdMundos,PreguntasIdPreguntas")] Niveles niveles)
        {
            if (ModelState.IsValid)
            {
                _context.Add(niveles);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MundosIdMundos"] = new SelectList(_context.Set<Mundos>(), "IdMundos", "IdMundos", niveles.MundosIdMundos);
            return View(niveles);
        }

        // GET: Niveles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var niveles = await _context.Niveles.FindAsync(id);
            if (niveles == null)
            {
                return NotFound();
            }
            ViewData["MundosIdMundos"] = new SelectList(_context.Set<Mundos>(), "IdMundos", "IdMundos", niveles.MundosIdMundos);
            return View(niveles);
        }

        // POST: Niveles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdNiveles,NombreNivel,Descripcion,PuntajeMinimo,PuntajeMaximo,Completado,MundosIdMundos,PreguntasIdPreguntas")] Niveles niveles)
        {
            if (id != niveles.IdNiveles)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(niveles);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NivelesExists(niveles.IdNiveles))
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
            ViewData["MundosIdMundos"] = new SelectList(_context.Set<Mundos>(), "IdMundos", "IdMundos", niveles.MundosIdMundos);
            return View(niveles);
        }

        // GET: Niveles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var niveles = await _context.Niveles
                .Include(n => n.MundosIdMundosNavigation)
                .FirstOrDefaultAsync(m => m.IdNiveles == id);
            if (niveles == null)
            {
                return NotFound();
            }

            return View(niveles);
        }

        // POST: Niveles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var niveles = await _context.Niveles.FindAsync(id);
            if (niveles != null)
            {
                _context.Niveles.Remove(niveles);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NivelesExists(int id)
        {
            return _context.Niveles.Any(e => e.IdNiveles == id);
        }
    }
}
