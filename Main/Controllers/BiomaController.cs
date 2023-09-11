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

    [HttpPost]
    public async Task<ActionResult> createBioma([FromBody] BiomaModel biomaCreated)
    {
        var newBioma = await _biomaService.createBioma(biomaCreated);
        return CreatedAtAction(nameof(filterBioma), new { name = biomaCreated.name }, biomaCreated);
    }

    [HttpGet]
    public async Task<IEnumerable<BiomaModel>> getBioma()
    { 
        var biomas = await _biomaService.getBioma();
        return biomas;
    }

    [HttpGet("{name}")]
    public async Task<ActionResult<BiomaModel>> filterBioma(string name)
    { 
        var filterBiomas = await _biomaService.filterBioma(name);
        ActionResult returnBiomas = filterBiomas != null ? Ok(filterBiomas) : NotFound();
        return returnBiomas;
    }

}