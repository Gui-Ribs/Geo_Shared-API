using GeoShared.Main.Services.Continente;
using GeoShared.Main.Services.Imagem;
using Main.Models;
using Microsoft.AspNetCore.Mvc;

namespace Main.Controllers;

[ApiController]
[Route("shared/[controller]")]
public class ImagemController : ControllerBase
{
    private readonly IImagemService _imagemService;

    public ImagemController(IImagemService imagemService)
    {
        this._imagemService = imagemService;
    }

    [HttpGet]
    public async Task<IEnumerable<ImagemModel>> getImagem()
    {
        var imagens = await _imagemService.getImagem();
        if (imagens == null)
        {
            NotFound("Erro 404");
        }
        return imagens;
    }

    [HttpGet("{code}")]
    public async Task<ActionResult<ImagemModel>> filterContinente(string code)
    {
        var filterImagens = await _imagemService.filterImagem(code);
        if (filterImagens == null)
        {
            NotFound("Erro 404");
        }
        return filterImagens;

    }

}