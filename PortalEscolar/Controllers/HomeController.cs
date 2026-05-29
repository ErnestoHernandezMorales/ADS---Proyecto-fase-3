using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace PortalEscolar.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var rol = HttpContext.Session.GetString("rol");

            if (rol == "DOCENTE")
            {
                return RedirectToAction("Docente", "Dashboard");
            }

            if (rol == "PADRE")
            {
                return RedirectToAction("Padre", "Dashboard");
            }

            return View();
        }
    }
}