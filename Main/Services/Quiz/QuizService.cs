using GeoShared.Main.Repository.Quiz;
using Main.Models;

namespace GeoShared.Main.Services.Quiz;

public class QuizService : IQuizService
{

    private readonly IQuizRepository _quizRepository;

    public QuizService(IQuizRepository quizRepository) 
    {
        this._quizRepository = quizRepository;
    }

    public async Task<QuizModel> createQuiz(QuizModel createQuiz)
    {
        return await _quizRepository.createQuiz(createQuiz);
    }

    public async Task<QuizModel> FilterQuiz(string code)
    {
        return await _quizRepository.FilterQuiz(code);
    }

    public async Task<IEnumerable<QuizModel>> GetQuiz()
    {
        return await _quizRepository.GetQuiz();
    }
}

