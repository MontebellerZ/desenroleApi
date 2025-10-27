using desenroleApi.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace desenroleApi.Data.Mappings;

public class FaturaMap : IEntityTypeConfiguration<Fatura>
{
    public void Configure(EntityTypeBuilder<Fatura> builder)
    {
        builder.HasOne(g => g.Usuario).WithMany(f => f.Faturas);
    }
}