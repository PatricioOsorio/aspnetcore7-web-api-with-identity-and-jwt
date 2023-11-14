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

    // Relación 1:N entre Asesores y Siniestros
    [ForeignKey(nameof(Asesor))]
    public string IdAsesor { get; set; }
    public Asesores Asesor { get; set; }

    // Propiedad de navegación hacia Ubicaciones para la relación 1 : N
    [ForeignKey(nameof(Ubicacion))]
    public int IdUbicacion { get; set; }
    public Ubicaciones Ubicacion { get; set; }

    public ICollection<Ubicaciones> Ubicaciones { get; set; } // Agregar una lista de Corralones en Ubicaciones para la relación inversa


    // Relación 1:1 con Arrastres
    public Arrastres Arrastre { get; set; }
  }
}
