using InterviewTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace InterviewTracker.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
            
        }

        public DbSet<JobApplication> JobApplications { get; set; }

    }
}
