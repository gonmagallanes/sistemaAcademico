using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademico.Data;
using SistemaAcademico.Helpers;
using SistemaAcademico.Models;

namespace SistemaAcademico.Pages
{
    public class EditCarreraModel : PageModel
    {
        [BindProperty]
        public Carrera oCarrera { get; set; }

        public List<string> Modalidades { get; set; } = new();
        public void OnGet(int id)
        {
            Modalidades = OpcionesModalidad.Lista;

            foreach(var carrera in DatosCompartidos.ListCarrera)
            {
                if(carrera.Id == id)
                {
                    oCarrera = carrera;
                    break;
                }
            }
        }
        public IActionResult OnPost()
        {
            Modalidades = OpcionesModalidad.Lista;

            if (!ModelState.IsValid) {
                return Page();
            }

            foreach(var carrera in DatosCompartidos.ListCarrera)
            {
                if(carrera.Id == oCarrera.Id)
                {
                    carrera.Nombre = oCarrera.Nombre;
                    carrera.Modalidad = oCarrera.Modalidad;
                    carrera.DuracionAnios = oCarrera.DuracionAnios;
                    carrera.TituloOtorgado = oCarrera.TituloOtorgado;
                    break;
                }
            }
            return RedirectToPage("TablaCarreras");
        }
            
    }
}
