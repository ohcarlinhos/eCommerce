using eCommerce.Console.Tracking.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Console.Tracking
{
    public class eCommerceContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<EnderecoEntrega> EnderecosEntrega { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(
                    "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=eCommerce2;Integrated Security=True;")
                .LogTo(System.Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information)
                .EnableSensitiveDataLogging();
            
            
            base.OnConfiguring(optionsBuilder);
        }
    }
}