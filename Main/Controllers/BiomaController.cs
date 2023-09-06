using GeoShared.Main.Services.Bioma;
using Main.Models;
using Main.Services;
using Microsoft.AspNetCore.Mvc;

namespace Main.Controllers;

[ApiController]
[Route("shared/[controller]")]
public class BiomaController : ControllerBase
{
    private readonly IBiomaService _biomaService;

    public BiomaController(IBiomaService biomaService)
    {
        this._biomaService = biomaService;
    }

    [HttpGet]
    public async Task<IEnumerable<BiomaModel>> getBioma()
    { 
        var biomas = await _biomaService.getBioma();
        if (biomas == null)
        {
            NotFound("Erro 404");
        }
        return biomas;
    }

    [HttpGet("{name}")]
    public async Task<ActionResult<BiomaModel>> filterBioma(string name)
    { 
        var filterBiomas = await _biomaService.filterBioma(name);
        if (filterBiomas == null)
        {
            NotFound("Erro 404");
        }
        return filterBiomas;
    
    }

}