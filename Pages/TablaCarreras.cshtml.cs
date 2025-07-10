using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademico.AccesoDatos;
using SistemaAcademico.Data;
using SistemaAcademico.Models;
using SistemaAcademico.Repositorios;
using SistemaAcademico.Services;
using SistemaAcademico.Servicios;

namespace SistemaAcademico.Pages
{
    public class TablaCarrerasModel : PageModel
    {
        public List<Carrera> ListaCarrera;
        private readonly ServicioCarrera oServicioCarrera;
        public TablaCarrerasModel()
        {
            IAccesoDatos<Carrera> acceso = new AccesoDatos<Carrera>("Carreras");
            IRepository<Carrera> repo = new RepositorioCrudJson<Carrera>(acceso);
            oServicioCarrera = new ServicioCarrera(repo);
        }
        public void OnGet()
        {
            ListaCarrera = oServicioCarrera.ObtenerTodos();
        }

    }
}
