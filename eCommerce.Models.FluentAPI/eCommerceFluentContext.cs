using Microsoft.EntityFrameworkCore;

namespace eCommerce.Models.FluentAPI
{
    public class eCommerceFluentContext: DbContext
    {
        public eCommerceFluentContext(DbContextOptions<eCommerceFluentContext> options) : base(options)
        {

        }

        public DbSet<Usuario>? Usuarios { get; set; }
        public DbSet<Departamento>? Departamentos { get; set; }
        public DbSet<EnderecoEntrega>? EnderecosEntrega { get; set; }
        public DbSet<Contato>? Contatos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().ToTable("TB_USUARIOS");

            modelBuilder.Entity<Usuario>().Property(a => a.RG)
                .HasColumnName("REGISTRO_GERAL")
                .HasMaxLength(10)
                .HasDefaultValue("RG-AUSENTE")
                .IsRequired();

            modelBuilder.Entity<Usuario>().Ignore(a => a.Sexo);

            modelBuilder.Entity<Usuario>().Property(a => a.Id).ValueGeneratedOnAdd();

            // Index

            // modelBuilder.Entity<Usuario>().HasIndex("CPF");
            modelBuilder.Entity<Usuario>()
                .HasIndex(a => a.CPF)
                .IsUnique()
                .HasFilter("[CPF] is not null")
                .HasDatabaseName("IX_CPF_UNIQUE");

            // modelBuilder.Entity<Usuario>().HasIndex("CPF", "Email");
            modelBuilder.Entity<Usuario>().HasIndex(a => new { a.CPF, a.Email});

            // PK
            modelBuilder.Entity<Usuario>().HasKey(a => a.Id);
            // modelBuilder.Entity<Usuario>().HasKey(a => new { a.Id, a.CPF });

            modelBuilder.Entity<Usuario>().HasAlternateKey(a => a.CPF);

            // FK
            // Um para um
            modelBuilder.Entity<Usuario>()
                .HasOne(a => a.Contato)
                .WithOne(a => a.Usuario)
                .HasForeignKey<Contato>(a => a.UsuarioId);

            // Muitos para um
            modelBuilder.Entity<Usuario>()
                .HasMany(a => a.EnderecosEntrega)
                .WithOne(a => a.Usuario)
                .HasForeignKey(a => a.UsuarioId);

            // Muitos para muitos
            modelBuilder.Entity<Usuario>()
                .HasMany(a => a.Departamentos)
                .WithMany(a => a.Usuarios);

            base.OnModelCreating(modelBuilder);
        }
    }
}
