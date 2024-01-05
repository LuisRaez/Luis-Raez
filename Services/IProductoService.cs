using Luis_Raez.Models;
using System.Collections.Generic;

public interface IProductoService
{
    IEnumerable<Producto> ObtenerProductos();
    Producto ObtenerProductoPorId(int id);
    Producto CrearProducto(Producto producto);
    Producto ActualizarProducto(Producto producto);
    void EliminarProducto(int id);
    bool ExisteProducto(int id);
}
