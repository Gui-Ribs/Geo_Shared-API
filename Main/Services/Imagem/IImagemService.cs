using Main.Models;

namespace GeoShared.Main.Services.Imagem;

public interface IImagemService
{
    Task<ImagemModel> filterImagem(string code);
    Task<IEnumerable<ImagemModel>> getImagem();
}
