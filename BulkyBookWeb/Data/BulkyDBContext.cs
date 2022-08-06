using BulkyBookWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBookWeb.Data
{
    public class BulkyDBContext:DbContext
    {
        public BulkyDBContext(DbContextOptions<BulkyDBContext> options): base(options)
        {
           
        }
        public DbSet<Category> Categories { get; set; } 
    }
}
