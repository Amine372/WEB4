using Microsoft.EntityFrameworkCore;

public class APIDbContext : DbContext
{
    public APIDbContext(DbContextOptions<APIDbContext> options) : base(options)
    {
    }

    // DbSet pour vos entités
    public DbSet<User> Users { get; set; }
}
