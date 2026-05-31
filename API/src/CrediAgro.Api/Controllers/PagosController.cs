using CrediAgro.Application.Pagos.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CrediAgro.Api.Controllers;

[ApiController]
[Route("api/creditos/{creditoId:int}")]
public sealed class PagosController : ControllerBase
{
    private readonly IPagoCuotaService _pagoCuotaService;

    public PagosController(IPagoCuotaService pagoCuotaService)
    {
        _pagoCuotaService = pagoCuotaService;
    }

    [HttpGet("pagos")]
    public async Task<IActionResult> Pagos([FromRoute] int creditoId, CancellationToken cancellationToken)
    {
        var result = await _pagoCuotaService.ListaPagosCuotasPrestamoAsync(creditoId, cancellationToken);
        return Ok(result);
    }

    [HttpGet("cuotas-pendientes")]
    public async Task<IActionResult> CuotasPendientes(
        [FromRoute] int creditoId,
        [FromQuery] DateTime fechaPago,
        [FromQuery] decimal monto,
        CancellationToken cancellationToken)
    {
        var result = await _pagoCuotaService.CuotasPendientePagoAsync(creditoId, fechaPago, monto, cancellationToken);
        return Ok(result);
    }
}
