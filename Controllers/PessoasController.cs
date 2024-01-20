using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PessoaFisica.Data;
using PessoaFisica.Models;
using PessoaFisica.ViewsModel;

namespace PessoaFisica.Controllers
{
    public class PessoasController : Controller
    {
        private readonly Contexto _context;

        public PessoasController(Contexto context)
        {
            _context = context;
        }

        // GET: Pessoas
        public async Task<IActionResult> Index()
        {
              return _context.Pessoas != null ? 
                          View(await _context.Pessoas.ToListAsync()) :
                          Problem("Entity set 'Contexto.Pessoas'  is null.");
        }

        // GET: Pessoas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Pessoas == null)
            {
                return NotFound();
            }

            var pessoa = await _context.Pessoas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pessoa == null)
            {
                return NotFound();
            }

            return View(pessoa);
        }

        // GET: Pessoas/Create
        public IActionResult Create(int? id)
        {
            if (id != null && _context.Usuarios != null)
            {
                var usuario =  _context.Usuarios
                .Include(u => u.ListaDePessoas)
                .FirstOrDefault(u => u.Id == id);

                if (usuario == null)
                {
                    return NotFound();
                }
                return View();
            }
            return NotFound();
        }

        // POST: Pessoas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PessoaCreateViewsModel pessoaCVM, int id)
        {
            var usuario = _context.Usuarios
                .Include(u => u.ListaDePessoas)
                .FirstOrDefault(u => u.Id == id);

            if (ModelState.IsValid)
            {
                Pessoa pessoa = new Pessoa();
                pessoa.RG = pessoaCVM.RG;
                pessoa.CPF = pessoaCVM.CPF;
                pessoa.Email = pessoaCVM.Email;
                pessoa.DataNascimento = pessoaCVM.DataNascimento;
                pessoa.Nome = pessoaCVM.Nome;
                pessoa.Sobrenome = pessoaCVM.Sobrenome;
                pessoa.Logradouro1 = pessoaCVM.Logradouro1;
                pessoa.Logradouro2 = pessoaCVM.Logradouro2;
                pessoa.Numero1 = pessoaCVM.Numero1;
                pessoa.Numero2 = pessoaCVM.Numero2;
                pessoa.CEP1 = pessoaCVM.CEP1;
                pessoa.CEP2 = pessoaCVM.CEP2;
                pessoa.Cidade1 = pessoaCVM.Cidade1;
                pessoa.Cidade2 = pessoaCVM.Cidade2;
                pessoa.Complemento1 = pessoaCVM.Complemento1;
                pessoa.Complemento2 = pessoaCVM.Complemento2;
                pessoa.Estado1 = pessoaCVM.Estado1;
                pessoa.Estado2 = pessoa.Estado2;
                pessoa.Nome1 = pessoaCVM.Nome1;
                pessoa.Nome2 = pessoaCVM.Nome2;
                pessoa.ValorContato1 = pessoaCVM.ValorContato1;
                pessoa.ValorContato2 = pessoaCVM.ValorContato2;
                pessoa.TipoContato1 = pessoaCVM.TipoContato1;
                pessoa.TipoContato2 = pessoaCVM.TipoContato2;

                usuario.ListaDePessoas.Add(pessoa);
                _context.Add(pessoa);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "Usuarios", new { id = usuario.Id });
            }

            // Se houver erros de validação, retorna para a view de criação
            return View(pessoaCVM);
        }


        // GET: Pessoas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Pessoas == null)
            {
                return NotFound();
            }

            var pessoa = await _context.Pessoas.FindAsync(id);
            if (pessoa == null)
            {
                return NotFound();
            }
            return View(pessoa);
        }

        // POST: Pessoas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Sobrenome,Email,DataNascimento,RG,CPF,Logradouro1,CEP1,Numero1,Complemento1,Cidade1,Estado1,Logradouro2,CEP2,Numero2,Complemento2,Cidade2,Estado2,Nome1,ValorContato1,TipoContato1,Nome2,ValorContato2,TipoContato2")] Pessoa pessoa)
        {
            if (id != pessoa.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pessoa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PessoaExists(pessoa.Id))
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
            return View(pessoa);
        }

        // GET: Pessoas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Pessoas == null)
            {
                return NotFound();
            }

            var pessoa = await _context.Pessoas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pessoa == null)
            {
                return NotFound();
            }

            return View(pessoa);
        }

        // POST: Pessoas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Pessoas == null)
            {
                return Problem("Entity set 'Contexto.Pessoas'  is null.");
            }
            var pessoa = await _context.Pessoas.FindAsync(id);
            if (pessoa != null)
            {
                _context.Pessoas.Remove(pessoa);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PessoaExists(int id)
        {
          return (_context.Pessoas?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
