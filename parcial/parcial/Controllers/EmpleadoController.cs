using data.repositorio;
using Microsoft.AspNetCore.Mvc;
using modelo;

namespace parcial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : Controller
    {

        public readonly IEmpleadoRepositorio _EmpleadoRepositorio;
        public EmpleadoController(IEmpleadoRepositorio EmpleadoRepositorio)
        {
            _EmpleadoRepositorio = EmpleadoRepositorio;
        }
        [HttpGet]
        public async Task<IActionResult> getEmpleado()
        {
            return Ok(await _EmpleadoRepositorio.getEmpleado());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> getEmpleadoById(int id)
        {
            return Ok(await _EmpleadoRepositorio.getEmpleadoById(id));
        }
        [HttpPost]
        public async Task<IActionResult> InsertEmpleado([FromBody] empleado empleado)
        {
            if (empleado == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var created = await _EmpleadoRepositorio.insertEmpleado(empleado);
            return Ok(created);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateEmpleado([FromBody] empleado empleado)
        {
            if (empleado == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var update = await _EmpleadoRepositorio.UpdateEmpleado(empleado);
            return Ok(update);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteEmpleadoById(int id)
        {
            return Ok(await _EmpleadoRepositorio.deleteEmpleado(id));
        }
    }
}
