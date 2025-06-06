using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademico.Data;
using SistemaAcademico.Models;

namespace SistemaAcademico.Pages
{
    public class EditAlumnoModel : PageModel
    {
        [BindProperty]
        public Alumno oAlumno { get; set; }
        public void OnGet(int id)
        {
            foreach (var alumno in DatosCompartidos.ListAlumno)
            {
                if (alumno.Id == id)
                {
                    oAlumno = alumno;
                    break;
                }
            }
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            foreach (var alumno in DatosCompartidos.ListAlumno)
            {
                if (alumno.Id == oAlumno.Id)
                {
                    alumno.Nombre = oAlumno.Nombre;
                    alumno.Apellido = oAlumno.Apellido;
                    alumno.Dni = oAlumno.Dni;
                    alumno.Email = oAlumno.Email;
                    alumno.FechaDeNacimiento = oAlumno.FechaDeNacimiento;

                    break;
                }
            }
            return RedirectToPage("TablaAlumnos");
        }
    }
}
