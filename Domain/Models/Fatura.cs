namespace desenroleApi.Domain.Models;

public class Fatura : BaseModel
{
    public required string Referencia { get; set; }
    public required string Arquivo { get; set; }
    public List<Gasto> Gastos { get; set; } = [];
    public required Usuario Usuario { get; set; }
}
