using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MatriculaApp.Pages
{
    public class MatriculaFormModel : PageModel
    {
        [BindProperty]
        public string Nombre { get; set; }
        [BindProperty]
        public string Documento { get; set; }
        [BindProperty]
        public string Curso { get; set; }
        [BindProperty]
        public string Email { get; set; }

        public string? Mensaje { get; set; }

        public void OnPost()
        {
            Mensaje = $"Estudiante {Nombre} matriculado al curso {Curso}";
        }
    }
}
