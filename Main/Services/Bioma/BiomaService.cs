using Main.Services;
using Main.Models;
using GeoShared.Main.Repository.Bioma;
using Microsoft.AspNetCore.Mvc;

namespace GeoShared.Main.Services.Bioma;
public class BiomaService : IBiomaService
{

    private readonly IBiomaRepository _biomaRepository;


    public BiomaService(IBiomaRepository biomaRepository)
    { 
        this._biomaRepository = biomaRepository;
    }

    public async Task<BiomaModel> createBioma(BiomaModel createBioma)
    {
        return await _biomaRepository.createBioma(createBioma);
    }

    public async Task<ActionResult<BiomaModel>> filterBioma(string name)
    { 
        return await _biomaRepository.filterBioma(name);
    }

    public async Task<IEnumerable<BiomaModel>> getBioma()
    {
       return await _biomaRepository.getBioma();
    }
}
