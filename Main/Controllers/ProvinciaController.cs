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

    [HttpGet]
    public async Task<IEnumerable<ProvinciaModel>> getProvincia()
    {
        var provincias = await _provinciaService.getProvincia();
        if (provincias == null)
        {
            NotFound("Erro 404");
        }
        return provincias;
    }

    [HttpGet("{code}")]
    public async Task<ActionResult<ProvinciaModel>> filterProvincia(string code)
    {
        var filterProvincias = await _provinciaService.filterProvincia(code);
        if (filterProvincias == null)
        {
            NotFound("Erro 404");
        }
        return filterProvincias;

    }
}