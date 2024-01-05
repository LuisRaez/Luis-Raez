using Luis_Raez.Models;
using Luis_Raez.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Luis_Raez.Services.Implementations
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly DataDbContext _dbContext;

        public UsuarioService(DataDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Usuario> ObtenerUsuarioPorCredencialesAsync(string userName, string password)
        {
            // Lógica para buscar el usuario por las credenciales proporcionadas
            // Ejemplo simple (debes implementar tu propia lógica de búsqueda)
            var usuario = await _dbContext.Usuarios.FirstOrDefaultAsync(u => u.UserName == userName && u.Password == password);

            return usuario;
        }

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        Usuario IUsuarioService.ActualizarUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        Usuario IUsuarioService.CrearUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        void IUsuarioService.EliminarUsuario(int id)
        {
            throw new NotImplementedException();
        }

        bool IUsuarioService.ExisteUsuario(int id)
        {
            throw new NotImplementedException();
        }

        Usuario IUsuarioService.ObtenerUsuarioPorId(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Usuario> IUsuarioService.ObtenerUsuarios()
        {
            throw new NotImplementedException();
        }

    }

}
