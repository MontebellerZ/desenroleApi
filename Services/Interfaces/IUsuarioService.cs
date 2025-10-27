using desenroleApi.Domain.Models;

namespace desenroleApi.Services.Interfaces;

public interface IUsuarioService : IBaseService<Usuario>
{
    Task<Usuario?> GetByEmailAsync(string email);
}