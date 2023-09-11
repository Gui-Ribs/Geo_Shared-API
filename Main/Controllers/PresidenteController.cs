using GeoShared.Main.Services.Imagem;
using GeoShared.Main.Services.Presidente;
using Main.Models;
using Microsoft.AspNetCore.Mvc;

namespace Main.Controllers;

[ApiController]
[Route("shared/[controller]")]
public class PresidenteController : ControllerBase
{
    private readonly IPresidenteService _presidenteService;

    public PresidenteController(IPresidenteService presidenteService)
    {
        this._presidenteService = presidenteService;
    }

    [HttpPost]
    public async Task<ActionResult> createPresidente([FromBody] PresidenteModel presidenteCreated)
    {
        var newPresidente = await _presidenteService.createPresidente(presidenteCreated);
        return CreatedAtAction(nameof(filterPresidente), new { name = presidenteCreated.name }, presidenteCreated);
    }

    [HttpGet]
    public async Task<IEnumerable<PresidenteModel>> getPresidente()
    {
        var presidentes = await _presidenteService.getPresidente();
        return presidentes;
    }

    [HttpGet("{name}")]
    public async Task<ActionResult<PresidenteModel>> filterPresidente(string name)
    {
        var filterPresidentes = await _presidenteService.filterPresidente(name);
        ActionResult returnPresidente = filterPresidentes != null ? Ok(filterPresidentes) : NotFound();
        return returnPresidente;
    }
}