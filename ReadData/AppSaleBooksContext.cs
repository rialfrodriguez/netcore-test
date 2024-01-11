using Microsoft.EntityFrameworkCore;

namespace ReadData
{
    public class AppSaleBooksContext : DbContext
    {        
        private const string connectionString = @"Data Source=DESKTOP-05FDVL2\SQLEXPRESS;Initial Catalog=BooksDB;Trust Server Certificate=True;Authentication=ActiveDirectoryIntegrated";

        public DbSet<Book> Books { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<Comment> Coments { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookAuthor> BooksAuthors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer(connectionString);           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookAuthor>().HasKey(
                x => new { x.BookId, x.AuthorId }
            );
        }
    }
}