using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalEscolar.Models
{
    [Table("notas")]
    public class Nota
    {
        [Key]
        public int id_nota { get; set; }

        public string? estudiante { get; set; }

        public string? materia { get; set; }

        public string? actividad { get; set; }

        public decimal nota { get; set; }

        public string? periodo { get; set; }
    }
}