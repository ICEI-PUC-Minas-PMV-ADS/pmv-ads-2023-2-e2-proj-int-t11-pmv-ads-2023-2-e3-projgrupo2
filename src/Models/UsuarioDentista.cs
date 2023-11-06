using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EassyDental.Models;

[Table("UsuarioDentista")]
public class UsuarioDentista
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

    [Required(ErrorMessage = "Obrigatório informar o CRO")]
    public string CRO { get; set; }

    [Required(ErrorMessage = "Obrigatório informar a Especialidade")]
    public Especialidade Especialidade { get; set; }

    [Required(ErrorMessage = "Obrigatório informar o nome da clínica")]
    public string NomeClinica { get; set; }

    [Required(ErrorMessage = "Obrigatório informar o Endereço")]
    public string Endereco { get; set; }

    [Required(ErrorMessage = "Obrigatório informar o Horario de Abertura")]
    public TimeSpan HorarioAbertura { get; set; }

    [Required(ErrorMessage = "Obrigatório informar o Horario de Encerramento")]
    public TimeSpan HorarioEncerramento { get; set; }

    public ICollection<AgendaEvento> AgendaEventos { get; set; }
}

public enum Especialidade
{
    Cirurgia_e_Traumatologia_Buco_Maxilo_Faciais,
    Dentística,
    Disfunção_Temporomandibular_e_Dor_Orofacial,
    Endodontia,
    Estomatologia,
    Radiologia_Odontológica_e_Imaginologia,
    Implantodontia,
    Odontologia_Legal,
    Odontologia_do_Trabalho,
    Odontologia_para_Pacientes_com_Necessidades_Especiais,
    Odontogeriatria,
    Odontopediatria,
    Ortodontia,
    Ortopedia_Funcional_dos_Maxilares,
    Patologia_Bucal,
    Periodontia,
    Prótese_Buco_Maxilo_Facial,
    Prótese_Dentária,
    Saúde_Coletiva_e_da_Família
}
