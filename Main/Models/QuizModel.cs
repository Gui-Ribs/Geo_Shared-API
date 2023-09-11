using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Main.Models;

[Table("Quiz")]
public class QuizModel
{
    [Key]
    public string code {get; set;}
    public int population {get; set;}
    public string orientation {get; set;}
    public int temperature {get; set;}
    public string continente {get; set;}
    public bool validation {get; set;}
    public string urlImage {get; set;}
}