using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademico.AccesoDatos;
using SistemaAcademico.Data;
using SistemaAcademico.Models;
using SistemaAcademico.Repositorios;
using SistemaAcademico.Servicios;

namespace SistemaAcademico.Pages
{
    public class TablaAlumnosModel : PageModel
    {
        public List<Alumno> listaAlumnos;
        private readonly ServicioAlumno oServicioAlumno;
        public TablaAlumnosModel()
        {
            IAccesoDatos<Alumno> acceso = new AccesoDatos<Alumno>("Alumnos");
            IRepository<Alumno> repo = new RepositorioCrudJson<Alumno>(acceso);
            oServicioAlumno = new ServicioAlumno(repo);
        }
        public void OnGet()
        {
            listaAlumnos = oServicioAlumno.ObtenerTodos();
        }
    }
}
