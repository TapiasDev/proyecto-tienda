using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LaQuiebraBack.Data;
using LaQuiebraModelo.Entidades;

namespace LaQuiebraBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly DataContext _context;

        public UsuariosController(DataContext context)
        {
            _context = context;
        }

        // POST: api/Usuarios/login
        // Control de acceso: valida usuario y contraseña y devuelve el rol
        [HttpPost("login")]
        public async Task<ActionResult<LoginRespuesta>> Login(Login login)
        {
            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(u => u.NombreUsuario == login.Usuario && u.Contrasena == login.Contrasena);

            if (usuario == null)
            {
                return Unauthorized(new LoginRespuesta
                {
                    Exito = false,
                    Mensaje = "Usuario o contraseña incorrectos"
                });
            }

            return new LoginRespuesta
            {
                Exito = true,
                Usuario = usuario.NombreUsuario,
                Rol = usuario.Rol,
                Mensaje = "Bienvenido " + usuario.NombreUsuario
            };
        }
    }
}
