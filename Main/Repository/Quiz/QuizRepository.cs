using GeoShared.Main.Configuration;
using Main.Models;

namespace GeoShared.Main.Repository.Quiz;

public class QuizRepository : DbInjection
{
    public QuizRepository(AppDbContext context) : base(context) { }


    public async Task<QuizModel> FilterQuiz(string code)
    {
        return await _context.Quiz.FirstOrDefaultAsync(c => c.code == code);
    }

    public async Task<IEnumerable<QuizModel>> GetQuiz()
    {
        return await _context.Quiz.ToListAsync();
    }
}
