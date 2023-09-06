using GeoShared.Main.Configuration;
using Main.Models;
using Microsoft.EntityFrameworkCore;

namespace GeoShared.Main.Repository.Bioma;

public class BiomaRepository : DbInjection, IBiomaRepository
{


    public BiomaRepository(AppDbContext context) : base(context) { }


    public async Task<BiomaModel> filterBioma(string name)
    {
        return await _context.Biomas.FirstOrDefaultAsync(b => b.name == name);
    
    }

    public async Task<IEnumerable<BiomaModel>> getBioma()
    {
        return await _context.Biomas.ToListAsync();
    }
}
