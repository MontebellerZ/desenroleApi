using desenroleApi.Data.Repositories.Interfaces;
using desenroleApi.Domain.Models;

namespace desenroleApi.Data.Repositories;

public class FaturaRepository(Context context) : BaseRepository<Fatura>(context), IFaturaRepository
{
}