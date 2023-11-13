using ApiNet7WithJwtAndIdentity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ApiNet7WithJwtAndIdentity.Context
{
  public class AuthIdentityDbContext : IdentityDbContext
  {
    public AuthIdentityDbContext(DbContextOptions options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);

      //Relación 1 a 1 entre Usuarios y Asesores
      builder.Entity<Asesores>()
       .HasOne(c => c.Usuario)
       .WithOne(u => u.Asesor)
       .HasForeignKey<Asesores>(c => c.IdAsesor);

      //Relación 1 a 1 entre Usuarios y Corraloneros
      builder.Entity<Corraloneros>()
        .HasOne(c => c.Usuario)
        .WithOne(u => u.Corralonero)
        .HasForeignKey<Corraloneros>(c => c.IdCorralonero);

      // Relación 1 a 1 entre Siniestros y Asesores
      builder.Entity<Siniestros>()
          .HasOne(s => s.Asesor)
          .WithOne(a => a.Siniestro)
          .HasForeignKey<Siniestros>(s => s.IdAsesor);

      // Relación 1 a 1 entre Siniestros y Ubicaciones
      builder.Entity<Siniestros>()
          .HasOne(s => s.Ubicacion)
          .WithOne(u => u.Siniestro)
          .HasForeignKey<Siniestros>(s => s.IdUbicacion);
    }

    public DbSet<Ubicaciones> Ubicaciones { get; set; }
    public DbSet<Regiones> Regiones { get; set; }
    public DbSet<TipoGruas> TipoGruas { get; set; }
    public DbSet<Vehiculos> Vehiculos { get; set; }

    public DbSet<Asesores> Asesores { get; set; }
    public DbSet<Corraloneros> Corraloneros { get; set; }

    public DbSet<Siniestros> Siniestros { get; set; }


    public DbSet<Employee> Employees { get; set; }
  }
}
