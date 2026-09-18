using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using RevMVCAtv3.Models;

namespace RevMVCAtv3.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:ConexaoPadrao");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Item>(entity =>
        {
            entity.HasKey(e => e.IdItem).HasName("PK__Item__51E842623B6421F5");

            entity.ToTable("Item");

            entity.Property(e => e.Descricao).HasMaxLength(500);
            entity.Property(e => e.NomeItem).HasMaxLength(120);
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__Usuario__5B65BF9759DF43B7");

            entity.ToTable("Usuario");

            entity.HasIndex(e => e.Nome, "UQ__Usuario__7D8FE3B285D3A214").IsUnique();

            entity.HasIndex(e => e.Email, "UQ__Usuario__A9D105347F481CF3").IsUnique();

            entity.Property(e => e.Email).HasMaxLength(150);
            entity.Property(e => e.Nome)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Senha).HasMaxLength(32);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
