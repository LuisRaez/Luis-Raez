using Luis_Raez.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

[Route("api/pedidos")]
[ApiController]
public class PedidoController : ControllerBase
{
    private readonly IPedidoService _pedidoService;

    public PedidoController(IPedidoService pedidoService)
    {
        _pedidoService = pedidoService;
    }

    [HttpGet]
    public IActionResult ObtenerPedidos()
    {
        var pedidos = _pedidoService.ObtenerPedidos();
        return Ok(pedidos);
    }

    [HttpGet("{id}")]
    public IActionResult ObtenerPedidoPorId(int id)
    {
        var pedido = _pedidoService.ObtenerPedidoPorId(id);
        if (pedido == null)
        {
            return NotFound();
        }
        return Ok(pedido);
    }

    [HttpPost]
    public IActionResult CrearPedido([FromBody] Pedido pedido)
    {
        var nuevoPedido = _pedidoService.CrearPedido(pedido);
        return CreatedAtAction(nameof(ObtenerPedidoPorId), new { id = nuevoPedido.Id }, nuevoPedido);
    }

    [HttpPut("{id}")]
    public IActionResult ActualizarPedido(int id, [FromBody] Pedido pedido)
    {
        if (id != pedido.Id)
        {
            return BadRequest();
        }

        try
        {
            var pedidoActualizado = _pedidoService.ActualizarPedido(pedido);
            return Ok(pedidoActualizado);
        }
        catch (Exception)
        {
            return NotFound();
        }
    }

    [HttpDelete("{id}")]
    public IActionResult EliminarPedido(int id)
    {
        var pedido = _pedidoService.ObtenerPedidoPorId(id);
        if (pedido == null)
        {
            return NotFound();
        }

        _pedidoService.EliminarPedido(id);
        return NoContent();
    }
}
