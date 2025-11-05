using Microsoft.EntityFrameworkCore;
using webappclinicaodontologica.Models;

namespace webappclinicaodontologica.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().ToTable("usuario");
            modelBuilder.Entity<Usuario>().HasKey(u => u.Id_Usuario);

            modelBuilder.Entity<Rol>().ToTable("rol");
            modelBuilder.Entity<Rol>().HasKey(r => r.id_rol);

            modelBuilder.Entity<Paciente>().ToTable("pacientes");
            modelBuilder.Entity<Paciente>().HasKey(p => p.id_paciente);
        }
        public DbSet<webappclinicaodontologica.Models.LoginViewModel> LoginViewModel { get; set; } = default!;
    }
}

