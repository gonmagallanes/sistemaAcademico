using SistemaAcademico.Models;

namespace SistemaAcademico.Data
{
    public static class DatosCompartidos
    {
        public static List<Carrera> ListCarrera = new();
        public static List<Alumno> ListAlumno = new();

        private static int ultimoId = 0;
        private static int ultimoAlumnoId = 0;

        public static int ObtenerNuevoId()
        {
            ultimoId++;
            return ultimoId;
        }
        public static int ObtenerNuevoAlumnoID()
        {
            ultimoAlumnoId++;
            return ultimoAlumnoId;
        }
    }

}
