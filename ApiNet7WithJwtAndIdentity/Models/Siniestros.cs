using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiNet7WithJwtAndIdentity.Models
{
  public class Siniestros
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdSiniestro { get; set; }

    [Required]
    [DataType(DataType.DateTime)]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Display(Name = "Fecha")]
    public DateTime Fecha { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(25)")]
    [Display(Name = "Folio")]
    public string Folio { get; set; }

    [Column(TypeName = "nvarchar(300)")]
    [Display(Name = "Detalles")]
    public string? Detalles { get; set; }

    // Agregado: Propiedad de navegación hacia Asesores para la relación uno a uno
    [ForeignKey(nameof(Asesor))]
    public string IdAsesor { get; set; }
    public Asesores Asesor { get; set; }

    // Agregado: Propiedad de navegación hacia Ubicaciones para la relación uno a uno
    [ForeignKey(nameof(Ubicacion))]
    public int IdUbicacion { get; set; }
    public Ubicaciones Ubicacion { get; set; }
  }
}
