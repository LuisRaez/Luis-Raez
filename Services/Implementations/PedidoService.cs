using Luis_Raez.Models;
using Luis_Raez.Repositories;

namespace Luis_Raez.Services.Implementations
{
    public class PedidoService : IPedidoService
    {
        private readonly IPedidoRepository _pedidoRepository;

        public PedidoService(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        public Pedido ActualizarPedido(Pedido pedido)
        {
            throw new NotImplementedException();
        }

        public Pedido CrearPedido(Pedido pedido)
        {
            throw new NotImplementedException();
        }

        public void EliminarPedido(int id)
        {
            throw new NotImplementedException();
        }

        public bool ExistePedido(int id)
        {
            throw new NotImplementedException();
        }

        public Pedido ObtenerPedidoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pedido> ObtenerPedidos()
        {
            throw new NotImplementedException();
        }

    }

}
