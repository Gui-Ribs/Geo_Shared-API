using GeoShared.Main.Configuration;
using Main.Models;
using Microsoft.EntityFrameworkCore;

namespace GeoShared.Main.Repository.Imagem;

public class ImagemRepository : DbInjection, IImagemRepository
{
    public ImagemRepository(AppDbContext context) : base(context) { }


    public async Task<ImagemModel> filterImagem(string code)
    {
        return await _context.Imagens.FirstOrDefaultAsync(c => c.code == code);
    }

    public async Task<IEnumerable<ImagemModel>> getImagem()
    {
        return await _context.Imagens.ToListAsync();
    }
}
