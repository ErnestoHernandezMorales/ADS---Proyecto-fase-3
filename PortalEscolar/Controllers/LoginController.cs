using Microsoft.AspNetCore.Mvc;

namespace PortalEscolar.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}