using InterviewTracker.Domain.Entities;
using InterviewTracker.Domain.Interfaces;
using MediatR;

namespace InterviewTracker.Application.Queries
{
    public class GetApplicationByIdQueryHandler : IRequestHandler<GetApplicationByIdQuery, JobApplication?>
    {
        private readonly IJobApplicationRepository _repository;
        public GetApplicationByIdQueryHandler(IJobApplicationRepository repository)
        {
            _repository = repository;
        }
        public async Task<JobApplication?> Handle(GetApplicationByIdQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetById(request.JobApplicationId);
        }
    }
}
