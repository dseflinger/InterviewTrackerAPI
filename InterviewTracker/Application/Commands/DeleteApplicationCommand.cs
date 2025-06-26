using MediatR;

namespace InterviewTracker.Application.Commands
{
    public class DeleteApplicationCommand : IRequest<bool>
    {
        public Guid JobApplicationId { get; private set; }
        public DeleteApplicationCommand(Guid jobApplicationId)
        {
            JobApplicationId = jobApplicationId;
        }
    }
}
