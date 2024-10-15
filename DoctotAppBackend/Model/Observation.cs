using System.ComponentModel.DataAnnotations;

namespace DoctotAppBackend.Model
{
    public class Observation
    {
        [Key]
        [Required]
        public int id { get; set; } // Hacer pública

        public int PatientId { get; set; }

        [Required]
        [StringLength(500)] // Agregar longitud máxima para un mejor control
        public string Notes { get; set; } = ""; // Inicializar en el constructor

        [Required]
        public string Date { get; set; } = ""; // Inicializar en el constructor
    }
}
