using Microsoft.AspNetCore.Mvc;

namespace parcial.Controllers
{
    public class VentasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
