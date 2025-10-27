namespace desenroleApi.Domain.Models;

public class Gasto : BaseModel
{
    public required DateOnly Date { get; set; }
    public required string Title { get; set; }
    public required int Amount { get; set; }
    public string? Category { get; set; }
    public required Fatura Fatura { get; set; }
    public required Usuario Usuario { get; set; }
}
