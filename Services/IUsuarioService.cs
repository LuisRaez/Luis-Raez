using Luis_Raez.Models;
using System.Collections.Generic;

public interface IUsuarioService
{
    public interface IUsuarioService
    {
        Task<Usuario> ObtenerUsuarioPorCredencialesAsync(string userName, string password);
    }
    IEnumerable<Usuario> ObtenerUsuarios();
    Usuario ObtenerUsuarioPorId(int id);
    Usuario CrearUsuario(Usuario usuario);
    Usuario ActualizarUsuario(Usuario usuario);
    void EliminarUsuario(int id);
    bool ExisteUsuario(int id);
}