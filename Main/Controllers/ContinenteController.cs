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

    [HttpGet]
    public async Task<IEnumerable<ContinenteModel>> getContinente()
    {
        var continentes = await _continenteService.getContinente();
        if (continentes == null)
        {
            NotFound("Erro 404");
        }
        return continentes;
    }

    [HttpGet("{code}")]
    public async Task<ActionResult<ContinenteModel>> filterContinente(string code)
    {
        var filterContinentes = await _continenteService.filterContinente(code);
        if (filterContinentes == null)
        {
            NotFound("Erro 404");
        }
        return filterContinentes;

    }
}