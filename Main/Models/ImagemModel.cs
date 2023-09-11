using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Main.Models;

[Table("Imagem")]
public class ImagemModel
{
    [Key]
    public string code {get; set;}

    [Required]
    public string url {get; set;}
}