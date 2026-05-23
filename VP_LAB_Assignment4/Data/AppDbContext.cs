using Microsoft.EntityFrameworkCore;
using VP_LAB_Assignment4.Models;

namespace VP_LAB_Assignment4.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<TodoTask> TodoTasks { get; set; }
    }
}
