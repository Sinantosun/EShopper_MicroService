using EShopper.Message.Application.Features.Mediator.Commands;
using EShopper.Message.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.Message.Application.Features.Mediator.Handlers
{
    public class UpdateMessageCommandHandler : IRequestHandler<UpdateMessageCommand>
    {
        private readonly IMessageService _messageService;

        public UpdateMessageCommandHandler(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public async Task Handle(UpdateMessageCommand request, CancellationToken cancellationToken)
        {
            var value = await _messageService.GetMesssageById(request.UserMessageId);
            value.Email = request.Email;
            value.NameSurname = request.NameSurname;
            value.MessageContent = request.MessageContent;
            value.NameSurname = request.NameSurname;
            value.Subject = request.Subject;
            await _messageService.UpdateMessage(value);
        }
    }
}
