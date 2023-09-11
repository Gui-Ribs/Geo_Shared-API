using Main.Models;

namespace GeoShared.Main.Repository.Imagem;

public interface IImagemRepository
{
    Task<ImagemModel> filterImagem(string code);
    Task<IEnumerable<ImagemModel>> getImagem();
    Task<ImagemModel> createImagem(ImagemModel createImagem);
}
