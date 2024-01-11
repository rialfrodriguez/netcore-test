using System.ComponentModel.DataAnnotations.Schema;

namespace ReadData
{
    [Table("Authors")]
    public class Author
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? Degree { get; set; }
        public byte[]? ProfilePicture { get; set; }
        public ICollection<BookAuthor>? BooksAuthors { get; set; }
    }
}