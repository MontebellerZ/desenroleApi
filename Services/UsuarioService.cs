using desenroleApi.Domain.Models;
using desenroleApi.Services.Interfaces;
using desenroleApi.Data.Repositories.Interfaces;

namespace desenroleApi.Services;

public class UsuarioService(IBaseRepository<Usuario> repository) : BaseService<Usuario>(repository), IUsuarioService
{
    public async Task<Usuario?> GetByEmailAsync(string email)
    {
        var usuarios = await _repository.Find(u => u.Email == email);
        return usuarios.FirstOrDefault();
    }
}