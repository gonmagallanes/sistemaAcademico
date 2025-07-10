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
    public class EditCarreraModel : PageModel
    {
        [BindProperty]
        public Carrera oCarrera { get; set; }
        public List<string> Modalidades = new List<string>();
        private readonly ServicioCarrera oServicioCarrera;

        public EditCarreraModel()
        {
            IAccesoDatos<Carrera> acceso = new AccesoDatos<Carrera>("Carreras");
            IRepository<Carrera> repo = new RepositorioCrudJson<Carrera>(acceso);
            oServicioCarrera = new ServicioCarrera(repo);
        }
        public void OnGet(int id)
        {
            Modalidades = OpcionesModalidad.Lista;

            Carrera? carrera = oServicioCarrera.BuscarPorId(id);

            if (carrera != null)
            {
                oCarrera = carrera;
            }
        }
        public IActionResult OnPost()
        {
            Modalidades = OpcionesModalidad.Lista;

            if (!ModelState.IsValid)
            {
                return Page();
            }

            oServicioCarrera.Editar(oCarrera);

            return RedirectToPage("TablaCarreras");
        }

    }
}
