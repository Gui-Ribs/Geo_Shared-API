using Main.Models;
using Microsoft.AspNetCore.Mvc;

namespace Main.Services;

public interface IBiomaService
{
    Task<ActionResult<BiomaModel>> filterBioma(string name);
    Task<IEnumerable<BiomaModel>> getBioma();
    
}