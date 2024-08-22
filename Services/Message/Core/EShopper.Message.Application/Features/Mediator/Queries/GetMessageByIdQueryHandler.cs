using EShopper.Message.Application.Features.Mediator.Results;
using EShopper.Message.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.Message.Application.Features.Mediator.Queries
{
    public class GetMessageByIdQueryHandler : IRequestHandler<GetMessageByIdQuery, GetMessageByIdQueryResult>
    {
        private readonly IMessageService _messageService;

        public GetMessageByIdQueryHandler(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public async Task<GetMessageByIdQueryResult> Handle(GetMessageByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _messageService.GetMesssageById(request.Id);
            return new GetMessageByIdQueryResult
            {
                Email = value.Email,
                MessageContent = value.MessageContent,
                NameSurname = value.NameSurname,
                Subject = value.Subject,
                UserMessageId = value.UserMessageId
            };
       
        }
    }
}
