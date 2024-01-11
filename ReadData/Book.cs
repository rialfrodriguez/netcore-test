using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReadData
{
    [Table("Books")]
    public class Book {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime PublicationDate { get; set; }
        public string? CoverPhoto { get; set; }
        public Price? Price {get; set; }
        public ICollection<Comment>? Comments { get; set; }
        public ICollection<BookAuthor>? BooksAuthors { get; set; }
    }
}