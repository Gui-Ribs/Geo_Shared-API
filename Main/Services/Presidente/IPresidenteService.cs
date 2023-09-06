using Main.Models;

namespace GeoShared.Main.Services.Presidente;

public interface IPresidenteService
{
    Task<PresidenteModel> filterPresidente(string name);
    Task<IEnumerable<PresidenteModel>> getPresidente();
}
