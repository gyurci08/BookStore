using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Genre
    {
        // Navigation property inicialization
        public Genre() => Books = new HashSet<Book>();


        // primary key property
        [MaxLength(10)]
        [Required(ErrorMessage = "Please enter a genre id.")]
        public string GenreId { get; set; } = string.Empty;

        [StringLength(25)]
        [Required(ErrorMessage = "Please enter a genre name.")]
        public string Name { get; set; } = string.Empty;


        // Navigation property
        public ICollection <Book> Books { get; set; }



    }
}
