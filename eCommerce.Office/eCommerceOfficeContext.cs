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
        #region Mapeamento: ColaboradorSetor - EF Core -3.1

        /*
         * Muito para Muitos usando 2 relacionamentos de Um para Muitos
         */

        modelBuilder.Entity<ColaboradorSetor>()
            .HasKey(cs => new { cs.ColaboradorId, cs.SetorId }); // chave composta

        /*
        modelBuilder.Entity<ColaboradorSetor>()
            .HasOne(cs => cs.Colaborador)
            .WithMany(c => c.ColaboradorSetor)
            .HasForeignKey(cs => cs.ColaboradorId);

        modelBuilder.Entity<ColaboradorSetor>()
            .HasOne(cs => cs.Setor)
            .WithMany(cs => cs.ColaboradorSetor)
            .HasForeignKey(cs => cs.SetorId);
        */


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

        #region Mapeamento: Colaborador <=> Turma - EF Core 5+

        modelBuilder.Entity<Colaborador>()
            .HasMany(c => c.Turmas)
            .WithMany(t => t.Colaboradores);

        #endregion

        #region Mapeamento: Colaborador <=> Veículo EF Core 5+

        modelBuilder.Entity<Colaborador>().HasMany(c => c.Veiculos)
            .WithMany(v => v.Colaboradores)
            .UsingEntity<ColaboradorVeiculo>(
                cv => cv
                    .HasOne(cv => cv.Veiculo)
                    .WithMany(v => v.ColaboradoresVeiculos)
                    .HasForeignKey(cv => cv.VeiculoId),
                cv => cv
                    .HasOne(cv => cv.Colaborador)
                    .WithMany(c => c.ColaboradoresVeiculos)
                    .HasForeignKey(cv => cv.ColaboradorId),
                cv => cv
                    .HasKey(cv => new { cv.ColaboradorId, cv.VeiculoId })
            );

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

        modelBuilder.Entity<Turma>().HasData(
            new Turma { Id = 1, Nome = "Turma A1" },
            new Turma { Id = 2, Nome = "Turma A2" },
            new Turma { Id = 3, Nome = "Turma A3" },
            new Turma { Id = 4, Nome = "Turma A4" },
            new Turma { Id = 5, Nome = "Turma A5" }
        );

        modelBuilder.Entity<Veiculo>().HasData(
            new Veiculo { Id = 1, Nome = "Fiat - Idea", Placa = "ABC-1234"},
            new Veiculo { Id = 2, Nome = "Fiat - Argo", Placa = "ABC-1111" },
            new Veiculo { Id = 3, Nome = "Fiat - Mobi", Placa = "ABC-2222" },
            new Veiculo { Id = 4, Nome = "Fiat - Sienna", Placa = "ABC-3333" },
            new Veiculo { Id = 5, Nome = "Fiat - Toro", Placa = "ABC-4444" }
        );

        #endregion
    }
}