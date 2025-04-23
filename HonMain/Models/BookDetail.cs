using System.ComponentModel.DataAnnotations;

namespace HonMain.Models
{
    public class BookDetail
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the book name.")]
        [StringLength(50, ErrorMessage = "Book name cannot exceed 50 characters.")]
        public string BookName { get; set; }

        [Required(ErrorMessage = "Please enter the genre name.")]
        [StringLength(20, ErrorMessage = "Genre name cannot exceed 20 characters.")]
        public String Genre { get; set; }

        public bool AvailabilityStatus { get; set; } = true;
    }

}
