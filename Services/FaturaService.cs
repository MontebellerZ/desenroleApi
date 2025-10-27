using desenroleApi.Data.Repositories.Interfaces;
using desenroleApi.Domain.Models;
using desenroleApi.Services.Interfaces;

namespace desenroleApi.Services;

public class FaturaService(IFaturaRepository repository) : IFaturaService
{
    private readonly IFaturaRepository _repository = repository;

    public async Task<List<Fatura>> GetFaturas()
    {
        var faturas = await _repository.GetAll();
        return faturas;
    }
}