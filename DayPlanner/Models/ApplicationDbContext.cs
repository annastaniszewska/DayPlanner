using Microsoft.EntityFrameworkCore;

namespace DayPlanner.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<DayPlan> DayPlans { get; set; }

        public DbSet<Activity> Activities { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {
        }

    }
}
