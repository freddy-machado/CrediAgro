using CrediAgro.Application.Pagos.Interfaces;
using CrediAgro.Contracts.Dtos.Pagos;
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

    [HttpPost("pagos")]
    public async Task<IActionResult> CrearPago(
        [FromRoute] int creditoId,
        [FromBody] CreatePagoCuotaRequestDto request,
        CancellationToken cancellationToken)
    {
        // Por ahora usamos el Name del token si existe; si no, caemos a "api".
        // Se puede integrar con el claim de usuario real del sistema cuando esté definido.
        var usuario = User?.Identity?.Name;
        if (string.IsNullOrWhiteSpace(usuario)) usuario = "api";

        // Normalizamos el CreditoId para trazabilidad.
        request = request with { CreditoId = creditoId };

        var result = await _pagoCuotaService.PagarCuotaPrestamoAsync(creditoId, request, usuario!, cancellationToken);
        return Created(string.Empty, result);
    }
}
