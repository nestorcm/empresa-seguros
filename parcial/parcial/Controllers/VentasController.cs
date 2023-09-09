using data.repositorio;
using Microsoft.AspNetCore.Mvc;
using modelo;

namespace parcial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentasController : Controller
    {

        public readonly IVentasRepositorio _VentasRepositorio;
        public VentasController(IVentasRepositorio VentasRepositorio)
        {
            _VentasRepositorio = VentasRepositorio;
        }
        [HttpGet]
        public async Task<IActionResult> getVentas()
        {
            return Ok(await _VentasRepositorio.getVentas());
        }
        
        [HttpPost]
        public async Task<IActionResult> InsertEmpleado([FromBody] ventas ventas)
        {
            if (ventas == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var created = await _VentasRepositorio.insertVentas(ventas);
            return Ok(created);
        }
    }
}
