using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Main.Models;

[Table("Continente")]
public class ContinenteModel
{
    [Key]
    public string code {get; set;}

    [Required]
    public string name {get; set;}

    public float latitude {get; set;}
    public float longitude {get; set;}

    public string Bioma { get; set; }
    public BiomaModel Biomas { get; set; }

    [Required]
    public string urlImage {get; set;}
}