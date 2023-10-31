using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EassyDental.Models
{
    [Table("UsuarioDentista")]
    public class UsuarioDentista
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Telefone")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o CRO")]
        public string CRO { get; set; }

        public string Especialidade { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome da clínica")]
        public string Nome_da_clinica { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Endereço")]
        public string Endereço { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a Senha")]
        public string Senha { get; set; }

        // Propriedade para armazenar o nome do arquivo da foto
        public string FotoFileName { get; set; }

        // Propriedades para horário de atendimento
        public string HorarioAtendimentoInicio { get; set; } // Por exemplo, "09:00"
        public string HorarioAtendimentoFim { get; set; }    // Por exemplo, "17:00"

        // Lista de dias disponíveis para atendimento (não mapeada no banco de dados)
        [NotMapped]
        public ICollection<DiaSemana> DiasDisponiveis { get; set; }

        // Relacionamento com a tabela AgendaEvento
        public ICollection<AgendaEvento> AgendaEventos { get; set; }
    }

    public enum DiaSemana
    {
        Domingo,
        Segunda,
        Terça,
        Quarta,
        Quinta,
        Sexta,
        Sábado
    }

    
}