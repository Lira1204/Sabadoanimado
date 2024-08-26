using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Sabadoanimado.Models;

#nullable disable

namespace Sabadoanimado.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240826173909_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.30")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity<concessionaria>(entity =>
            {
                entity.Property(e => e.id)
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                entity.Property(e => e.ano)
                    .HasColumnType("int");

                entity.Property(e => e.estoque)
                    .HasColumnType("int");

                entity.Property(e => e.marca)
                    .IsRequired()
                    .HasColumnType("longtext");

                entity.Property(e => e.modelo)
                    .IsRequired()
                    .HasColumnType("longtext");

                entity.Property(e => e.preco)
                    .HasColumnType("float");

                entity.HasKey(e => e.id);

                entity.ToTable("carros");
            });
        }
    }
}

