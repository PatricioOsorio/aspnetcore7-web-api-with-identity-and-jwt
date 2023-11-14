using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiNet7WithJwtAndIdentity.Models
{
  public class Arrastres
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdArrastre { get; set; }

    [Required]
    [DataType(DataType.Date)]
    [Display(Name = "Fecha Entrada")]
    public DateTime FechaEntrada { get; set; }

    [DataType(DataType.Date)]
    [Display(Name = "Fecha Salida")]
    public DateTime? FechaSalida { get; set; }

    [Required]
    [Display(Name = "Kilometros Recorridos")]
    public float KmRecorridos { get; set; }

    [Required]
    [Display(Name = "Costo por arrastre")]
    public float CostoPorArrastre { get; set; }

    [Required]
    [Display(Name = "Costo por dia")]
    public float CostoPorDia { get; set; }

    // Relación 1:1 con Siniestros
    [ForeignKey(nameof(Siniestro))]
    [Key]
    public int IdSiniestro { get; set; }
    public Siniestros Siniestro { get; set; }

    // Relación 1:1 con Vehiculos
    [ForeignKey(nameof(Vehiculo))]
    [Key]
    public int IdVehiculo { get; set; }
    public Vehiculos Vehiculo { get; set; }

    // Relación 1:1 con Gruas
    [ForeignKey(nameof(Gruas))]
    public int IdGrua { get; set; }
    public Gruas Grua { get; set; }

    // Relación 1:1 con Corralones
    [ForeignKey(nameof(Corralones))]
    public int IdCorralon { get; set; }
    public Corralones Corralon { get; set; }
  }
}
