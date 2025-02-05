using System.ComponentModel.DataAnnotations;

namespace BookApp.Models;

// Enum för att ange status på boklån
public enum LoanStatus
{
    Utlånad, // Aktivt lån
    Återlämnad, // Lånet är återlämnat
    Försenad // Lånet är försenat
}

// Modell som representerar ett boklån
public class Loan
{
    public int Id { get; set; } // Primärnyckel

    [Required(ErrorMessage = "Du måste välja en bok")]
    [Display(Name = "Bok")]
    public int BookId { get; set; } // Koppling till boken (främmande nyckel)

    [Required(ErrorMessage = "Du måste välja en låntagare")]
    [Display(Name = "Låntagare")]
    public int UserId { get; set; } // Koppling till låntagaren (främmande nyckel)

    [Required(ErrorMessage = "Du måste välja ett lånedatum")]
    [DataType(DataType.Date)] // Anger att det är ett datum
    [Display(Name = "Lånedatum")] // Visningsnamn
    public DateTime LoanDate { get; set; } = DateTime.Now; // Datum då boken lånades

    [DataType(DataType.Date)]
    [Display(Name = "Återlämningsdatum")]
    public DateTime? ReturnDate { get; set; } // Datum då boken återlämnas, kan vara null

    // Navigationsegenskaper för att kunna navigera till boken och användaren
    [Display(Name = "Bok")]
    public Book? Book { get; set; }

    [Display(Name = "Låntagare")]
    public User? User { get; set; }

    // Status på lånet
    [Display(Name = "Lånestatus")]
    public LoanStatus Status
    {
        get
        {
            // Om boken har ett återlämningsdatum
            if (ReturnDate.HasValue)
            {
                return LoanStatus.Återlämnad; // Sätt status till återlämnad
            }
            else if (DateTime.Now > LoanDate.AddDays(14)) // Om dagens datum är senare än 14 dagar efter lånedatum
            {
                return LoanStatus.Försenad; // Sätt status till försenad
            }
            else
            {
                return LoanStatus.Utlånad; // Annars är lånet aktivt och boken utlånad
            }
        }
    }
}
