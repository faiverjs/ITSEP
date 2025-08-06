using Microsoft.EntityFrameworkCore;


namespace ITSEP.Models
{
    public class ItsepDbContext : DbContext
    {
        public ItsepDbContext()
        {

        }

        public ItsepDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Envios> Envios { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<EnviosDetails> EnviosDetails { get; set; }
        public DbSet<RolUsuario> RolUsuarios { get; set; }
        public DbSet<Rol> Rols { get; set; }
        public DbSet<Modules> Modules { get; set; }
        public DbSet<ModuleRol> ModuleRols { get; set; }

    }
}
