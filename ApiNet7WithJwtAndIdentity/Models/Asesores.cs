using GestionPracticasProfesionalesUtp.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApiNet7WithJwtAndIdentity.Models
{
  public class Asesores
  {
    [Key]
    [Required]
    [ForeignKey(nameof(Usuarios))]
    public string IdAsesor { get; set; }

    // Propiedad de navegación hacia el modelo Usuarios
    public Usuarios Usuario { get; set; }

    // Propiedad de navegación inversa para establecer la relación uno a uno con Siniestros
    public Siniestros Siniestro { get; set; }
  }
}
