using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Main.Models;

[Table("Bioma")]
public class BiomaModel
{
    [Key]
    public string name {get; set;}

    [Required]
    public string clima {get; set;}

    [Required]
    public string urlImage {get; set;}

    [Required]
    public string description {get; set;}
}