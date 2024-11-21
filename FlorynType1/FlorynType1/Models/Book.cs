namespace FlorynType1.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; } // Navigation Property to Author
        public DateTime ReleaseDate { get; set; }
    }

}
