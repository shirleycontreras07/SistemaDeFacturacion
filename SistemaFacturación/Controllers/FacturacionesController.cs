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
    public class FacturacionesController : Controller
    {
        private readonly FacturacionDbContext _context;

        public FacturacionesController(FacturacionDbContext context)
        {
            _context = context;
        }

        // GET: Facturaciones
        public async Task<IActionResult> Index()
        {
            var facturacionDbContext = _context.Facturaciones.Include(f => f.Cliente).Include(f => f.Vendedor);
            return View(await facturacionDbContext.ToListAsync());
        }

        // GET: Facturaciones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var facturacion = await _context.Facturaciones
                .Include(f => f.Cliente)
                .Include(f => f.Vendedor)
                .FirstOrDefaultAsync(m => m.IdFactura == id);
            if (facturacion == null)
            {
                return NotFound();
            }

            return View(facturacion);
        }

        // GET: Facturaciones/Create
        public IActionResult Create()
        {
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "IdCliente", "Nombre");
            ViewData["IdVendedor"] = new SelectList(_context.Vendedores, "IdVendedor", "Nombre");
            return View();
        }

        // POST: Facturaciones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdFactura,IdVendedor,IdCliente,Fecha,Comentario,Estado")] Facturacion facturacion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(facturacion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "IdCliente", "Nombre", facturacion.IdCliente);
            ViewData["IdVendedor"] = new SelectList(_context.Vendedores, "IdVendedor", "Nombre", facturacion.IdVendedor);
            return View(facturacion);
        }

        // GET: Facturaciones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var facturacion = await _context.Facturaciones.FindAsync(id);
            if (facturacion == null)
            {
                return NotFound();
            }
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "IdCliente", "Nombre", facturacion.IdCliente);
            ViewData["IdVendedor"] = new SelectList(_context.Vendedores, "IdVendedor", "Nombre", facturacion.IdVendedor);
            return View(facturacion);
        }

        // POST: Facturaciones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdFactura,IdVendedor,IdCliente,Fecha,Comentario,Estado")] Facturacion facturacion)
        {
            if (id != facturacion.IdFactura)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(facturacion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FacturacionExists(facturacion.IdFactura))
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
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "IdCliente", "Nombre", facturacion.IdCliente);
            ViewData["IdVendedor"] = new SelectList(_context.Vendedores, "IdVendedor", "Nombre", facturacion.IdVendedor);
            return View(facturacion);
        }

        // GET: Facturaciones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var facturacion = await _context.Facturaciones
                .Include(f => f.Cliente)
                .Include(f => f.Vendedor)
                .FirstOrDefaultAsync(m => m.IdFactura == id);
            if (facturacion == null)
            {
                return NotFound();
            }

            return View(facturacion);
        }

        // POST: Facturaciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var facturacion = await _context.Facturaciones.FindAsync(id);
            _context.Facturaciones.Remove(facturacion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FacturacionExists(int id)
        {
            return _context.Facturaciones.Any(e => e.IdFactura == id);
        }
    }
}
