using InterviewTracker.Domain.Entities;
using MediatR;

namespace InterviewTracker.Application.Queries
{
    public class GetAllApplicationsQuery : IRequest<IEnumerable<JobApplication>>
    {
        // todo add any necessary properties for filtering or sorting if needed (date range, status, etc.)
    }
}
