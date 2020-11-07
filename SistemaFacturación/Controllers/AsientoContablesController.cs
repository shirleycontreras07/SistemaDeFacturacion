using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SistemaFacturación.Data;
using SistemaFacturación.Models.FacturacionModels;

namespace SistemaFacturación.Controllers
{
    public class AsientoContablesController : Controller
    {
        private readonly FacturacionDbContext _context;

        public AsientoContablesController(FacturacionDbContext context)
        {
            _context = context;
        }

        // GET: AsientoContables
        public async Task<IActionResult> Index()
        {
            var facturacionDbContext = _context.AsientoContables.Include(a => a.Cliente).Include(a => a.TipoMovimiento);
            return View(await facturacionDbContext.ToListAsync());
        }

        // GET: AsientoContables/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var asientoContable = await _context.AsientoContables
                .Include(a => a.Cliente)
                .Include(a => a.TipoMovimiento)
                .FirstOrDefaultAsync(m => m.IdAsiento == id);
            if (asientoContable == null)
            {
                return NotFound();
            }

            return View(asientoContable);
        }

        // GET: AsientoContables/Create
        public IActionResult Create()
        {
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "IdCliente", "Nombre");
            ViewData["IdTipoMovimiento"] = new SelectList(_context.TipoMovimientos, "IdTipoMovimiento", "Descripcion");
            return View();
        }

        // POST: AsientoContables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdAsiento,Descripción,IdCliente,Cuenta,IdTipoMovimiento,Fecha,MontoAsiento,Estado")] AsientoContable asientoContable)
        {
            if (ModelState.IsValid)
            {
                _context.Add(asientoContable);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "IdCliente", "Nombre", asientoContable.IdCliente);
            ViewData["IdTipoMovimiento"] = new SelectList(_context.TipoMovimientos, "IdTipoMovimiento", "Descripcion", asientoContable.IdTipoMovimiento);
            return View(asientoContable);
        }

        // GET: AsientoContables/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var asientoContable = await _context.AsientoContables.FindAsync(id);
            if (asientoContable == null)
            {
                return NotFound();
            }
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "IdCliente", "Nombre", asientoContable.IdCliente);
            ViewData["IdTipoMovimiento"] = new SelectList(_context.TipoMovimientos, "IdTipoMovimiento", "Descripcion", asientoContable.IdTipoMovimiento);
            return View(asientoContable);
        }

        // POST: AsientoContables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdAsiento,Descripción,IdCliente,Cuenta,IdTipoMovimiento,Fecha,MontoAsiento,Estado")] AsientoContable asientoContable)
        {
            if (id != asientoContable.IdAsiento)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(asientoContable);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AsientoContableExists(asientoContable.IdAsiento))
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
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "IdCliente", "Nombre", asientoContable.IdCliente);
            ViewData["IdTipoMovimiento"] = new SelectList(_context.TipoMovimientos, "IdTipoMovimiento", "Descripcion", asientoContable.IdTipoMovimiento);
            return View(asientoContable);
        }

        // GET: AsientoContables/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var asientoContable = await _context.AsientoContables
                .Include(a => a.Cliente)
                .Include(a => a.TipoMovimiento)
                .FirstOrDefaultAsync(m => m.IdAsiento == id);
            if (asientoContable == null)
            {
                return NotFound();
            }

            return View(asientoContable);
        }

        // POST: AsientoContables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var asientoContable = await _context.AsientoContables.FindAsync(id);
            _context.AsientoContables.Remove(asientoContable);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AsientoContableExists(int id)
        {
            return _context.AsientoContables.Any(e => e.IdAsiento == id);
        }
    }
}
