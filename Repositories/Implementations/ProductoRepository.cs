using Luis_Raez.Models;

namespace Luis_Raez.Repositories.Implementations
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly DataDbContext _context;

        public ProductoRepository(DataDbContext context)
        {
            _context = context;
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
