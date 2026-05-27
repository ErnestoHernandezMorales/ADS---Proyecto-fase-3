using Microsoft.AspNetCore.Mvc;
using PortalEscolar.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;

namespace PortalEscolar.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var usuario =
                HttpContext.Session.GetString("usuario");

            var rol =
                HttpContext.Session.GetString("rol");

            if (usuario != null)
            {
                if (rol == "DOCENTE")
                {
                    return RedirectToAction(
                        "Docente",
                        "Dashboard");
                }

                else
                {
                    return RedirectToAction(
                        "Padre",
                        "Dashboard");
                }
            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
