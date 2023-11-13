using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApiNet7WithJwtAndIdentity.Models
{
  public class Corralones
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdCorralon { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(7)")]
    [Display(Name = "Dias Activo")]
    public string DiasActivo { get; set; }

    [Column(TypeName = "nvarchar(50)")]
    [Display(Name = "Correo Electrónico")]
    public string? Correo { get; set; }

    [Column(TypeName = "nvarchar(15)")]
    [Display(Name = "Correo Electrónico")]
    public string? Telefono { get; set; }
  }
}
