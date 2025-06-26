using InterviewTracker.Domain.Entities;
using InterviewTracker.Domain.Interfaces;
using MediatR;

namespace InterviewTracker.Application.Commands
{
    public class CreateApplicationHandler : IRequestHandler<CreateApplicationCommand, Guid>
    {
        private readonly IJobApplicationRepository _repository;

        public CreateApplicationHandler(IJobApplicationRepository repository)
        {
            _repository = repository;
        }
        public async Task<Guid> Handle(CreateApplicationCommand request, CancellationToken cancellationToken)
        {
            var jobApp = new JobApplication(
                request.CompanyName,
                request.Position,
                request.Status,
                request.Notes,
                request.IsRemote
                );
            return await _repository.Add(jobApp);
        }
    }
}
