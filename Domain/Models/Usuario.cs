namespace desenroleApi.Domain.Models;

public class Usuario : BaseModel
{
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Senha { get; set; } = string.Empty;
    public List<Fatura> Faturas { get; set; } = [];
    public List<Gasto> Gastos { get; set; } = [];
}