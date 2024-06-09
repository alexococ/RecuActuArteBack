using Microsoft.AspNetCore.Mvc;
using ActuArte.Models;
using ActuArte.Business;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace ActuArte.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class AsientosController : ControllerBase
    {
        private readonly AsientosService _asientoService;

        private readonly ILogger<AsientosController> _logger;

        public AsientosController(AsientosService asientoService, ILogger<AsientosController> logger)
        {
            _asientoService = asientoService;
            _logger = logger;
        }

        // GET: /Asientos
        [HttpGet]
        public ActionResult<List<Asientos>> GetAll() => _asientoService.GetAll();

        [HttpGet("{Id}")]
        public ActionResult<Asientos> Get(int Id)
        {
            try
            {
                var asientos = _asientoService.Get(Id);

                if (asientos == null)
                    return NotFound();

                _logger.LogInformation("Obtenido asiento por ID");
                return asientos;
            }
            catch
            {
                _logger.LogError("Error al obtener un asiento por ID");
                return StatusCode(500, "Error interno del servidor");
            }
        }


        [HttpPut("{Id}")]
        public IActionResult Update(int Id, Asientos asientos)
        {
            try
            {
                if (Id != asientos.idAsiento)
                    return BadRequest();

                var existingAsiento = _asientoService.Get(Id);
                if (existingAsiento is null)
                    return NotFound();

                _asientoService.Update(asientos);
                
                _logger.LogInformation("Put correcto de asiento");
                return NoContent();
            }
            catch
            {
                _logger.LogError("");
                return StatusCode(500, "Error interno del servidor");
            }
        }


    }
}
