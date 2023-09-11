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

    [HttpPost]
    public async Task<ActionResult> createImagem([FromBody] ImagemModel imagemCreated)
    {
        var newImagem = await _imagemService.createImagem(imagemCreated);
        return CreatedAtAction(nameof(filterImagem), new { code = imagemCreated.code }, imagemCreated);
    }

    [HttpGet]
    public async Task<IEnumerable<ImagemModel>> getImagem()
    {
        var imagens = await _imagemService.getImagem();
        return imagens;
    }

    [HttpGet("{code}")]
    public async Task<ActionResult<ImagemModel>> filterImagem(string code)
    {
        var filterImagens = await _imagemService.filterImagem(code);
        ActionResult returnImagem = filterImagens != null ? Ok(filterImagens) : NotFound();
        return returnImagem;

    }

}