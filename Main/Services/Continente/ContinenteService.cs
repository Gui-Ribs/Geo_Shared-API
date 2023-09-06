using GeoShared.Main.Repository.Continente;
using Main.Models;

namespace GeoShared.Main.Services.Continente;

public class ContinenteService : IContinenteService
{

    private readonly IContinenteRepository _continenteRepository;

    public ContinenteService(IContinenteRepository _continenteRepository)
    { 
        this._continenteRepository = _continenteRepository;
    }

    async Task<ContinenteModel> IContinenteService.filterContinente(string code)
    {
        return await _continenteRepository.filterContinente(code);
    }

    async Task<IEnumerable<ContinenteModel>> IContinenteService.getContinente()
    {
        return await _continenteRepository.getContinente();
    }
}
