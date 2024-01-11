using Microsoft.EntityFrameworkCore;

namespace ReadData
{
    class Program 
    {
        static void Main(string[] args) 
        {
          using (var db = new AppSaleBooksContext()) 
          {
            var newAuthor = new Author {
              Name = "Alfredo",
              LastName = "Ojeda",
              Degree = "Master"
            };
            db.Authors.Add(newAuthor);
            db.SaveChanges();
          }
        }
    }
}