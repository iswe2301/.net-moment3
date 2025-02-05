using System.ComponentModel.DataAnnotations; // Inkluderar dataannotations för att kunna använda required

namespace BookApp.Models;

// Modell för böcker
public class Book
{
    public int Id { get; set; } // Primärnyckel

    [Required] // Obligatoriskt fält
    [Display(Name = "Titel")] // Visa "Titel" i formuläret
    public string Title { get; set; } = string.Empty; // Titel på boken

    [Required] // Obligatoriskt fält
    [Display(Name = "Utgivningsår")] // Visa "Utgivningsår" i formuläret
    public int PublicationYear { get; set; } // Utgivningsår

    // Främmandenyckel för författare
    [Required] // Obligatoriskt fält
    public int AuthorId { get; set; }

    // Författare som boken tillhör från Author-modellen
    public Author? Author { get; set; }
}
