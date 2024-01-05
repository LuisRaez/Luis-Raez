using Luis_Raez.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

[Route("api/productos")]
[ApiController]
public class ProductoController : ControllerBase
{
    private readonly IProductoService _productoService;

    public ProductoController(IProductoService productoService)
    {
        _productoService = productoService;
    }

    [HttpGet]
    public IActionResult ObtenerProductos()
    {
        var productos = _productoService.ObtenerProductos();
        return Ok(productos);
    }

    [HttpGet("{id}")]
    public IActionResult ObtenerProductoPorId(int id)
    {
        var producto = _productoService.ObtenerProductoPorId(id);
        if (producto == null)
        {
            return NotFound();
        }
        return Ok(producto);
    }

    [HttpPost]
    public IActionResult CrearProducto([FromBody] Producto producto)
    {
        var nuevoProducto = _productoService.CrearProducto(producto);
        return CreatedAtAction(nameof(ObtenerProductoPorId), new { id = nuevoProducto.Id }, nuevoProducto);
    }

    [HttpPut("{id}")]
    public IActionResult ActualizarProducto(int id, [FromBody] Producto producto)
    {
        if (id != producto.Id)
        {
            return BadRequest();
        }

        try
        {
            var productoActualizado = _productoService.ActualizarProducto(producto);
            return Ok(productoActualizado);
        }
        catch (Exception)
        {
            return NotFound();
        }
    }

    [HttpDelete("{id}")]
    public IActionResult EliminarProducto(int id)
    {
        var producto = _productoService.ObtenerProductoPorId(id);
        if (producto == null)
        {
            return NotFound();
        }

        _productoService.EliminarProducto(id);
        return NoContent();
    }
}
