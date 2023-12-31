﻿using System.ComponentModel.DataAnnotations.Schema;
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

    // Relación 1 a 1 con Regiones
    [ForeignKey(nameof(IdRegion))]
    public Regiones Region { get; set; }
    public int IdRegion { get; set; }

    public ICollection<Regiones> Regiones { get; set; } // Agregar una lista de Corralones en Regiones para la relación inversa

    // Relación 1 a 1 con Ubicaciones
    [ForeignKey(nameof(IdUbicacion))]
    public Ubicaciones Ubicacion { get; set; }
    public int IdUbicacion { get; set; }

    public ICollection<Ubicaciones> Ubicaciones { get; set; } // Agregar una lista de Corralones en Ubicaciones para la relación inversa

    // Relación 1 a 1 con Corraloneros
    [ForeignKey(nameof(IdCorralonero))]
    public Corraloneros Corralonero { get; set; }
    public string IdCorralonero { get; set; }

    public ICollection<Corraloneros> Corraloneros { get; set; } // Agregar una lista de Corralones en Corraloneros para la relación inversa

    // Relación 1:N con Gruas
    public ICollection<Gruas> Gruas { get; set; }

    // Relación 1:N con Arrastres
    public ICollection<Arrastres> Arrastres { get; set; }
  }
}
