using System.ComponentModel.DataAnnotations.Schema;

namespace ReadData
{
    [Table("Comments")]
    public class Comment
    {
        public int Id  { get; set; }
        public string? Student { get; set; }
        public int Score { get; set; }
        public string? CommentText { get; set; }
        public int BookId { get; set; }
        public Book? Book { get; set; }
    }
}