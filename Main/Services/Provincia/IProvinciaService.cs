using Main.Models;

namespace GeoShared.Main.Services.Provincia;

public interface IProvinciaService
{
    Task<ProvinciaModel> filterProvincia(string code);
    Task<IEnumerable<ProvinciaModel>> getProvincia();
    Task<ProvinciaModel> createProvincia(ProvinciaModel createProvincia);
}
