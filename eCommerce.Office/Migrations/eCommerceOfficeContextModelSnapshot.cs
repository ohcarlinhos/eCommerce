﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eCommerce.Office;

#nullable disable

namespace eCommerce.Office.Migrations
{
    [DbContext(typeof(eCommerceOfficeContext))]
    partial class eCommerceOfficeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ColaboradorTurma", b =>
                {
                    b.Property<int>("ColaboradoresId")
                        .HasColumnType("int");

                    b.Property<int>("TurmasId")
                        .HasColumnType("int");

                    b.HasKey("ColaboradoresId", "TurmasId");

                    b.HasIndex("TurmasId");

                    b.ToTable("ColaboradorTurma");
                });

            modelBuilder.Entity("ColaboradorVeiculo", b =>
                {
                    b.Property<int>("ColaboradoresId")
                        .HasColumnType("int");

                    b.Property<int>("VeiculosId")
                        .HasColumnType("int");

                    b.HasKey("ColaboradoresId", "VeiculosId");

                    b.HasIndex("VeiculosId");

                    b.ToTable("ColaboradorVeiculo");
                });

            modelBuilder.Entity("eCommerce.Office.Models.Colaborador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Colaboradores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Carlos"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Roberto"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Silva"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Júnior"
                        },
                        new
                        {
                            Id = 5,
                            Nome = "Anna"
                        },
                        new
                        {
                            Id = 6,
                            Nome = "Maria"
                        },
                        new
                        {
                            Id = 7,
                            Nome = "José"
                        });
                });

            modelBuilder.Entity("eCommerce.Office.Models.ColaboradorSetor", b =>
                {
                    b.Property<int>("ColaboradorId")
                        .HasColumnType("int");

                    b.Property<int>("SetorId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("Criado")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("ColaboradorId", "SetorId");

                    b.HasIndex("SetorId");

                    b.ToTable("ColaboradoresSetores");

                    b.HasData(
                        new
                        {
                            ColaboradorId = 1,
                            SetorId = 3,
                            Criado = new DateTimeOffset(new DateTime(2024, 8, 21, 23, 55, 4, 965, DateTimeKind.Unspecified).AddTicks(8158), new TimeSpan(0, -3, 0, 0, 0))
                        },
                        new
                        {
                            ColaboradorId = 1,
                            SetorId = 4,
                            Criado = new DateTimeOffset(new DateTime(2024, 8, 21, 23, 55, 4, 965, DateTimeKind.Unspecified).AddTicks(8191), new TimeSpan(0, -3, 0, 0, 0))
                        },
                        new
                        {
                            ColaboradorId = 2,
                            SetorId = 3,
                            Criado = new DateTimeOffset(new DateTime(2024, 8, 21, 23, 55, 4, 965, DateTimeKind.Unspecified).AddTicks(8193), new TimeSpan(0, -3, 0, 0, 0))
                        },
                        new
                        {
                            ColaboradorId = 2,
                            SetorId = 5,
                            Criado = new DateTimeOffset(new DateTime(2024, 8, 21, 23, 55, 4, 965, DateTimeKind.Unspecified).AddTicks(8195), new TimeSpan(0, -3, 0, 0, 0))
                        },
                        new
                        {
                            ColaboradorId = 3,
                            SetorId = 3,
                            Criado = new DateTimeOffset(new DateTime(2024, 8, 21, 23, 55, 4, 965, DateTimeKind.Unspecified).AddTicks(8197), new TimeSpan(0, -3, 0, 0, 0))
                        },
                        new
                        {
                            ColaboradorId = 3,
                            SetorId = 2,
                            Criado = new DateTimeOffset(new DateTime(2024, 8, 21, 23, 55, 4, 965, DateTimeKind.Unspecified).AddTicks(8199), new TimeSpan(0, -3, 0, 0, 0))
                        },
                        new
                        {
                            ColaboradorId = 4,
                            SetorId = 2,
                            Criado = new DateTimeOffset(new DateTime(2024, 8, 21, 23, 55, 4, 965, DateTimeKind.Unspecified).AddTicks(8201), new TimeSpan(0, -3, 0, 0, 0))
                        },
                        new
                        {
                            ColaboradorId = 5,
                            SetorId = 2,
                            Criado = new DateTimeOffset(new DateTime(2024, 8, 21, 23, 55, 4, 965, DateTimeKind.Unspecified).AddTicks(8203), new TimeSpan(0, -3, 0, 0, 0))
                        },
                        new
                        {
                            ColaboradorId = 6,
                            SetorId = 5,
                            Criado = new DateTimeOffset(new DateTime(2024, 8, 21, 23, 55, 4, 965, DateTimeKind.Unspecified).AddTicks(8205), new TimeSpan(0, -3, 0, 0, 0))
                        },
                        new
                        {
                            ColaboradorId = 7,
                            SetorId = 3,
                            Criado = new DateTimeOffset(new DateTime(2024, 8, 21, 23, 55, 4, 965, DateTimeKind.Unspecified).AddTicks(8206), new TimeSpan(0, -3, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("eCommerce.Office.Models.Setor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Setores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Administração"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Logística"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Separação"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Vendas"
                        },
                        new
                        {
                            Id = 5,
                            Nome = "Financeiro"
                        });
                });

            modelBuilder.Entity("eCommerce.Office.Models.Turma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Turmas");
                });

            modelBuilder.Entity("eCommerce.Office.Models.Veiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Veiculos");
                });

            modelBuilder.Entity("ColaboradorTurma", b =>
                {
                    b.HasOne("eCommerce.Office.Models.Colaborador", null)
                        .WithMany()
                        .HasForeignKey("ColaboradoresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eCommerce.Office.Models.Turma", null)
                        .WithMany()
                        .HasForeignKey("TurmasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ColaboradorVeiculo", b =>
                {
                    b.HasOne("eCommerce.Office.Models.Colaborador", null)
                        .WithMany()
                        .HasForeignKey("ColaboradoresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eCommerce.Office.Models.Veiculo", null)
                        .WithMany()
                        .HasForeignKey("VeiculosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eCommerce.Office.Models.ColaboradorSetor", b =>
                {
                    b.HasOne("eCommerce.Office.Models.Colaborador", "Colaborador")
                        .WithMany("ColaboradorSetor")
                        .HasForeignKey("ColaboradorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eCommerce.Office.Models.Setor", "Setor")
                        .WithMany("ColaboradorSetor")
                        .HasForeignKey("SetorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Colaborador");

                    b.Navigation("Setor");
                });

            modelBuilder.Entity("eCommerce.Office.Models.Colaborador", b =>
                {
                    b.Navigation("ColaboradorSetor");
                });

            modelBuilder.Entity("eCommerce.Office.Models.Setor", b =>
                {
                    b.Navigation("ColaboradorSetor");
                });
#pragma warning restore 612, 618
        }
    }
}
