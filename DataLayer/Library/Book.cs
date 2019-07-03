using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Library
{
    [Table("Books")]
    public class Book
    {
        [Key]

        public int BookId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int NumberOfPages { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public int GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}
