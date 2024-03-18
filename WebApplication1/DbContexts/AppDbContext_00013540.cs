using Microsoft.EntityFrameworkCore;
using WebApplication1.Enums;
using WebApplication1.Models;

namespace WebApplication1.DbContexts
{
    public class AppDbContext_00013540 : DbContext
    {
        public AppDbContext_00013540(DbContextOptions<AppDbContext_00013540> options) : base(options) { }


        public DbSet<UserTask_00013540> UserTasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed the database with mock data
            modelBuilder.Entity<UserTask_00013540>().HasData(
                new UserTask_00013540
                {
                    Id = 1,
                    Title = "Complete project proposal",
                    Description = "Finish writing the project proposal document.",
                    DueDate = DateTime.Now.AddDays(7),
                    Status = StatusEnum_00013540.New,
                    Priority = PrioritiesEnum_00013540.High
                },
                new UserTask_00013540
                {
                    Id = 2,
                    Title = "Meeting with client",
                    Description = "Discuss project requirements with the client.",
                    DueDate = DateTime.Now.AddDays(3),
                    Status = StatusEnum_00013540.New,
                    Priority = PrioritiesEnum_00013540.Medium
                },
                new UserTask_00013540
                {
                    Id = 3,
                    Title = "Prepare presentation",
                    Description = "Create a presentation for the project update meeting.",
                    DueDate = DateTime.Now.AddDays(10),
                    Status = StatusEnum_00013540.New,
                    Priority = PrioritiesEnum_00013540.Low
                }
            );
        }
    }
}
