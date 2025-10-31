using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;

namespace FilmER.Models;

public partial class FilmDbContext : DbContext
{
    public DbSet<Film> Films { get; set; }
    public DbSet<Regista> Registi { get; set; }
    public FilmDbContext()
    {
    }

    public FilmDbContext(DbContextOptions<FilmDbContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=localhost;Database=FILMS;User Id=SA;Password=burbero2025;Encrypt=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);

        modelBuilder.Entity<Regista>()
            .HasKey(i => i.Id);

        modelBuilder.Entity<Film>()
            .HasOne(o => o.Regista)
            .WithMany(m => m.Films)
            .HasForeignKey(f => f.idRegista);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
