using GeoShared.Main.Services.Continente;
using GeoShared.Main.Services.Governador;
using Main.Models;
using Microsoft.AspNetCore.Mvc;

namespace Main.Controllers;

[ApiController]
[Route("shared/[controller]")]
public class GovernadorController : ControllerBase
{
    private readonly IGovernadorService _governadorService;

    public GovernadorController(IGovernadorService governadorService)
    {
        this._governadorService = governadorService;
    }

    [HttpPost]
    public async Task<ActionResult> createGovernador([FromBody] GovernadorModel governadorCreated)
    {
        var newGovernador = await _governadorService.createGovernador(governadorCreated);
        return CreatedAtAction(nameof(filterGovernador), new { name = governadorCreated.name }, governadorCreated);
    }

    [HttpGet]
    public async Task<IEnumerable<GovernadorModel>> getGovernador()
    {
        var governadores = await _governadorService.getGovernador();
        return governadores;
    }

    [HttpGet("{name}")]
    public async Task<ActionResult<GovernadorModel>> filterGovernador(string name)
    {
        var filterGovernadores = await _governadorService.filterGovernador(name);
        ActionResult returnGovernadores = filterGovernadores != null ? Ok(filterGovernadores) : NotFound();
        return returnGovernadores;

    }
}