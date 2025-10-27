using Microsoft.AspNetCore.Mvc;

namespace desenroleApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsuarioController : ControllerBase
{
  [HttpGet()]
  public List<int> GetTeste()
  {
    return [1, 2, 3, 4, 5];
  }

  [HttpPost()]
  public List<string> PostTeste([FromBody] string batata, string cenoura)
  {
    return [batata, cenoura];
  }
}
