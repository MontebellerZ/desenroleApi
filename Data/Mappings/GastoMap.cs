using desenroleApi.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace desenroleApi.Data.Mappings;

public class GastoMap : IEntityTypeConfiguration<Gasto>
{
    public void Configure(EntityTypeBuilder<Gasto> builder)
    {
        builder.HasOne(g => g.Fatura).WithMany(f => f.Gastos);
    }
}