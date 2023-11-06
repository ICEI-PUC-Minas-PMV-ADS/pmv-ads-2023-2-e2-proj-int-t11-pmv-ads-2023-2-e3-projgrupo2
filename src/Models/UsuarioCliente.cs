using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EassyDental.Models;

[Table("UsuarioCliente")]
public class UsuarioCliente
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Obrigatório informar o Nome")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Obrigatório informar o Telefone")]
    public string Telefone { get; set; }

    [Required(ErrorMessage = "Obrigatório informar o E-mail")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Obrigatório informar a Senha")]
    [DataType(DataType.Password)]
    public string Senha { get; set; }

    public ICollection<AgendaEvento> AgendaEventos { get; set; }
}
