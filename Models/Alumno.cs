﻿namespace SistemaAcademico.Models
{
    public class Alumno
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public int Dni { get; set; }
        public string? Email { get; set; }
        public DateOnly? FechaDeNacimiento { get; set; }

    }
}
