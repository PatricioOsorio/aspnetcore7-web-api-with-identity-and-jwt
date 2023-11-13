using System.ComponentModel.DataAnnotations;

namespace ApiNet7WithJwtAndIdentity.Models
{
  public class Arrastres
  {
    [Required]
    [DataType(DataType.Date)]
    [Display(Name = "Fecha Entrada")]
    public DateTime FechaEntrada { get; set; }

    [DataType(DataType.Date)]
    [Display(Name = "Fecha Salida")]
    public DateTime? FechaSalida{ get; set; }

    [Required]
    [Display(Name = "Kilometros Recorridos")]
    public float KmRecorridos { get; set; }

    [Required]
    [Display(Name = "Costo por arrastre")]
    public float CostoPorArrastre { get; set; }

    [Required]
    [Display(Name = "Costo por dia")]
    public float CostoPorDia { get; set; }
  }
}
