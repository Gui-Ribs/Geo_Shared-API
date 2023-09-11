using Main.Models;

namespace GeoShared.Main.Repository.Bioma;

public interface IBiomaRepository
{
    Task<BiomaModel> filterBioma(string name);
    Task<IEnumerable<BiomaModel>> getBioma();
    Task<BiomaModel> createBioma(BiomaModel createBioma);

}
