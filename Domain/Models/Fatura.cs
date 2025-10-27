namespace desenroleApi.Domain.Models;

public class Fatura
{
    public Guid Id { get; set; }
    public string Referencia { get; set; } = "";
    public string Arquivo { get; set; } = "";
    public List<Gasto>? Gastos { get; set; }
}
