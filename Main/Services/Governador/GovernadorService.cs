﻿using GeoShared.Main.Repository.Governador;
using Main.Models;

namespace GeoShared.Main.Services.Governador;

public class GovernadorService : IGovernadorService
{

    private readonly IGovernadorRepository _governadorRepository;

    public GovernadorService(IGovernadorRepository _governadorRepository)
    { 
        this._governadorRepository = _governadorRepository;
    }

    public async Task<GovernadorModel> createGovernador(GovernadorModel createGovernador)
    {
        return await _governadorRepository.createGovernador(createGovernador);
    }

    async Task<GovernadorModel> IGovernadorService.filterGovernador(string name)
    {
        return await _governadorRepository.filterGovernador(name);
    }

    async Task<IEnumerable<GovernadorModel>> IGovernadorService.getGovernador()
    {
        return await _governadorRepository.getGovernador();
    }
}
