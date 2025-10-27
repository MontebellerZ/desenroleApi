using Microsoft.AspNetCore.Mvc;

namespace desenroleApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsuarioController : ControllerBase
{
    [HttpGet()]
    public ActionResult<List<int>> GetTeste()
    {
        List<int> vetor = [1, 2, 3, 4, 5];
        return Ok(vetor);
    }

    [HttpPost()]
    public ActionResult<List<string>> PostTeste([FromBody] string batata, string cenoura)
    {
        List<string> vetor = [batata, cenoura];
        return Ok(vetor);
    }
}
