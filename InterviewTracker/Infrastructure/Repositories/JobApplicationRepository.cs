using InterviewTracker.Domain.Entities;
using InterviewTracker.Domain.Interfaces;
using InterviewTracker.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace InterviewTracker.Infrastructure.Repositories
{
    public class JobApplicationRepository : IJobApplicationRepository
    {
        private readonly AppDbContext _dbContext;
        public JobApplicationRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Guid> Add(JobApplication jobApp)
        {
            await _dbContext.JobApplications.AddAsync(jobApp);
            await _dbContext.SaveChangesAsync();
            return jobApp.Id;
        }

        public async Task<bool> Delete(JobApplication jobApp)
        {

            _dbContext.JobApplications.Remove(jobApp);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<JobApplication>> GetAll()
        {
            return await _dbContext.JobApplications.ToListAsync();
        }

        public async Task<JobApplication?> GetById(Guid jobAppId)
        {
            return await _dbContext.JobApplications.FindAsync(jobAppId);
        }

        public async Task<bool> Update(JobApplication jobApp)
        {
            _dbContext.JobApplications.Update(jobApp);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
