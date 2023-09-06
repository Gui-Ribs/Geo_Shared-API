using Main.Models;

namespace GeoShared.Main.Repository.Quiz;

public interface IQuizRepository
{
    Task<QuizModel> FilterQuiz(string code);
    Task<IEnumerable<QuizModel>> GetQuiz();
}
