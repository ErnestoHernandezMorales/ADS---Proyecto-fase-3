using Microsoft.AspNetCore.Mvc;

namespace PortalEscolar.Controllers
{
    public class AvisosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}