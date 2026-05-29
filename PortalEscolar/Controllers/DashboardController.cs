using Microsoft.AspNetCore.Mvc;

namespace PortalEscolar.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Docente()
        {
            return View();
        }

        public IActionResult Padre()
        {
            return View();
        }
    }


}