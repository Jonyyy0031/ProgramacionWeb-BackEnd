using System.ComponentModel.DataAnnotations;

namespace ProgramacionWeb_Backend.Models
{
    public class Curriculum
    {
        [Required(ErrorMessage = "El campo Nombre es requerido.")]
        [StringLength(50,ErrorMessage = "El campo Nombre no debe superar los 50 caracteres")]
        public string Nombre { get; set; }
        
        [StringLength(50, ErrorMessage = "El campo Apellidos no debe superar los 50 caracteres")]
        public string Apellidos { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "La fecha de nacimiento es requerida")]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }
        [Required(ErrorMessage = "La direccion es un campo obligatorio")]
        public string Direccion {  get; set; }
        public string Objetivo { get; set; }
        public IFormFile Foto { get; set; }
        public List<DatoLaboral>? DatosLaborales { get; set; }
    }
}
