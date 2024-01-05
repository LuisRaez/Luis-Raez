using Luis_Raez.Models;
using Luis_Raez.Repositories;

namespace Luis_Raez.Services.Implementations
{
    public class ProductoService : IProductoService
    {
        private readonly IProductoRepository _productoRepository;

        public ProductoService(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }

        public Producto ActualizarProducto(Producto producto)
        {
            throw new NotImplementedException();
        }

        public Producto CrearProducto(Producto producto)
        {
            throw new NotImplementedException();
        }

        public void EliminarProducto(int id)
        {
            throw new NotImplementedException();
        }

        public bool ExisteProducto(int id)
        {
            throw new NotImplementedException();
        }

        public Producto ObtenerProductoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Producto> ObtenerProductos()
        {
            throw new NotImplementedException();
        }

    }

}
