using SistemaAcademico.Models;
using SistemaAcademico.Repositorios;

namespace SistemaAcademico.Services
{
    public class ServicioCarrera
    {
        private readonly IRepository<Carrera> repos;
        public ServicioCarrera(IRepository<Carrera> repo)
        {
            repos = repo;
        }
        public List<Carrera> ObtenerTodos()
        {
            return repos.ObtenerTodos();
        }
        public Carrera? BuscarPorId(int id)
        {
            return repos.BuscarPorId(id);
        }
        public void Editar(Carrera carrera)
        {
            repos.Editar(carrera);
        }
        public void EliminarPorId(int id)
        {
            repos.EliminarPorId(id);
        }
        public void Agregar(Carrera carrera)
        {
            repos.Agregar(carrera);
        }
    }
}
