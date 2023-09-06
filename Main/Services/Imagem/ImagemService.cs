using GeoShared.Main.Repository.Imagem;
using Main.Models;

namespace GeoShared.Main.Services.Imagem;

public class ImagemService : IImagemService
{
    private readonly IImagemRepository _imagemRepository;

    public ImagemService(IImagemRepository imagemRepository) 
    { 
        this._imagemRepository = imagemRepository;
    }  

    async Task<ImagemModel> IImagemService.filterImagem(string code)
    {
        return await _imagemRepository.filterImagem(code);
    }

    Task<IEnumerable<ImagemModel>> IImagemService.getImagem()
    {
        return _imagemRepository.getImagem();
    }
}
