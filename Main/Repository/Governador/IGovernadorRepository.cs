using Main.Models;

namespace GeoShared.Main.Repository.Governador;

public interface IGovernadorRepository
{
    Task<GovernadorModel> filterGovernador(string name);
    Task<IEnumerable<GovernadorModel>> getGovernador();
    Task<GovernadorModel> createGovernador(GovernadorModel createGovernador);
}
