using GeoShared.Main.Configuration;
using Main.Models;
using Microsoft.EntityFrameworkCore;

namespace GeoShared.Main.Repository.Governador;

public class GovernadorRepository : DbInjection, IGovernadorRepository
{
    public GovernadorRepository(AppDbContext context) : base(context) { }

    public async Task<GovernadorModel> createGovernador(GovernadorModel createGovernador)
    {
        _context.Governadores.Add(createGovernador);
        await _context.SaveChangesAsync();
        return createGovernador;
    }

    public async Task<GovernadorModel> filterGovernador(string name)
    {
        return await _context.Governadores.FirstOrDefaultAsync(n => n.name == name);
    }

    public async Task<IEnumerable<GovernadorModel>> getGovernador()
    {
        return await _context.Governadores.ToListAsync();
    }
}
