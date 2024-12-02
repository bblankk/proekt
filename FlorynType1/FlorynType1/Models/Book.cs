namespace FlorynType1.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; } // works
        public virtual Author Author { get; set; } //ts dont work 
        public DateOnly ReleaseDate { get; set; }
    }

}
