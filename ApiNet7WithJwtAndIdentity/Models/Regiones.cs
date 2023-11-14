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

    // Lista de Corralones para establecer la relación uno a muchos con Corralones
    public ICollection<Corralones> Corralones { get; set; }
  }
}
