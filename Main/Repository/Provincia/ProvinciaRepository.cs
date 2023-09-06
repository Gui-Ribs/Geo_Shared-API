using GeoShared.Main.Configuration;
using Main.Models;
using Microsoft.EntityFrameworkCore;

namespace GeoShared.Main.Repository.Provincia;

public class ProvinciaRepository : DbInjection, IProvinciaRepository
{

    public ProvinciaRepository(AppDbContext context) : base(context) { }


    public async Task<ProvinciaModel> filterProvincia(string code)
    {
        return await _context.Provincias.FirstOrDefaultAsync(b => b.code == code);
    }

    public async Task<IEnumerable<ProvinciaModel>> getProvincia()
    {
        return await _context.Provincias.ToListAsync();
    }


}
