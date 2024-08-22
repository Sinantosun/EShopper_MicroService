using EShopper.Message.Application.Features.Mediator.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EShopper.Message.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly IMediator _meditor;

        public MessagesController(IMediator meditor)
        {
            _meditor = meditor;
        }

        [HttpPost]
        public async Task<IActionResult> CreateMessage(CreateMessageCommand command)
        {
            await _meditor.Send(command);
            return Ok();
        }
    }
}
