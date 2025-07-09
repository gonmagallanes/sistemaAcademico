using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademico.Data;
using SistemaAcademico.Helpers;
using SistemaAcademico.Models;


namespace SistemaAcademico.Pages
{
    public class CreateCarreraModel : PageModel
    {
        [BindProperty]
        public Carrera oCarrera { get; set; }
        public List<string> Modalidades { get; set; } = new();
        public void OnGet(){
            Modalidades = OpcionesModalidad.Lista;
        }

        public static int ultimoId = 0;

        public IActionResult OnPost() {

            Modalidades = OpcionesModalidad.Lista;

            if (!ModelState.IsValid)
            {
                return Page();
            }

            oCarrera.Id = DatosCompartidos.ObtenerNuevoId();
            DatosCompartidos.ListCarrera.Add(oCarrera);
            return RedirectToPage("TablaCarreras");
        }
    }
}
