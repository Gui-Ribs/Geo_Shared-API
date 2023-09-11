using GeoShared.Main.Services.Bioma;
using GeoShared.Main.Services.Continente;
using Main.Models;
using Main.Services;
using Microsoft.AspNetCore.Mvc;

namespace Main.Controllers;

[ApiController]
[Route("shared/[controller]")]
public class ContinenteController : ControllerBase
{
    private readonly IContinenteService _continenteService;

    public ContinenteController(IContinenteService continenteService)
    {
        this._continenteService = continenteService;
    }

    [HttpPost]
    public async Task<ActionResult> createContinente([FromBody] ContinenteModel continenteCreated)
    {
        var newContinente = await _continenteService.createContinente(continenteCreated);
        return CreatedAtAction(nameof(filterContinente), new { code = continenteCreated.code }, continenteCreated);
    }


    [HttpGet]
    public async Task<IEnumerable<ContinenteModel>> getContinente()
    {
        var continentes = await _continenteService.getContinente();
        return continentes;
    }

    [HttpGet("{code}")]
    public async Task<ActionResult<ContinenteModel>> filterContinente(string code)
    {
        var filterContinentes = await _continenteService.filterContinente(code);
        ActionResult returnContinentes = filterContinentes != null ? Ok(filterContinentes) : NotFound(); 
        return returnContinentes;
    }
}