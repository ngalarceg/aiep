namespace BoockWorldApp.Models
{
    public class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
        public int AnioPublicacion { get; set; }
        public string Genero { get; set; } = string.Empty;
        public bool Disponible { get; set; } = true;
    }
}
