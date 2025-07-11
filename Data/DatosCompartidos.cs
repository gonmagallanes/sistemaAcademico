using SistemaAcademico.Models;

namespace SistemaAcademico.Data
{
    public static class DatosCompartidos
    {
        public static List<Carrera> ListCarreras = new List<Carrera>();
        public static List<Alumno> ListaAlumnos = new List<Alumno>();

        private static int carreraId = 0;
        private static int almunoId = 0;
        public static int ObtenerNuevoCarreraId()
        {
            carreraId++;
            return carreraId;
        }

        public static int ObtenerNuevoAlumnoId()
        {
            almunoId++;
            return almunoId;
        }
    }

}
