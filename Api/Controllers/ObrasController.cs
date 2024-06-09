using Microsoft.AspNetCore.Mvc;
using ActuArte.Models;
using ActuArte.Business;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace ActuArte.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class ObrasController : ControllerBase
    {
        private readonly ObrasService _obraService;
        private readonly ILogger<ObrasController> _logger;

        public ObrasController(ObrasService obraService, ILogger<ObrasController> logger)
        {
            _obraService = obraService;
            _logger = logger;
        }

        // GET: /Obras
        [HttpGet]
        public ActionResult<List<Obras>> GetAll() => _obraService.GetAll();


        [HttpGet("{Id}")]
        public ActionResult<Obras> Get(int Id)
        {
            try
            {
                var obras = _obraService.Get(Id);
                if (obras == null)
                    return NotFound();

                _logger.LogInformation("Obteniendo obra por ID");
                return obras;
            }
            catch
            {
                _logger.LogError("Error obteniendo todas las obras.");
                return StatusCode(500, "Un error ocurrió al obtener la lista de obras.");
            }

        }


        [HttpPut("{Id}")]
        public IActionResult Update(int Id, Obras obras)
        {
            try
            {
                if (Id != obras.idObra)
                    return BadRequest();

                var existingObra = _obraService.Get(Id);
                if (existingObra is null)
                    return NotFound();

                _obraService.Update(obras);
                
                _logger.LogInformation("Put de Obra por id correcto");
                return NoContent();
            }
            catch
            {
                _logger.LogError("Error al hacer PUT");
                return StatusCode(500, "Error interno del servidor al hacer put de obras");
            }

        }



        [HttpPost]
        public ActionResult<Obras> Create(Obras obra)
        {
            try
            {
                var existeObra = _obraService.Get(obra.idObra);
                if (existeObra != null)
                {
                    return BadRequest($"Una obra con el ID {obra.idObra} ya existe.");
                }

                _logger.LogInformation("Posteada una Obra");
                _obraService.Add(obra);
                return CreatedAtAction(nameof(Create), new { Id = obra.idObra }, obra);
            }
            catch
            {
                _logger.LogError("Error al hacer un post de obras");
                return StatusCode(500, "Error interno del servidor");
            }


        }



        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {

            try
            {
                var obras = _obraService.Get(Id);

                if (obras is null)
                    return NotFound();

                _obraService.Delete(Id);

                _logger.LogInformation("Obra eliminada correctamente");
                return NoContent();
            }
            catch
            {
                _logger.LogError("La obra no ha sido eliminada como se esperaba");
                return StatusCode(500, "Error interno del servidor");
            }

        }



        /* ID DE OBRA E ID DE SESION */
        [HttpPost("{id}/Sesion/{sesionId}")]
        public IActionResult AddObra(int id, int sesionId, [FromBody] List<int> asientos)
        {
            try
            {
                if (asientos == null)
                {
                    return BadRequest("No hay información de asiento para agregar.");
                }

                foreach (var asiento in asientos)
                {
                    _obraService.AddObra(id, sesionId, asiento);
                }

                _logger.LogInformation("Los asientos han sido añadidos correctamente");
                return Ok("Asientos añadidos correctamente.");
            }
            catch
            {
                _logger.LogError("Los asientos no han podido ser añaidos");
                return StatusCode(500, "Error interno del servidor");
            }
        }



        [HttpGet("{id}/Session")]
        public ActionResult GetAsientos(int id, int sessionId)
        {
            try
            {
                var asientosId = _obraService.GetObrasAsientos(id, sessionId);

                if (asientosId == null)
                {
                    return NotFound("No se ha encontrado la obra.");
                }

                _logger.LogInformation("Recogiendo los asientos ocupados");
                return Ok(asientosId);
            }
            catch
            {
                _logger.LogError("No se han podido devolver los asientos ocupados");
                return StatusCode(500, "Error interno del servidor");
            }
        }


        [HttpGet("aclamadas")]
        public ActionResult<List<Obras>> GetAclamadas() => _obraService.GetAclamadas();

        [HttpGet("recientes")]
        public ActionResult<List<Obras>> GetRecientes() => _obraService.GetRecientes();

        [HttpGet("ultimasSesiones")]
        public ActionResult<List<Obras>> GetUltimasSesiones() => _obraService.GetUltimasSesiones();
    }
}