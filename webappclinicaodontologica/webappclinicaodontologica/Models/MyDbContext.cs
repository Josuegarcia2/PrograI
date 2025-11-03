using Microsoft.EntityFrameworkCore;
namespace webappclinicaodontologica.Models
{
    public class MyDbContext: DbContext
    {
        public MyDbContext() { }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
            public DbSet<usuario> usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<usuario>().HasKey(u => u.id_usuario);
        }
    }
}
