using ApiNet7WithJwtAndIdentity.Models;
using GestionPracticasProfesionalesUtp.Models;
using Microsoft.AspNetCore.Identity;

namespace ApiNet7WithJwtAndIdentity.Context
{
  public enum Roles
  {
    SUPERADMIN,
    ASESOR,
    CORRALONERO
  }

  public static class ContextSeed
  {
    // Seed roles
    public static async Task SeedRolesAsync(RoleManager<IdentityRole> roleManager)
    {
      await roleManager.CreateAsync(new IdentityRole(Roles.SUPERADMIN.ToString()));
      await roleManager.CreateAsync(new IdentityRole(Roles.ASESOR.ToString()));
      await roleManager.CreateAsync(new IdentityRole(Roles.CORRALONERO.ToString()));
    }

    // Seed usuarios
    public static async Task SeedUserAsesorAsync(UserManager<Usuarios> userManager, AuthIdentityDbContext context)
    {
      var newUser = new Usuarios()
      {
        Nombre = "Mariano",
        ApellidoPaterno = "Perez",
        ApellidoMaterno = "Sanchez",
        UserName = "marianoperez@hotmail.com",
        Email = "marianoperez@hotmail.com",
        EmailConfirmed = true,
      };
      if (userManager.Users.All(u => u.Id != newUser.Id))
      {
        var user = await userManager.FindByEmailAsync(newUser.Email);
        if (user == null)
        {
          await userManager.CreateAsync(newUser, "Test123.");
          await userManager.AddToRoleAsync(newUser, Roles.ASESOR.ToString());

          // Create Asesor record
          var newAsesor = new Asesores()
          {
            IdAsesor = newUser.Id,
          };

          context.Asesores.Add(newAsesor);
          await context.SaveChangesAsync();
        }
      }
    }
    public static async Task SeedUserCorraloneroAsync(UserManager<Usuarios> userManager, AuthIdentityDbContext context)
    {
      var newUser = new Usuarios()
      {
        Nombre = "Pedro",
        ApellidoPaterno = "Torrez",
        ApellidoMaterno = "Martinez",
        UserName = "pedrotorrez@hotmail.com",
        Email = "pedrotorrez@hotmail.com",
        EmailConfirmed = true,
      };
      if (userManager.Users.All(u => u.Id != newUser.Id))
      {
        var user = await userManager.FindByEmailAsync(newUser.Email);
        if (user == null)
        {
          await userManager.CreateAsync(newUser, "Test123.");
          await userManager.AddToRoleAsync(newUser, Roles.CORRALONERO.ToString());

          // Create Corralonero record
          var newCorralonero = new Corraloneros()
          {
            IdCorralonero = newUser.Id,
          };

          context.Corraloneros.Add(newCorralonero);
          await context.SaveChangesAsync();
        }
      }

      var newUser2 = new Usuarios()
      {
        Nombre = "Santiago",
        ApellidoPaterno = "Rosas",
        ApellidoMaterno = "Lopez",
        UserName = "santiagolopez@hotmail.com",
        Email = "santiagolopez@hotmail.com",
        EmailConfirmed = true,
      };
      if (userManager.Users.All(u => u.Id != newUser2.Id))
      {
        var user = await userManager.FindByEmailAsync(newUser2.Email);
        if (user == null)
        {
          await userManager.CreateAsync(newUser2, "Test123.");
          await userManager.AddToRoleAsync(newUser2, Roles.CORRALONERO.ToString());

          // Create Corralonero record
          var newCorralonero = new Corraloneros()
          {
            IdCorralonero = newUser2.Id,
          };

          context.Corraloneros.Add(newCorralonero);
          await context.SaveChangesAsync();
        }
      }
    }

    // Seed tablas independientes
    public static async Task SeedTableRegionesAsync(AuthIdentityDbContext context)
    {
      if (!context.Regiones.Any())
      {
        var regiones = new List<Regiones>
        {
          new Regiones {Nombre = "Sierra norte"},
          new Regiones {Nombre = "Sierra nororiental"},
          new Regiones {Nombre = "Valle de Serdán"},
          new Regiones {Nombre = "Angelópolis"},
          new Regiones {Nombre = "Valle de Atlixco y Matamoros"},
          new Regiones {Nombre = "Mixteca"},
          new Regiones {Nombre = "Tehuacán y Sierra negra"},
        };

        context.Regiones.AddRange(regiones);
        await context.SaveChangesAsync();
      }
    }

    public static async Task SeedTableTipoGruasAsync(AuthIdentityDbContext context)
    {
      if (!context.TipoGruas.Any())
      {
        var tipoGruas = new List<TipoGruas>
        {
          new TipoGruas {Tipo = "A"},
          new TipoGruas {Tipo = "B"},
          new TipoGruas {Tipo = "C"},
          new TipoGruas {Tipo = "D"},
        };

        context.TipoGruas.AddRange(tipoGruas);
        await context.SaveChangesAsync();
      }
    }

