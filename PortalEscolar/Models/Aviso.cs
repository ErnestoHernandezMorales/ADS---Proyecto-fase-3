using System.ComponentModel.DataAnnotations;

namespace PortalEscolar.Models
{
    public class Aviso
    {
        [Key]
        public int id_aviso { get; set; }

        public string titulo { get; set; }

        public string contenido { get; set; }

        public DateTime fecha_publicacion { get; set; }
    }
}