using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiNet7WithJwtAndIdentity.Models
{
  public class TipoGruas
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdTipoGrua { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(50)")]
    [Display(Name = "Tipo")]
    public string Tipo { get; set; }

    // Lista de Gruas para establecer la relación uno a muchos con Gruas
    public ICollection<Gruas> Gruas { get; set; }
  }
}
