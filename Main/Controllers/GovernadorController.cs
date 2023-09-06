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

    [HttpGet]
    public async Task<IEnumerable<GovernadorModel>> getGovernador()
    {
        var governadores = await _governadorService.getGovernador();
        if (governadores == null)
        {
            NotFound("Erro 404");
        }
        return governadores;
    }

    [HttpGet("{name}")]
    public async Task<ActionResult<GovernadorModel>> filterContinente(string name)
    {
        var filterGovernadores = await _governadorService.filterGovernador(name);
        if (filterGovernadores == null)
        {
            NotFound("Erro 404");
        }
        return filterGovernadores;

    }
}