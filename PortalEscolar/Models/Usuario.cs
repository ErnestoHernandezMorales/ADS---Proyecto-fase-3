using System.ComponentModel.DataAnnotations;

namespace PortalEscolar.Models
{
    public class Usuario
    {
        [Key]
        public int id_usuario { get; set; }

        public string nombre { get; set; }

        public string apellido { get; set; }

        public string correo { get; set; }

        public string password { get; set; }

        public string rol { get; set; }
    }
}