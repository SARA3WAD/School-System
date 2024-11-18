using Microsoft.EntityFrameworkCore;

namespace School.Models
{
    public class AppDbContextL : DbContext
    {
        public AppDbContextL(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Student> students { get; set; }
        public DbSet<Subject> subjects { get; set; }
    }
}
