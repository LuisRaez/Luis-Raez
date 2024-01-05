using Luis_Raez.Models;

namespace Luis_Raez.Repositories.Implementations
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly DataDbContext _context;

        public PedidoRepository(DataDbContext context)
        {
            _context = context;
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
