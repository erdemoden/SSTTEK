using Microsoft.EntityFrameworkCore;
using SSTTEK.Entity;

namespace SSTTEK.Repositories;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
        
    }
    
    public DbSet<Books> Books { get; set; }
}