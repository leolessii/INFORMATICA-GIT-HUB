using System;
using System.Collections.Generic;
using System.Security.Principal;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace Webapi.Models;
public partial class FilmDBContext: DbContext
{
    public DbSet<Film> Films { set; get; }
    public DbSet<Regista> Registi  { get; set; }
    public FilmDbContext()
    {
    }

    public FilmDbContext(DbContextOptions<FilmDbContext> options)
        : base(options)
    {
    }

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //     => optionsBuilder.UseSqlServer("Server=localhost;Database=FILMS;User Id=SA;Password=burbero2025;Encrypt=True;TrustServerCertificate=True");

    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     OnModelCreatingPartial(modelBuilder);

    //     modelBuilder.Entity<Regista>()
    //     .HasKey(i => i.Id);

    //     modelBuilder.Entity<Film>()
    //     .HasOne(o => o.Regista)
    //     .WithMany(c => c.Films)
    //     .HasForeignKey(f => f.IdRegista);
    // }

    // partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

}