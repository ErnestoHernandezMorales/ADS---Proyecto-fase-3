using Microsoft.AspNetCore.Mvc;
using PortalEscolar.Data;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace PortalEscolar.Controllers
{

    public class LoginController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LoginController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Acceder(string correo, string password)
        {
            var usuario = _context.Usuarios
                .FirstOrDefault(u =>
                    u.correo == correo &&
                    u.password == password);

            if (usuario != null)
            {
                HttpContext.Session.SetString("usuario", usuario.nombre);

                HttpContext.Session.SetString("rol", usuario.rol);
                if (usuario.rol == "DOCENTE")
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

            ViewBag.Error =
                "Correo o contraseña incorrectos";

            return View("Index");
        }
    }
}