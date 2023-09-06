using Main.Models;

namespace GeoShared.Main.Repository.Presidente;

public interface IPresidenteRepository
{
    Task<PresidenteModel> filterPresidente(string name);
    Task<IEnumerable<PresidenteModel>> getPresidente();
}
