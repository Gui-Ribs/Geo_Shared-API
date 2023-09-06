using GeoShared.Main.Services.Quiz;
using Main.Models;
using Microsoft.AspNetCore.Mvc;

namespace Main.Controllers;

[ApiController]
[Route("shared/[controller]")]
public class QuizController : ControllerBase
{

    DateTime yesterday = DateTime.Today;

   /*  private static readonly string[] Summaries = new[]
    {

    }*/

    private readonly IQuizService _quizService;


      public QuizController(IQuizService quizService)
    {
        this._quizService = quizService;
    }

    [HttpGet]
    public async Task<IEnumerable<QuizModel>> GetQuiz()
    { 
        var puzzles = await _quizService.GetQuiz();
        if (puzzles == null)
        {
            NotFound("Erro 404");
        }
        return puzzles;
    }

    [HttpGet("{code}")]
    public async Task<ActionResult<QuizModel>> FilterQuiz(string code)
    { 
        var filterQuiz = await _quizService.FilterQuiz(code);
        if (filterQuiz == null)
        {
            NotFound("Erro 404");
        }
        return filterQuiz;
    
    }

}