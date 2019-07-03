using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Library
{
    [Table("Library")]
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Book> Books { get; set; }
    }
}
