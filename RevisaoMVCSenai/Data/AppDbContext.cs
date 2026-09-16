using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using RevisaoMVCSenai.Models;

namespace RevisaoMVCSenai.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Livro> Livros { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConexaoPadrao");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Livro>(entity =>
        {
            entity.HasKey(e => e.IdLivro).HasName("PK__Livro__3B69D85A75486443");

            entity.ToTable("Livro");

            entity.Property(e => e.Descricao).HasMaxLength(500);
            entity.Property(e => e.NomeLivro).HasMaxLength(120);
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsario).HasName("PK__Usuarios__C9BC84CD4D21588E");

            entity.HasIndex(e => e.Nome, "UQ__Usuarios__7D8FE3B2005E07A7").IsUnique();

            entity.HasIndex(e => e.Email, "UQ__Usuarios__A9D105340B04A4AE").IsUnique();

            entity.Property(e => e.Email).HasMaxLength(150);
            entity.Property(e => e.Nome).HasMaxLength(40);
            entity.Property(e => e.Senha).HasMaxLength(32);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
