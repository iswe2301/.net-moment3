using System.ComponentModel.DataAnnotations; // Inkluderar dataannotations för att kunna använda required

namespace BookApp.Models;

// Modell för böcker
public class Book
{
    public int Id { get; set; } // Primärnyckel

    [Required(ErrorMessage = "Titel måste anges")] // Titel måste anges
    [Display(Name = "Titel")] // Visa "Titel" i formuläret
    public string Title { get; set; } = string.Empty; // Titel på boken

    [Required(ErrorMessage = "Utgivningsår måste anges")] // Utgivningsår måste anges
    [Display(Name = "Utgivningsår")] // Visa "Utgivningsår" i formuläret
    public int PublicationYear { get; set; } // Utgivningsår

    // Främmandenyckel för författare
    [Required(ErrorMessage = "Författare måste anges")] // Författare måste anges
    [Display(Name = "Författare")] // Visa "Författare" i formuläret
    public int AuthorId { get; set; }

    // Författare som boken tillhör från Author-modellen
    [Display(Name = "Författare")] // Visa "Författare" i formuläret
    public Author? Author { get; set; }
}
