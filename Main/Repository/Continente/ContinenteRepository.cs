using GeoShared.Main.Configuration;
using Main.Models;
using Microsoft.EntityFrameworkCore;

namespace GeoShared.Main.Repository.Continente;

public class ContinenteRepository : DbInjection, IContinenteRepository
{


    public ContinenteRepository(AppDbContext context) : base(context) { }

    public async Task<ContinenteModel> createContinente(ContinenteModel createContinente)
    {
        _context.Continentes.Add(createContinente);
        await _context.SaveChangesAsync();
        return createContinente;
    }

    public async Task<ContinenteModel> filterContinente(string code)
    {
        return await _context.Continentes.FirstOrDefaultAsync(c => c.code == code);
    }

    public async Task<IEnumerable<ContinenteModel>> getContinente()
    {
        return await _context.Continentes.ToListAsync();
    }
}

