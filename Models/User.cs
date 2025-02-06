using System.ComponentModel.DataAnnotations;

namespace BookApp.Models;

// Modell som representerar en användare
public class User
{
    public int Id { get; set; } // Primärnyckel

    [Required(ErrorMessage = "Ange ditt namn")] // Namn måste anges
    [Display(Name = "Namn")] // Visas som "Namn" i formuläret
    public string Name { get; set; } = string.Empty; // Namn på låntagaren, satt till tom sträng som default

    [Required(ErrorMessage = "Ange din e-postadress")] // E-postadress måste anges
    [EmailAddress(ErrorMessage = "Ange en giltig e-postadress")] // Validerar att det är en giltig e-postadress
    [Display(Name = "E-postadress")] // Visas som "E-postadress" i formuläret
    public string Email { get; set; } = string.Empty; // E-postadress, satt till tom sträng som default

    [Display(Name = "Telefonnummer")] // Visas som "Telefonnummer" i formuläret
    public string? Phone { get; set; } // Telefonnummer, kan vara null

    public List<Loan> Loans { get; set; } = new List<Loan>(); // Lista över lån som användaren har
}
