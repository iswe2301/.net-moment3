using Microsoft.EntityFrameworkCore;
using BookApp.Models; // Inkludera modellerna Book och Author

namespace BookApp.Data;

// Klass för att skapa databaskopplingen
public class ApplicationDbContext : DbContext
{
    // Konstruktor som tar emot inställningar och skickar dem vidare till basklassen
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // DbSet för att skapa tabeller i databasen
    public DbSet<Book> Books { get; set; } // Tabell för böcker baserat på modellen Book
    public DbSet<Author> Authors { get; set; } // Tabell för författare baserat på modellen Author
    public DbSet<User> Users { get; set; } // Tabell för användare baserat på modellen User
    public DbSet<Loan> Loans { get; set; } // Tabell för boklån baserat på modellen Loan
}