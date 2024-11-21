using Humanizer.Localisation;

namespace FlorynType1.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        // Navigation Properties
        public List<Book> BooksList { get; set; } = new List<Book>();
        public List<Genre> GenreList { get; set; } = new List<Genre>();
    }

}

