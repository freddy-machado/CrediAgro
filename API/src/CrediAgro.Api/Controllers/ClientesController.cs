using CrediAgro.Application.Clientes.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CrediAgro.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class ClientesController : ControllerBase
{
    private readonly IClienteService _clienteService;

    public ClientesController(IClienteService clienteService)
    {
        _clienteService = clienteService;
    }

    [HttpGet]
    public async Task<IActionResult> Get(CancellationToken cancellationToken)
    {
        var result = await _clienteService.ListadoClientesAsync(cancellationToken);
        return Ok(result);
    }

    [HttpGet("combo")]
    public async Task<IActionResult> Combo(CancellationToken cancellationToken)
    {
        var result = await _clienteService.ListadoClientesComboAsync(cancellationToken);
        return Ok(result);
    }
}
