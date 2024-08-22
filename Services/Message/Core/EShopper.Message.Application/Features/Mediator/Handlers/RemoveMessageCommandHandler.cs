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
    public class RemoveMessageCommandHandler : IRequestHandler<RemoveMessageCommand>
    {
        private readonly IMessageService _messageService;

        public RemoveMessageCommandHandler(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public async Task Handle(RemoveMessageCommand request, CancellationToken cancellationToken)
        {
            await _messageService.DeleteMessage(request.Id);
        }
    }
}
