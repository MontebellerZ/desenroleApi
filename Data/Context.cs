using desenroleApi.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace desenroleApi.Data;

public class Context : DbContext
{
    public Context(DbContextOptions<Context> options) : base(options)
    {
    }

    public Context()
    {
    }

    public DbSet<Fatura> Faturas => Set<Fatura>();
    public DbSet<Gasto> Gastos => Set<Gasto>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=Desenrole;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(Context).Assembly);
    }
}