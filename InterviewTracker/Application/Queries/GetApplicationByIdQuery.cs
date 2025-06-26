using InterviewTracker.Domain.Entities;
using MediatR;

namespace InterviewTracker.Application.Queries
{
    public class GetApplicationByIdQuery : IRequest<JobApplication>
    {
        public Guid JobApplicationId { get; private set; }

        public GetApplicationByIdQuery(Guid jobApplicationId)
        {
            JobApplicationId = jobApplicationId;
        }
    }
}
