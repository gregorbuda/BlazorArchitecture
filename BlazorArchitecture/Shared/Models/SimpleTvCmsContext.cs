using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BlazorArchitecture.Shared.Models;

public partial class SimpleTvCmsContext : DbContext
{
    public SimpleTvCmsContext()
    {
    }

    public SimpleTvCmsContext(DbContextOptions<SimpleTvCmsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Medio> Medios { get; set; }

    public virtual DbSet<TipoMedio> TipoMedios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost\\SQLLOCAL;Database=SimpleTvCMS;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Medio>(entity =>
        {
            entity.HasKey(e => e.MediosId);

            entity.Property(e => e.MediosId).ValueGeneratedNever();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Enlace)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Leyenda)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Titulo)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoMedio>(entity =>
        {
            entity.Property(e => e.TipoMedioId).ValueGeneratedNever();
            entity.Property(e => e.TipoMedios).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
