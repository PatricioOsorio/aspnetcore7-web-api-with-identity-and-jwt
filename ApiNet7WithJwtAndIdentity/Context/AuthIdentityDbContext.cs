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

      //Relación 1 a 1 entre Users y Asesores
      builder.Entity<Asesores>()
       .HasOne(c => c.Usuario)
       .WithOne(u => u.Asesor)
       .HasForeignKey<Asesores>(c => c.IdAsesor);

      //Relación 1 a 1 entre Users y Students
      builder.Entity<Corraloneros>()
        .HasOne(c => c.Usuario)
        .WithOne(u => u.Corralonero)
        .HasForeignKey<Corraloneros>(c => c.IdCorralonero);
    }

    public DbSet<Employee> Employees { get; set; }
    public DbSet<Asesores> Asesores { get; set; }
    public DbSet<Corraloneros> Corraloneros { get; set; }
  }
}
