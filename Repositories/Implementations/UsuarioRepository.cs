using Luis_Raez.Models;

namespace Luis_Raez.Repositories.Implementations
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly DataDbContext _context;

        public UsuarioRepository(DataDbContext context)
        {
            _context = context;
        }

        public Usuario ActualizarUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Usuario CrearUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void EliminarUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public bool ExisteUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public Usuario ObtenerUsuarioPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> ObtenerUsuarios()
        {
            throw new NotImplementedException();
        }

    }

}
