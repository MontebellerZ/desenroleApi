using desenroleApi.Domain.Models;

namespace desenroleApi.Services.Interfaces;

public interface IFaturaService
{
    Task<List<Fatura>> GetFaturas();
}