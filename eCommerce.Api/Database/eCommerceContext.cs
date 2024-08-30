using Microsoft.EntityFrameworkCore;

namespace eCommerce.Api.Database
{
    public class eCommerceContext: DbContext
    {
        #region
        // Configurando quando não há distinção de ambientes como desenvolvimento e produção.
        /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=eCommerce;Integrated Security=True;");
            base.OnConfiguring(optionsBuilder);
        }*/
        #endregion

        public eCommerceContext(DbContextOptions<eCommerceContext> options) : base(options)
        {
            
        }

        // defininindo tabelas.
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<EnderecoEntrega> EnderecosEntrega { get; set; }
        public DbSet<Contato> Contatos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departamento>().HasData(
                new Departamento { Id = 1, Nome = "Moda" },
                new Departamento { Id = 2, Nome = "Informática" },
                new Departamento { Id = 3, Nome = "Eletrodomésticos" },
                new Departamento { Id = 4, Nome = "Ninja" }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
