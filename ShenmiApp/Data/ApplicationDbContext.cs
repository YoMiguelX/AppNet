using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShenmiApp.Models;

namespace ShenmiApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
: base(options)
{
}
        public DbSet<ShenmiApp.Models.Jugador> Jugador { get; set; } = default!;
        public DbSet<ShenmiApp.Models.ProgresoJugador> ProgresoJugador { get; set; } = default!;
        public DbSet<ShenmiApp.Models.Preguntas> Preguntas { get; set; } = default!;
        public DbSet<ShenmiApp.Models.Niveles> Niveles { get; set; } = default!;


}
}
