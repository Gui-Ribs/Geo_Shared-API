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

    [HttpGet]
    public async Task<IEnumerable<PresidenteModel>> getImagem()
    {
        var imagens = await _presidenteService.getPresidente();
        if (imagens == null)
        {
            NotFound("Erro 404");
        }
        return imagens;
    }

    [HttpGet("{name}")]
    public async Task<ActionResult<PresidenteModel>> filterPresidente(string name)
    {
        var filterPresidentes = await _presidenteService.filterPresidente(name);
        if (filterPresidentes == null)
        {
            NotFound("Erro 404");
        }
        return filterPresidentes;
    }
}