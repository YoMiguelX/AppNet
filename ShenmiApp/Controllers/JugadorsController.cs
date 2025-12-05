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
    public class JugadorsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public JugadorsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Jugadors
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Jugador.Include(j => j.ProgresoJugadorIdProgresoJugadorNavigation);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Jugadors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jugador = await _context.Jugador
                .Include(j => j.ProgresoJugadorIdProgresoJugadorNavigation)
                .FirstOrDefaultAsync(m => m.IdJugador == id);
            if (jugador == null)
            {
                return NotFound();
            }

            return View(jugador);
        }

        // GET: Jugadors/Create
        public IActionResult Create()
        {
            ViewData["ProgresoJugadorIdProgresoJugador"] = new SelectList(_context.ProgresoJugador, "IdProgresoJugador", "IdProgresoJugador");
            return View();
        }

        // POST: Jugadors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdJugador,Nombre,FechaRegistro,UltimaConexion,ProgresoJugadorIdProgresoJugador,UsuarioIdUsuario")] Jugador jugador)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jugador);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProgresoJugadorIdProgresoJugador"] = new SelectList(_context.ProgresoJugador, "IdProgresoJugador", "IdProgresoJugador", jugador.ProgresoJugadorIdProgresoJugador);
            return View(jugador);
        }

        // GET: Jugadors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jugador = await _context.Jugador.FindAsync(id);
            if (jugador == null)
            {
                return NotFound();
            }
            ViewData["ProgresoJugadorIdProgresoJugador"] = new SelectList(_context.ProgresoJugador, "IdProgresoJugador", "IdProgresoJugador", jugador.ProgresoJugadorIdProgresoJugador);
            return View(jugador);
        }

        // POST: Jugadors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdJugador,Nombre,FechaRegistro,UltimaConexion,ProgresoJugadorIdProgresoJugador,UsuarioIdUsuario")] Jugador jugador)
        {
            if (id != jugador.IdJugador)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jugador);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JugadorExists(jugador.IdJugador))
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
            ViewData["ProgresoJugadorIdProgresoJugador"] = new SelectList(_context.ProgresoJugador, "IdProgresoJugador", "IdProgresoJugador", jugador.ProgresoJugadorIdProgresoJugador);
            return View(jugador);
        }

        // GET: Jugadors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jugador = await _context.Jugador
                .Include(j => j.ProgresoJugadorIdProgresoJugadorNavigation)
                .FirstOrDefaultAsync(m => m.IdJugador == id);
            if (jugador == null)
            {
                return NotFound();
            }

            return View(jugador);
        }

        // POST: Jugadors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jugador = await _context.Jugador.FindAsync(id);
            if (jugador != null)
            {
                _context.Jugador.Remove(jugador);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JugadorExists(int id)
        {
            return _context.Jugador.Any(e => e.IdJugador == id);
        }
    }
}
