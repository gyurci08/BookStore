using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Book
    {
        // Navigation property inicialisation
        public Book() => Authors = new HashSet<Author>();

        // primary key property
        public int BookId { get; set; }

        [Required(ErrorMessage = "Please enter a title.")]
        [MaxLength(200)]
        public string Title { get; set; } = string.Empty;

        [Range(1.0, 1000000.0, ErrorMessage = "Price must be 1 or more.")]
        public double Price { get; set; }


        // Foreignkey property
        [Required(ErrorMessage ="Please select a genre!")]
        public string GenreId { get; set; } = string.Empty;




        // Navigation properties
        [ValidateNever]     //kizárjuk a validációt a modell ellenőrzésből, lehet null, lehet idegen, nem tudjuk
        public Genre Genre { get; set; } = null!;
        public ICollection<Author> Authors { get; set;}

    }
}
