using InterviewTracker.Application.Commands;
using InterviewTracker.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InterviewTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobApplicationsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public JobApplicationsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _mediator.Send(new GetAllApplicationsQuery());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var jobApp = await _mediator.Send(new GetApplicationByIdQuery(id));
            if (jobApp == null)
            {
                return NotFound();
            }
            return Ok(jobApp);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateApplicationCommand request)
        {
            var id = await _mediator.Send(request);
            return CreatedAtAction(nameof(Get), new { id }, null);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] UpdateApplicationCommand request)
        {
            var isUpdated = await _mediator.Send(request);
            if (!isUpdated)
            {
                return NotFound();
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var isDeleted = await _mediator.Send(new DeleteApplicationCommand(id));
            if (!isDeleted)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
