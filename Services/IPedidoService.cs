using Luis_Raez.Models;
using System.Collections.Generic;

public interface IPedidoService
{
    IEnumerable<Pedido> ObtenerPedidos();
    Pedido ObtenerPedidoPorId(int id);
    Pedido CrearPedido(Pedido pedido);
    Pedido ActualizarPedido(Pedido pedido);
    void EliminarPedido(int id);
    bool ExistePedido(int id);
}
