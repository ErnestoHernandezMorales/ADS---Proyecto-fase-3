using Microsoft.AspNetCore.Mvc;
using PortalEscolar.Data;
using PortalEscolar.Models;
using System.Linq;

namespace PortalEscolar.Controllers
{
    public class AvisosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AvisosController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var avisos = _context.Avisos.ToList();

            return View(avisos);
        }

        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(Aviso aviso)
        {
            aviso.fecha_publicacion = DateTime.Now;

            _context.Avisos.Add(aviso);

            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}