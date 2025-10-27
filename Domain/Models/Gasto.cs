namespace desenroleApi.Domain.Models;

public class Gasto
{
    public Guid Id { get; set; }
    public required DateOnly Date { get; set; }
    public required string Title { get; set; }
    public required int Amount { get; set; }
    public string? Category { get; set; }
    public required Fatura Fatura { get; set; }
}
