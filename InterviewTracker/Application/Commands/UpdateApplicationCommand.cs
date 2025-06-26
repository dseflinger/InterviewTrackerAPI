using InterviewTracker.Domain.Entities;
using MediatR;

namespace InterviewTracker.Application.Commands
{
    public class UpdateApplicationCommand : IRequest<bool>
    {
        public Guid Id { get; set; }
        public string CompanyName { get;  set; }
        public string Position { get; set; }
        public Status Status { get; set; }
        public string Notes { get; set; }
        public bool IsRemote { get; set; }
    }
}