    public static async Task SeedTableVehiculosAsync(AuthIdentityDbContext context)
    {
      if (!context.Vehiculos.Any())
      {
        var vehiculos = new List<Vehiculos>
        {
          new Vehiculos {Matricula = "AABBCC1", Color = "Negro", Marca = "Chevrolet", Modelo = "Onix"},
          new Vehiculos {Matricula = "AABBCC2", Color = "Rojo", Marca = "Audi", Modelo = "Audi"},
          new Vehiculos {Matricula = "AABBCC3", Color = "Azul", Marca = "Mercedez", Modelo = "EQS SUV"},
        };

        context.Vehiculos.AddRange(vehiculos);
        await context.SaveChangesAsync();
      }
    }

    public static async Task SeedTableUbicacionesAsync(AuthIdentityDbContext context)
    {
      if (!context.Ubicaciones.Any())
      {
        var ubicaciones = new List<Ubicaciones>
        {
          new Ubicaciones {
            Latitud = 19.064565363053347f,
            Longitud = -98.1916778068095f,
            Cp = "72080",
            Estado = "Puebla",
            Municipio = "Heroica Puebla de Zaragoza",
            Calle = "Diag. Defensores de la República",
          },
          new Ubicaciones {
            Latitud = 19.059524085426162f,
            Longitud = -98.22197038370923f,
            Cp = "72140",
            Estado = "Puebla",
            Municipio = "Heroica Puebla de Zaragoza",
            Calle = "Av. 4 Pte. 3311B",
          },
          new Ubicaciones {
            Latitud = 19.16149894803104f,
            Longitud = -98.40896902375917f,
            Cp = "74160",
            Estado = "Puebla",
            Municipio = "Huejotzingo",
            Calle = "Ayala 440-438",
          },
        };

        context.Ubicaciones.AddRange(ubicaciones);
        await context.SaveChangesAsync();
      }
    }

    // Seed tablas dependientes
    public static async Task SeedTableCorralonesAsync(UserManager<Usuarios> userManager, AuthIdentityDbContext context)
    {
      if (!context.Corralones.Any())
      {
        int idRegion = context.Regiones
          .Where(r => r.Nombre == "Angelópolis")
          .Select(r => r.IdRegion)
          .FirstOrDefault();

        int idUbicacion = context.Ubicaciones
          .Where(u => u.Calle == "Diag. Defensores de la República")
          .Select(r => r.IdUbicacion)
          .FirstOrDefault();

        string idCorralonero = context.Corraloneros
         .Where(c => c.Usuario.Email == "pedrotorrez@hotmail.com")
         .Select(c => c.IdCorralonero)
         .FirstOrDefault();

        // =================================
        int idUbicacion2 = context.Ubicaciones
          .Where(u => u.Calle == "Av. 4 Pte. 3311B")
          .Select(r => r.IdUbicacion)
          .FirstOrDefault();

        string idCorralonero2 = context.Corraloneros
         .Where(c => c.Usuario.Email == "santiagolopez@hotmail.com")
         .Select(c => c.IdCorralonero)
         .FirstOrDefault();

        var corralones = new List<Corralones>
        {
          new Corralones {
            IdRegion = idRegion,
            IdUbicacion = idUbicacion,
            IdCorralonero = idCorralonero,
            DiasActivo = "1010101",
            Correo = "DefensoresCorralon@hotmail.com",
            Telefono = "1111111111"
          },
          new Corralones {
            IdRegion = idRegion,
            IdUbicacion = idUbicacion2,
            IdCorralonero = idCorralonero2,
            DiasActivo = "0101010",
            Correo = "Avenida4Poniente@hotmail.com",
            Telefono = "1111111111"
          },
        };

        context.Corralones.AddRange(corralones);
        await context.SaveChangesAsync();
      }
    }

    public static async Task SeedTableGruasAsync(UserManager<Usuarios> userManager, AuthIdentityDbContext context)
    {
      if (!context.Gruas.Any())
      {
        int IdCorralon = context.Regiones
          .Where(r => r.IdRegion == 1)
          .Select(r => r.IdRegion)
          .FirstOrDefault();


        // =================================
        int idUbicacion2 = context.Ubicaciones
          .Where(u => u.Calle == "Av. 4 Pte. 3311B")
          .Select(r => r.IdUbicacion)
          .FirstOrDefault();


        var gruas = new List<Gruas>
        {
          new Gruas {
            IdCorralon = IdCorralon,
            IdTipoGrua = 1, // Tipo 'A'
            Matricula = "GGRRUU1",
            Color = "Gris",
            Marca = "HIAB",
            Modelo = "Model 1"
          },
          new Gruas {
            IdCorralon = IdCorralon,
            IdTipoGrua = 1, // Tipo 'A'
            Matricula = "GGRRUU2",
            Color = "Gris",
            Marca = "HIAB",
            Modelo = "Model 2"
          },
        };

        context.Gruas.AddRange(gruas);
        await context.SaveChangesAsync();
      }
    }

  }
}