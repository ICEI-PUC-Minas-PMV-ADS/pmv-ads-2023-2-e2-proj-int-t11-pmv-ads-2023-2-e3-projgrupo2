using Microsoft.EntityFrameworkCore;

namespace EassyDental.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<UsuarioCliente> UsuariosClientes { get; set; }
    public DbSet<UsuarioDentista> UsuariosDentistas { get; set; }
    public DbSet<AgendaEvento> AgendaEventos { get; set; }
}
