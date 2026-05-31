using CrediAgro.Application.Creditos.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CrediAgro.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class CreditosController : ControllerBase
{
    private readonly ICreditoService _creditoService;

    public CreditosController(ICreditoService creditoService)
    {
        _creditoService = creditoService;
    }

    [HttpGet]
    public async Task<IActionResult> Get(CancellationToken cancellationToken)
    {
        var result = await _creditoService.ListadoCreditosAsync(cancellationToken);
        return Ok(result);
    }
}
