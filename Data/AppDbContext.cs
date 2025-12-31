using DragSequenceDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace DragSequenceDemo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Item> Items { get; set; }
    }
}
