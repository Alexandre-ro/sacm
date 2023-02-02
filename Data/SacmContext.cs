using Microsoft.EntityFrameworkCore;
using SACM.Entities;

namespace SACM.Data
{
    public class SacmContext : DbContext
    {
        public SacmContext(DbContextOptions<SacmContext> options) :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        public DbSet<Especialidade> Especialidades { get; set; }
        public DbSet<Medico> Medicos { get; set; }
    }
}
