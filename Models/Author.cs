using System.ComponentModel.DataAnnotations; // Inkluderar dataannotations för att kunna använda required

namespace BookApp.Models;

// Modell för författare
public class Author
{
    public int Id { get; set; } // Primärnyckel

    [Required(ErrorMessage = "Författare måste anges")] // Författare måste anges
    [Display(Name = "Författare")] // Visa "Författare" i formuläret
    public string Name { get; set; } = string.Empty; // Namn på författaren

    // Lista med böcker som tillhör författaren från Book-modellen
    public List<Book> Books { get; set; } = new List<Book>();
}