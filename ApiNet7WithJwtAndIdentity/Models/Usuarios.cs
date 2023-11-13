using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using ApiNet7WithJwtAndIdentity.Models;

namespace GestionPracticasProfesionalesUtp.Models
{
  public class Usuarios : IdentityUser
  {
    [Required]
    [PersonalData]
    [Column(TypeName = "nvarchar(50)")]
    [Display(Name = "Nombre")]
    public string? Nombre { get; set; }

    [Required]
    [PersonalData]
    [Column(TypeName = "nvarchar(50)")]
    [Display(Name = "Apellido Paterno")]
    public string? ApellidoPaterno { get; set; }

    [Required]
    [PersonalData]
    [Column(TypeName = "nvarchar(50)")]
    [Display(Name = "Apellido Materno")]
    public string? ApellidoMaterno { get; set; }

    // Agregado: Propiedad de navegación inversa para establecer la relación uno a uno
    public Asesores Asesor { get; set; }

    // Agregado: Propiedad de navegación inversa para establecer la relación uno a uno
    public Corraloneros Corralonero { get; set; }
  }
}
