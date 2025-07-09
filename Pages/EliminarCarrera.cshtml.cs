using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademico.Data;
using SistemaAcademico.Models;
using SistemaAcademico.Servicios;

namespace SistemaAcademico.Pages
{
    public class EliminarCarreraModel : PageModel
    {
        [BindProperty]

        public Carrera oCarrera { get; set; }
        public IActionResult OnGet(int id)
        {

            var carrera = ServicioCarrera.BuscarPorId(id);
            if (carrera == null)
            {
                return RedirectToPage("Index");
            }

            oCarrera = carrera;
            return Page();

        }

        public IActionResult OnPost(int id)
        {
            ServicioCarrera.EliminarPorId(id);

            return RedirectToPage("TablaCarreras");
        }
    }
}
