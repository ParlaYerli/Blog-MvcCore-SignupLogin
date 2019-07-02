using blogblog.Models;
using Microsoft.EntityFrameworkCore;

namespace blogblog.Data
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        { }

        public DbSet<User> User { get; set; }
    }
}
