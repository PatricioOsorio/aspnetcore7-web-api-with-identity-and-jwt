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
      // Relación 1 a N entre Asesores y Siniestros
      builder.Entity<Siniestros>()
          .HasOne(s => s.Asesor)
          .WithMany(a => a.Siniestros)
          .HasForeignKey(s => s.IdAsesor);

      // Relación 1 a N entre Siniestros y Ubicaciones
      builder.Entity<Siniestros>()
          .HasOne(s => s.Ubicacion)
          .WithMany(u => u.Siniestros)
          .HasForeignKey(s => s.IdUbicacion);

      // ==================================
      // Relaciones de Corralones
      // ==================================
      // Relación 1 a N entre Corralones y Regiones
      builder.Entity<Corralones>()
          .HasOne(c => c.Region)
          .WithMany(r => r.Corralones)
          .HasForeignKey(c => c.IdRegion);

      // Relación 1 a N entre Corralones y Ubicaciones
      builder.Entity<Corralones>()
          .HasOne(c => c.Ubicacion)
          .WithMany(u => u.Corralones)
          .HasForeignKey(c => c.IdUbicacion);

      // Relación 1 a N entre Corralones y Corraloneros
      builder.Entity<Corralones>()
          .HasOne(c => c.Corralonero)
          .WithMany(cr => cr.Corralones)
          .HasForeignKey(c => c.IdCorralonero);

      // ==================================
      // Relaciones de Gruas
      // ==================================
      // Relación 1:N entre Corralones y Gruas
      builder.Entity<Gruas>()
          .HasOne(g => g.Corralon)
          .WithMany(c => c.Gruas)
          .HasForeignKey(g => g.IdCorralon);

      // Relación 1:N entre Gruas y TipoGruas
      builder.Entity<Gruas>()
          .HasOne(g => g.TipoGrua)
          .WithMany(t => t.Gruas)
          .HasForeignKey(g => g.IdTipoGrua);

      // ==================================
      // Relaciones de Arrastres
      // ==================================
      builder.Entity<Arrastres>()
              .HasKey(a => a.IdArrastre);

      // Relación 1 a 1 entre Arrastres y Siniestros
      builder.Entity<Arrastres>()
          .HasOne(a => a.Siniestro)
          .WithOne(s => s.Arrastre)
          .HasForeignKey<Arrastres>(a => a.IdSiniestro)
          .OnDelete(DeleteBehavior.Restrict); // Evita la eliminacion en cascada

      // Relación 1 a 1 entre Arrastres y Vehiculos
      builder.Entity<Arrastres>()
          .HasOne(a => a.Vehiculo)
          .WithOne(v => v.Arrastre)
          .HasForeignKey<Arrastres>(a => a.IdVehiculo)
          .OnDelete(DeleteBehavior.Restrict); // Evita la eliminacion en cascada

      // Relación 1 a 1 entre Arrastres y Gruas
      builder.Entity<Arrastres>()
          .HasOne(a => a.Grua)
          .WithOne(g => g.Arrastre)
          .HasForeignKey<Arrastres>(a => a.IdGrua)
          .OnDelete(DeleteBehavior.Restrict); // Evita la eliminacion en cascada

      // Relación 1 a 1 entre Arrastres y Corralones
      builder.Entity<Arrastres>()
          .HasOne(a => a.Corralon)
          .WithOne(c => c.Arrastre)
          .HasForeignKey<Arrastres>(a => a.IdCorralon)
          .OnDelete(DeleteBehavior.Restrict); // Evita la eliminacion en cascada
    }

    public DbSet<Regiones> Regiones { get; set; }
    public DbSet<TipoGruas> TipoGruas { get; set; }
    public DbSet<Vehiculos> Vehiculos { get; set; }
    public DbSet<Ubicaciones> Ubicaciones { get; set; }

    public DbSet<Asesores> Asesores { get; set; }
    public DbSet<Corraloneros> Corraloneros { get; set; }

    public DbSet<Corralones> Corralones { get; set; }
    public DbSet<Gruas> Gruas { get; set; }
    public DbSet<Siniestros> Siniestros { get; set; }
    public DbSet<Arrastres> Arrastres { get; set; }
  }
}
