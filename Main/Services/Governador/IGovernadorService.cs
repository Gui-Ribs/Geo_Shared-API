using Main.Models;

namespace GeoShared.Main.Services.Governador;

public interface IGovernadorService
{
    Task<GovernadorModel> filterGovernador(string name);
    Task<IEnumerable<GovernadorModel>> getGovernador();
    Task<GovernadorModel> createGovernador(GovernadorModel createGovernador);
}
