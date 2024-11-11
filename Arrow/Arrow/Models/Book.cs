namespace Arrow.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Book(int id, string title, int authorId, Author author, DateTime releaseDate)
        {
            Id = id;
            Title = title;
            AuthorId = authorId;
            Author = author; 
            ReleaseDate = releaseDate;
        }

        public void DisplayBookInfo()
        {
            Console.WriteLine($"Book ID: {Id}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author ID: {AuthorId}");
            Console.WriteLine($"Author: {Author.Name}");  
            Console.WriteLine($"Release Date: {ReleaseDate.ToShortDateString()}");
        }
    }
}
