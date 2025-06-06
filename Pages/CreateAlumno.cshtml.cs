using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademico.Data;
using SistemaAcademico.Models;

namespace SistemaAcademico.Pages
{
    public class CreateAlumnoModel : PageModel
    {
        [BindProperty]
        public Alumno oAlumno { get; set; }
        public void OnGet()
        {
        }

        public static int ultimoAlumnoId = 0;

        public IActionResult OnPost()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }
            oAlumno.Id = DatosCompartidos.ObtenerNuevoAlumnoID();
            DatosCompartidos.ListAlumno.Add(oAlumno);
            return RedirectToPage("TablaAlumnos");
        }
    }
}
