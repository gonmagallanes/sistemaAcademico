using System.ComponentModel.DataAnnotations;

namespace SistemaAcademico.Models
{
    public class Carrera
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Debe tener entre 5 y 20 caracteres")]
        public string? Nombre { get; set; }
        [Display(Name = "Duración en años")]
        [Required(ErrorMessage = "La duracion es obligatoria")]
        [Range(1, 7, ErrorMessage = "La duracion debe ser entre 1 y 7 años")]
        public int? DuracionAnios { get; set; }
        [Display(Name = "Titulo otorgado")]
        [Required(ErrorMessage = "El titulo es obligatorio")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Debe tener entre 5 y 20 caracteres")]
        public string? TituloOtorgado { get; set; }
        [Required(ErrorMessage = "La modalidad es obligatoria")]
        public string? Modalidad { get; set; }

    }
}
