using InterviewTracker.Domain.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace InterviewTracker.Application.Commands
{
    public class DeleteApplicationCommandHandler : IRequestHandler<DeleteApplicationCommand, bool>
    {
        private readonly IJobApplicationRepository _jobApplicationRepository;
        public DeleteApplicationCommandHandler(IJobApplicationRepository jobApplicationRepository)
        {
            _jobApplicationRepository = jobApplicationRepository;
        }

        public async Task<bool> Handle(DeleteApplicationCommand request, CancellationToken cancellationToken)
        {
            var jobApp = await _jobApplicationRepository.GetById(request.JobApplicationId);
            if (jobApp == null)
            {
                return false;
            }
            return await _jobApplicationRepository.Delete(jobApp);
        }
    }
}
