using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademico.AccesoDatos;
using SistemaAcademico.Data;
using SistemaAcademico.Helpers;
using SistemaAcademico.Models;
using SistemaAcademico.Repositorios;
using SistemaAcademico.Services;
using SistemaAcademico.Servicios;


namespace SistemaAcademico.Pages
{
    public class CreateCarreraModel : PageModel
    {
        [BindProperty]
        public Carrera oCarrera { get; set; }
        public List<string> Modalidades { get; set; } = new List<string>();
        private readonly ServicioCarrera oServicioCarrera;

        public CreateCarreraModel()
        {
            IAccesoDatos<Carrera> acceso = new AccesoDatos<Carrera>("Carreras");
            IRepository<Carrera> repo = new RepositorioCrudJson<Carrera>(acceso);
            oServicioCarrera = new ServicioCarrera(repo);
        }
        public void OnGet()
        {
            Modalidades = OpcionesModalidad.Lista;
        }

        public IActionResult OnPost()
        {
            Modalidades = OpcionesModalidad.Lista;

            if (!ModelState.IsValid)
            {
                return Page();
            }

            oServicioCarrera.Agregar(oCarrera);

            return RedirectToPage("TablaCarreras");
        }
    }
}
