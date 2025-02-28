using Microsoft.EntityFrameworkCore;

namespace Mission08_Team0403.Models
{
    public class TaskDbContext : DbContext
    {
        public TaskDbContext(DbContextOptions<TaskDbContext> options) : base(options) { }

        public DbSet<Task> Tasks { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed default categories
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Home" },
                new Category { CategoryId = 2, Name = "School" },
                new Category { CategoryId = 3, Name = "Work" },
                new Category { CategoryId = 4, Name = "Church" }
            );
        }
    }
}