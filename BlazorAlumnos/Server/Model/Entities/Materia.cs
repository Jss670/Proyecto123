using System.ComponentModel.DataAnnotations;

namespace BlazorAlumnos.Server.Model.Entities
{
    public class Materia
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Nombre { get; set; }

    }
}
