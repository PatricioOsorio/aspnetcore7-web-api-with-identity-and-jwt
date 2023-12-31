﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApiNet7WithJwtAndIdentity.Models
{
  public class Vehiculos
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdVehiculo { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(7)")]
    [MaxLength(7)]
    [MinLength(5)]
    [Display(Name = "Matricula")]
    public string Matricula { get; set; }

    [Column(TypeName = "nvarchar(20)")]
    [Display(Name = "Color")]
    public string? Color { get; set; }

    [Column(TypeName = "nvarchar(20)")]
    [Display(Name = "Marca")]
    public string? Marca { get; set; }

    [Column(TypeName = "nvarchar(20)")]
    [Display(Name = "Modelo")]
    public string? Modelo { get; set; }

    // Relación 1:N con Arrastres
    public ICollection<Arrastres> Arrastres { get; set; }
  }
}
