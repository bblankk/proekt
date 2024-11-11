using System.ComponentModel.DataAnnotations;

namespace Arrow.Models
{
    public class Author
    {
        public int Id { get; set; }
        [Required] //makes the field below required, yiou have to input value
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> BooksList { get; set; }
        public List<string> GenreList { get; set; }

    }
}
