using AllPropertiesApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AllPropertiesApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
