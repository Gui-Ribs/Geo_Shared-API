using Main.Models;

namespace GeoShared.Main.Services.Continente;

public interface IContinenteService
{
    Task<ContinenteModel> filterContinente(string code);
    Task<IEnumerable<ContinenteModel>> getContinente();
    Task<ContinenteModel> createContinente(ContinenteModel createContinente);

}
