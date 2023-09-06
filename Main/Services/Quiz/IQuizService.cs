using Main.Models;

namespace GeoShared.Main.Services.Quiz;

public interface IQuizService
{
    Task<QuizModel> FilterQuiz(string code);
    Task<IEnumerable<QuizModel>> GetQuiz();
}
