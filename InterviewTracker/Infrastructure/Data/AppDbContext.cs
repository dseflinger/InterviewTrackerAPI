using InterviewTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace InterviewTracker.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<JobApplication> JobApplications { get; set; }

    }
}
