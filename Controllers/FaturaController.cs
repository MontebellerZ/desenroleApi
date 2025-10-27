using desenroleApi.Domain.Models;
using desenroleApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace desenroleApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FaturaController(ILogger<FaturaController> logger, IFaturaService service) : ControllerBase
{
    private readonly ILogger<FaturaController> _logger = logger;
    private readonly IFaturaService _service = service;

    [HttpGet]
    public async Task<ActionResult<List<Fatura>>> GetFaturas()
    {
        List<Fatura> result = await _service.GetFaturas();
        return Ok(result);
    }
}
