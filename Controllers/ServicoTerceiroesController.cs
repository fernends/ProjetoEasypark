using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoEasypark.Models;

namespace ProjetoEasypark.Controllers
{
    public class ServicoTerceiroesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ServicoTerceiroesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ServicoTerceiroes
        public async Task<IActionResult> Index()
        {
            return View(await _context.ServicoTerceiros.ToListAsync());
        }

        // GET: ServicoTerceiroes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var servicoTerceiro = await _context.ServicoTerceiros
                .FirstOrDefaultAsync(m => m.Cliente_id == id);
            if (servicoTerceiro == null)
            {
                return NotFound();
            }

            return View(servicoTerceiro);
        }

        // GET: ServicoTerceiroes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ServicoTerceiroes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Cliente_id,NomeEmpresa,Cnpj,Email,Lugadouro,Numero,Complemento,Cidade,Estado,CEP,Telefone,TipoServico")] ServicoTerceiro servicoTerceiro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(servicoTerceiro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(servicoTerceiro);
        }

        // GET: ServicoTerceiroes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var servicoTerceiro = await _context.ServicoTerceiros.FindAsync(id);
            if (servicoTerceiro == null)
            {
                return NotFound();
            }
            return View(servicoTerceiro);
        }

        // POST: ServicoTerceiroes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Cliente_id,NomeEmpresa,Cnpj,Email,Lugadouro,Numero,Complemento,Cidade,Estado,CEP,Telefone,TipoServico")] ServicoTerceiro servicoTerceiro)
        {
            if (id != servicoTerceiro.Cliente_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(servicoTerceiro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ServicoTerceiroExists(servicoTerceiro.Cliente_id))
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
            return View(servicoTerceiro);
        }

        // GET: ServicoTerceiroes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var servicoTerceiro = await _context.ServicoTerceiros
                .FirstOrDefaultAsync(m => m.Cliente_id == id);
            if (servicoTerceiro == null)
            {
                return NotFound();
            }

            return View(servicoTerceiro);
        }

        // POST: ServicoTerceiroes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var servicoTerceiro = await _context.ServicoTerceiros.FindAsync(id);
            _context.ServicoTerceiros.Remove(servicoTerceiro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ServicoTerceiroExists(int id)
        {
            return _context.ServicoTerceiros.Any(e => e.Cliente_id == id);
        }
    }
}
