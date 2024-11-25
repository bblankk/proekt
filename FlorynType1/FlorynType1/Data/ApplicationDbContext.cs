using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FlorynType1.Models;

namespace FlorynType1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<FlorynType1.Models.Author> Author { get; set; } = default!;
        public DbSet<FlorynType1.Models.Book> Book { get; set; } = default!;
        public DbSet<FlorynType1.Models.Genre> Genre { get; set; } = default!;
    }
}
