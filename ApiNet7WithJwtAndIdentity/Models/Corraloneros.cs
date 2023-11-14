using GestionPracticasProfesionalesUtp.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApiNet7WithJwtAndIdentity.Models
{
  public class Corraloneros
  {
    [Key]
    [Required]
    [ForeignKey(nameof(Usuarios))]
    public string IdCorralonero { get; set; }

    // Propiedad de navegación hacia el modelo Usuarios
    public Usuarios Usuario { get; set; }

    // Lista de Corralones para establecer la relación uno a muchos con Corralones
    public ICollection<Corralones> Corralones { get; set; }
  }
}
