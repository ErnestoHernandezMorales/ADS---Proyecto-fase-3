using Microsoft.EntityFrameworkCore;
using PortalEscolar.Models;

namespace PortalEscolar.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext
        (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Aviso> Avisos { get; set; }

        public DbSet<Nota> Notas { get; set; }
    }
}