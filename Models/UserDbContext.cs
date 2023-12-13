using Microsoft.EntityFrameworkCore;


namespace ASPNetCoreMVC.Models
{
    public class UserDbContext:DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> Options) : base(Options)
        {}

        public DbSet<User> Users { get; set; }
    }
}