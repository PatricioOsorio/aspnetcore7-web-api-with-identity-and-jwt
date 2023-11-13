using GestionPracticasProfesionalesUtp.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApiNet7WithJwtAndIdentity.Models
{
  public class Corraloneros
  {
    [Key]
    [ForeignKey(nameof(Usuario))]
    public string IdCorralonero { get; set; }

    // Propiedad de navegación hacia el modelo Usuarios
    public Usuarios Usuario { get; set; }
  }
}
