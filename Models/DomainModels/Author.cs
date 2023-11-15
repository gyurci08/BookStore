using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Author
    {
        // Navigation property initialize - Kapcsolat definíció inicializáció
        public Author() => Books = new HashSet<Book>();     // Nem lista mert lehetnek ugyanolyan elemek



        // primary key property
        public int AuthorId { get; set; }

        [Required(ErrorMessage = "Please enter a first name.")]
        [MaxLength(200)]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a last name.")]
        [MaxLength(200)]
        public string LastName { get; set; } = string.Empty;

        // read-only property
        public string FullName => $"{FirstName} {LastName}";


        // Navigation property - Kapcsolat definíció
        // 1 szerző : Sok könyv
        public ICollection<Book> Books { get; set; }    // Nincs aláhúzás, mert lett inicializálva fentebb ;)


    }
}

// A CASCADE MEGMARADT!!!!!!!!!!!!!!!!!! //