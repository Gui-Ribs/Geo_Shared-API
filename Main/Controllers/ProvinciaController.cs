using GeoShared.Main.Services.Imagem;
using GeoShared.Main.Services.Provincia;
using Main.Models;
using Microsoft.AspNetCore.Mvc;

namespace Main.Controllers;

[ApiController]
[Route("shared/[controller]")]
public class ProvinciaController : ControllerBase
{
    private readonly IProvinciaService _provinciaService;

    public ProvinciaController(IProvinciaService provinciaService)
    {
        this._provinciaService = provinciaService;
    }

    [HttpPost]
    public async Task<ActionResult> createProvincia([FromBody] ProvinciaModel provinciaCreated)
    { 
        var newProvincia = await _provinciaService.createProvincia(provinciaCreated);
        return CreatedAtAction(nameof(filterProvincia), new { code = provinciaCreated.code }, provinciaCreated);

    }

    [HttpGet]
    public async Task<IEnumerable<ProvinciaModel>> getProvincia()
    {
        var provincias = await _provinciaService.getProvincia();
        return provincias;
    }

    [HttpGet("{code}")]
    public async Task<ActionResult<ProvinciaModel>> filterProvincia(string code)
    {
        var filterProvincias = await _provinciaService.filterProvincia(code);
        ActionResult returnProvincia = filterProvincias != null ? Ok(filterProvincias) : NotFound();
        return returnProvincia;
    }
}