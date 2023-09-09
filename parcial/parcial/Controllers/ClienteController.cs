using data.repositorio;
using Microsoft.AspNetCore.Mvc;
using modelo;

namespace parcial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : Controller
    {
        public readonly IclienteRepositorio _ClienteRepositorio;
        public ClienteController(IclienteRepositorio ClienteRepsitorio)
        {
            _ClienteRepositorio = ClienteRepsitorio;
        }
        [HttpGet]
        public async Task<IActionResult> getCondcutor()
        {
            return Ok(await _ClienteRepositorio.getClientes());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> getClienteById(int id)
        {
            return Ok(await _ClienteRepositorio.getClienteById(id));
        }
        [HttpPost]
        public async Task<IActionResult> InsertCliente([FromBody] Cliente Cliente)
        {
            if (Cliente == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var created = await _ClienteRepositorio.insertCliente(Cliente);
            return Ok(created);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCliente([FromBody] Cliente Cliente)
        {
            if (Cliente == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var update = await _ClienteRepositorio.UpdateClientes(Cliente);
            return Ok(update);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteClienteById(int id)
        {
            return Ok(await _ClienteRepositorio.deleteCliente(id));
        }
    }
}
