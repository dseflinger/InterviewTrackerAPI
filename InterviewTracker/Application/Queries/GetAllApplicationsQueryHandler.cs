using InterviewTracker.Domain.Entities;
using InterviewTracker.Domain.Interfaces;
using MediatR;

namespace InterviewTracker.Application.Queries
{
    public class GetAllApplicationsQueryHandler : IRequestHandler<GetAllApplicationsQuery, IEnumerable<JobApplication>>
    {
        private readonly IJobApplicationRepository _repository;
        public GetAllApplicationsQueryHandler(IJobApplicationRepository repository)
        {
            _repository = repository;
        }
        public Task<IEnumerable<JobApplication>> Handle(GetAllApplicationsQuery request, CancellationToken cancellationToken)
        {
            return _repository.GetAll();
        }
    }
}
