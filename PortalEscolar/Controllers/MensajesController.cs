using Microsoft.AspNetCore.Mvc;

namespace PortalEscolar.Controllers
{
    public class MensajesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}