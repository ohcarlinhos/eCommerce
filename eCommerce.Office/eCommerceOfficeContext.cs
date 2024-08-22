using eCommerce.Office.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Office;

public class eCommerceOfficeContext : DbContext
{
    public DbSet<Colaborador>? Colaboradores { get; set; }
    public DbSet<ColaboradorSetor>? ColaboradoresSetores { get; set; }
    public DbSet<Setor>? Setores { get; set; }

    public DbSet<Turma>? Turmas { get; set; }
    public DbSet<Veiculo>? Veiculos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlServer(
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=eCommerceOffice;Integrated Security=True;"
            );
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region ColaboradorSetor

        /*
         * Muito para Muitos usando 2 relacionamentos de Um para Muitos
         */

        modelBuilder.Entity<ColaboradorSetor>()
            .HasKey(cs => new { cs.ColaboradorId, cs.SetorId }); // chave composta
        
        // modelBuilder.Entity<ColaboradorSetor>()
        //     .HasOne(cs => cs.Colaborador)
        //     .WithMany(c => c.ColaboradorSetor)
        //     .HasForeignKey(cs => cs.ColaboradorId);
        //
        // modelBuilder.Entity<ColaboradorSetor>()
        //     .HasOne(cs => cs.Setor)
        //     .WithMany(cs => cs.ColaboradorSetor)
        //     .HasForeignKey(cs => cs.SetorId);


        /*
         * Mapeamento contrário.
         */

        modelBuilder.Entity<Colaborador>()
            .HasMany(c => c.ColaboradorSetor)
            .WithOne(cs => cs.Colaborador)
            .HasForeignKey(cs => cs.ColaboradorId);
        
        modelBuilder.Entity<Setor>()
            .HasMany(s => s.ColaboradorSetor)
            .WithOne(cs => cs.Setor)
            .HasForeignKey(cs => cs.SetorId);

        #endregion

        #region Seeds

        modelBuilder.Entity<Colaborador>().HasData(
            new Colaborador { Id = 1, Nome = "Carlos" },
            new Colaborador { Id = 2, Nome = "Roberto" },
            new Colaborador { Id = 3, Nome = "Silva" },
            new Colaborador { Id = 4, Nome = "Júnior" },
            new Colaborador { Id = 5, Nome = "Anna" },
            new Colaborador { Id = 6, Nome = "Maria" },
            new Colaborador { Id = 7, Nome = "José" }
        );

        modelBuilder.Entity<Setor>().HasData(
            new Setor { Id = 1, Nome = "Administração" },
            new Setor { Id = 2, Nome = "Logística" },
            new Setor { Id = 3, Nome = "Separação" },
            new Setor { Id = 4, Nome = "Vendas" },
            new Setor { Id = 5, Nome = "Financeiro" }
        );

        modelBuilder.Entity<ColaboradorSetor>().HasData(
            new ColaboradorSetor { ColaboradorId = 1, SetorId = 3, Criado = DateTimeOffset.Now },
            new ColaboradorSetor { ColaboradorId = 1, SetorId = 4, Criado = DateTimeOffset.Now },
            new ColaboradorSetor { ColaboradorId = 2, SetorId = 3, Criado = DateTimeOffset.Now },
            new ColaboradorSetor { ColaboradorId = 2, SetorId = 5, Criado = DateTimeOffset.Now },
            new ColaboradorSetor { ColaboradorId = 3, SetorId = 3, Criado = DateTimeOffset.Now },
            new ColaboradorSetor { ColaboradorId = 3, SetorId = 2, Criado = DateTimeOffset.Now },
            new ColaboradorSetor { ColaboradorId = 4, SetorId = 2, Criado = DateTimeOffset.Now },
            new ColaboradorSetor { ColaboradorId = 5, SetorId = 2, Criado = DateTimeOffset.Now },
            new ColaboradorSetor { ColaboradorId = 6, SetorId = 5, Criado = DateTimeOffset.Now },
            new ColaboradorSetor { ColaboradorId = 7, SetorId = 3, Criado = DateTimeOffset.Now }
        );

        #endregion
    }
}