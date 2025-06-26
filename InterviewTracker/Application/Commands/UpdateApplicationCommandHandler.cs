using InterviewTracker.Domain.Interfaces;
using MediatR;

namespace InterviewTracker.Application.Commands
{
    public class UpdateApplicationCommandHandler : IRequestHandler<UpdateApplicationCommand, bool>
    {
        private readonly IJobApplicationRepository _repository;

        public UpdateApplicationCommandHandler(IJobApplicationRepository repository)
        {
            _repository = repository;
        }
        public async Task<bool> Handle(UpdateApplicationCommand request, CancellationToken cancellationToken)
        {
            var jobApp = await _repository.GetById(request.Id);
            if (jobApp == null) {
                return false;
            }
            jobApp.UpdateDetails(
                request.CompanyName,
                request.Position,
                request.Status,
                request.Notes,
                request.IsRemote
                );

            return await _repository.Update(jobApp);
        }
    }
}
