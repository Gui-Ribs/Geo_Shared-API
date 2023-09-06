using GeoShared.Main.Configuration;
using Main.Models;
using Microsoft.EntityFrameworkCore;

namespace GeoShared.Main.Repository.Presidente;

public class PresidenteRepository : DbInjection, IPresidenteRepository
{
    public PresidenteRepository(AppDbContext context) : base(context) { }


    public async Task<PresidenteModel> filterPresidente(string name)
    {
        return await _context.Presidentes.FirstOrDefaultAsync(n => n.name == name);
    }

    public async Task<IEnumerable<PresidenteModel>> getPresidente()
    {
        return await _context.Presidentes.ToListAsync();
    }
}
