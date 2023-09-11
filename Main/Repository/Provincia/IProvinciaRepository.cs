using Main.Models;

namespace GeoShared.Main.Repository.Provincia;

public interface IProvinciaRepository
{
    Task<ProvinciaModel> filterProvincia(string code);
    Task<IEnumerable<ProvinciaModel>> getProvincia();
    Task<ProvinciaModel> createProvincia(ProvinciaModel createProvincia);
}
