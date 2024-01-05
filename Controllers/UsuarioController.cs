using Luis_Raez.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Luis_Raez.Controllers
{
    public class UsuarioController : Controller
    {
        [ApiController]
        [Route("api/[controller]")]
        public class UsuariosController : ControllerBase
        {
            private readonly IUsuarioService _usuarioService;

            public UsuariosController(IUsuarioService usuarioService)
            {
                _usuarioService = usuarioService;
            }

            [HttpGet]
            public IActionResult ObtenerUsuarios()
            {
                var usuarios = _usuarioService.ObtenerUsuarios();
                return Ok(usuarios);
            }

            [HttpGet("{id}")]
            public IActionResult ObtenerUsuario(int id)
            {
                var usuario = _usuarioService.ObtenerUsuarioPorId(id);
                if (usuario == null)
                {
                    return NotFound();
                }
                return Ok(usuario);
            }

            [HttpPost]
            public IActionResult CrearUsuario([FromBody] Usuario usuario)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var nuevoUsuario = _usuarioService.CrearUsuario(usuario);
                return CreatedAtAction(nameof(ObtenerUsuario), new { id = nuevoUsuario.Id }, nuevoUsuario);
            }

            [HttpPut("{id}")]
            public IActionResult ActualizarUsuario(int id, [FromBody] Usuario usuario)
            {
                if (id != usuario.Id)
                {
                    return BadRequest();
                }

                if (!_usuarioService.ExisteUsuario(id))
                {
                    return NotFound();
                }

                var usuarioActualizado = _usuarioService.ActualizarUsuario(usuario);
                return Ok(usuarioActualizado);
            }

            [HttpDelete("{id}")]
            public IActionResult EliminarUsuario(int id)
            {
                var usuario = _usuarioService.ObtenerUsuarioPorId(id);
                if (usuario == null)
                {
                    return NotFound();
                }

                _usuarioService.EliminarUsuario(id);
                return NoContent();
            }
        }

    }
}
