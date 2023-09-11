using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Main.Models;

[Table("Provincia")]
public class ProvinciaModel
{
    [Key]
    public string code {get; set;}

    [Required]
    public string name {get; set;}

    [Required]
    public string country {get; set;}

    public float longitude {get; set;}
    public float latitude {get; set;}

    public int? population {get; set;}

    [Required]
    public string bioma { get; set; }

    [Required]
    public string urlImage {get; set;}

    public string ddd {get; set;}
}