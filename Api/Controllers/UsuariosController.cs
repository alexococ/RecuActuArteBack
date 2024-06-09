using Microsoft.AspNetCore.Mvc;
using ActuArte.Models;
using ActuArte.Business;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace ActuArte.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class UsuariosController : ControllerBase
    {
        private readonly UsuariosService _usuarioService;

        private readonly ILogger<UsuariosController> _logger;

        public UsuariosController(UsuariosService usuarioService, ILogger<UsuariosController> logger)
        {
            _usuarioService = usuarioService;
            _logger = logger;
        }



        [HttpGet]
        public ActionResult<List<Usuarios>> GetAll() => _usuarioService.GetAll();



        [HttpGet("{Id}")]
        public ActionResult<Usuarios> Get(int Id)
        {
            try
            {
                var usuarios = _usuarioService.Get(Id);

                if (usuarios == null)
                    return NotFound();

                _logger.LogInformation("Recogiendo usuario por ID");
                return usuarios;
            }
            catch
            {
                _logger.LogError("Error al obtener el usuario");
                return StatusCode(400, "Usuario no encontrado");
            }
        }



        [HttpPut("{Id}")]
        public IActionResult Update(int Id, Usuarios usuarios)
        {
            try
            {
                if (Id != usuarios.idUsuario)
                    return BadRequest();

                var existingUser = _usuarioService.Get(Id);
                if (existingUser is null)
                    return NotFound();

                _usuarioService.Update(usuarios);

                _logger.LogInformation("Realizado el put de Usuario correctamente");
                return NoContent();
            }
            catch
            {
                _logger.LogError("");
                return StatusCode(500, "Error interno del servidor");
            }
        }



        [HttpPost]
        public ActionResult<UsuariosDTO> Create(Usuarios usuario)
        {
            try
            {
                var existeUser = _usuarioService.Get(usuario.idUsuario);
                if (existeUser != null)
                {
                    return BadRequest($"Una obra con el ID {usuario.idUsuario} ya existe.");
                }

                _usuarioService.Add(usuario);

                _logger.LogInformation("Usuario posteado correctamente");
                return CreatedAtAction(nameof(Create), new { Id = usuario.idUsuario }, usuario);
            }
            catch
            {
                _logger.LogError("Error al postear un Usuario");
                return StatusCode(500, "Error interno del servidor");
            }
        }



        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {
            try
            {
                var usuario = _usuarioService.Get(Id);

                if (usuario is null)
                    return NotFound();

                _usuarioService.Delete(Id);

                _logger.LogInformation("Usuario eliminado correctamente");
                return NoContent();
            }
            catch
            {
                _logger.LogError("Error al eliminar un usuario");
                return StatusCode(500, "Error interno del servidor");
            }
        }



    }
}
