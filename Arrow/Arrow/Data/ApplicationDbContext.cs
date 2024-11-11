using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Arrow.Models;

namespace Arrow.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Arrow.Models.Author> Author { get; set; } = default!;
      
        public DbSet<Arrow.Models.Book> Book { get; set; } = default!;
        public DbSet<Arrow.Models.Genre> Genre { get; set; } = default!;
    }
}
