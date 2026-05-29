using Microsoft.AspNetCore.Mvc;
using PortalEscolar.Data;
using PortalEscolar.Models;
using System.Linq;

namespace PortalEscolar.Controllers
{
    public class NotasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NotasController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var notas = _context.Notas.ToList();

            return View(notas);
        }

        public IActionResult Crear()
        {
            var rol = HttpContext.Session.GetString("rol");

            if (rol != "DOCENTE")
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpPost]
        public IActionResult Crear(
            string estudiante,
            string materia,
            string actividad,
            decimal nota,
            string periodo)
        {
            Nota nuevaNota = new Nota();

            nuevaNota.estudiante = estudiante;

            nuevaNota.materia = materia;

            nuevaNota.actividad = actividad;

            nuevaNota.nota = nota;

            nuevaNota.periodo = periodo;

            _context.Notas.Add(nuevaNota);

            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}