using desenroleApi.Data.Repositories.Interfaces;
using desenroleApi.Domain.Models;

namespace desenroleApi.Data.Repositories;

public class UsuarioRepository(Context context) : BaseRepository<Usuario>(context), IUsuarioRepository
{
}