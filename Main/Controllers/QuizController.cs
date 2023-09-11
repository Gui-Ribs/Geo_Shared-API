using GeoShared.Main.Services.Quiz;
using Main.Models;
using Microsoft.AspNetCore.Mvc;

namespace Main.Controllers;

[ApiController]
[Route("shared/[controller]")]
public class QuizController : ControllerBase
{
    private readonly IQuizService _quizService;


    public QuizController(IQuizService quizService)
    {
        this._quizService = quizService;
    }

    [HttpPost]
    public async Task<ActionResult> createQuiz([FromBody] QuizModel quizCreated)
    {
        var newQuiz = await _quizService.createQuiz(quizCreated);
        return CreatedAtAction(nameof(FilterQuiz), new { code = quizCreated.code }, quizCreated);
    }

    [HttpGet]
    public async Task<IEnumerable<QuizModel>> GetQuiz()
    { 
        var puzzles = await _quizService.GetQuiz();
        return puzzles;
    }

    [HttpGet("{code}")]
    public async Task<ActionResult<QuizModel>> FilterQuiz(string code)
    { 
        var filterQuiz = await _quizService.FilterQuiz(code);
        ActionResult returnQuiz = filterQuiz != null ? Ok(filterQuiz) : NotFound();
        return returnQuiz;
    }

}