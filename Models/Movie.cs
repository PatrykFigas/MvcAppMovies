using System.ComponentModel.DataAnnotations;

namespace MvcAppMovies.Models
{
    // Model reprezentujący film w bazie danych
    public class Movie
    {
        // Klucz główny (automatycznie generowany)
        public int Id { get; set; }

        // Tytuł filmu (pole wymagane)
        [Required(ErrorMessage = "Tytuł jest wymagany")]
        public string Tytul { get; set; } = string.Empty;

        // Długość filmu w minutach
        public int Dlugosc { get; set; }  

        // Imię i nazwisko reżysera
        public string? Rezyser { get; set; }
    }
}
