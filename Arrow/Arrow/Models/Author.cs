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


        //process: make new class, in models, add shit to it.
        // go to controllers, new scaffolded item, mvc controller with views using entity framwework
        // tools/nuget package manager/ nuget console 
        // add-migration (name of migration) 
        //this adds to the database
        // update database
        //this gets u on the llatest version :D
        //phew. then go to run, and in the search bar just add /(name of model) and u should be at the site.
        //debugging time.
    }
}
