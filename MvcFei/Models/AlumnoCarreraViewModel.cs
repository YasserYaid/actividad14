using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcFei.Models
{
    public class AlumnoCarreraViewModel
    {
        // Lista de alumnos
        public List<Alumno> Alumnos { get; set; }

        // Lista de carreras para seleccionar
        public SelectList Carreras { get; set; }

        //Contiene la carrera seleccionada
        public string? AlumnoCarrera { get; set; }

        // Contiene el texto que los usuarios escriben en el cuadro de texto de busqueda
        public string? SearchString { get; set; }

    }
}
