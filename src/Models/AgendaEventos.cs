using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EassyDental.Models;

[Table("AgendaEvento")]
public class AgendaEvento
{
    [Key]
    public int Id { get; set; }

    public DateTime HorarioConsulta { get; set; }

    public int UsuarioClienteId { get; set; }
    
    [ForeignKey("UsuarioClienteId")]
    public UsuarioCliente UsuarioCliente { get; set; }

    public int UsuarioDentistaId { get; set; }

    [ForeignKey("UsuarioDentistaId")]
    public UsuarioDentista UsuarioDentista { get; set; }
}
