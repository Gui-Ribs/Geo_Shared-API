using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Main.Models;

[Table("Presidente")]
public class PresidenteModel
{
    [Key]
    public string name {get; set;}

    [Required]
    public string country {get; set;}

    [Required]
    public string policy {get; set;}

    public int? age {get; set;}

    [Required]
    public string nationality {get; set;}

    [Required]
    public string urlImage {get; set;}
}
