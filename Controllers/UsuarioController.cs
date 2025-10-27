using System.Threading.Tasks;
using desenroleApi.Domain.Models;
using desenroleApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace desenroleApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsuarioController(IUsuarioService service) : ControllerBase
{
    private readonly IUsuarioService _service = service;

    [HttpGet()]
    [Route("{id}")]
    public async Task<ActionResult<Usuario>> GetById(Guid id)
    {
        var usuario = await _service.GetById(id);
        return Ok(usuario);
    }

    [HttpPost()]
    public async Task<ActionResult<List<string>>> Create([FromBody] Usuario usuarioDto)
    {
        var usuario = await _service.Create(usuarioDto);
        return Ok(usuario);
    }
}
