using GeoShared.Main.Repository.Presidente;
using Main.Models;

namespace GeoShared.Main.Services.Presidente
{
    public class PresidenteService : IPresidenteService
    {
        private readonly IPresidenteRepository _presidenteRepository;

        public PresidenteService(IPresidenteRepository _presidenteRepository) 
        { 
            this._presidenteRepository = _presidenteRepository;
        }

        public async Task<PresidenteModel> createPresidente(PresidenteModel createPresidente)
        {
            return await _presidenteRepository.createPresidente(createPresidente);
        }

        async Task<PresidenteModel> IPresidenteService.filterPresidente(string name)
        {
            return await _presidenteRepository.filterPresidente(name);
        }

        async Task<IEnumerable<PresidenteModel>> IPresidenteService.getPresidente()
        {
            return await _presidenteRepository.getPresidente();
        }
    }
}
