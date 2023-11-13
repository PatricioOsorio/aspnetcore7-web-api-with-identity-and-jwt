using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiNet7WithJwtAndIdentity.Models
{
  public class Regiones
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdRegion { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(100)")]
    [Display(Name = "Nombre")]
    public string Nombre { get; set; }

    // Propiedad de navegación inversa para establecer la relación uno a uno con Corralones
    public Corralones Corralon { get; set; }
  }
}
