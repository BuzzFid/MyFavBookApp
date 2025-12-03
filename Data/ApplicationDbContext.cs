using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyFavBookApp.Models;

namespace MyFavBookApp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)
    {
        public DbSet<MyFavBookApp.Models.Book> Book { get; set; } = default!;
    }
}
