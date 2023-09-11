using GeoShared.Main.Configuration;
using Main.Models;
using Microsoft.EntityFrameworkCore;

namespace GeoShared.Main.Repository.Quiz;

public class QuizRepository : DbInjection, IQuizRepository
{
    public QuizRepository(AppDbContext context) : base(context) { }

    public async Task<QuizModel> createQuiz(QuizModel createQuiz)
    {
        _context.Quiz.Add(createQuiz);
        await _context.SaveChangesAsync();
        return createQuiz;
    }

    public async Task<QuizModel> FilterQuiz(string code)
    {
        return await _context.Quiz.FirstOrDefaultAsync(c => c.code == code);
    }

    public async Task<IEnumerable<QuizModel>> GetQuiz()
    {
        return await _context.Quiz.ToListAsync();
    }
}
