using System.ComponentModel.DataAnnotations;

namespace PeliculaApi.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public bool Estado { get; set; }
    }
}
