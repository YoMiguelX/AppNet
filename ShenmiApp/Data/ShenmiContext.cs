using Microsoft.EntityFrameworkCore;
using ShenmiApp.Models;  // <-- IMPORTANTE

namespace ShenmiApp.Data
{
    public class ShenmiContext : DbContext
    {
        public ShenmiContext(DbContextOptions<ShenmiContext> options)
            : base(options)
        {
        }

        // TABLAS
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
