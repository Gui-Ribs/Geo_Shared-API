using GeoShared.Main.Repository.Provincia;
using Main.Models;

namespace GeoShared.Main.Services.Provincia;

public class ProvinciaService : IProvinciaService
{
    private readonly IProvinciaRepository _provinciaRepository;
    public ProvinciaService(IProvinciaRepository provinciaRepository) 
    { 
        this._provinciaRepository = provinciaRepository;
    }

    public async Task<ProvinciaModel> filterProvincia(string code)
    {
        return await _provinciaRepository.filterProvincia(code);
    }

    public async Task<IEnumerable<ProvinciaModel>> getProvincia()
    {
       return await _provinciaRepository.getProvincia();
    }
}
