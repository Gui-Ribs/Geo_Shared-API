using Main.Models;

namespace GeoShared.Main.Repository.Continente;

public interface IContinenteRepository
{
    Task<ContinenteModel> filterContinente(string code);
    Task<IEnumerable<ContinenteModel>> getContinente();
    Task<ContinenteModel> createContinente(ContinenteModel createContinente);

}
