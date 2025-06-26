using InterviewTracker.Domain.Entities;
using MediatR;

namespace InterviewTracker.Application.Commands
{
    public class CreateApplicationCommand : IRequest<Guid>
    {
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public Status Status { get; set; }
        public string Notes { get; set; }
        public bool IsRemote { get; set; }
    }
}
