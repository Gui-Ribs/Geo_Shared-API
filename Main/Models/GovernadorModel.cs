using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Main.Models;

[Table("Governador")]
public class GovernadorModel
{
    [Key]
    public string name {get; set;}

    [Required]
    public string policy {get; set;}

    [Required]
    public string Provincia {get; set;}
    public ProvinciaModel Provincias { get; set; }

    public int? age {get; set;}

    [Required]
    public string urlImage {get; set;}

    [Required]
    public string nacionality {get; set;}
}