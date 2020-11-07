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
    public class DetalleFacturasController : Controller
    {
        private readonly FacturacionDbContext _context;

        public DetalleFacturasController(FacturacionDbContext context)
        {
            _context = context;
        }

        // GET: DetalleFacturas
        public async Task<IActionResult> Index()
        {
            var facturacionDbContext = _context.DetalleFacturas.Include(d => d.Articulo).Include(d => d.Facturacion);
            return View(await facturacionDbContext.ToListAsync());
        }

        // GET: DetalleFacturas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalleFactura = await _context.DetalleFacturas
                .Include(d => d.Articulo)
                .Include(d => d.Facturacion)
                .FirstOrDefaultAsync(m => m.IdDetalleFactura == id);
            if (detalleFactura == null)
            {
                return NotFound();
            }

            return View(detalleFactura);
        }

        // GET: DetalleFacturas/Create
        public IActionResult Create()
        {
            ViewData["IdArticulo"] = new SelectList(_context.Articulos, "IdArticulo", "Descripcion");
            ViewData["IdFactura"] = new SelectList(_context.Facturaciones, "IdFactura", "IdFactura");
            return View();
        }

        // POST: DetalleFacturas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdDetalleFactura,IdArticulo,Cantidad,IdFactura,Precio,Estado")] DetalleFactura detalleFactura)
        {
            if (ModelState.IsValid)
            {
                _context.Add(detalleFactura);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdArticulo"] = new SelectList(_context.Articulos, "IdArticulo", "Descripcion", detalleFactura.IdArticulo);
            ViewData["IdFactura"] = new SelectList(_context.Facturaciones, "IdFactura", "IdFactura", detalleFactura.IdFactura);
            return View(detalleFactura);
        }

        // GET: DetalleFacturas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalleFactura = await _context.DetalleFacturas.FindAsync(id);
            if (detalleFactura == null)
            {
                return NotFound();
            }
            ViewData["IdArticulo"] = new SelectList(_context.Articulos, "IdArticulo", "Descripcion", detalleFactura.IdArticulo);
            ViewData["IdFactura"] = new SelectList(_context.Facturaciones, "IdFactura", "IdFactura", detalleFactura.IdFactura);
            return View(detalleFactura);
        }

        // POST: DetalleFacturas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdDetalleFactura,IdArticulo,Cantidad,IdFactura,Precio,Estado")] DetalleFactura detalleFactura)
        {
            if (id != detalleFactura.IdDetalleFactura)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(detalleFactura);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DetalleFacturaExists(detalleFactura.IdDetalleFactura))
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
            ViewData["IdArticulo"] = new SelectList(_context.Articulos, "IdArticulo", "Descripcion", detalleFactura.IdArticulo);
            ViewData["IdFactura"] = new SelectList(_context.Facturaciones, "IdFactura", "IdFactura", detalleFactura.IdFactura);
            return View(detalleFactura);
        }

        // GET: DetalleFacturas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalleFactura = await _context.DetalleFacturas
                .Include(d => d.Articulo)
                .Include(d => d.Facturacion)
                .FirstOrDefaultAsync(m => m.IdDetalleFactura == id);
            if (detalleFactura == null)
            {
                return NotFound();
            }

            return View(detalleFactura);
        }

        // POST: DetalleFacturas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var detalleFactura = await _context.DetalleFacturas.FindAsync(id);
            _context.DetalleFacturas.Remove(detalleFactura);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DetalleFacturaExists(int id)
        {
            return _context.DetalleFacturas.Any(e => e.IdDetalleFactura == id);
        }
    }
}
