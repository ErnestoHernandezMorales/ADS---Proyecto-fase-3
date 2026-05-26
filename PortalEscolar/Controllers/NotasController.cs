using Microsoft.AspNetCore.Mvc;

namespace PortalEscolar.Controllers
{
    public class NotasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}