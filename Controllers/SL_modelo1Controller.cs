using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SebastianLargo_Examen1P.Data;
using SebastianLargo_Examen1P.Models;

namespace SebastianLargo_Examen1P.Controllers
{
    public class SL_modelo1Controller : Controller
    {
        private readonly SebastianLargo_Examen1PContext _context;

        public SL_modelo1Controller(SebastianLargo_Examen1PContext context)
        {
            _context = context;
        }

        // GET: SL_modelo1
        public async Task<IActionResult> Index()
        {
            return View(await _context.SL_modelo1.ToListAsync());
        }

        // GET: SL_modelo1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sL_modelo1 = await _context.SL_modelo1
                .FirstOrDefaultAsync(m => m.SLPerfilID == id);
            if (sL_modelo1 == null)
            {
                return NotFound();
            }

            return View(sL_modelo1);
        }

        // GET: SL_modelo1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SL_modelo1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SLPerfilID,SLDecimal,SLNombre,SLCaracter,Fecha")] SL_modelo1 sL_modelo1)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sL_modelo1);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sL_modelo1);
        }

        // GET: SL_modelo1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sL_modelo1 = await _context.SL_modelo1.FindAsync(id);
            if (sL_modelo1 == null)
            {
                return NotFound();
            }
            return View(sL_modelo1);
        }

        // POST: SL_modelo1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SLPerfilID,SLDecimal,SLNombre,SLCaracter,Fecha")] SL_modelo1 sL_modelo1)
        {
            if (id != sL_modelo1.SLPerfilID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sL_modelo1);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SL_modelo1Exists(sL_modelo1.SLPerfilID))
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
            return View(sL_modelo1);
        }

        // GET: SL_modelo1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sL_modelo1 = await _context.SL_modelo1
                .FirstOrDefaultAsync(m => m.SLPerfilID == id);
            if (sL_modelo1 == null)
            {
                return NotFound();
            }

            return View(sL_modelo1);
        }

        // POST: SL_modelo1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sL_modelo1 = await _context.SL_modelo1.FindAsync(id);
            if (sL_modelo1 != null)
            {
                _context.SL_modelo1.Remove(sL_modelo1);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SL_modelo1Exists(int id)
        {
            return _context.SL_modelo1.Any(e => e.SLPerfilID == id);
        }
    }
}
