using InterviewTracker.Domain.Entities;

namespace InterviewTracker.Domain.Interfaces
{
    public interface IJobApplicationRepository
    {
        Task<Guid> Add(JobApplication jobApp);
        Task<JobApplication?> GetById(Guid jobAppId);
        Task<IEnumerable<JobApplication>> GetAll();
        Task<bool> Update(JobApplication jobApp);
        Task<bool> Delete(JobApplication jobApp);
    }
}
