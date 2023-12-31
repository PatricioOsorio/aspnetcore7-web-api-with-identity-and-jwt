﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiNet7WithJwtAndIdentity.Models
{
  public class Ubicaciones
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdUbicacion { get; set; }

    [Required]
    [Display(Name = "Latitud")]
    public float Latitud { get; set; }

    [Required]
    [Display(Name = "Longitud")]
    public float Longitud { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(5)")]
    [Display(Name = "Código Postal")]
    public string Cp { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(50)")]
    [Display(Name = "Estado")]
    public string Estado { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(50)")]
    [Display(Name = "Municipio")]
    public string Municipio { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(50)")]
    [Display(Name = "Calle")]
    public string Calle { get; set; }

    [Display(Name = "Número Exterior")]
    public int? NumeroExterior { get; set; }

    [Display(Name = "Número Interior")]
    public int? NumeroInterior { get; set; }

    // Lista de Siniestros para establecer la relación uno a muchos con Siniestros
    public ICollection<Siniestros> Siniestros { get; set; }

    // Lista de Corralones para establecer la relación uno a muchos con Corralones
    public ICollection<Corralones> Corralones { get; set; }
  }
}
