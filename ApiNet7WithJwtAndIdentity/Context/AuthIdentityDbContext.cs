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

      // ==================================
      // Relaciones de Usuarios
      // ==================================
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

      // ==================================
      // Relaciones de Siniestros
      // ==================================
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

      // ==================================
      // Relaciones de Corralones
      // ==================================
      // Relación 1 a 1 entre Corralones y Regiones
      builder.Entity<Corralones>()
          .HasOne(c => c.Region)
          .WithOne(r => r.Corralon)
          .HasForeignKey<Corralones>(c => c.IdRegion);

      // Relación 1 a 1 entre Corralones y Ubicaciones
      builder.Entity<Corralones>()
          .HasOne(c => c.Ubicacion)
          .WithOne(u => u.Corralon)
          .HasForeignKey<Corralones>(c => c.IdUbicacion);

      // Relación 1 a 1 entre Corralones y Corraloneros
      builder.Entity<Corralones>()
          .HasOne(c => c.Corralonero)
          .WithOne(cr => cr.Corralon)
          .HasForeignKey<Corralones>(c => c.IdCorralonero);

      // ==================================
      // Relaciones de Gruas
      // ==================================
      // Relación 1:N entre Corralones y Gruas
      builder.Entity<Gruas>()
          .HasOne(g => g.Corralon)
          .WithMany(c => c.Gruas)
          .HasForeignKey(g => g.IdCorralon);

      // Relación 1:1 entre Gruas y TipoGruas
      builder.Entity<Gruas>()
          .HasOne(g => g.TipoGruas)
          .WithOne(t => t.Gruas)
          .HasForeignKey<Gruas>(g => g.IdTipoGruas);
    }

    public DbSet<Ubicaciones> Ubicaciones { get; set; }
    public DbSet<Regiones> Regiones { get; set; }
    public DbSet<TipoGruas> TipoGruas { get; set; }
    public DbSet<Vehiculos> Vehiculos { get; set; }

    public DbSet<Asesores> Asesores { get; set; }
    public DbSet<Corraloneros> Corraloneros { get; set; }

    public DbSet<Siniestros> Siniestros { get; set; }
    public DbSet<Corralones> Corralones { get; set; }
    public DbSet<Gruas> Gruas { get; set; }



    public DbSet<Employee> Employees { get; set; }
  }
}
