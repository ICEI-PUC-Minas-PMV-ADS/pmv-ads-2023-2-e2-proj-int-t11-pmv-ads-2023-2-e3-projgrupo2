using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EassyDental.Models;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;

namespace EassyDental.Controllers;

public class UsuarioClientesController : Controller
{
    private readonly AppDbContext _context;

    public UsuarioClientesController(AppDbContext context)
    {
        _context = context;
    }

    #region Login
    [HttpGet]
    public IActionResult Login()
    {
        ViewBag.Message = "";
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Login(string email, string senha)
    {
        var usuario = await _context.UsuariosClientes.FirstOrDefaultAsync(u => u.Email == email);

        if (usuario is not null && BCrypt.Net.BCrypt.Verify(senha, usuario.Senha))
        {
            List<Claim> claims = new ()
            {
                new Claim(ClaimTypes.Name, usuario.Name),
                new Claim(ClaimTypes.NameIdentifier, usuario.Id.ToString()),
                new Claim(ClaimTypes.Role, "Cliente")
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
        ViewBag.Message = "";
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
    public async Task<IActionResult> Create(UsuarioCliente usuarioCliente)
    {
        if (ModelState.IsValid)
        {
            usuarioCliente.Senha = BCrypt.Net.BCrypt.HashPassword(usuarioCliente.Senha);
            _context.UsuariosClientes.Add(usuarioCliente);
            await _context.SaveChangesAsync();
            return RedirectToAction("Login");
        }
        return View(usuarioCliente);
    }
    #endregion

    [HttpGet]
    public async Task<IActionResult> IndexEventos(int id)
    {
        var eventos = await _context.AgendaEventos
            .Include(e => e.UsuarioDentista)
            .ToListAsync();

        var eventosCliente = eventos.FindAll(e => e.UsuarioClienteId == id);
        return View(eventosCliente);
    }

    [HttpGet]
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null || _context.UsuariosClientes == null)
        {
            return NotFound();
        }

        var usuarioCliente = await _context.UsuariosClientes.FindAsync(id);
        if (usuarioCliente == null)
        {
            return NotFound();
        }

        return View(usuarioCliente);
    }

    #region Edit
    [HttpGet]
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null || _context.UsuariosClientes == null)
        {
            return NotFound();
        }

        var usuariosClientes = await _context.UsuariosClientes.FindAsync(id);
        if (usuariosClientes == null)
        {
            return NotFound();
        }
        return View(usuariosClientes);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, UsuarioCliente usuarioCliente)
    {
        if (id != usuarioCliente.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                usuarioCliente.Senha = BCrypt.Net.BCrypt.HashPassword(usuarioCliente.Senha);
                _context.Update(usuarioCliente);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsuarioClienteExists(usuarioCliente.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction("Index", "UsuarioDentistas");
        }
        return View(usuarioCliente);
    }
    #endregion

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        if (_context.UsuariosClientes == null)
        {
            return Problem("Entity set 'AppDbContext.UsuariosClientes'  is null.");
        }
        var usuarioCliente = await _context.UsuariosClientes.FindAsync(id);
        if (usuarioCliente != null)
        {
            _context.UsuariosClientes.Remove(usuarioCliente);
        }

        await _context.SaveChangesAsync();
        await Logout();
        return RedirectToAction("Index", "UsuarioDentistas");
    }

    private bool UsuarioClienteExists(int id)
    {
        return _context.UsuariosClientes.Any(e => e.Id == id);
    }
}
