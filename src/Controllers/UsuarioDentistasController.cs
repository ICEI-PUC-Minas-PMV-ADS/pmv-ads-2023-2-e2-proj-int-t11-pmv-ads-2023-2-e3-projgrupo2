using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EassyDental.Models;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;

namespace EassyDental.Controllers;

public class UsuarioDentistasController : Controller
{
    private readonly AppDbContext _context;

    public UsuarioDentistasController(AppDbContext context)
    {
        _context = context;
    }

    #region Login
    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Login(string email, string senha)
    {
        var usuario = await _context.UsuariosDentistas.FirstOrDefaultAsync(u => u.Email == email);

        if (usuario is not null && BCrypt.Net.BCrypt.Verify(senha, usuario.Senha))
        {
            List<Claim> claims = new ()
            {
                new Claim(ClaimTypes.Name, usuario.Name),
                new Claim(ClaimTypes.NameIdentifier, usuario.Id.ToString()),
                new Claim(ClaimTypes.Role, "Dentista")
            };

            ClaimsIdentity userIdentity = new (claims, "login");
            ClaimsPrincipal principal = new (userIdentity);

            AuthenticationProperties props = new ()
            {
                AllowRefresh = true,
                ExpiresUtc = DateTime.UtcNow.ToLocalTime().AddHours(8),
                IsPersistent = true
            };

            await HttpContext.SignInAsync(principal, props);

            return RedirectToAction("Index", "UsuarioDentistas");
        }
        else
        {
            ViewBag.Message = "Email e/ou senha inválidos!";
            return View();
        }
    }

    public async Task<IActionResult> Logout()
    {
        await HttpContext.SignOutAsync();
        return RedirectToAction("Login");
    }
    #endregion

    #region Create
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(UsuarioDentista usuarioDentista)
    {
        if (ModelState.IsValid)
        {
            usuarioDentista.Senha = BCrypt.Net.BCrypt.HashPassword(usuarioDentista.Senha);
            _context.Add(usuarioDentista);
            await _context.SaveChangesAsync();
            return RedirectToAction("Login");
        }
        return View(usuarioDentista);
    }
    #endregion

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        return View(await _context.UsuariosDentistas.ToListAsync());
    }

    [HttpPost]
    public async Task<IActionResult> CreateEventos(int id, DateTime horarioConsulta)
    {
        AgendaEvento agendaEvento = new()
        {
            Id = 0,
            HorarioConsulta = horarioConsulta,
            UsuarioClienteId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value),
            UsuarioDentistaId = id
        };

        _context.AgendaEventos.Add(agendaEvento);
        await _context.SaveChangesAsync();
        return RedirectToAction("IndexEventos", "UsuarioClientes", new { id = agendaEvento.UsuarioClienteId });
    }

    [HttpGet]
    public async Task<IActionResult> IndexEventos(int id)
    {
        var eventos = await _context.AgendaEventos
            .Include(e => e.UsuarioCliente)
            .ToListAsync();

        var eventosDentista = eventos.FindAll(e => e.UsuarioDentistaId == id);
        return View(eventosDentista);
    }

    [HttpGet]
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null || _context.UsuariosDentistas == null)
        {
            return NotFound();
        }

        var usuarioDentista = await _context.UsuariosDentistas.FindAsync(id);
        if (usuarioDentista == null)
        {
            return NotFound();
        }

        return View(usuarioDentista);
    }

    #region Edit
    [HttpGet]
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null || _context.UsuariosDentistas == null)
        {
            return NotFound();
        }

        var usuarioDentista = await _context.UsuariosDentistas.FindAsync(id);
        if (usuarioDentista == null)
        {
            return NotFound();
        }
        return View(usuarioDentista);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, UsuarioDentista usuarioDentista)
    {
        if (id != usuarioDentista.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                usuarioDentista.Senha = BCrypt.Net.BCrypt.HashPassword(usuarioDentista.Senha);
                _context.Update(usuarioDentista);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsuarioDentistaExists(usuarioDentista.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction("Index");
        }
        return View(usuarioDentista);
    }
    #endregion

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        if (_context.UsuariosDentistas == null)
        {
            return Problem("Entity set 'AppDbContext.UsuariosDentistas'  is null.");
        }
        var usuarioDentista = await _context.UsuariosDentistas.FindAsync(id);
        if (usuarioDentista != null)
        {
            _context.UsuariosDentistas.Remove(usuarioDentista);
        }
        
        await _context.SaveChangesAsync();
        await Logout();
        return RedirectToAction("Index");
    }

    private bool UsuarioDentistaExists(int id)
    {
      return _context.UsuariosDentistas.Any(e => e.Id == id);
    }
}
