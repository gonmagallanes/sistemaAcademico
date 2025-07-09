using SistemaAcademico.Models;
using System.Text.Json;

namespace SistemaAcademico.Servicios
{
    public class ServicioCarrera
    {
        private static string ruta = "Data/carreras.json";

        public static string LeerTextoDelArchivo()
        {
            if (File.Exists(ruta))
            {
                return File.ReadAllText(ruta);
            }
            return "[]";
        }

        public static List<Carrera> ObtenerCarrera()
        {
            string json = LeerTextoDelArchivo();

            var lista = JsonSerializer.Deserialize<List<Carrera>>(json);
            return lista ?? new List<Carrera>();
        }

        public static int ObtenerNuevoId(List<Carrera> carreras) 
        {
            int maxId = 0;
            foreach (var carrera in carreras)
            {
                if(carrera.Id > maxId)
                {
                    maxId = carrera.Id;
                }
            }

            return maxId + 1;
        }

        public static void GuardarCarreras(List<Carrera> carreras)
        {
            string textoJson = JsonSerializer.Serialize(carreras);
            File.WriteAllText(ruta, textoJson);
        }

        public static void AgregarCarrera(Carrera nuevaCarrera)
        {
            var carreras = ObtenerCarrera();
            nuevaCarrera.Id = ObtenerNuevoId(carreras);
            carreras.Add(nuevaCarrera);
            GuardarCarreras(carreras);
        }
    }
}
