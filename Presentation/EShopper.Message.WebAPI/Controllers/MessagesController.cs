using EShopper.Message.Application.Features.Mediator.Commands;
using EShopper.Message.Application.Features.Mediator.Queries;
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
        [HttpGet]
        public async Task<IActionResult> GetMessages()
        {
            var values = await _meditor.Send(new GetMessageQuery());
            return Ok(values);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveMessage(int id)
        {
            await _meditor.Send(new RemoveMessageCommand(id));
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMessageById(int id)
        {
            var value = await _meditor.Send(new GetMessageByIdQuery(id));
            return Ok(value);
        }

        [HttpPut]
        public async Task <IActionResult> UpdateMessage(UpdateMessageCommand updateMessageCommand)
        {
            await _meditor.Send(updateMessageCommand);
            return Ok();
        }
    }
}
