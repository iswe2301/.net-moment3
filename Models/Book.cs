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
    public int AuthorId { get; set; }

    // Författare som boken tillhör från Author-modellen, required för att det är obligatoriskt att en bok har en författare
    [Required]
    public required Author Author { get; set; }
}
