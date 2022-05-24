using ExoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ExoApi.Contexts

{
    public class ProjetoContext : DbContext
    {
        public ProjetoContext()
        {
        }

        public ProjetoContext(DbContextOptions<ProjetoContext> options) : base(options)
        {
        }

        protected override void
            OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-PH8GVRC\\SQLEXPRESS; initial catalog = ExoApi; Integrated Security = true");
            }            
        }

        public DbSet<Projeto> Projetos { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
