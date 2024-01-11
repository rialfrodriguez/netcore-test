using System.ComponentModel.DataAnnotations.Schema;

namespace ReadData
{
    [Table("Prices")]
    public class Price
    {
        public int Id { get; set; }
        public decimal ActualPrice { get; set; }
         public decimal Promotion { get; set; }
        public int BookId { get; set; }
        public Book? Book { get; set;}
    }
}