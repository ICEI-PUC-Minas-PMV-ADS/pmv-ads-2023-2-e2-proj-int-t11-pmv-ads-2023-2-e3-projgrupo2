using EassyDental.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace EassyDental.Controllers;

public class AgendaEventoesController : Controller
{
    private readonly AppDbContext _context;

    public AgendaEventoesController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Details(int? id)
    {
        if (id == null || _context.AgendaEventos == null)
        {
            return NotFound();
        }

        var agendaEvento = await _context.AgendaEventos
            .Include(a => a.UsuarioCliente)
            .Include(a => a.UsuarioDentista)
            .FirstOrDefaultAsync(m => m.Id == id);

        if (agendaEvento == null)
        {
            return NotFound();
        }

        return View(agendaEvento);
    }

    #region Edit
    [HttpGet]
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null || _context.AgendaEventos == null)
        {
            return NotFound();
        }

        var agendaEvento = await _context.AgendaEventos.FindAsync(id);
        if (agendaEvento == null)
        {
            return NotFound();
        }

        var clienteId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
        var cliente = await _context.UsuariosClientes.Where(c => c.Id.ToString() == clienteId).ToListAsync();
        ViewData["UsuarioClienteId"] = new SelectList(cliente, "Id", "Name", agendaEvento.UsuarioClienteId);
        ViewData["UsuarioDentistaId"] = new SelectList(_context.UsuariosDentistas, "Id", "Name", agendaEvento.UsuarioDentistaId);
        return View(agendaEvento);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, AgendaEvento agendaEvento)
    {
        if (id != agendaEvento.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(agendaEvento);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AgendaEventoExists(agendaEvento.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            if (User.IsInRole("Dentista"))
            {
                return RedirectToAction("IndexEventos", "UsuarioDentistas", new { id = User.FindFirst(ClaimTypes.NameIdentifier).Value });
            }
            else
            {
                return RedirectToAction("IndexEventos", "UsuarioClientes", new { id = User.FindFirst(ClaimTypes.NameIdentifier).Value });
            }
        }
        return View(agendaEvento);
    }
    #endregion

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        if (_context.AgendaEventos == null)
        {
            return Problem("Entity set 'AppDbContext.AgendaEventos'  is null.");
        }
        var agendaEventos = await _context.AgendaEventos.FindAsync(id);
        if (agendaEventos != null)
        {
            _context.AgendaEventos.Remove(agendaEventos);
        }

        await _context.SaveChangesAsync();

        if (User.IsInRole("Dentista"))
        {
            return RedirectToAction("IndexEventos", "UsuarioDentistas", new { id = User.FindFirst(ClaimTypes.NameIdentifier).Value });
        }
        else
        {
            return RedirectToAction("IndexEventos", "UsuarioClientes", new { id = User.FindFirst(ClaimTypes.NameIdentifier).Value });
        }
    }

    private bool AgendaEventoExists(int id)
    {
        return _context.AgendaEventos.Any(e => e.Id == id);
    }
}