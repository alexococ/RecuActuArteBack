using Microsoft.AspNetCore.Mvc;
using ActuArte.Models;
using ActuArte.Business;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace ActuArte.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class CredencialesController : ControllerBase
    {
        private readonly CredentialsService _credentialsService;

        private readonly ILogger<CredencialesController> _logger;

        public CredencialesController(CredentialsService credentialsService, ILogger<CredencialesController> logger)
        {
            _credentialsService = credentialsService;
            _logger = logger;
        }


        [HttpPost("login")]
        public IActionResult Login([FromBody] UsuariosDTO usuariosDTO)
        {
            try
            {
                _logger.LogInformation("Intentando logear usuario");


                var usuario = _credentialsService.Authenticate(usuariosDTO);

                if (usuario == null)
                {
                    return Unauthorized("Credenciales incorrectas");
                }

                _logger.LogInformation("Usuario correcto");
                return Ok(usuario);
            }
            catch
            {
                _logger.LogError("Error de autenticación");
                return StatusCode(500, "Error interno del servidor");
            }
        }



    }
}