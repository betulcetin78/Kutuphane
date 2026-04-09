using KutuphaneProjesi.Models;
using Microsoft.EntityFrameworkCore;


namespace KutuphaneProjesi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Book> Books { get; set; } // Veri tabanında Books tablosu oluşsun dedik
    }
}
