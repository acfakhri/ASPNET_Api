using APIPROJECT.Models;
using Microsoft.EntityFrameworkCore;



namespace APIPROJECT.Repositories
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }
        public DbSet<Post> Post { get; set; }
    }
}
