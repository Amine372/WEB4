using Microsoft.EntityFrameworkCore;

public class APIDbContext : DbContext
{
    public APIDbContext(DbContextOptions<APIDbContext> options) : base(options)
    {
    }

    // DbSet pour vos entités, par exemple :
    // public DbSet<User> Users { get; set; }
}
